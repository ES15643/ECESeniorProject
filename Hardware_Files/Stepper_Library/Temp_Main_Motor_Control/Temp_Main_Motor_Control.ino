#include "Stepper_Motor.h"

Stepper_Motor stpm1;
Stepper_Motor stpm2;
Stepper_Motor stpm3;

int stmp1_directionpin = 52;
int stmp1_steppin = 53;

int maxSPS = 100;


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

    // Set up Serial for testing
    Serial.begin(115200);

    // Set up stepper motors
    stpm1 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS);
    // stpm2 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS);
    // stpm3 = Stepper_Motor(200, stmp1_directionpin, stmp1_steppin, maxSPS);

    // Ready to go
    Serial.println("Motor ready.");
}

void loop()
{
    uint8_t bytesRead;
    if (Serial.available() > 0)
    {
        bytesRead = Serial.read();
        Serial.println(bytesRead);
        if (bytesRead == 'y')
        {
            stpm1.MoveMotor(600, 0);
            // stpm2.MoveMotor(600, 1);
            // stpm3.MoveMotor(600, 1);
        }
        
    }
}

