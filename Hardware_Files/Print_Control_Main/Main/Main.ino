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
ISR(TIMER5_COMPA_vect)
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

    Home();
    // WaitForInput();   
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
    // Serial.println("Triggered");
    // digitalWrite(1, LOW);
    stpm1.ResetMotor();
    // stpm2.ResetMotor();
    // stpm3.ResetMotor();

    if(!homingx)
    {
        digitalWrite(49, HIGH);
        //send error to GUI
    }
    else
    {
        stpm1.SetCurrPos(0.0);
        // z = 0;
        homingx = false;
    }
}

void boundaryTriggeredY()
{
    // Serial.println("Triggered");
    // digitalWrite(1, LOW);
    stpm2.ResetMotor();
    // stpm2.ResetMotor();
    // stpm3.ResetMotor();

    if(!homingy)
    {
        digitalWrite(48, HIGH);
        //send error to GUI
    }
    else
    {
        stpm2.SetCurrPos(0.0);
        homingy = false;
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

    Serial.println("Motor Ready");
}