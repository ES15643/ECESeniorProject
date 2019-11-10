from argparse import ArgumentParser
from image_to_gcode.image_to_gcode import ImageToGcode

import cv2
import numpy as np

def create_args():
    parser = ArgumentParser()

    parser.add_argument("--image_file", type=str, required=True)
    parser.add_argument("--threshold", type=int, required=True)
    parser.add_argument("--scale", type=float, default=None, required=False)

    return parser.parse_args()

def main(image_file, threshold, scale=None):
    image = cv2.imread(image_file)
    image_gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    numpy_array = np.ones_like(image_gray) * 255

    ret, thresh = cv2.threshold(image_gray, threshold, 255, 0)

    contours, hierarchy = cv2.findContours(thresh, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

    print(contours)

    cv2.drawContours(numpy_array, contours, -1, (0,0,0), 3)

    cv2.imwrite("preview_contour.jpg", numpy_array)

    offsets = [[0, 0],
               [30.5, 0.1],
               [0, 0],
               [0, 0]]

if __name__ == '__main__':
    args = create_args()
    main(args.image_file, args.threshold, args.scale)