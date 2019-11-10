String[][] parse_commands(int buffer_length, int code_length)
{
  String[][] commands = new String[buffer_length][code_length];
  int comm_index = 0;
  int line_index = 0;

  while(Serial.available() > 0 && comm_index < buffer_length)
    {
      String temp = "";
      int ind = 0;

      temp = Serial.readStringUntil('\n');

      while(line_index < code_length && ind < temp.length())
	{
	  commands[comm_index][line_index++] = temp.substring(ind, temp.indexOf(' ', ind));
	  ind = temp.indexOf(' ', ind) + 1;
	  line_index++;
	}
    }
}

bool interpret_gcode(String[] command)
{
  switch(command[0])
    {
    case 'N':
      break;
    case 'G':
      switch(command[1][1])
	{
	case'0':
	  switch(command[1][2])
	    {
	    case'0': //Rapid positioning
		  
	    case'1': //Linear interpolation

	    case'2': //Circular clockwise interpolation

	    case'3': //Circular counterclockwise interpolation

	    default:
	      break;
	    }
	case'2':
	  switch(command[1][2])
	    {
	    case'0': //Programming in inches

	    case'1': //Programming in mm
	      
	    case'8': //Return to home position
		  
	    default:
	      break;
	    }
	default:
	  break;
	}
    default:
      break;
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
  float x, y, z, i, j;

  x = command.substring(command.indexOf('X'),command.indexOf(' ', command.indexOf('X')).toFloat());
  y = command.substring(command.indexOf('Y'),command.indexOf(' ', command.indexOf('Y')).toFloat());
  z = -1.0;
  i = command.substring(command.indexOf('I'),command.indexOf(' ', command.indexOf('I')).toFloat());
  j = command.substring(command.indexOf('J'),command.indexOf(' ', command.indexOf('J')).toFloat());
  
  //Move around arc

  
}
