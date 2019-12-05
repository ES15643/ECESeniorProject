// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

extern volatile byte stepperFlags;

Stepper_Motor::Stepper_Motor(int stepsPerRev, uint8_t directionPin, uint8_t stepPin, bool x_plane)
{
    
    SPR = stepsPerRev;
    DirPin = directionPin;
    StepPin = stepPin;
    XPlane = x_plane;

    pinMode(DirPin, OUTPUT);
    pinMode(StepPin, OUTPUT);

    ResetMotor();
}

void Stepper_Motor::SetDir(uint8_t dir)
{
    Direction = dir;

    if(XPlane)
    {
        if(dir == 0)
        {
            X_MoveNeg
        }
        else
        {
            X_MovePos
        }
    }
    else
    {
        if(dir == 0)
        {
            Y_MoveNeg
        }
        else
        {
            Y_MovePos
        }
    }
}

void Stepper_Motor::MoveMotor(unsigned long steps, uint8_t dir)
{
    ResetMotor();
    SetDir(dir);

    if(XPlane)
    {
        stepperFlags |= (1 << 0);        
    }
    else
    {
        stepperFlags |= (1 << 1);
    }

    TotalSteps = steps;
    MovingDone = false;
}

void Stepper_Motor::Step() 
{
    if(XPlane)
    {
        X_Step_High
        delayMicroseconds(50);
        X_Step_Low
    }
    else
    {
        Y_Step_High
        delayMicroseconds(50);
        Y_Step_Low
    }

    StepCount++;

    if (Direction == 0)
    {
        CurPos -= 0.00125;
    }
    else
    {
        CurPos += 0.00125;
    }
}

void Stepper_Motor::ResetMotor()
{
    MovingDone = true;
    StartingDelay = Accel;
    CurrentDelay = StartingDelay;
    TruncateDelay = CurrentDelay;
    StepsToMax = 0;
    StepCount = 0;
    TotalSteps = 0;
    AccelCurveIndex = 0;
    MinDelay = min_delay_default;
}

void Stepper_Motor::Home()
{
    ResetMotor();
    if(XPlane)
    {
        stepperFlags |= (1 << 0);        
    }
    else
    {
        stepperFlags |= (1 << 1);
    }
    TotalSteps = 20000;
    MovingDone = false;

    Enable_Timer
}
