// Created by Evan Scullion 6/2/2019 for Senior Project Stepper Motor
#include "Arduino.h"
#include "Macros.h"


class Stepper_Motor
{
    public:
    Stepper_Motor(){}
    Stepper_Motor(int stepsPerRevolution, uint8_t directionPin, uint8_t stepPin, bool x_plane = true); 
    void Step();
    void ResetMotor();
    void Home();
    void MoveMotor(unsigned long steps, uint8_t dir);

    // Gets
    bool MotorIsMoving(){ return MovingDone; }
    uint8_t GetDir(){ return Direction; }
    long GetCurPos(){ return CurPos; }
    float GetCurrentDelay(){ return CurrentDelay; }
    unsigned long GetTotalSteps(){ return TotalSteps; }
    unsigned int GetStepsToMax(){ return StepsToMax; }
    unsigned int GetStartingDelay(){ return StartingDelay; }
    unsigned int GetAccelIndex(){ return AccelCurveIndex; }
    unsigned long GetStepCount(){ return StepCount; }
    unsigned int GetMinDelay(){ return MinDelay; }
    unsigned long GetTruncDelay(){ return TruncateDelay; }

    // Sets
    void SetDir(uint8_t dir);
    void SetMotorDone(){ MovingDone = true; }
    void SetCurPos(long pos){ CurPos = pos; }
    void SetCurrentDelay(float delay) { CurrentDelay = delay; }
    void SetTruncDelay(unsigned long delay) { TruncateDelay = delay; }
    void SetAccelIndex(unsigned int i){ AccelCurveIndex = i; }
    void SetMinDelay(unsigned int delay){ MinDelay = delay; }
    void SetAccel(float accel){ Accel = accel; }
    void IncrementAccelIndex(){ AccelCurveIndex++; }
    void DecrementAccelIndex(){ AccelCurveIndex--; }
    void SetStepsToMax(unsigned int count){ StepsToMax = count; } 

    private:
    volatile bool MovingDone = true;
    volatile bool XPlane;
    volatile uint8_t DirPin;
    volatile uint8_t StepPin;
    volatile uint8_t Direction;
    volatile float Accel = 1000;
    volatile float CurrentDelay; // d
    volatile long CurPos;
    volatile unsigned long TotalSteps;
    volatile unsigned int StepsToMax; // rampUpCount
    volatile unsigned int StartingDelay; // c0
    volatile unsigned int AccelCurveIndex;
    volatile unsigned int SPR; // Steps Per Rev
    volatile unsigned int MinDelay = 50; // Max Speed
    volatile unsigned long StepCount; // Current Step
    volatile unsigned long TruncateDelay; // d1

};
