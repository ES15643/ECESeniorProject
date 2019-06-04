// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Arduino.h"

class Stepper_Motor
{
    public:
    Stepper_Motor(){};
    Stepper_Motor(int stepsPerRevolution, int directionPin, int stepPin, int startingSpeed); 
    void MoveMotor(int steps, int direction); // Direction should 0 or 1
    void SetSpeed(int speed){ Speed = speed; } 
    int GetStepsPerRevolution() { return StepsPerRevolution; }
    int GetDirectionPin() { return DirectionPin; }
    int GetStepPin() { return StepPin; }

    private:
    int StepsPerRevolution;
    int DirectionPin;
    int StepPin;
    int Speed;
};
