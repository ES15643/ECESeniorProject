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

String gcodesForTesting[5] = {"", "", "", "", ""};

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
    gcinter = gcode_interpretation(stpm1, stpm2);

    // Set Interrupts
    attachInterrupt(digitalPinToInterrupt(3), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredY, LOW);
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
                attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredX, LOW);
                attachInterrupt(digitalPinToInterrupt(21), boundaryTriggeredY, LOW);
                attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredY, LOW);
                Serial.println("Motor Ready");
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
            stpm1.MoveMotor(2500, 1);
            // stpm2.MoveMotor(2500, 1);
            // stpm3.MoveMotor(2500, 1);
        }
    }
}

void boundaryTriggeredX()
{   
    if(!gcinter.homingx)
    {
        digitalWrite(49, HIGH);
        //send error to GUI
    }
    else if (gcinter.homingx)
    {
        stpm1.ResetMotor();
        stpm1.SetCurrPos(0.0);
        gcinter.homingx = false;
        detachInterrupt(digitalPinToInterrupt(3));
        detachInterrupt(digitalPinToInterrupt(18));
    }
}

void boundaryTriggeredY()
{
    Serial.println("Y Triggered");

    if(!gcinter.homingy)
    {
        digitalWrite(48, HIGH);
        //send error to GUI
    }
    else if (gcinter.homingy)
    {
        stpm2.ResetMotor();
        stpm2.SetCurrPos(0.0);
        gcinter.homingy = false;
        detachInterrupt(digitalPinToInterrupt(19));
        detachInterrupt(digitalPinToInterrupt(21));
    }
}

