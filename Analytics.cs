using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_EMGUCVBase
{
    public partial class Analytics : UserControl
    {
        public int numberOfDetectedFrames;

        private string outputDetectedFramesFolderPath = @"C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\OutputFrames\\";

        public Analytics()
        {
            InitializeComponent();   
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(numberOfDetectedFrames.ToString()); // load ilk başta da oluyor, bug olabilir
            SetTrackBarProperties();
        }

        private void SetTrackBarProperties()
        {
            if(numberOfDetectedFrames <= 0)
            {
                // do nothing for now
            }
            else
            {
                metroTrackBar1.Maximum = numberOfDetectedFrames - 1;
                metroTrackBar1.Value = 0;
            }
            
            
            metroTrackBar1.BackColor = ColorTranslator.FromHtml("#91BBF2");
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e) // Prev photo
        {
            if ((metroTrackBar1.Value - 1) >= metroTrackBar1.Minimum)
            {
                metroTrackBar1.Value--;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Next photo
        {
            if( (metroTrackBar1.Value + 1) <= metroTrackBar1.Maximum)
            {
                metroTrackBar1.Value++;
            }
            
        }

        private void detectedFramesPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            string framePath = outputDetectedFramesFolderPath + "Video_" + metroTrackBar1.Value + ".jpg";
            Image image = Image.FromFile(framePath);
            detectedFramesPictureBox.Image = image;
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            string framePath = outputDetectedFramesFolderPath + "Video_" + metroTrackBar1.Value + ".jpg";
            Image image = Image.FromFile(framePath);
            detectedFramesPictureBox.Image = image;
        }
    }
}
