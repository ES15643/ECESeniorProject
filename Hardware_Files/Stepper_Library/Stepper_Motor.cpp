// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

Stepper_Motor::Stepper_Motor(int stepsPerRev, int directionPin, int stepPin)
{
    StepsPerRevolution = stepsPerRev;
    DirectionPin = directionPin;
    StepPin = stepPin;

    pinMode(DirectionPin, OUTPUT);
    pinMode(StepPin, OUTPUT);
}

void Stepper_Motor::MoveMotor(int steps, int direction)
{
    digitalWrite(DirectionPin, direction);
    delay(100);

    for(int i = 0; i < steps; i++)
    {
        digitalWrite(StepPin, HIGH);
        digitalWrite(StepPin, LOW);
        delay(1);
    }
}
