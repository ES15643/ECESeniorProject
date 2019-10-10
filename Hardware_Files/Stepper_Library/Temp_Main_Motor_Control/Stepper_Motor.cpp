// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

Stepper_Motor::Stepper_Motor(int stepsPerRev, uint8_t directionPin, uint8_t stepPin, int maxSPS)
{
    StepsPerRevolution = stepsPerRev;
    DirectionPin = directionPin;
    StepPin = stepPin;
    MaxSPS = maxSPS;
    CurrentSPS = 10;
    AmountOfStepsTaken = 0;
    Accelerate = false;
    Decelerate = false;
    MotorIsMoving = false;

    pinMode(DirectionPin, OUTPUT);
    pinMode(StepPin, OUTPUT);

    noInterrupts();// disable all interrupts

    // Set up interupt for timer 1 (Stepping Timer)
    TCCR1A = 0;
    TCCR1B = 0;
    TCNT1  = 0;
    OCR1A = CalcSPSTimerRegisterValue();  // Compare match regsiter
    TCCR1B |= (1 << WGM12);   // CTC mode
    TCCR1B |= (1 << CS12);    // 1 prescaler 

    // Set up interupt for acceleration (Acceleration Timer)
    TCCR3A = 0;
    TCCR3B = 0;
    TCNT3  = 0;
    OCR3A = 1600;
    TCCR3B |= (1 << WGM32);   // CTC mode
    TCCR3B |= (1 << CS32);    // 1 prescaler 

    interrupts();   // enable all interrupts
}

void Stepper_Motor::MoveMotor(int steps, int direction)
{
    digitalWrite(DirectionPin, direction);
    // delay(100);
    TotalSteps = steps;
    Accelerate = true;
    MotorIsMoving = true;

    TIMSK1 |= (1 << OCIE1A);  // enable timer compare interrupt (Steps)
    TIMSK3 |= (1 << OCIE3A);  // enable timer compare interrupt (Acceleration)
}

void Stepper_Motor::Step() 
{
    digitalWrite(StepPin, HIGH);
    // delay(1);
    digitalWrite(StepPin, LOW);
    AmountOfStepsTaken += 1;

    if (AmountOfStepsTaken == TotalSteps)
    {
        noInterrupts();// disable all interrupts
        MotorIsMoving = false;
        ResetMotor();
        Serial.println("Stepping finished\n");
        interrupts();   // enable all interrupts
    }

    OCR1A = CalcSPSTimerRegisterValue(); // Set Timer Reg to new value
}

uint16_t Stepper_Motor::CalcSPSTimerRegisterValue()
{
    return CLCKSPD/CurrentSPS; // Clock speed divided by desired steps per second
}

void Stepper_Motor::StepperAccelerationAdjuster()
{
    float temp = float(AmountOfStepsTaken) / float(TotalSteps);

    if(Accelerate && temp < 0.5)
    {
        if (CurrentSPS < MaxSPS)
        {
            CurrentSPS += accelerationRate;
        }
        
        if (CurrentSPS == MaxSPS)
        {
            Accelerate = false;
        }
        
        return;
    }
    else if ( !Decelerate && temp > 0.8)
    {
        Accelerate = false;
        Decelerate = true;
    }
    else if(Decelerate)
    {
        if (CurrentSPS > 1)
        {
            CurrentSPS -= accelerationRate;
        }
        else
        {
            Decelerate = false;
        }
    }
}

void Stepper_Motor::ResetMotor()
{
    CurrentSPS = 10;
    AmountOfStepsTaken = 0;
    Accelerate = false;
    Decelerate = false;

    uint8_t temp = 0;
    temp = (1 << OCIE1A);
    temp != temp;
    TIMSK1 &= temp;  // disable timer compare interrupt (Steps)

    temp = 0;
    temp = (1 << OCIE3A);
    temp != temp;
    TIMSK3 &= temp;  // disable timer compare interrupt (Acceleration)
}
