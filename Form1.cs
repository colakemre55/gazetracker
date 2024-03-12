using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Emgu.CV;
using MediaToolkit;
using MediaToolkit.Model;
//using Microsoft.DirectX.AudioVideoPlayback; // These 2 dll were added by references 
//using Microsoft.DirectX; // 

using System.Threading.Tasks;
using System.Threading;
using SharpDX;
using SharpDX.MediaFoundation;
using Emgu.CV.Face;
using Emgu.CV.Features2D;
using SharpDX.MediaFoundation.DirectX;
using System.Diagnostics;
using Microsoft.ML;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using Python.Runtime;
using WindowsFormsApp_EMGUCVBase.lib;
using System.Text.RegularExpressions;
//using SharpDX.MediaFoundation.EVR;
//using SharpDX.Windows;

// Desing -> Form1 -> KeyPreview true dan false değiştirdim

namespace WindowsFormsApp_EMGUCVBase
{
    
    public partial class Form1 : Form
    {
        private Size normalSize;
        private System.Drawing.Point normalLocation;
        private DockStyle normalDock;
        
        VideoCapture cameraCapture; // readonly?
        VideoCapture videoFileCapture;
        
        ObjectDetect myobject;

        private string selectedFilePath;
        private string pythonText;

        private int numberOfDetected;

        string resultsPath = @"C:\Users\colak\source\repos\WindowsFormsApp_EMGUCVBase\OutputFrames\results.txt";
        // Path to object detected frames
        private string outputDetectedFramesFolderPath = @"C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\OutputFrames\\";
        

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.Icon = Properties.Resources.gaze;

            //menuStrip1.BackColor = ColorTranslator.FromHtml("#0276A7"); // Navigation bar color
            //analytics1.BackColor = ColorTranslator.FromHtml("#C4D4F2"); // Analytics user control color
            
            menuStrip1.Renderer = new GradientMenuRenderer("#6DA7F2", "#91BBF2");
            
            //textBox1.BackColor = Form1.DefaultBackColor;
            //textBox2.BackColor = Form1.DefaultBackColor;
            textBox1.Font = new Font("Calibri", 28, FontStyle.Bold);
            textBox2.Font = new Font("Calibri", 12, FontStyle.Regular);
            textBox3.Font = new Font("Calibri", 20, FontStyle.Regular);
            
            //SetGradientBackground(panel2, System.Drawing.Color.White, ColorTranslator.FromHtml("#C4D4F2"));
            //textBox1.BackColor = panel1.BackColor; textBox2.BackColor = panel2.BackColor;
            // panel2.BackColor = ColorTranslator.FromHtml("#C4D4F2");

        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
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

                         /*pictureBox3.Invoke((Action)delegate
                         {
                             //pictureBox3.Image = myBmpCamera;
                         }); */
                        //pictureBox2.Image = myBmpVideo;
                        //pictureBox3.Image = myBmpCamera;
                        var filenameCamera = Path.Combine("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\CameraFrames\\", $"Camera_{frameNumber}.png");
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void newPlay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                // On Start button click, play the video in fullscreen mode
                this.WindowState = FormWindowState.Maximized;
                //pictureBox2.Dock = DockStyle.Fill;
                //System.Drawing.Size = new Size(1920, 1080);
                //pictureBox2.Size = System.Drawing.Size (1920, 1080);
                //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                System.Threading.Thread cameraThread2 = new System.Threading.Thread(() => CaptureCameraAndVideoFrames());
                cameraThread2.Start();
                //CaptureCameraAndVideoFrames();

            }
            else
            {
                MessageBox.Show("Please select a media file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detect_Click(object sender, EventArgs e)
        {
            myobject = new ObjectDetect();
            var detectionResult = myobject.RunScript();
            string results = detectionResult.ToString();
            
            var detectedTuples = pyObjectToArray(results);

            int lengthOfTuples = detectedTuples.Length;
            
            // Firstly find first item of last element ( 30 , person ) then add frame '0' ( 30 + 1 )
            int numberOfDetectedImages = Int32.Parse(detectedTuples[lengthOfTuples - 1].Item1) + 1;

            numberOfDetected = numberOfDetectedImages;
            MessageBox.Show("Detection complete");
            
        }

        private (string,string)[] pyObjectToArray(string pyObject) // g 
        {

            string pattern = @"\(([^)]+)\)";
            MatchCollection matches = Regex.Matches(pyObject, pattern);
            (string, string)[] tuples = new (string, string)[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                string[] elements = matches[i].Groups[1].Value.Split(',');
                tuples[i] = (elements[0].Trim(), elements[1].Trim());
            }
            /*for (int j = 0; j < tuples.Length; j++)
            {
                Console.WriteLine($" tuple{j}: {tuples[j]} \n");
            }
            Console.WriteLine("LENGTH IS : " + tuples.Length);*/

            return tuples;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            /*
            if (listView1.SelectedIndices.Count > 0)
            {
                //int selectedIndex = listView1.SelectedIndices[0];
                var firstSelectedItem = listView1.SelectedItems[0];
                string frameNum = firstSelectedItem.Text; // 0 1 2 3 4 
                //MessageBox.Show("Selected : " + frameNum);
                showDetectedFrames(frameNum);
            }*/
            

            
        }

        private void showDetectedFrames(string frameNumber)
        {
            /*string framePath = outputDetectedFramesFolderPath + "Video_" + frameNumber + ".jpg";
            //MessageBox.Show(framePath);
            Image image = Image.FromFile(framePath);
            pictureBoxDetect.Image = image; */
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            readResults();
        }
        
        private void readResults()
        {
            string[] lines = File.ReadAllLines(resultsPath);
            
            Dictionary<int, Tuple<int, List<string>>> frameObjectData = new Dictionary<int, Tuple<int, List<string>>>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                if (parts.Length == 2 && parts[0].StartsWith("Frame:") && int.TryParse(parts[0].Substring("Frame:".Length), out int frame))
                {
                   // MessageBox.Show("here");
                    if (frameObjectData.ContainsKey(frame))
                    {
                        // increment obj count
                        int count = frameObjectData[frame].Item1;
                        frameObjectData[frame] = new Tuple<int, List<string>>(count + 1, frameObjectData[frame].Item2);
                    }
                    else
                    {
                        // add frame to dict with initial obj count 1 and empty frames list
                        frameObjectData[frame] = new Tuple<int, List<string>>(1, new List<string>());
                    }
                    // Add the object name to the list for the current frame
                    frameObjectData[frame].Item2.Add(parts[1]);

                }
            }
            foreach (var sds in frameObjectData)
            {
                int dictFrame = sds.Key;
                int count = sds.Value.Item1;
                List<string> objectNames = sds.Value.Item2 as List<string>;

                ListViewItem item = new ListViewItem(new[] { dictFrame.ToString(), count.ToString(), string.Join(", ", objectNames) });
                //listView1.Items.Add(item);
            }
            
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // Nav Bar Analytics Button
        {
            if( numberOfDetected > 0)
            {
                analytics1.numberOfDetectedFrames = numberOfDetected; // check later
                analytics1.Show();
                analytics1.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("First apply detection to see Analysis page", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //analytics1.Show(); // sonra sil üstteki tarafı kullan
            //analytics1.Dock = DockStyle.Fill;

        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e) // Nav Bar Home Button
        {
            analytics1.Hide();
            analytics1.Dock = DockStyle.Fill;
        }

        private void UploadMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "MP4|*.mp4|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo chosenFile = new FileInfo(ofd.FileName);
                    selectedFilePath = chosenFile.FullName;
                    newPlay.Enabled = true; // Start button
                }
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //mX = e.X;
            //mY = e.Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // temporary button
        {
            analytics1.Show();
            analytics1.Dock = DockStyle.Fill;
        }
        private void SetGradientBackground(Panel panel, System.Drawing.Color startColor, System.Drawing.Color endColor) // g // for gradient background
        {
            panel.Paint += (sender, e) =>
            {
                // Create a linear gradient brush
                LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Fill the panel with the gradient brush
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            
            WindowState = FormWindowState.Maximized;
            pictureBox2.Dock = DockStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            TopMost = true;
            pictureBox2.Size = ClientSize;

            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.BringToFront();
        }
    }
}
