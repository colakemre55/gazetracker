import mediapipe as mp
import cv2
import cv2
import numpy as np
from helpers import relative, relativeT
import os

def readcoeffs(fileName):
    with open(fileName, "r") as file:
        lines = file.readlines()

    values = []

    for line in lines:
        # Remove '[' and ']' characters, split the line by whitespace, and convert strings to float
        values_str = line.strip().replace('[', '').replace(']', '').split()
        values.append([float(val) for val in values_str])

    # Extract values using a loop instead of listing them one by one
    extracted_values = []
    for i in range(len(values)):
        extracted_values.extend(values[i])

    return extracted_values

def main():
    filterx = []
    filtery = []
    screenx = 0
    screeny = 0

    #temporal gaze filtering
    idx = 0
    bufLen = 10
    xBuffer = np.ones(bufLen)
    yBuffer = np.ones(bufLen)

    mp_face_mesh = mp.solutions.face_mesh  # initialize the face mesh model

    prev_circle_center = None # to avoid inifinite circles on the gaze direction

    # camera stream:
    cap = cv2.VideoCapture(0)  # chose camera index (try 1, 2, 3)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH, 1280)
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 720)

    width, height = 1920,1080
    trackingScreenImage =  np.ones((height, width, 3), dtype=np.uint8) * 255 #255 for white screen 

    # Specify the folder containing images
    folder_path = "\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\CameraFrames\\"  # Path to inputs folder
    image_files = [os.path.join(folder_path, f) for f in os.listdir(folder_path) if f.endswith(('.png', '.jpg', '.jpeg'))]  # List all image files

    estimatedPoints = []

    with mp_face_mesh.FaceMesh(
            max_num_faces=1,                                        # number of faces to track in each frame
            refine_landmarks=True,                                  # includes iris landmarks in the face mesh model
            min_detection_confidence=0.5,
            min_tracking_confidence=0.5) as face_mesh:
    
        for file_name in image_files:
            image = cv2.imread(file_name)
            if image is None:  # Check if the image was successfully loaded
                continue

            image.flags.writeable = False
            image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)  # frame to RGB for the face-mesh model
            results = face_mesh.process(image)
            image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)  # frame back to BGR for OpenCV

        

            if results.multi_face_landmarks:
                points = results.multi_face_landmarks[0]
                lp = relative(points.landmark[468], image.shape) #left pupil
                rp = relative(points.landmark[473], image.shape) # right pupil
                FL = np.array([
                        relative(points.landmark[4], image.shape),  # Nose tip
                        relative(points.landmark[152], image.shape),  # Chin
                        relative(points.landmark[263], image.shape),  # Left eye left corner
                        relative(points.landmark[33], image.shape),  # Right eye right corner
                        relative(points.landmark[287], image.shape),  # Left Mouth corner
                        relative(points.landmark[57], image.shape),  # Right mouth corner
                        relative(points.landmark[234], image.shape), # Left edge of the face
                        relative(points.landmark[10], image.shape), # Top edge of the face
                        relative(points.landmark[447], image.shape), # right edge of the face
                ], dtype="double")

                deneme = np.array([
                            relative(points.landmark[4], image.shape),  # Nose tip
                            relative(points.landmark[152], image.shape),  # Chin
                            relative(points.landmark[263], image.shape),  # Left eye left corner
                            relative(points.landmark[33], image.shape),  # Right eye right corner
                            relative(points.landmark[287], image.shape),  # Left Mouth corner
                            relative(points.landmark[57], image.shape)  # Right mouth corner
                            ], dtype="double")



            cv2.putText(image, f'Left Pupil: {lp}', (50, 50), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 2, cv2.LINE_AA)
            
            # Write right pupil value
            cv2.putText(image, f'Right Pupil: {rp}', (50, 100), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 2, cv2.LINE_AA)
        
            centerX = (lp[0] + rp[0]) / 2
            centerY = (lp[1] + rp[1]) / 2
            lRel = [lp[0] - centerX , lp[1] - centerY]
            rRel = [rp[0] - centerX , rp[1] - centerY]


            coeffs = readcoeffs("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\left_coefficients.txt")
            coeffsX = coeffs[::2]  # Start from index 0, take every other element
            coeffsY = coeffs[1::2]

            #lpMatrix = [lRel[0]*lRel[0], lRel[1]*lRel[1], lRel[0] , lRel[1], lRel[0]*lRel[1], FL[0][0],FL[0][1],FL[1][0],FL[1][1],FL[2][0],FL[2][1],FL[3][0],FL[3][1],FL[4][0],FL[4][1],FL[5][0],FL[5][1],1 ]

            lpMatrix = [lRel[0], lRel[1] , lRel[0]*lRel[0] , lRel[1]*lRel[1], lRel[0]*lRel[1], lp[0] , lp[0]*lp[1] , lp[1], 1]
            estimatedXleft = np.dot(lpMatrix, coeffsX)
            estimatedYleft = np.dot(lpMatrix,coeffsY)


            coeffs = readcoeffs("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\right_coefficients.txt")
            coeffsX = coeffs[::2]  # Start from index 0, take every other element
            coeffsY = coeffs[1::2]
            #rpMatrix = [rRel[0]*rRel[0], rRel[1]*rRel[1], rRel[0] , rRel[1], rRel[0]*rRel[1], FL[0][0],FL[0][1],FL[1][0],FL[1][1],FL[2][0],FL[2][1],FL[3][0],FL[3][1],FL[4][0],FL[4][1],FL[5][0],FL[5][1] ,  1 ]
            rpMatrix = [rRel[0], rRel[1] , rRel[0]*rRel[0] , rRel[1]*rRel[1], rRel[0]*rRel[1], rp[0] , rp[0]*rp[1] , rp[1], 1]
            estimatedXright = np.dot(rpMatrix, coeffsX)
            estimatedYright = np.dot(rpMatrix,coeffsY)



            '''xBuffer[idx] = ( estimatedXleft + estimatedXright ) / 2
            yBuffer[idx] = ( estimatedYright + estimatedYright ) / 2
            idx = (idx+1) % bufLen'''

            estimatedLeft = ( estimatedXleft + estimatedXright ) / 2
            estimatedRight = ( estimatedYright + estimatedYright ) / 2

            '''filteredGazeX = (xBuffer.sum() / bufLen) 
            filteredGazeY = (yBuffer.sum() / bufLen)'''         

            # Keeping the estimated circle in screen bounds
            filterXmax = max(0, min(1920, estimatedLeft))
            filterYmax = max(0, min(1080, estimatedRight)) 
            gazePoint = (filterXmax , filterYmax)
            print(gazePoint)
            estimatedPoints.append(gazePoint)
        
            if cv2.waitKey(2) & 0xFF == 27:
                break
    cap.release()
    return estimatedPoints



    


