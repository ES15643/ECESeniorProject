//Created by Nathan Page for Senior Project GCode interpretation on November 1, 2019
// #include <String>
#include "Arduino.h"
#include "Stepper_Motor.h"

class gcode_interpretation
{

    public:
    gcode_interpretation(){}
    gcode_interpretation(Stepper_Motor m1, Stepper_Motor m2);
    String parse_commands(int buffer_length);
    bool interpret_gcode(String command);
    bool rapid_positioning(String command);
    bool linear_interpolation(String command);
    bool circ_interpolation_cw(String command);
    bool circ_interpolation_ccw(String command);
    bool GetHomingx(){ return homingx; }
    bool GetHomingy(){ return homingy; }
    void SetHomingx(bool homing){ homingx = homing; }
    void SetHomingy(bool homing){ homingy = homing; }
    void Home();

    private:
    uint32_t stepRatio = 200;
    bool homingx = false;
    bool homingy = false;
    // Stepper_Motor stm1;
    // Stepper_Motor stpm2;
};