#include "gcode_interpretation.h"

extern volatile byte stepperFlags;

gcode_interpretation::gcode_interpretation()
{
  stpms[0] = Stepper_Motor(StepsPerRev, stmp1_DirectionPin, stmp1_StepPin, true);
  stpms[1] = Stepper_Motor(StepsPerRev, stmp2_DirectionPin, stmp2_StepPin, false);
  stpms[2] = Stepper_Motor(StepsPerRev, stpm3_dir, stpm3_step, false);
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
  command = command + " ";
  String temp = "";

  while(index < command.length())
    {
      switch(command[index])
      {
        case 'G':
          temp = command.substring(index, command.indexOf(' ', index));

          if (temp == "G00" || temp == "G0") //Rapid positioning
          {
            rapid_positioning(command);
            break;
          }
          else if (temp == "G01" || temp == "G1") //Linear interpolation
          {
            linear_interpolation(command);
            break; 
          }
          else if (temp == "G02" || temp == "G2") //Circular clockwise interpolation
          {
            circ_interpolation_cw(command);
            break;
          }
          else if (temp == "G03" || temp == "G3")//Circular counterclockwise interpolation
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
          temp = command.substring(index, command.indexOf(' ', index));

          if(temp == "M3" || temp == "M03" || temp == "M4" || temp == "M04")
          {
            drop_medium();
            break;
          }
          else if(temp == "M5" || temp == "M05")
          {
            raise_medium();
            break;
          }
          else
          {
            break;
          }
          
        case 'Z':
          temp = command.substring(command.indexOf('Z') + 1 , command.indexOf(' ', command.indexOf('Z')));

          if(temp.toFloat() < 0) 
          {
            stpms[2].MoveMotor(abs(temp.toFloat()) * stepRatio, 0);
          }
          else
          {
            stpms[2].MoveMotor(abs(temp.toFloat()) * stepRatio, 1);
          }

          break;
          
        default:
          break;
      }

      index++;
    }

    return true;
}

bool gcode_interpretation::rapid_positioning(String command)
{
  float x, y, z, X, Y;

  Serial.println("Rapid");
  raise_medium();
  if (command.indexOf('X') == -1 || command.indexOf('Y') == -1)
  {
    return false;
  }
  x = command.substring(command.indexOf('X') + 1, command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1 , command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = 0.0;

  X = stpms[0].GetCurPos();
  Y = stpms[1].GetCurPos();

  // //Retract Z

  if(x-X > 0) 
  {
    stpms[0].MoveMotor(abs((x-X)) * stepRatio , 1);
  } 
  else
  {
    stpms[0].MoveMotor(abs((x-X)) * stepRatio, 0);
  }
  
  if(y-Y > 0)
  {
    stpms[1].MoveMotor(abs((y-Y)) * stepRatio, 1);      
  }
  else
  {
    stpms[1].MoveMotor(abs((y-Y)) * stepRatio, 0);
  }

  while(stepperFlags); // Wait till that stop

  return true;
}

bool gcode_interpretation::linear_interpolation(String command)
{
  float x, y, z, X, Y, delay_x, delay_y, min_delay_x, min_delay_y, mag, diff_X, diff_Y, slope_X, slope_Y;

  Serial.println("Linear");
  if (command.indexOf('X') == -1 || command.indexOf('Y') == -1)
  {
    return false;
  }
  x = command.substring(command.indexOf('X') + 1 ,command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1 ,command.indexOf(' ', command.indexOf('Y'))).toFloat();
  // z = -1.0;

  X = stpms[0].GetCurPos();
  Y = stpms[1].GetCurPos();

  // Serial.println(x);
  // Serial.println(y);
  diff_Y = abs(y - Y);
  diff_X = abs(x - X);

  mag = sqrt( sq(diff_X) + sq(diff_Y) );

  slope_X = diff_X/mag;
  slope_Y = diff_Y/mag;

  delay_x = stpms[0].GetAccel() * 1/slope_Y;
  delay_y = stpms[1].GetAccel() * 1/slope_X;

  min_delay_x = stpms[0].GetMinDelay() * 1/slope_Y;
  min_delay_y = stpms[1].GetMinDelay() * 1/slope_X;

  Serial.println(delay_x);
  Serial.println(min_delay_x);

  if(min_delay_x < min_delay_default)
  {
    min_delay_x = min_delay_default;
  }

  if(min_delay_y < min_delay_default)
  {
    min_delay_y = min_delay_default;
  }

  stpms[0].SetAccel(delay_x);
  stpms[0].SetMinDelay(min_delay_x);
  stpms[1].SetAccel(delay_y);
  stpms[1].SetMinDelay(min_delay_y);


  if(diff_X > 0)
  {
    if(x - X > 0) 
    {
      stpms[0].MoveMotor(diff_X*stepRatio, 1);
    } 
    else
    {
      stpms[0].MoveMotor(diff_X*stepRatio, 0);
    }
  }
  
  if(diff_Y > 0)
  {
    if(y - Y > 0)
    {
      stpms[1].MoveMotor(diff_X*stepRatio, 1);      
    }
    else
    {
      stpms[1].MoveMotor(diff_X*stepRatio, 0);
    }
  }

  while(stepperFlags);

  // Set motors back to default
  for (int i = 0; i < NumOFMotors; i++)
  {
    stpms[i].SetMinDelayToDefault();
    stpms[i].SetAccelToDefault();
  }

  return true;
}

bool gcode_interpretation::circ_interpolation_cw(String command)
{
  float x, y, z, i, j, I, J, rad, theta, arclen, center_angle, x_toMove, y_toMove;

  Serial.println("Circ cw");
  x = command.substring(command.indexOf('X') + 1,command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1,command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;
  I = command.substring(command.indexOf('I') + 1,command.indexOf(' ', command.indexOf('I'))).toFloat();
  J = command.substring(command.indexOf('J') + 1,command.indexOf(' ', command.indexOf('J'))).toFloat();
  i = x + I;
  j = y + J;

  // rad = sqrt(sq(x-i)+sq(y-j));

  // if (abs(x - stpm1.GetCurrPos()) < 0.01 && abs(y - stpm2.GetCurrPos()) < 0.01)
  // {
  //   center_angle = 360.0;
  // }
  // else
  // {
  //   center_angle = ( atan2(y - j, x - i) - atan2(stpm2.GetCurrPos() - j, stpm1.GetCurrPos() - i) ) * 180 / PI; 
  // }

  // Serial.print("Center angle: ");
  // Serial.println(center_angle);

  // arclen = 2 * PI * rad * center_angle / 360;
  // Serial.print("Arclen: ");
  // Serial.println(arclen);

  // stpm1.SetRadius(rad);
  // stpm2.SetRadius(rad);

  // stpm1.SetCircle(true);
  // stpm2.SetCircle(true);

  // stpm1.SetCenter(i);
  // stpm2.SetCenter(j);

  // int x_direction = 1;
  // int y_direction = 1;
  // float radians;

  // float temp_x, temp_y;

  // for(float angle = 0.0; angle < center_angle; angle++)
  // {

  //   radians = angle * PI / 180;
    
  //   x_toMove = rad * cos(radians);
  //   y_toMove = rad * sin(radians);

  //   // Serial.print("Angle: ");
  //   // Serial.println(angle);

  //   // Serial.print("x_toMove: ");
  //   // Serial.println(x_toMove);

  //   // Serial.print("y_toMove: ");
  //   // Serial.println(y_toMove);

  //   if(angle < 180.0)
  //   {
  //     x_direction = 1;
  //   }
  //   else
  //   {
  //     x_direction = 0;
  //   }

  //   if(270.0 > angle > 90.0)
  //   {
  //     y_direction = 0;
  //   }
  //   else if (angle > 270.0)
  //   {
  //     y_direction = 1;
  //   }

  //   // Serial.print("X Dir: ");
  //   // Serial.println(x_direction);
  //   // Serial.print("Y Dir: ");
  //   // Serial.println(y_direction);

  //   temp_x = x_toMove / 0.05;
  //   temp_y = y_toMove / 0.05;

  //   // Serial.print("X Move: ");
  //   // Serial.println(temp_x);
  //   // Serial.print("Y Move: ");
  //   // Serial.println(temp_y);

  //   stpm1.MoveMotor(temp_x, x_direction);
  //   stpm2.MoveMotor(temp_y, y_direction);

  //   while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);}

  // }

  // while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

  return true;
}

bool gcode_interpretation::circ_interpolation_ccw(String command)
{
  float x, y, z, i, j, I, J, rad, theta;

  Serial.println("Circ ccw");
  x = command.substring(command.indexOf('X') + 1,command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1,command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;
  I = command.substring(command.indexOf('I') + 1,command.indexOf(' ', command.indexOf('I'))).toFloat();
  J = command.substring(command.indexOf('J') + 1,command.indexOf(' ', command.indexOf('J'))).toFloat();
  i = x + I;
  j = y + J;

  // rad = sqrt(sq(x-i)+sq(y-j));
  // theta = acos( (sq(x - stpm1.GetCurrPos()) - 2*sq(rad) ) / (2*rad) ) * rad;
  // Serial.print("Arclen: ");
  // Serial.println(theta);

  // stpm1.SetRadius(rad);
  // stpm2.SetRadius(rad);

  // stpm1.SetCircle(true);
  // stpm2.SetCircle(true);

  // stpm1.SetCenter(i);
  // stpm2.SetCenter(j);
  
  // //Move around arc
  // stpm1.MoveMotor(0, 0);
  // stpm2.MoveMotor(0, 0);
  
  // //Move around arc
  // while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

  return true;
}

void gcode_interpretation::drop_medium()
{
  digitalWrite(solen, LOW);
}

void gcode_interpretation::raise_medium()
{
  digitalWrite(solen, HIGH);
}

void gcode_interpretation::Home()
{
  raise_medium();
  SetHomingx(true);
  SetHomingy(true);

  stpms[0].SetDir(0);
  stpms[1].SetDir(0);

  stpms[0].Home();
  // Serial.println("Home x");
  stpms[1].Home();
  // Serial.println("Home y");

  while(stepperFlags);

  // Serial.println("Both were triggered");

  stpms[0].MoveMotor(2*StepsPerRev, 1);
  stpms[1].MoveMotor(2*StepsPerRev, 1);

  while(stepperFlags); // Wait till that stop

  SetHomingx(false);
  SetHomingy(false);
  
  stpms[0].SetCurPos(0);
  stpms[1].SetCurPos(0);
}
