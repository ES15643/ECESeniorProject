#include "gcode_interpretation.h"

extern Stepper_Motor stpm1;
extern Stepper_Motor stpm2;

gcode_interpretation::gcode_interpretation(Stepper_Motor m1, Stepper_Motor m2)
{
  // stpm1 = m1;
  // stpm2 = m2;
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

  while(index < command.length())
    {
      switch(command[index])
      {
        case 'G':
          String temp = command.substring(index, command.indexOf(' ', index));

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
  x = command.substring(command.indexOf('X') + 1, command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1 , command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = 0.0;

  Serial.println(x);
  Serial.println(y);

  X = stpm1.GetCurrPos();
  Y = stpm2.GetCurrPos();

  //Retract Z

  if(x-X > 0) 
  {
    stpm1.MoveMotor(abs((x-X))*stepRatio, 1);
  } 
  else
  {
    stpm1.MoveMotor(abs((x-X))*stepRatio, 0);
  }
  
  if(y-Y > 0)
  {
    stpm2.MoveMotor(abs((y-Y))*stepRatio, 1);      
  }
  else
  {
    stpm2.MoveMotor(abs((y-Y))*stepRatio, 0);
  }

  while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

  return true;
}

bool gcode_interpretation::linear_interpolation(String command)
{
  float x, y, z, X, Y, slope;

  Serial.println("Linear");
  x = command.substring(command.indexOf('X') + 1 ,command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1 ,command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;

  X = stpm1.GetCurrPos();
  Y = stpm2.GetCurrPos();

  Serial.println(x);
  Serial.println(y);

  slope = ((y-Y)/(x-X));

  //Actuate Z

  stpm1.SetCurrentSPS(stpm1.GetCurrentSPS()*abs(1/slope));
  stpm2.SetCurrentSPS(stpm2.GetCurrentSPS()*abs(slope));
  float changeX = abs((x-X));
  float changeY = abs((y-Y));
  Serial.println(changeX);
  Serial.println(changeY);

  if(x-X > 0) 
  {
    stpm1.MoveMotor(changeX*stepRatio, 1);
  } 
  else
  {
    stpm1.MoveMotor(changeX*stepRatio, 0);
  }
  
  if(y-Y > 0)
  {
    stpm2.MoveMotor(changeY*stepRatio, 1);      
  }
  else
  {
    stpm2.MoveMotor(changeY*stepRatio, 0);
  }

  while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

  return true;
}

bool gcode_interpretation::circ_interpolation_cw(String command)
{
  float x, y, z, i, j, I, J, rad, theta, arclen;

  Serial.println("Circ cw");
  x = command.substring(command.indexOf('X') + 1,command.indexOf(' ', command.indexOf('X'))).toFloat();
  y = command.substring(command.indexOf('Y') + 1,command.indexOf(' ', command.indexOf('Y'))).toFloat();
  z = -1.0;
  I = command.substring(command.indexOf('I') + 1,command.indexOf(' ', command.indexOf('I'))).toFloat();
  J = command.substring(command.indexOf('J') + 1,command.indexOf(' ', command.indexOf('J'))).toFloat();
  i = x + I;
  j = y + J;

  rad = sqrt(sq(x-i)+sq(y-j));
  
  theta = atan2( (y - j), (x - i) ) + atan2( (stpm2.GetCurrPos() - j), (stpm1.GetCurrPos() - i) );
  Serial.print("Theta: ");
  Serial.println(theta);
  arclen = rad * theta;

  // Serial.print("X: ");
  // Serial.println(rad);

  stpm1.SetRadius(rad);
  stpm2.SetRadius(rad);

  stpm1.SetCircle(true);
  stpm2.SetCircle(true);

  stpm1.SetCenter(i);
  stpm2.SetCenter(j);
  
  //Move around arc
  stpm1.MoveMotor(0, 1);
  stpm2.MoveMotor(0, 1);

  while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

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

  rad = sqrt(sq(x-i)+sq(y-j));
  theta = acos( (sq(x - stpm1.GetCurrPos()) - 2*sq(rad) ) / (2*rad) ) * rad;
  Serial.print("Arclen: ");
  Serial.println(theta);

  stpm1.SetRadius(rad);
  stpm2.SetRadius(rad);

  stpm1.SetCircle(true);
  stpm2.SetCircle(true);

  stpm1.SetCenter(i);
  stpm2.SetCenter(j);
  
  //Move around arc
  stpm1.MoveMotor(0, 0);
  stpm2.MoveMotor(0, 0);
  
  //Move around arc
  while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop

  return true;
}

void gcode_interpretation::Home()
{
    SetHomingx(true);
    SetHomingy(true);

    stpm1.SetDirection(0);
    stpm2.SetDirection(0);

    stpm1.Home();
    Serial.println("Home x");
    stpm2.Home();
    Serial.println("Home y");

    while(GetHomingx() || GetHomingy()){delay(1);}

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

    while(stpm1.IsMotorMoving() || stpm2.IsMotorMoving()){delay(1);} // Wait till that stop
}
