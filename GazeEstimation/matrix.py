import numpy as np
import matplotlib.pyplot as plt

def calculateAngle(distanceToScreen, mainPosition, estimatedPosition):
    #print("ASDASD" , mainPosition[0])
    dx = mainPosition[0] - estimatedPosition[0]
    dy = mainPosition[1] - estimatedPosition[1]
    dxSquared = dx**2
    dySquared = dy**2
    difference = np.sqrt(dxSquared + dySquared)

    a = distanceToScreen
    b = distanceToScreen
    c = difference * 0.179 * 10
    cosx = (a*a + b*b - c*c) / (2*a*b) 
    angle = np.arccos(cosx)
    return angle


def read_coordinates_from_file(file_path):
    coordinates = []
    with open(file_path, 'r') as file:
        for line in file:
            x, y = map(float, line.strip().replace('(', '').replace(')', '').split(','))
            coordinates.append((x, y))
    return coordinates

def findx2(data):
    x2data = []
    for x,y in data:
        x2data.append((x*x, y*y))
    return x2data

def findxy(data):
    xydata = []
    for x in data:
        xydata.append(x[0]*x[1])
    return xydata

def combinematrices(leftsq, leftpup, xpyp):
    combined = []
    ones = np.ones(len(xpyp)).tolist()
    for i in range(len(xpyp)):
        row = [leftsq[i][0], leftsq[i][1], leftpup[i][0], leftpup[i][1], xpyp[i], ones[i]]
        combined.append(row)
    return combined

def combinematrices2(leftsq, leftpup, xpyp, xnyn, xcyc, XlecYlec, XrecYrec, XlmcYlmc, XrmcYrmc,): # combines all matrices
    combined = []
    ones = np.ones(len(xpyp)).tolist()
    for i in range(len(xpyp)):
        row = [leftsq[i][0], leftsq[i][1], leftpup[i][0], leftpup[i][1], xpyp[i],
               xnyn[i][0], xnyn[i][1], xcyc[i][0], xcyc[i][1],
               XlecYlec[i][0], XlecYlec[i][1], XrecYrec[i][0], XrecYrec[i][1],
               XlmcYlmc[i][0], XlmcYlmc[i][1], XrmcYrmc[i][0], XrmcYrmc[i][1],               
                ones[i]]
        combined.append(row)
    return combined


def combinematrices3(rel, pupil): # combines all matrices
    combined = []
    ones = np.ones(len(rel)).tolist()
    for i in range(len(rel)):
        row = [rel[i][0], rel[i][1], rel[i][0]*rel[i][0], rel[i][1]*rel[i][1] , rel[i][0]*rel[i][1],
               pupil[i][0], pupil[i][0]*pupil[i][1], pupil[i][1],        
                ones[i]]
        combined.append(row)
    return combined


def main(): 
    DISTANCE_TO_SCREEN = 50 #cm

    # Define file paths
    landmarksFolderPath = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\"
    left_pupil_file = landmarksFolderPath + 'left_pupil.txt'
    right_pupil_file = landmarksFolderPath + 'right_pupil.txt'
    screen_file = landmarksFolderPath +'screen_coordinates.txt'

    noseTipFile = landmarksFolderPath + "nose_tip.txt"
    chinFile = landmarksFolderPath +"chin.txt"
    leftEyeCornerFile = landmarksFolderPath +"lefteyecorner.txt"
    rightEyeCornerFile = landmarksFolderPath + "righteyecorner.txt"
    leftMouthCornerFile = landmarksFolderPath +"leftmouthcorner.txt"
    rightMouthCornerFile = landmarksFolderPath + "rightmouthcorner.txt"

    relLeftFile = landmarksFolderPath + "relativeLeft.txt"
    relRightFile = landmarksFolderPath + "relativeRight.txt"

    nose = read_coordinates_from_file(noseTipFile)
    chin = read_coordinates_from_file(chinFile)
    leftEyeCorner = read_coordinates_from_file(leftEyeCornerFile)
    rightEyeCorner = read_coordinates_from_file(rightEyeCornerFile)
    leftMouth = read_coordinates_from_file(leftMouthCornerFile)
    rightMouth = read_coordinates_from_file(rightMouthCornerFile)

    screenCoordinates = read_coordinates_from_file(screen_file)

    #not used 
    leftPupil = read_coordinates_from_file(left_pupil_file)
    rightPupil = read_coordinates_from_file(right_pupil_file)
    #

    lRel = read_coordinates_from_file(relLeftFile)
    leftSquared = findx2(lRel)
    leftxy = findxy(lRel)

    rRel = read_coordinates_from_file(relRightFile)
    rightSquared = findx2(rRel)
    rightxy = findxy(rRel)

    matrixLeft = combinematrices3(lRel,leftPupil)
    matrixRight = combinematrices3(rRel, rightPupil)

    E = matrixLeft   # this is left eye coordinates combined with nose etc. 
    F = screenCoordinates

    G = matrixRight   # this is left eye coordinates combined with nose etc. 
    H = screenCoordinates

    coefficientsLeftAdvanced, _, _, _, = np.linalg.lstsq(E, F, rcond=None)
    coefficientsRightAdvanced, _, _, _, = np.linalg.lstsq(G, H, rcond=None)

    with open(landmarksFolderPath +"left_coefficients.txt", 'w') as f:
            for line in coefficientsLeftAdvanced:
                f.write(str(line) + '\n')

    with open(landmarksFolderPath + "right_coefficients.txt", 'w') as f:
            for line in coefficientsRightAdvanced:
                f.write(str(line) + '\n')


    predicted_screenLeftAdv = np.dot(E, coefficientsLeftAdvanced) ## ortalama al
    predicted_screenRightAdv = np.dot(G, coefficientsRightAdvanced) ## ortalama al



    averagePrediction = (predicted_screenLeftAdv + predicted_screenRightAdv) / 2


    # Calculate the error
    error = np.linalg.norm(F - averagePrediction, axis=1)

    

    B = np.array(F) # screen coordinates

    # Your existing code goes here..

    # Extract x and y coordinates from predicted and real screen points
    pred_x, pred_y = averagePrediction[:, 0], averagePrediction[:, 1]
    real_x, real_y = B[:, 0], B[:, 1]

    # Plot the predicted points and real screen points
    plt.scatter(real_x, real_y, s = 250, label='Real Screen Points', color='red')
    plt.scatter(pred_x, pred_y, label='Predicted Screen Points', color='blue')


    plt.xlabel('X Coordinate')
    plt.ylabel('Y Coordinate')
    #plt.title('Predicted vs. Real Screen Points')
    #plt.legend()
    plt.grid(True)
    plt.show()

    # Calculate the error
    error = np.linalg.norm(B - predicted_screenLeftAdv, axis=1)




if __name__ == "__main__":
    main()