#include "Stepper_Motor.h"

Stepper_Motor stpm1;
Stepper_Motor stpm2;
// Stepper_Motor stpm3;

int stmp1_directionpin = 52;
int stmp1_steppin = 53;

int stmp2_directionpin = 50;
int stmp2_steppin = 51;
int maxSPS = 1000;

long x;
long y;
// long z;

volatile bool homingx = false;
volatile bool homingy = false;
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

    // Set Interrupts
    attachInterrupt(digitalPinToInterrupt(3), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredX, LOW);

    attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredY, LOW);
    attachInterrupt(digitalPinToInterrupt(21), boundaryTriggeredY, LOW);

    //Enable interrupt pins
    pinMode(48, OUTPUT);
    pinMode(49, OUTPUT);

    stpm1 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS, true); // X motor
    stpm2 = Stepper_Motor(200, stmp2_directionpin, stmp2_steppin, maxSPS, false); // y motor

    // Home();
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
                Home(); // Home Motors
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
    if(!homingx)
    {
        digitalWrite(49, HIGH);
        //send error to GUI
    }
    else if (homingx)
    {
        stpm1.ResetMotor();
        stpm1.SetCurrPos(0.0);
        homingx = false;
        detachInterrupt(digitalPinToInterrupt(3));
        detachInterrupt(digitalPinToInterrupt(18));
    }
}

void boundaryTriggeredY()
{
    Serial.println("Y Triggered");

    if(!homingy)
    {
        digitalWrite(48, HIGH);
        //send error to GUI
    }
    else if (homingy)
    {
        stpm2.ResetMotor();
        stpm2.SetCurrPos(0.0);
        homingy = false;
        detachInterrupt(digitalPinToInterrupt(19));
        detachInterrupt(digitalPinToInterrupt(21));
    }
}

void Home()
{
    homingx = true;
    homingy = true;

    stpm1.SetDirection(0);
    stpm2.SetDirection(0);

    stpm1.Home();
    Serial.println("Home x");
    stpm2.Home();
    Serial.println("Home y");
    while(homingx || homingy){}

    Serial.println("Both were triggered");
    if(stpm1.GetDirection() == 0)
    {
        stpm1.MoveMotor(200, 1);
    }
    else
    {
        stpm1.MoveMotor(200, 0);
    }

    if(stpm2.GetDirection() == 0)
    {
        stpm2.MoveMotor(200, 1);
    }
    else
    {
        stpm2.MoveMotor(200, 0);
    }

    while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){}

    attachInterrupt(digitalPinToInterrupt(3), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(18), boundaryTriggeredX, LOW);
    attachInterrupt(digitalPinToInterrupt(21), boundaryTriggeredY, LOW);
    attachInterrupt(digitalPinToInterrupt(19), boundaryTriggeredY, LOW);
    Serial.println("Motor Ready");
}