#include "Stepper_Motor.h"

Stepper_Motor stpm1;
// Stepper_Motor stpm2;
// Stepper_Motor stpm3;


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
    stpm1 = Stepper_Motor(50, 0, 1, 200);
}

void loop()
{

}

