// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

Stepper_Motor::Stepper_Motor(int stepsPerRev, uint8_t directionPin, uint8_t stepPin, int maxSPS)
{
    StepsPerRevolution = stepsPerRev;
    DirectionPin = directionPin;
    StepPin = stepPin;
    MaxSPS = maxSPS;
    CurrentSPS = 300;
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
    TCCR1B |= (1 << CS10);    // 1 prescaler 

    // Set up interupt for acceleration (Acceleration Timer)
    TCCR3A = 0;
    TCCR3B = 0;
    TCNT3  = 0;
    OCR3A = 1600;
    TCCR3B |= (1 << WGM32);   // CTC mode
    TCCR3B |= (1 << CS32);    // 256 prescaler

    interrupts();   // enable all interrupts
}

void Stepper_Motor::MoveMotor(int steps, int direction)
{
    digitalWrite(DirectionPin, direction);
    // delay(100);
    Direction = direction;
    TotalSteps = steps;
    Accelerate = true;
    MotorIsMoving = true;

    TIMSK1 |= (1 << OCIE1A);  // enable timer compare interrupt (Steps)
    TIMSK3 |= (1 << OCIE3A);  // enable timer compare interrupt (Acceleration)
}

void Stepper_Motor::Step() 
{
    digitalWrite(StepPin, HIGH);
    // delayMicroseconds(1);
    digitalWrite(StepPin, LOW);
    AmountOfStepsTaken += 1;

    if (AmountOfStepsTaken == TotalSteps)
    {
        Serial.print("Steps Taken: ");
        Serial.println(AmountOfStepsTaken);
        noInterrupts();// disable all interrupts
        TIFR1 |= (1 << OCF1A);
        TIFR3 |= (1 << OCF3A);
        MotorIsMoving = false;
        ResetMotor();
        Serial.println("Stepping finished\n");
        interrupts();   // enable all interrupts
    }

    OCR1A = CalcSPSTimerRegisterValue(); // Set Timer Reg to new value
}

uint16_t Stepper_Motor::CalcSPSTimerRegisterValue()
{
    uint32_t timePerStep = (CLCKSPD/CurrentSPS);
    // Serial.print("TimePerStep: ");
    // Serial.println(timePerStep);
    if(timePerStep >= 65535) //Checks for potential overflow
    {
        timePerStep = 65535;
    }
    uint16_t temp = timePerStep;
    // Serial.println(temp);
    return temp; // Clock speed divided by desired steps per second
}

void Stepper_Motor::StepperAccelerationAdjuster()
{
    float temp = (float)AmountOfStepsTaken / (float)TotalSteps;
    // Serial.print("Temp: ");
    // Serial.println(temp);

    if(Accelerate && temp < 0.2)
    {
        if (CurrentSPS < MaxSPS)
        {
            CurrentSPS += accelerationRate;
            // Serial.print("SPS: ");
            // Serial.println(CurrentSPS);
        }
        
        if (CurrentSPS == MaxSPS)
        {
            Serial.println("Max reached");
            Accelerate = false;
        }
        
        return;
    }
    
    if ( !Decelerate && temp > 0.8)
    {
        Accelerate = false;
        Decelerate = true;
    }
    
    if(Decelerate)
    {
        if (CurrentSPS > 300)
        {
            CurrentSPS -= accelerationRate;
            // Serial.print("SPS: ");
            // Serial.println(CurrentSPS);
        }
        else
        {
            CurrentSPS = 300;
        }
        
        return;
    }
}

void Stepper_Motor::ResetMotor()
{
    CurrentSPS = 300;
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

void Stepper_Motor::Home()
{
    Direction = 0;
    digitalWrite(DirectionPin, Direction);
    // delay(100);
    TotalSteps = 20000;
    MotorIsMoving = true;

    TIMSK1 |= (1 << OCIE1A);  // enable timer compare interrupt (Steps)
}
