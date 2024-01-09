using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using MediaToolkit;
using MediaToolkit.Model;
using Microsoft.DirectX.AudioVideoPlayback; // These 2 dll were added by references 
using Microsoft.DirectX; // 
using System.Drawing;

namespace WindowsFormsApp_EMGUCVBase
{
    public partial class Form1 : Form
    {
        readonly VideoCapture cameraCapture; // readonly?
        readonly VideoCapture videoFileCapture;

        private string selectedFilePath;

        //string fileToSaveFrames = @"C:\Users\colak\Downloads\popcorn.mp4";

        // video directx part
        private Video video;
        private string[] videoPaths;
        private string folderPath = @"C:\Users\colak\Downloads\popcorn.mp4";
        private Size formSize;
        private Size pnlSize;



        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            //directx part
            //VolumeTrackBar.Value = 4;
        }
     
        private void Form1_Load(object sender, System.EventArgs e)
        {
            formSize = new Size(this.Width , this.Height) ;
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height) ;

            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            if( videoPaths != null)
            {

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
                    var filename = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp EMGUCVBase\\Frames\\", $"Video_{i}.png");
                    CvInvoke.Imwrite(filename, img);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PlayMedia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                axWindowsMediaPlayer1.URL = selectedFilePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();

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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            PlayingPosition = CalculateTime(video.CurrentPosition);
            txtStatus.Text = PlayingPosition + "/" + Duration;
            if (video.CurrentPosition >= video.Duration)
            {
                timer1.Stop();
                Duration = CalculateTime(vdo.Duration);
                PlayingPosition = "0:00:00";
                txtStatus.Text = PlayingPosition + "/" + Duration;
                video.Stop();
                btnPlay.BackgroundImage = Play_Video.Properties.Resources.btnplay;
                vdoTrackBar.Value = 0;
            }
            else
                vdoTrackBar.Value += 1;
        }
        public string CalculateTime(double Time)
        {
            string mm, ss, CalculatedTime;
            int h, m, s, T;
            Time = Math.Round(Time);
            T = Convert.ToInt32(Time);
            h = (T / 3600);
            T = T % 3600;
            m = (T / 60);
            s = T % 60;
            if (m < 10)
                mm = string.Format("0{0}", m);
            else
                mm = m.ToString();
            if (s < 10)
                ss = string.Format("0{0}", s);
            else
                ss = s.ToString();
            CalculatedTime = string.Format("{0}:{1}:{2}", h, mm, ss);
            return CalculatedTime;
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
    }
}
