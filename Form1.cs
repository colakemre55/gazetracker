using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using MediaToolkit;
using MediaToolkit.Model;
//using Microsoft.DirectX.AudioVideoPlayback; // These 2 dll were added by references 
//using Microsoft.DirectX; // 


using System.Threading.Tasks;
using SharpDX;
using SharpDX.MediaFoundation;
using Emgu.CV.Face;
using Emgu.CV.Features2D;
using SharpDX.MediaFoundation.DirectX;
using System.Diagnostics;
using Microsoft.ML;
using WindowsFormsApp_EMGUCVBase.Models;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
//using SharpDX.MediaFoundation.EVR;
//using SharpDX.Windows;

// Desing -> Form1 -> KeyPreview true dan false değiştirdim

namespace WindowsFormsApp_EMGUCVBase
{
    public partial class Form1 : Form
    {
         VideoCapture cameraCapture; // readonly?
         VideoCapture videoFileCapture;
        
        

        private string selectedFilePath;

        //string fileToSaveFrames = @"C:\Users\colak\Downloads\popcorn.mp4";

        int mX, mY;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            //vlcControl1.VlcLibDirectoryNeeded += vlcControl1_VlcLibDirectoryNeeded;
            //  listVideos.SelectedIndex = selectedIndex;
            mX = 0;
            mY = 0;
        }

        private void CaptureCameraAndVideoFrames()
        {
            int frameNumber = 0;

            using (var videoCapture = new VideoCapture(selectedFilePath))
            using (var cameraCapture = new VideoCapture(0))
            {
                while (true)  /// degis
                {
                    using (var imgCameraFrame = new Mat())
                    using (var imgVideoFrame = new Mat())
                    {
                        cameraCapture.Read(imgCameraFrame);
                        videoCapture.Read(imgVideoFrame);

                        Bitmap myBmpVideo = imgVideoFrame.ToImage<Bgr, byte>().ToBitmap();
                        Bitmap myBmpCamera = imgCameraFrame.ToImage<Bgr, byte>().ToBitmap();
                        Font myFont = new Font("Arial", 30f);
                        Graphics gx = Graphics.FromImage(myBmpVideo);
                        Graphics gx2 = Graphics.FromImage(myBmpCamera);
                        gx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                         //gx.DrawEllipse(myPen, rect);
                         
                         gx.DrawString(frameNumber.ToString(), myFont, Brushes.Cyan, new PointF(0, 0));

                         gx.Dispose();
                        
                        
                        //gx.DrawEllipse(myPen, rect);
                        
                        gx2.DrawString(frameNumber.ToString(), myFont, Brushes.Cyan, new PointF(0, 0));

                        gx2.Dispose();

                        // Update PictureBox controls on the UI thread
                         pictureBox2.Invoke((Action)delegate
                         {
                             pictureBox2.Image = myBmpVideo;
                         });

                         pictureBox3.Invoke((Action)delegate
                         {
                             pictureBox3.Image = myBmpCamera;
                         });
                        //pictureBox2.Image = myBmpVideo;
                        //pictureBox3.Image = myBmpCamera;
                        var filenameCamera = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\Frames\\", $"Camera_{frameNumber}.png");
                        var filenameVideo = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\Frames\\", $"Video_{frameNumber}.png");

                        CvInvoke.Imwrite(filenameCamera, imgCameraFrame);
                        CvInvoke.Imwrite(filenameVideo, imgVideoFrame);

                        System.Threading.Thread.Sleep(30);

                        frameNumber++;

                        // Add an exit condition if needed
                        // For example, break the loop if a certain number of frames have been processed
                        // or if a stop button is pressed in your UI
                    }
                }
            }
        }

        private void CaptureCameraAndVideoFrames2()
        {
            int frameNumber = 0;
            using (var cameraCapture = new VideoCapture(selectedFilePath))
            {
                // using (var imgVideoFrame = new Mat())
                using (var imgCameraFrame = new Mat())
                {
                    while (cameraCapture.Grab())
                    {
                        cameraCapture.Retrieve(imgCameraFrame);
                        //cameraCapture.Retrieve(imgCameraFrame);
                        //videoCapture.Retrieve(imgVideoFrame);

                        //Bitmap myBmpVideo = imgVideoFrame.ToImage<Bgr, Byte>().ToBitmap();
                        Bitmap myBmpCamera = imgCameraFrame.ToImage<Bgr, Byte>().ToBitmap();

                        //pictureBox2.Image = myBmpVideo;
                        pictureBox3.Image = myBmpCamera;


                        var filenameCamera = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp EMGUCVBase\\Frames\\", $"Camera_{frameNumber}.png");
                        //var filenameVideo = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp EMGUCVBase\\Frames\\", $"Video_{frameNumber}.png");
                        CvInvoke.Imwrite(filenameCamera, imgCameraFrame);
                        //CvInvoke.Imwrite(filenameVideo, imgVideoFrame);
                        System.Threading.Thread.Sleep(30);

                        frameNumber++;
                    }



                }



            }
        }

        private void CaptureFramesFromCamera()
        {
            int i = 0; // for file names
            using (var cameraVideo = new VideoCapture(0))
            using (var img = new Mat())
            {
                while (cameraVideo.Grab())
                {                    
                    cameraVideo.Retrieve(img);

                    var filename = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp EMGUCVBase\\Frames\\", $"Camera_{i}.png");
                    CvInvoke.Imwrite(filename, img);
                    i++;
                }
            }


        }

        private void CaptureFramesFromVideoFile(string filePath)
        {
            int i = 0; // for file names
            using (var displayedVideo = new VideoCapture(filePath))
            using (var img = new Mat())
            {
                while (displayedVideo.Grab())
                {
                    displayedVideo.Retrieve(img);
                    //Image<Bgr, Byte> myIm = img.ToImage<Bgr, Byte>().ToBitmap();
                    Bitmap myBmp = img.ToImage<Bgr, Byte>().ToBitmap();
                                        
                    //var filename = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp EMGUCVBase\\Frames\\", $"Video_{i}.png");
                    //CvInvoke.Imwrite(filename, img);

                    Pen myPen = new Pen(Brushes.Red, 5);
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(mX, mY, 200, 100);
                    Font myFont = new Font("Arial", 30f);

                    Graphics gx = Graphics.FromImage(myBmp);
                    gx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    //gx.DrawEllipse(myPen, rect);
                    gx.FillEllipse(Brushes.BlueViolet, rect);
                    gx.DrawString(i.ToString(), myFont, Brushes.Cyan, new PointF(0, 0));

                    gx.Dispose();

                    pictureBox2.Image = myBmp;

                    System.Threading.Thread.Sleep(30);
                    i++;
                }
            }


        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cameraCapture != null && cameraCapture.IsOpened)
                cameraCapture.Dispose();

            if (videoFileCapture != null && videoFileCapture.IsOpened)
                videoFileCapture.Dispose();

        }


        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }



        private void PlayMedia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                //axWindowsMediaPlayer1.URL = selectedFilePath;
                //axWindowsMediaPlayer1.Ctlcontrols.play();

                System.Threading.Thread cameraThread = new System.Threading.Thread(() => CaptureFramesFromCamera());
                cameraThread.Start();
                System.Threading.Thread dispalyVideoThread = new System.Threading.Thread(() => CaptureFramesFromVideoFile(selectedFilePath));
                dispalyVideoThread.Start();

            }
            else
            {
                MessageBox.Show("Please select a media file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UploadVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "MP4|*.mp4|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo chosenFile = new FileInfo(ofd.FileName);
                    selectedFilePath = chosenFile.FullName;
                }
            }
        }

        private void listVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }



       /* private void vlcControl1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(fileToSaveFrames);
            this.vlcControl1.SetMedia(fi);
            this.vlcControl1.Play();
        }*/

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            e.VlcLibDirectory = new DirectoryInfo(@"C:\Users\colak\.nuget\packages\videolan.libvlc.windows\3.0.20\build\x64");
        }






        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void newPlay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                System.Threading.Thread cameraThread2 = new System.Threading.Thread(() => CaptureCameraAndVideoFrames());
                cameraThread2.Start();
                //CaptureCameraAndVideoFrames();

            }
            else
            {
                MessageBox.Show("Please select a media file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            mX = e.X;
            mY = e.Y;
        }
    }
}
