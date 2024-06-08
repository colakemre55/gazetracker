def clean_file(file_path):
    # Open the file in write mode to clear its content
    with open(file_path, 'w') as file:
        pass
        
def cleanAll():
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\left_pupil.txt")
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\right_pupil.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\screen_coordinates.txt')

    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\nose_tip.txt")
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\chin.txt")
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\lefteyecorner.txt")
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\righteyecorner.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\leftmouthcorner.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\rightmouthcorner.txt')

    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\relativeLeft.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\relativeRight.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\gazevector.txt')

def cleanExceptScreenCoords():
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\left_pupil.txt")
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\right_pupil.txt')

    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\nose_tip.txt")
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\chin.txt")
    clean_file("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\lefteyecorner.txt")
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\righteyecorner.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\leftmouthcorner.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\rightmouthcorner.txt')

    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\relativeLeft.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\relativeRight.txt')
    clean_file('C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\GazeEstimation\\landmarks\\gazevector.txt')
