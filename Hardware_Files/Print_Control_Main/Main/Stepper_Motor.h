// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Arduino.h"

class Stepper_Motor
{
    public:
    Stepper_Motor(){}
    Stepper_Motor(int stepsPerRevolution, uint8_t directionPin, uint8_t stepPin, int maxSPS, bool x_plane); 
    uint8_t GetDirectionPin() { return DirectionPin; }
    uint8_t GetStepPin() { return StepPin; }
    uint32_t GetStepsPerRevolution() { return StepsPerRevolution; }
    uint32_t GetStepsTaken() { return AmountOfStepsTaken; }
    uint32_t GetCurrentSPS() { return CurrentSPS; }
    uint32_t SetCurrentSPS(uint32_t inSPS) { CurrentSPS = inSPS; }
    uint32_t SetDefaultCircleSPS( uint32_t inSPS) { DefaultSPS = inSPS; }
    int GetDirection() { return Direction; }
    void MoveMotor(int steps, int direction); // Direction should 0 or 1
    void Home();
    void SetDirection(int inDirection) { Direction = inDirection; }
    void Step();
    void IncrementSPS();
    void ResetMotor();
    void StepperAccelerationAdjuster();
    void SetCircle(bool circle){ Circle = Circle; }
    void SetCurrPos(float pos){ cur_pos = pos; }
    void SetRadius(float r){ rad = r; }
    void SetDest(float d){ dest = d; }
    void SetCenter(float c){ center_point = c; }
    bool IsMotorMoving() { return MotorIsMoving; }
    bool GetIfCircle(){ return Circle; }
    float GetCurrPos(){ return cur_pos; }

    private:
    int Direction = 0;
    bool X_plane;
    float cur_pos;
    float center_point;
    float dest;
    float rad;
    uint32_t CLCKSPD = 16000000;
    uint32_t accelerationRate = 2;
    uint32_t AmountOfStepsTaken;
    uint32_t DefaultStepsPerSecond;
    uint32_t StepsPerRevolution;
    uint8_t DirectionPin;
    uint8_t StepPin;
    uint32_t MaxSPS;
    uint32_t CurrentSPS;
    uint32_t DefaultSPS = 500;
    uint32_t TotalSteps;
    bool Accelerate;
    bool Decelerate;
    bool MotorIsMoving;
    bool Circle = false;

    uint16_t CalcSPSTimerRegisterValue();
};
