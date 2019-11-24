
#include "gcode_interpretation.h"

gcode_interpretation::gcode_interpretation(Stepper_Motor m1, Stepper_Motor m2)
{
  stpm1 = m1;
  stpm2 = m2;
}

String gcode_interpretation::parse_commands(int buffer_length)
{
  String commands[buffer_length];
  int comm_index = 0;
  int line_index = 0;

  while(Serial.available() > 0 && comm_index < buffer_length)
    {
      String command = "";

      command = Serial.readStringUntil('\n');
    }

  String command;
  command = Serial.readStringUntil('\n');

  return command;
}

bool gcode_interpretation::interpret_gcode(String command)
{
  int index = 0;

  while(index < command.length())
    {
      switch(command[index])
      {
        case 'G':
          String temp = command.substring(index, command.indexOf(' ', index));

          if (temp == "G00") //Rapid positioning
          {

          }
          else if (temp == "G0")
          {
            rapid_positioning(command);
            break;
          }
          else if (temp == "G01") //Linear interpolation
          {

          }
          else if (temp == "G1")
          {
            linear_interpolation(command);
            break; 
          }
          else if (temp == "G02") //Circular clockwise interpolation
          {

          }
          else if (temp == "G2")
          {
            circ_interpolation_cw(command);
            break;
          }
          else if (temp == "G03")//Circular counterclockwise interpolation
          {

          }
          else if (temp == "G3")
          {
            circ_interpolation_ccw(command);
            break;
          }
          else if (temp == "G28")//Home machine
          {
            Home();
            break;
          }
          else
          {
            break;
          }

        case 'M':

        default:
          break;
      }

      index++;
    }
}

bool gcode_interpretation::rapid_positioning(String command)
{
  float x, y, z, X, Y;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = 0.0;

  X = stpm1.GetCurrPos();
  Y = stpm2.GetCurrPos();

  //Retract Z

  if(x-X > 0) 
  {
    stpm1.MoveMotor((x-X)*stepRatio, 1);
  } 
  else
  {
    stpm1.MoveMotor((x-X)*-stepRatio, 0);
  }
  
  if(y-Y > 0)
  {
    stpm2.MoveMotor((y-Y)*stepRatio, 1);      
  }
  else
  {
    stpm2.MoveMotor((y-Y)*-stepRatio, 0);
  }

  return true;
}

bool gcode_interpretation::linear_interpolation(String command)
{
  float x, y, z, X, Y, slope;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;

  X = stpm1.GetCurrPos();
  Y = stpm2.GetCurrPos();

  slope = ((y-Y)/(x-X));

  //Actuate Z

  stpm1.SetCurrentSPS(stpm1.GetCurrentSPS()*abs(1/slope));
  stpm2.SetCurrentSPS(stpm2.GetCurrentSPS()*abs(slope));

  if(x-X > 0) 
  {
    stpm1.MoveMotor((x-X)*stepRatio, 1);
  } 
  else
  {
    stpm1.MoveMotor((x-X)*-stepRatio, 0);
  }
  
  if(y-Y > 0)
  {
    stpm2.MoveMotor((y-Y)*stepRatio, 1);      
  }
  else
  {
    stpm2.MoveMotor((y-Y)*-stepRatio, 0);
  }

  return true;
}

bool gcode_interpretation::circ_interpolation_cw(String command)
{
  float x, y, z, i, j, rad;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = 1.0;
  i = command.substring(command.indexOf('I'),command.indexOf(' ', command.indexOf('I'))).toFloat();
  j = command.substring(command.indexOf('J'),command.indexOf(' ', command.indexOf('J'))).toFloat();
  
  rad = sqrt(sq(x-i)+sq(y-j));

  stpm1.SetRadius(rad);
  stpm2.SetRadius(rad);

  stpm1.SetCircle(true);
  stpm2.SetCircle(true);
  
  //Move around arc

  return true;
}

bool gcode_interpretation::circ_interpolation_ccw(String command)
{
  float x, y, z, i, j, rad;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;
  i = command.substring(command.indexOf('I'),command.indexOf(' ', command.indexOf('I'))).toFloat();
  j = command.substring(command.indexOf('J'),command.indexOf(' ', command.indexOf('J'))).toFloat();
  
  rad = sqrt(sq(x-i)+sq(y-j));
  
  //Move around arc

  return true;
}

void gcode_interpretation::Home()
{
    homingx = true;
    homingy = true;

    stpm1.SetDirection(0);
    stpm2.SetDirection(0);

    stpm1.Home();
    Serial.println("Home x");
    stpm2.Home();
    Serial.println("Home y");
    while(homingx || homingy){}

    Serial.println("Both were triggered");
    if(stpm1.GetDirection() == 0)
    {
        stpm1.MoveMotor(200, 1);
    }
    else
    {
        stpm1.MoveMotor(200, 0);
    }

    if(stpm2.GetDirection() == 0)
    {
        stpm2.MoveMotor(200, 1);
    }
    else
    {
        stpm2.MoveMotor(200, 0);
    }

    while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){} // Wait till that stop
}
