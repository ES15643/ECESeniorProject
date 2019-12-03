// #include "Stepper_Motor.h"
#include "gcode_interpretation.h"

Stepper_Motor stpm1;
Stepper_Motor stpm2;

gcode_interpretation gcinter;

int stmp1_directionpin = 52;
int stmp1_steppin = 53;

int stmp2_directionpin = 50;
int stmp2_steppin = 51;
int maxSPS = 1000;

//Linear
// String gcodesForTesting[5] = {"G00 X10.0 Y10.0", "G01 X12.0 Y12.0", "G01 X14.0 Y10.0", "G01 X12.0 Y8.0", "G01 X10.0 Y10.0"};

//Circle
String gcodesForTesting[2] = {"G00 X10.0 Y10.0", "G02 X10.0 Y10.0 I2.0 J0.0"};

// volatile int triggered = LOW;

// X Motor Step interrupt
ISR(TIMER1_COMPA_vect)
{
    if (stpm1.IsMotorMoving())
    {

        stpm1.Step();
    }
}

// Y Motor Step interrupt
ISR(TIMER4_COMPA_vect)
{
    if (stpm2.IsMotorMoving())
    {
        stpm2.Step();
    }
}

// Motor acceleration
ISR(TIMER3_COMPA_vect)
{
    if (stpm1.IsMotorMoving())
    {
        stpm1.StepperAccelerationAdjuster();
    }

    if (stpm2.IsMotorMoving())
    {
        stpm2.StepperAccelerationAdjuster();
    }
}

void setup()
{
    // Set pinmodes
    pinMode(stmp1_directionpin, OUTPUT);
    pinMode(stmp1_steppin, OUTPUT);

    pinMode(stmp2_directionpin, OUTPUT);
    pinMode(stmp2_steppin, OUTPUT);

    Serial.begin(115200);
    Serial3.begin(115200);
    
    pinMode(21, INPUT_PULLUP);
    pinMode(3, INPUT_PULLUP);
    pinMode(18, INPUT_PULLUP);
    pinMode(19, INPUT_PULLUP);

    pinMode(22, OUTPUT);
    pinMode(4, OUTPUT);
    pinMode(17, OUTPUT);
    pinMode(20, OUTPUT);

    digitalWrite(22, LOW);
    digitalWrite(4, LOW);
    digitalWrite(17, LOW);
    digitalWrite(20, LOW);

    //Enable interrupt pins
    pinMode(48, OUTPUT);
    pinMode(49, OUTPUT);

    stpm1 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS, true); // X motor
    stpm2 = Stepper_Motor(200, stmp2_directionpin, stmp2_steppin, maxSPS, false); // y motor
    // gcinter = gcode_interpretation(stpm1, stpm2); // GCode interpeter

    // Set Interrupts
    attachInterrupt(digitalPinToInterrupt(3), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredY, LOW);
    attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(21), boundaryTriggeredY, LOW);

    WaitForInput();   
}

void WaitForInput()
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
                
                attachInterrupt(digitalPinToInterrupt(3), boundaryTriggeredX, LOW);
                attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredY, LOW);
                attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredX, LOW);
                attachInterrupt(digitalPinToInterrupt(21), boundaryTriggeredY, LOW);
                Serial.println("Motor Ready");
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
                Serial.println(stpm1.GetCurrPos());
                Serial.print("Y pos: ");
                Serial.println(stpm2.GetCurrPos());
            }
        }
    }
}

void boundaryTriggeredX()
{   
    if(!gcinter.GetHomingx())
    {
        digitalWrite(49, HIGH);
        digitalWrite(48, HIGH);
        // stpm1.ResetMotor();
        //send error to GUI
    }
    else if (gcinter.GetHomingx())
    {
        stpm1.ResetMotor();
        stpm1.SetCurrPos(0.0);
        gcinter.SetHomingx(false);
        detachInterrupt(digitalPinToInterrupt(3));
        detachInterrupt(digitalPinToInterrupt(19));        
    }
}

void boundaryTriggeredY()
{

    if(!gcinter.GetHomingy())
    {
        digitalWrite(48, HIGH);
        digitalWrite(49, HIGH);
        // stpm2.ResetMotor();
        //send error to GUI
    }
    else if (gcinter.GetHomingy())
    {
        stpm2.ResetMotor();
        stpm2.SetCurrPos(0.0);
        gcinter.SetHomingy(false);
        detachInterrupt(digitalPinToInterrupt(18));
        detachInterrupt(digitalPinToInterrupt(21));
    }
}
