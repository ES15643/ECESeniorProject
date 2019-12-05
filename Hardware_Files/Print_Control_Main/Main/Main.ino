#include "gcode_interpretation.h"

// Globals for Printer
gcode_interpretation gcinter = gcode_interpretation();
Stepper_Motor* stpms = gcinter.GetMotors();
volatile byte stepperFlags = 0;
volatile byte nextStepper = 0;
volatile bool x_home, y_home;

// GCodes for Testing
//Linear
String gcodesForTesting[5] = {"G00 X10.0 Y10.0", "G01 X12.0 Y12.0", "G01 X14.0 Y10.0", "G01 X12.0 Y8.0", "G01 X10.0 Y10.0"};

//Circle
//String gcodesForTesting[2] = {"G00 X10.0 Y10.0", "G02 X10.0 Y10.0 I2.0 J0.0"};

//Command from server
String currentGCode = "";

// volatile int triggered = LOW;

void nextInterval()
{
    unsigned int delay = 65500;

    for(int i = 0; i < NumOFMotors; i++)
    {
        unsigned long temp = stpms[i].GetTruncDelay();
        if ( ((1 << i) & stepperFlags) && temp < delay )
        {
            delay = temp;
        }
    }

    nextStepper = 0;
    for(int i = 0; i < NumOFMotors; i++)
    {
        unsigned long temp = stpms[i].GetTruncDelay();
        if ( ((1 << i) & stepperFlags) && temp == delay )
        {
            nextStepper |= (1 << i);
        }
    }

    if (stepperFlags == 0)
    {
        OCR1A = 65500;
    }
    
    OCR1A = delay;

}

ISR(TIMER1_COMPA_vect)
{
    unsigned int temp_ORC1A = OCR1A;

    OCR1A = 65500;

    for (int i = 0; i < NumOFMotors; i++)
    {
        if ( !((1 << i) & stepperFlags) )
        {
            continue;
        }

        if (! (nextStepper & (1 << i)) )
        {
            unsigned long temp_truc = stpms[i].GetTruncDelay();
            stpms[i].SetTruncDelay(temp_truc - temp_ORC1A);
            continue;
        }

        if (stpms[i].GetStepCount() < stpms[i].GetTotalSteps())
        {
            stpms[i].Step();

            if(digitalRead(X_Left_Switch) == 0 || digitalRead(X_Right_Switch) == 0)
            {
                boundaryTriggeredX();
            }

            if (digitalRead(Y_Bot_Switch) == 0 || digitalRead(Y_Top_Switch) == 0)
            {
                boundaryTriggeredY();
            }

            if (stpms[i].GetStepCount() >= stpms[i].GetTotalSteps())
            {
                stpms[i].SetMotorDone();
                stepperFlags &= ~(1 << i);
            }
        }

        if (stpms[i].GetStepsToMax() == 0)
        {
            stpms[i].IncrementAccelIndex();
            float temp = stpms[i].GetCurrentDelay();
            temp = temp - (2 * temp) / (4 * stpms[i].GetAccelIndex() + 1);
            stpms[i].SetCurrentDelay(temp);

            if (temp <= stpms[i].GetMinDelay() )
            {
                stpms[i].SetCurrentDelay(stpms[i].GetMinDelay());
                stpms[i].SetStepsToMax(stpms[i].GetStepCount());
            }
            if (stpms[i].GetStepCount() >= stpms[i].GetTotalSteps() / 2)
            {
                stpms[i].SetStepsToMax(stpms[i].GetStepCount());
            }
        }
        else if (stpms[i].GetStepCount() >= stpms[i].GetTotalSteps() - stpms[i].GetStepsToMax())
        {
            float temp = stpms[i].GetCurrentDelay();
            temp = (temp * (4 * stpms[i].GetAccelIndex() + 1) / (4 * stpms[i].GetAccelIndex() + 1 - 2));
            stpms[i].SetCurrentDelay(temp);
            stpms[i].DecrementAccelIndex();
        }

        stpms[i].SetTruncDelay(stpms[i].GetCurrentDelay());
    }

    nextInterval();

    TCNT1 = 0;
}

void setup()
{
     Serial.begin(115200);

    x_home = true;
    y_home = true;

    noInterrupts();// disable all interrupts

    // Set up interupt for timer 1 (Stepping Timer)
    TCCR1A = 0;
    TCCR1B = 0;
    TCNT1  = 0;
    OCR1A = 1000;  // Compare match regsiter
    TCCR1B |= (1 << WGM12);   // CTC mode
    TCCR1B |= (1 << CS11) | (1 << CS10);    // 64 prescaler 

    interrupts();   // enable all interrupts

    // Set pinmodes
    pinMode(stmp1_DirectionPin, OUTPUT);
    pinMode(stmp1_StepPin, OUTPUT);

    pinMode(stmp2_DirectionPin, OUTPUT);
    pinMode(stmp2_StepPin, OUTPUT);
    
    // x plane switches
    pinMode(40, INPUT_PULLUP);
    pinMode(41, OUTPUT);
    pinMode(46, INPUT_PULLUP);
    pinMode(47, OUTPUT);
    
    digitalWrite(41, LOW);
    digitalWrite(47, LOW);

    // Y plane switches
    pinMode(38, INPUT_PULLUP);
    pinMode(39, OUTPUT);
    pinMode(44, INPUT_PULLUP);
    pinMode(45, OUTPUT);

    digitalWrite(39, LOW);
    digitalWrite(45, LOW);

    //Enable interrupt pins
    pinMode(48, OUTPUT);
    pinMode(49, OUTPUT);

    Home();   
}

void Home()
{
    uint8_t bytesRead;
    bool run = true;
    Serial.println("Home Motors? Y/N");

    while(run)
    {
        if (Serial.available() > 0)
        {
            bytesRead = Serial.read();
            if (bytesRead == 'y')
            {
                run = false;
                gcinter.Home(); // Home Motors
                Serial.println("motor Ready");
                Serial.println("Ready to Start y/n?");
            }
        }
    }
}

void loop()
{   
    uint8_t bytesRead;
    if (Serial.available() > 0)
    {
        bytesRead = Serial.read();
        if (bytesRead == 'y')
        {
            int length = sizeof(gcodesForTesting)/sizeof(*gcodesForTesting);
            Serial.println("Starting");
            for (int i = 0; i < length; i++)
            {
                Serial.println("Using " + gcodesForTesting[i]);
                gcinter.interpret_gcode(gcodesForTesting[i]);
                Serial.print("X pos: ");
                Serial.println(stpms[0].GetCurPos());
                Serial.print("Y pos: ");
                Serial.println(stpms[1].GetCurPos());
            }
        }
    }

//    while(!Serial3.available()) {}

//    currentGCode = Serial3.readString();
//    gcinter.interpret_gcode(currentGCode);
//    Serial3.print('Y');
}

void boundaryTriggeredX()
{   
    // Serial.println(x_home);
    if(!gcinter.GetHomingx())
    {
        digitalWrite(49, HIGH);
        digitalWrite(48, HIGH);
    }
    else if (gcinter.GetHomingx())
    {
        if(x_home)
        {
            // Serial.println("X here");
            x_home = false;
            stpms[0].ResetMotor();
            stepperFlags &= ~(1 << 0); 
        }
    }
}

void boundaryTriggeredY()
{
    // Serial.println(gcinter.GetHomingy());
    if(!gcinter.GetHomingy())
    {
        digitalWrite(48, HIGH);
        digitalWrite(49, HIGH);
    }
    else if (gcinter.GetHomingy())
    {
        if(y_home)
        {
            // Serial.println("Y here");
            y_home = false;
            stpms[1].ResetMotor();
            stepperFlags &= ~(1 << 1);
        }
    }
}
