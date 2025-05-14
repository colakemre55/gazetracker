# 👁️ Vision-Based Gaze Estimation System

A graduation project developed at Istanbul Technical University that combines real-time gaze estimation and object detection to analyze user attention in video content using only a standard laptop webcam.

## 📌 Project Overview

This system is designed to estimate a user's gaze on a video, identify the most viewed objects, and visualize the results through gaze heatmaps. It employs appearance-based gaze estimation using convolutional neural networks (CNNs) and object detection via the YOLO algorithm, all integrated into a custom-built desktop GUI.

## ✨ Key Features

- 🔍 **Real-time Gaze Estimation** using a VGG16-inspired CNN
- 📦 **Object Detection** with YOLOv5 via Python integration
- 🖼️ **Gaze-Object Mapping** for attention analysis
- 🌡️ **Heatmap Visualization** of gaze points
- 💻 **User-Friendly GUI** developed in C# with OpenCV (via Emgu CV)
- 🎥 **Video Upload & Processing** directly from the GUI
- 🎯 **Camera and Screen Calibration** for increased precision

## 🧠 Technologies Used

- Unity (C# GUI, EmguCV)
- Python.NET for script integration
- OpenCV (face detection, video processing)
- YOLOv5 (object detection)
- VGG-based CNN (gaze estimation)

## 🔧 Installation Requirements

- Windows OS with Visual Studio 2022
- Python ≥ 3.10 with Anaconda environment
- GPU with 6GB+ VRAM recommended
- .NET-compatible webcam

## 🚀 How It Works

1. **Upload a video** via the GUI.
2. **Calibrate** the camera and screen for each user.
3. **Record video playback and webcam** feed simultaneously.
4. **Estimate gaze vectors** and match them with detected objects.
5. **Generate heatmaps** showing where the user looked.
6. **Display final results** including object attention analysis.

## 📂 Project Structure (Simplified)
/GazeEstimationSystem
├── /GUI # C# Desktop GUI with threading support
├── /PythonScripts # YOLO and gaze estimation models
├── /Models # Trained CNN models
├── /VideoFrames # Processed video and camera frames
├── /Results # Heatmaps and analytics


## 🧪 Use Cases

- 🎯 Neuromarketing analysis
- 🧪 Human-Computer Interaction research
- 📊 UX and UI testing for video content
- 🧑‍💻 Gaze-based accessibility tools

#
## 📃 License

This project is for academic purposes and released under the MIT License.

## 📈 Future Improvements

- Increase robustness against lighting and head pose variations
- Add support for multi-user gaze aggregation
- Enable cloud-based video processing for scalability

