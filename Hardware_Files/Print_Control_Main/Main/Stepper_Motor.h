// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Arduino.h"

class Stepper_Motor
{
    public:
    Stepper_Motor(){}
    Stepper_Motor(int stepsPerRevolution, uint8_t directionPin, uint8_t stepPin, int maxSPS); 
    void MoveMotor(int steps, int direction); // Direction should 0 or 1
    void Home();
    uint32_t GetStepsPerRevolution() { return StepsPerRevolution; }
    uint8_t GetDirectionPin() { return DirectionPin; }
    uint8_t GetStepPin() { return StepPin; }
    uint32_t GetStepsTaken() { return AmountOfStepsTaken; }
    uint32_t GetCurrentSPS() { return CurrentSPS; }
    int GetDirection() { return Direction; }
    void Step();
    void IncrementSPS();
    void ResetMotor();
    void StepperAccelerationAdjuster();
    bool IsMotorMoving() { return MotorIsMoving; }

    private:
    int Direction;
    uint32_t CLCKSPD = 16000000;
    uint32_t accelerationRate = 2;
    uint32_t AmountOfStepsTaken;
    uint32_t DefaultStepsPerSecond;
    uint32_t StepsPerRevolution;
    uint8_t DirectionPin;
    uint8_t StepPin;
    uint32_t MaxSPS;
    uint32_t CurrentSPS;
    uint32_t TotalSteps;
    bool Accelerate;
    bool Decelerate;
    bool MotorIsMoving;

    uint16_t CalcSPSTimerRegisterValue();
};
