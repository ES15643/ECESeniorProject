#include "Stepper_Motor.h"

Stepper_Motor stpm1;
// Stepper_Motor stpm2;
// Stepper_Motor stpm3;

int stmp1_directionpin = 52;
int stmp1_steppin = 53;
int maxSPS = 1000;

long x;
long y;
// long z;

volatile bool homing = false;
// volatile int triggered = LOW;

ISR(TIMER1_COMPA_vect)
{
    if (stpm1.IsMotorMoving())
    {
        stpm1.Step();
    }
}

ISR(TIMER3_COMPA_vect)
{
    if (stpm1.IsMotorMoving())
    {
        stpm1.StepperAccelerationAdjuster();
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
    attachInterrupt(digitalPinToInterrupt(21), boundaryTriggered, LOW);
    attachInterrupt(digitalPinToInterrupt(3), boundaryTriggered, LOW);
    attachInterrupt(digitalPinToInterrupt(18), boundaryTriggered, LOW);
    attachInterrupt(digitalPinToInterrupt(19), boundaryTriggered, LOW);

    pinMode(49, OUTPUT); //Enable interrupt pin
    pinMode(50, OUTPUT);
    pinMode(51, OUTPUT);

    stpm1 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS);

    Home();

    Serial.println("Motor Ready");
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

void boundaryTriggered()
{
    // Serial.println("Triggered");
    // digitalWrite(1, LOW);
    stpm1.ResetMotor();
    // stpm2.ResetMotor();
    // stpm3.ResetMotor();

    if(!homing)
    {
        digitalWrite(49, HIGH);
        digitalWrite(50, HIGH);
        digitalWrite(51, HIGH);

        //send error to GUI
    }
    else
    {
        x = 0;
        y = 0;
        // z = 0;
        
        homing = false;
    }
}

void Home()
{
    homing = true;

    stpm1.Home();
    while(homing){}
    Serial.println(stpm1.GetDirection());

    if(stpm1.GetDirection() == 0)
    {
        stpm1.MoveMotor(200, 1);
    }
    else
    {
        stpm1.MoveMotor(200, 0);
    }
    // stpm2.Home();
    // stpm3.Home();
}