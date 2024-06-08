from ast import Tuple
import os
import cv2 
import numpy as np 
from typing import Tuple, Union
import mediapipe as mp
import cv2
import cleantxt
import numpy as np
from helpers import relative, relativeT
import re
from itertools import chain



def distance(p1, p2):
    return np.sqrt((p1[0] - p2[0])**2 + (p1[1] - p2[1])**2)


def writeScreenCoordinates(closestCirclesNum):  # Writes screen coordinates in a file, if we recod 3 closest numbers -> 3 times the circle's coordinates repeated
    centernew = [[0] * 4 for _ in range(3)] 
    for i in range(3):
        for j in range(4): 
            centernew[i][j] = ((j+1)*384, (i+1)*270)
    centernew = list(chain(*centernew))

    for i in centernew:  
        for j in range(closestCirclesNum):
            write_to_file(i, "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\screen_coordinates.txt")


def Calibrate(image_files, landmarksFolderPath ,folder_path ):
    idx = 0 #for finding the 3 closest point
    outputIndex = 0
    #numberOfPoints = calib.GetNumberOfPoints() # returns these numbers from the calibration code
    numberOfPoints = 3 # # of points to take for every circle shown
    numberOfClosest = 3 # number of closest points to choose among all chosen points for 1 circle shown
    #writeScreenCoordinates(numberOfClosest)
    points = []
    
    model_points = np.array([
    (0.0, 0.0, 0.0),             # Nose tip
    (0.0, -330.0, -65.0),        # Chin
    (-225.0, 170.0, -135.0),     # Left eye left corner
    (225.0, 170.0, -135.0),      # Right eye right corner
    (-150.0, -150.0, -125.0),    # Left Mouth corner
    (150.0, -150.0, -125.0)      # Right mouth corner
    ])

    for image_file in image_files:
        image_path = os.path.join(folder_path, image_file)
        #cap = cv2.imread(image_path)
        mp_face_mesh = mp.solutions.face_mesh  # initialize the face mesh model
        cap = cv2.VideoCapture(image_path)

        cap.set(cv2.CAP_PROP_FRAME_WIDTH, 1280)
        cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 720)

        with mp_face_mesh.FaceMesh(
                max_num_faces=1,                                        # number of faces to track in each frame
                refine_landmarks=True,                                  # includes iris landmarks in the face mesh model
                min_detection_confidence=0.5,
                min_tracking_confidence=0.5) as face_mesh:

                    success, image = cap.read()
                    if not success:                                         # no frame input
                        print("Ignoring empty camera frame.")
                        continue        
                    
                    image.flags.writeable = False
                    image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)  # frame to RGB for the face-mesh model
                    results = face_mesh.process(image)
                    image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)  # frame back to BGR for OpenCV 

                    if results.multi_face_landmarks:
                        points = results.multi_face_landmarks[0]
                        left_pupil = relative(points.landmark[468], image.shape)
                        right_pupil = relative(points.landmark[473], image.shape)

                        faceLandmarks = np.array([
                        relative(points.landmark[4], image.shape),  # Nose tip
                        relative(points.landmark[152], image.shape),  # Chin
                        relative(points.landmark[263], image.shape),  # Left eye left corner
                        relative(points.landmark[33], image.shape),  # Right eye right corner
                        relative(points.landmark[287], image.shape),  # Left Mouth corner
                        relative(points.landmark[57], image.shape)  # Right mouth corner
                        ], dtype="double")

                        #centerOfEyes = (left_pupil + right_pupil ) / 2
                        centerOfEyes = tuple((lp + rp) / 2 for lp, rp in zip(left_pupil, right_pupil))
                        lRel = tuple(map(lambda i, j: i - j, left_pupil, centerOfEyes))
                        rRel = tuple(map(lambda i, j: i - j, right_pupil, centerOfEyes))
                        #lRel = left_pupil - centerOfEyes
                        #rRel = right_pupil - centerOfEyes

                        #----
                        '''size = image.shape
                        focal_length = size[1]
                        center = (size[1]/2, size[0]/2)
                        camera_matrix = np.array(
                            [[focal_length, 0, center[0]],
                            [0, focal_length, center[1]],
                            [0, 0, 1]], dtype = "double"
                        )
                        dist_coeffs = np.zeros((4,1))
                        (success, rotation_vector, translation_vector) = cv2.solvePnP(model_points, faceLandmarks, camera_matrix, dist_coeffs, flags=cv2.SOLVEPNP_ITERATIVE)'''
                        #write_to_file(rotation_vector, "landmarks/rotation.txt" )
                        #write_to_file(translation_vector, "landmarks/translation.txt" )
                        #----

                        write_to_file(left_pupil, landmarksFolderPath + "left_pupil.txt")
                        write_to_file(right_pupil, landmarksFolderPath + "right_pupil.txt")
                        #write_to_file(center_coordinates, "landmarks/screen_coordinates.txt")

                        write_to_file(tuple(faceLandmarks[0]), landmarksFolderPath + "nose_tip.txt")
                        write_to_file(tuple(faceLandmarks[1]),landmarksFolderPath + "chin.txt")
                        write_to_file(tuple(faceLandmarks[2]),landmarksFolderPath + "lefteyecorner.txt")
                        write_to_file(tuple(faceLandmarks[3]), landmarksFolderPath +"righteyecorner.txt")
                        write_to_file(tuple(faceLandmarks[4]),landmarksFolderPath + "leftmouthcorner.txt")
                        write_to_file(tuple(faceLandmarks[5]), landmarksFolderPath +"rightmouthcorner.txt")

                        write_to_file(tuple(lRel), landmarksFolderPath +"relativeLeft.txt")
                        write_to_file(tuple(rRel),landmarksFolderPath + "relativeRight.txt")

    print("finished")
    cap.release()
    
    # Wait for 5 seconds or until 'q' is pressed
         
        
def write_to_file(coordinates, filename):
    with open(filename, "a") as file:  # Open file in append mode
            file.write(f"{coordinates}\n")

def extract_number(f):
    s = re.findall("\d+", f)
    return (int(s[0]) if s else -1, f)


def main():
    landmarksFolderPath = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\"
    folder_path = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\RecordedFrames"
    cleantxt.cleanExceptScreenCoords()
    
    image_files = [f for f in os.listdir(folder_path) if f.endswith(('.jpg', '.png'))]
    image_files = sorted(image_files, key=extract_number)


    Calibrate(image_files,landmarksFolderPath ,folder_path ) # burdaki 2 variable silindi



if __name__ == "__main__":
    main()