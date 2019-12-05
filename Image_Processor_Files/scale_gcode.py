import sys

scale_factor = sys.argv[1]
file = sys.argv[2]
out_file = open(file[0:-4] + '_scaled.gco',"w")

with open(file) as fp:
	count = 0
	for line in fp:
		if count > 3:
			line_values = line.split()

			if len(line_values) >= 3:

				#Scale X
				x = line_values[1][1:len(line_values[1])]

				x = float(x) * float(scale_factor)
				line_values[1] = 'X' + str(x)

				#Scale Y
				y = line_values[2][1:len(line_values[2])]

				y = float(y) * float(scale_factor)
				line_values[2] = 'Y' + str(y)

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

	