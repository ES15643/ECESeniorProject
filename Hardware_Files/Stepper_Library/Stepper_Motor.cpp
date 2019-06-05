// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

Stepper_Motor::Stepper_Motor(int stepsPerRev, int directionPin, int stepPin, int startingSpeed)
{
    StepsPerRevolution = stepsPerRev;
    DirectionPin = directionPin;
    StepPin = stepPin;
    SetSpeed(speed)

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
        delay(DelayBetweenSteps);
    }
}

void Stepper_Motor::SetSpeed(int speed) // Speed given in RPM
{
    stepsPerSecond = (speed * 60) / StepsPerRevolution;
    DelayBetweenSteps = (1 / stepsPerSecond) * 1000;
} 
