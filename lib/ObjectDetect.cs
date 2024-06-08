
using Python.Runtime;
using System;

namespace WindowsFormsApp_EMGUCVBase.lib
{
    
    internal class ObjectDetect
    {

        private string scriptName = "detectframes";
        private string functionNameToCall = "framesObjectDetection";
        private string scriptPath = @"C:\Users\colak\source\repos\WindowsFormsApp_EMGUCVBase\YOLO";
        private string pythonDLLpath = @"C:\Users\colak\AppData\Local\Programs\Python\Python310\python310.dll";

        private string inputFramesFolderPath = @"C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\VideoFrames\\";
        private string outputDetectedFramesFolderPath = @"C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\OutputFrames\\";

        public ObjectDetect()
        {
            if (!PythonEngine.IsInitialized)
            {
                Runtime.PythonDLL = pythonDLLpath; // Set Python DLL path
                PythonEngine.Initialize(); // Initialize the Python engine
            }
        }
        public PyObject RunScript()
        {
            //Runtime.PythonDLL = pythonDLLpath; // Local path for python 3.10 DLL
            //PythonEngine.Initialize();

            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(scriptPath); // Append path to the python script
                var pythonScript = Py.Import(scriptName); // Name of the python script

                //var result = pythonScript.InvokeMethod("sayHello"); // To pass parameteter var message = new PyString("message 1231232")  -> InvokeMethod("test" , new PyObject[] {message} )
                var inputFolder = new PyString(inputFramesFolderPath);
                var outputFolder = new PyString(outputDetectedFramesFolderPath);
                var result = pythonScript.InvokeMethod(functionNameToCall, new PyObject[] {inputFolder, outputFolder });
                //Console.WriteLine(result + "\n asdasdsad");
                return result;
            }

        }



    }
}
