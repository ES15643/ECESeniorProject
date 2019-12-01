// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Stepper_Motor.h"

Stepper_Motor::Stepper_Motor(int stepsPerRev, uint8_t directionPin, uint8_t stepPin, int maxSPS, bool x_plane)
{
    StepsPerRevolution = stepsPerRev;
    DirectionPin = directionPin;
    StepPin = stepPin;
    MaxSPS = maxSPS;
    CurrentSPS = DefaultSPS;
    AmountOfStepsTaken = 0;
    Accelerate = false;
    Decelerate = false;
    MotorIsMoving = false;
    X_plane = x_plane;

    pinMode(DirectionPin, OUTPUT);
    pinMode(StepPin, OUTPUT);

    noInterrupts();// disable all interrupts

    if (X_plane)
    {
        // Set up interupt for timer 1 (Stepping Timer)
        TCCR1A = 0;
        TCCR1B = 0;
        TCNT1  = 0;
        OCR1A = CalcSPSTimerRegisterValue();  // Compare match regsiter
        TCCR1B |= (1 << WGM12);   // CTC mode
        TCCR1B |= (1 << CS10);    // 1 prescaler 

    }
    else
    {
        // Set up interupt for timer 1 (Stepping Timer)
        TCCR4A = 0;
        TCCR4B = 0;
        TCNT4  = 0;
        OCR4A = CalcSPSTimerRegisterValue();  // Compare match regsiter
        TCCR4B |= (1 << WGM12);   // CTC mode
        TCCR4B |= (1 << CS10);    // 1 prescaler 
    }

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
    if(!Circle)
        TotalSteps = steps;
    Accelerate = true;
    MotorIsMoving = true;

    if(X_plane)
    {
        TIMSK1 |= (1 << OCIE1A);  // enable timer compare interrupt (Steps)   
    }
    else
    {
        TIMSK4 |= (1 << OCIE4A);  // enable timer compare interrupt (Steps)
    }

    TIMSK3 |= (1 << OCIE3A);  // enable timer compare interrupt (Acceleration)
}

void Stepper_Motor::Step() 
{
    digitalWrite(StepPin, HIGH);
    // delayMicroseconds(1);
    digitalWrite(StepPin, LOW);
    AmountOfStepsTaken += 1;
    
    if(Direction == 0)
    {
        cur_pos-=0.005;
    }
    else
    {
        cur_pos+=0.005;
    }

    // if(Circle)
    // {
    //     // if(X_plane)
    //     // {
    //     //     Serial.print("Cur Pos X: ");
    //     //     Serial.println(cur_pos);            
    //     // }
    //     // else
    //     // {
    //     //     Serial.print("Cur Pos: ");
    //     //     Serial.print(cur_pos);
    //     // }

    //     if(abs(cur_pos - center_point - rad) < 0.009)
    //     {
    //         Serial.println("Here yo!");
    //         if(Direction == 0)
    //         {
    //             Direction = 1;
    //         }
    //         else
    //         {
    //             Direction = 0;
    //         }
    //     }

    //     if(abs(cur_pos-dest) < 0.01)
    //     {
    //         Serial.print("Cur Pos: ");
    //         Serial.print(cur_pos);
    //         // Serial.println(AmountOfStepsTaken);
    //         noInterrupts();// disable all interrupts
    //         if(X_plane)
    //         {
    //             TIFR1 |= (1 << OCF1A);
    //         }
    //         else
    //         {
    //             TIFR4 |= (1 << OCF4A);
    //         }
    //         TIFR3 |= (1 << OCF3A); 
    //         MotorIsMoving = false;
    //         ResetMotor();
    //         // Serial.println("Stepping finished\n");
    //         interrupts();   // enable all interrupts
    //     }
    // }
    if (AmountOfStepsTaken == TotalSteps)
    {
        // Serial.print("Steps Taken: ");
        // Serial.println(AmountOfStepsTaken);
        noInterrupts();// disable all interrupts
        if(X_plane)
        {
            TIFR1 |= (1 << OCF1A);
        }
        else
        {
            TIFR4 |= (1 << OCF4A);
        }
        TIFR3 |= (1 << OCF3A); 
        MotorIsMoving = false;
        ResetMotor();
        // Serial.println("Stepping finished\n");
        interrupts();   // enable all interrupts
    }

    OCR1A = CalcSPSTimerRegisterValue(); // Set Timer Reg to new value
}

uint16_t Stepper_Motor::CalcSPSTimerRegisterValue()
{
    // if(Circle)
    // {
    //     if(X_plane)
    //     {
    //         CurrentSPS = abs(acos( ((cur_pos - center_point)/rad))/(PI/2) -1) * DefaultSPS;
    //         // Serial.print("Cur Pos X: ");
    //         // Serial.println(cur_pos);  
    //     }
    //     else
    //     {
    //         CurrentSPS = abs(asin( ((cur_pos - center_point)/rad))/(PI/2) ) * DefaultSPS;

    //         // Serial.print("Cur Pos: ");
    //         // Serial.print(cur_pos);
    //         // Serial.print(" Direction: ");
    //         // Serial.println(Direction);
    //         // Serial.print("CurSPS: ");
    //         // Serial.println(CurrentSPS);
    //     }
            
    // }

    uint32_t timePerStep;
    if (CurrentSPS < 1)
    {
        timePerStep = CLCKSPD;
    }
    else
    {
        timePerStep = (CLCKSPD/(uint32_t)CurrentSPS);
    }
    // Serial.print("TimePerStep: ");
    // Serial.println(timePerStep);
    if(timePerStep >= 65535) //Checks for potential overflow
    {
        timePerStep = 65535;
    }
    uint16_t temp = timePerStep;
    
    if(X_plane)
    {
        // Serial.println(temp);
    }
    else
    {
        // Serial.println(temp);
    }
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
            // Serial.println("Max reached");
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
    // Serial.print("Plane: ");
    // if (X_plane)
    // {
    //     Serial.println("X hit");
    // }
    // else
    // {
    //     Serial.println("Y hit");
    // }
    CurrentSPS = DefaultSPS;
    AmountOfStepsTaken = 0;
    Accelerate = false;
    Decelerate = false;
    Circle = false;

    uint8_t temp = 0;
    if(X_plane)
    {
        temp = (1 << OCIE1A);
        temp != temp;
        TIMSK1 &= 0;  // disable timer compare interrupt (Steps)
    }
    else
    {
        temp = (1 << OCIE4A);
        temp != temp;
        TIMSK4 &= 0;  // disable timer compare interrupt (Steps)
    }

    temp = 0;
    temp = (1 << OCIE3A);
    temp != temp;
    TIMSK3 &= 0;  // disable timer compare interrupt (Acceleration)
}

void Stepper_Motor::Home()
{
    digitalWrite(DirectionPin, Direction);
    // delay(100);
    TotalSteps = 20000;
    MotorIsMoving = true;

    if(X_plane)
        TIMSK1 |= (1 << OCIE1A);  // enable timer compare interrupt (Steps)
    else
        TIMSK4 |= (1 << OCIE4A);  // enable timer compare interrupt (Steps)
}
