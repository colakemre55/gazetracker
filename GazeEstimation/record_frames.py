from itertools import chain
import os
import sys
import cv2
import time

import traceback
import numpy as np
import cleantxt

def clear_folder(folder_path):
    # Check if the folder exists
    if os.path.exists(folder_path):
        # Iterate over all files in the folder
        for file_name in os.listdir(folder_path):
            file_path = os.path.join(folder_path, file_name)
            try:
                # Attempt to remove the file
                os.remove(file_path)
                print(f"Deleted: {file_path}")
            except Exception as e:
                # Handle any errors while deleting files
                print(f"Error deleting {file_path}: {e}")
    else:
        print(f"Folder not found: {folder_path}")


def Calibration(windowName, monitorPixels, outputFolder):

    centernew = [[0] * 4 for _ in range(3)] 
    for i in range(3):
        for j in range(4): 
            centernew[i][j] = ((j+1)*384, (i+1)*270)
    centernew = list(chain(*centernew))
    margin = 40
    width, height = monitorPixels
    centernew = [
        (margin, margin),  # Top-left
        (width - margin, 0),  # Top-right
        (0, height - margin),  # Bottom-left
        (width - margin, height - 1),  # Bottom-right
        (width // 2, height // 2),  # Center
        (width // 2, 0),  # Midpoint of the top edge
        (width // 2, height - margin),  # Midpoint of the bottom edge
        (0, height // 2),  # Midpoint of the left edge
        (width - margin, height // 2)  # Midpoint of the right edge
    ]
    index = 0
    frameIndex = 0
    numberOfPoints = 3
    k=1

    cap = cv2.VideoCapture(0)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH, 1280) #! 
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 720)

    width, height = monitorPixels
    blackImage = np.zeros((height, width, 3), np.float32)


    radius = 30  # Radius of the circle
    color = (255, 255, 255)  # Green color in BGR
    thickness = -1  # Thickness of the circle boundary

    while True:
        try:
            
            start_time = time.time()  # Record start time
            center_coordinates = centernew[index]

            
            cv2.circle(blackImage, center_coordinates, radius, color, thickness)
            cv2.circle(blackImage, center_coordinates, 3, (0,0,0), thickness)
            cv2.imshow(windowName, blackImage)  


            while (time.time() - start_time) < 1:  # circle time
                key22 = cv2.waitKey(10) & 0xFF
                if key22 == ord('s'):
                    break
                if key22 == ord('q'):
                    cv2.destroyAllWindows()
                    sys.exit()

            ret, frame = cap.read()
            if not ret:
                print("Failed to grab frame")
                break
 
            if ret:
                cv2.imwrite(os.path.join(outputFolder, f"frame_{frameIndex}.jpg"), frame)
                write_to_file(center_coordinates,"C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\screen_coordinates.txt")
                frameIndex += 1

            if k % numberOfPoints == 0:
                index = index + 1
            k = k + 1
            
            blackImage.fill(0) # Clear the image
            
        except Exception:
            exc_type, exc_value, exc_traceback = sys.exc_info()
            cap.release()               
            cv2.destroyAllWindows()
            traceback.print_exception(exc_type, exc_value, exc_traceback,
                                limit=2, file=sys.stdout)
            break

    cap.release()
    cv2.destroyAllWindows()


def write_to_file(coordinates, filename):
    with open(filename, "a") as file:  # Open file in append mode
            file.write(f"{coordinates}\n")


def main():
    cleantxt.cleanAll()
    recordedFramesFolder = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\RecordedFrames"
    outputFramesFolder = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\OutputFrames"
    os.makedirs(recordedFramesFolder, exist_ok=True)
    os.makedirs(outputFramesFolder, exist_ok=True)

    clear_folder(recordedFramesFolder)
    clear_folder(outputFramesFolder)
    

    monitorPixels = (1920,1080)
    windowName = "Personal Calibration"


    cv2.namedWindow(windowName, cv2.WINDOW_NORMAL)
    cv2.setWindowProperty(windowName, cv2.WND_PROP_FULLSCREEN, cv2.WINDOW_FULLSCREEN)

    Calibration(windowName,monitorPixels, recordedFramesFolder)
    


if __name__ == "__main__":
    main()