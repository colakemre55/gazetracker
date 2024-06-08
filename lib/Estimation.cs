using Python.Runtime;
using System;

namespace WindowsFormsApp_EMGUCVBase.lib
{
    internal class Estimation
    {
        private string scriptName = "record_frames";
        private string calibrateScriptName = "calib_from_frames";
        private string matrixScriptName = "matrix";
        private string estimateName = "estimatephotos";
        private string calibrationName = "calibration"; // record frame + calib from frame + matrix all inside
        private string maincode = "main";


        private string maincodeFuncToCall = "main";
        private string functionNameToCall = "main";
        private string calibrateFunctionToCall = "main";
        private string matrixFunctionToCall = "main";
        private string estimateFunctionToCall = "main";
        private string calibrationFunctionToCall = "main";
        private string scriptPath = @"C:\Users\colak\source\repos\WindowsFormsApp_EMGUCVBase\GazeEstimation";
        private string pythonDLLpath = @"C:\Users\colak\AppData\Local\Programs\Python\Python39\python39.dll";


        // TODO send the folder paths from here to scripts

        //private string pythonDLLpath = @"C:\Users\colak\anaconda3\envs\pipeline39\python39.dll";
        public Estimation()
        {
            if (!PythonEngine.IsInitialized)
            {
                Runtime.PythonDLL = pythonDLLpath; // Set Python DLL path
                PythonEngine.Initialize(); // Initialize the Python engine
            }
        }
        public PyObject MainEstimation()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(maincode); // Name of the python script

                var result = pythonScript.InvokeMethod(maincodeFuncToCall);
                Console.WriteLine(result);
                return result;
            }

        }

        public PyObject Calibration()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(calibrationName); // Name of the python script

                var result = pythonScript.InvokeMethod(calibrationFunctionToCall);
                Console.WriteLine(result);
                return result;
            }

        }

        public PyObject RecordFramesPython()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(scriptName); // Name of the python script

                var result = pythonScript.InvokeMethod(functionNameToCall);
                Console.WriteLine(result);
                return result;
            }

        }

        public PyObject LandmarksDetection()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(calibrateScriptName); // Name of the python script

                var result = pythonScript.InvokeMethod(calibrateFunctionToCall);
                Console.WriteLine(result);
                return result;
            }

        }

        public PyObject CalculateCoefficients()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(matrixScriptName); // Name of the python script

                var result = pythonScript.InvokeMethod(matrixFunctionToCall);
                Console.WriteLine(result);
                return result;
            }

        }

        public PyObject EstimateUsingFrames()
        {

            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(estimateName); // Name of the python script

                var result = pythonScript.InvokeMethod(estimateFunctionToCall);
                Console.WriteLine(result);
                return result;
            }

        }

    }
}
