import sys

def Swap(items):
	x = items[1][1:len(items[1])]
	y = items[2][1:len(items[2])]

	x_swapped = 'X' + y
	y_swapped = 'Y' + x

	items[1] = x_swapped
	items[2] = y_swapped

	new_line = ''
	for i in items:
		new_line = new_line + str(i) + " "
	new_line = new_line + '\n'

	return new_line

def Scale(items):
	#Scale X
	x = items[1][1:len(items[1])]

	x = float(x) * float(scale_factor)
	items[1] = 'X' + str(x)

	#Scale Y
	y = items[2][1:len(items[2])]

	y = float(y) * float(scale_factor)
	items[2] = 'Y' + str(y)
	
	return items

for i in sys.argv:
	print(i)

file = sys.argv[1]
out_file = open(sys.argv[2], "w")
if len(sys.argv) == 4:
	scale_factor = sys.argv[3]

with open(file) as fp:
	count = 0
	for line in fp:
		if count > 3:
			line_values = line.split()
			if len(line_values) >= 3:
				temp = ''
				
				if len(sys.argv) == 4:
					temp = Swap(Scale(line_values))
				else:
					temp = Swap(line_values)

				out_file.write(temp)
			else:
				out_file.write(line)

		else:
			count = count + 1
			out_file.write(line)