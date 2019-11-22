//Created by Nathan Page for Senior Project GCode interpretation on November 1, 2019
#include <string.h>
#include "Arduino.h"
#include "Stepper_Motor.h"

uint32_t stepRatio = 50;

String* parse_commands(int buffer_length)
{
  String commands[] = new String[buffer_length];
  int comm_index = 0;
  int line_index = 0;

  while(Serial.available() > 0 && comm_index < buffer_length)
    {
      String command = "";

      command = Serial.readStringUntil('\n');
    }

  return commands;
}

bool interpret_gcode(String command)
{
  int index = 0;

  while(index < command.length())
    {
      switch(command[index])
	{
	case 'G':
	  switch(command.substring(index, command.indexOf(' ', index)))
	    {
	    case"G00": //Rapid positioning
	    case"G0":
	      rapid_positioning(command);
	    break;
	    case"G01": //Linear interpolation
	    case"G1":
	      linear_interpolation(command);
	    break;
	    case"G02": //Circular clockwise interpolation
	    case"G2":
	      circ_interpolation_cw(command);
	    break;
	    case"G03": //Circular counterclockwise interpolation
	    case"G3":
	      circ_interpolation_ccw(command);
	    break;
	    case"G28": //Home machine
	      Home();
	      break;
	    default:
	      break;
	    }
	case 'M':
	default:
	  break;
	}

      index++;
    }
}

bool rapid_positioning(String command)
{
  float x, y, z, X, Y;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
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

bool linear_interpolation(String command)
{
  float x, y, z, X, Y, slope;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
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

bool circ_interpolation_cw(String command)
{
  float x, y, z, i, j, rad;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
  z = -1.0;
  i = command.substring(command.indexOf('I'),command.indexOf(' ', command.indexOf('I')).toFloat());
  j = command.substring(command.indexOf('J'),command.indexOf(' ', command.indexOf('J')).toFloat());
  
  rad = sqrt(sq(x-i)+sq(y-j));

  stpm1.SetRadius(rad);
  stpm2.SetRadius(rad);

  stpm1.SetCircle(true);
  stpm2.SetCircle(true);

  
  
  //Move around arc

  return true;
}

bool circ_interpolation_ccw(String command)
{
  float x, y, z, i, j, rad;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
  z = -1.0;
  i = command.substring(command.indexOf('I'),command.indexOf(' ', command.indexOf('I')).toFloat());
  j = command.substring(command.indexOf('J'),command.indexOf(' ', command.indexOf('J')).toFloat());
  
  rad = sqrt(sq(x-i)+sq(y-j));
  
  //Move around arc

  return true;
}
