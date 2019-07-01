#Image processor for contervting images to black and white created by Evan Scullion on 5/20/19 for Senior Project
import sys
import numpy as np
from PIL import Image

def CompareSums(sumOfThree1, sumOfThree2, sumOfThree3, i):
    if sumOfThree1 > 126:
        pix_values[i] = (0,0,0)
    else:
        pix_values[i] = (255,255,255) 

    if sumOfThree2 > 126:
        pix_values[i + 1] = (0,0,0)
    else:
        pix_values[i + 1] = (255,255,255) 

    if sumOfThree3 > 126:
        pix_values[i + 2] = (0,0,0) 
    else:
        pix_values[i + 2] = (255,255,255)


def CompareSum(sumOfThree, i):
    if sumOfThree > 126:
        pix_values[i] = (0,0,0)
    else:
        pix_values[i] = (255,255,255) 


fileName = sys.argv[1]
print('File name: ', sys.argv[1])
image = Image.open(fileName, 'r')
pix_values = list(image.getdata())
length = len(pix_values) - 1

new_matrix = [[(0,0,0) for x in range(512)] for y in range(512)]

# i =  0
# while i < length:
#     # sumOfThree1 = (pix_values[i][0] + pix_values[i + 1][0]  + pix_values[i + 2][0]) / 3

#     # sumOfThree2 = (pix_values[i][1] + pix_values[i + 1][1]  + pix_values[i + 2][1]) / 3

#     # sumOfThree3 = (pix_values[i][2] + pix_values[i + 1][2]  + pix_values[i + 2][2]) / 3
#     # CompareSums(sumOfThree1, sumOfThree2, sumOfThree3, i)
#     # i = i + 3

for i in range(len(pix_values)):
    sumOfThree = (pix_values[i][0] + pix_values[i][1]  + pix_values[i][2]) / 3
    CompareSum(sumOfThree, i)

i = 0
for j in range(512):
    for k in range(512):
        new_matrix[j][k] = pix_values[i]
        i = i + 1

array = np.array(new_matrix, dtype=np.uint8)
new_image = Image.fromarray(array)
new_image.save("temp.png")
print("Done")