//Created by Nathan Page for Senior Project GCode interpretation on November 1, 2019

String[] parse_commands(int buffer_length)
{
  String[] commands = new String[buffer_length];
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
	case'M':
	default:
	  break;
	}

      index++;
    }
}

bool rapid_positioning(String command)
{
  float x, y, z;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
  z = 0.0;

  //Move motor to (x, y, z) with standard methods

  return true;
}

bool linear_interpolation(String command)
{
  float x, y, z;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
  z = -1.0;

  //Drive motor to (x, y, z) along straight line from current position

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
