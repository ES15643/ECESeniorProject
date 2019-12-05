import sys

file = sys.argv[1]
out_file = open(file[0:-4] + '_swapped.gco',"w")

with open(file) as fp:
	count = 0
	for line in fp:
		if count > 3:
			line_values = line.split()
			if len(line_values) >= 3:
				x = line_values[1][1:len(line_values[1])]
				y = line_values[2][1:len(line_values[2])]

				x_swapped = 'X' + y
				y_swapped = 'Y' + x

				line_values[1] = x_swapped
				line_values[2] = y_swapped

				temp = ''
				for i in line_values:
					temp = temp + str(i) + " "
				temp = temp + '\n'

				out_file.write(temp)
			else:
				out_file.write(line)

		else:
			count = count + 1
			out_file.write(line)