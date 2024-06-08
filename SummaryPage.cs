using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp_EMGUCVBase.lib;

namespace WindowsFormsApp_EMGUCVBase
{
    

    public partial class SummaryPage : UserControl
    {
        private FlowLayoutPanel panel;
        private Image defaultImage = Image.FromFile("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\Assets\\gaze.png");
        private string detectedImagesFolderPath = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\OutputFrames\\";
        private Dictionary<string, int> objectCounts = new Dictionary<string, int>();
        public SummaryPage()
        {
            InitializeComponent();
            //InitializeFlowLayout();
            AddHeaderLabel();
            //ConfigureFlowLayoutPanel();
        }

        public void SetObjectCounts(Dictionary<string, int> object2)
        {
            objectCounts = object2;
        }

        public void InitializeMethods()
        {
            UpdateObjectCounts();
        }

        private void AddHeaderLabel()
        {
            Label headerLabel = new Label
            {
                Text = "You have looked at these objects",
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10)
            };
            flowLayoutPanel2.Controls.Add(headerLabel);
        }

        public void UpdateObjectCounts()
        {
            // Clear previous items but keep the header
            flowLayoutPanel1.Controls.Clear();
            
            chart1.Series.Clear();

            // Calculate the total number of gaze points on objects
            int totalGazePointsOnObjects = objectCounts.Values.Sum();

            // Create a new series for the bar chart
            Series series = new Series
            {
                Name = "GazeDistribution",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Pie // Change to Column for vertical bars
            };

            foreach (var entry in objectCounts)
            {
                string dirtyClassName = entry.Key;
                string cleanClassName = ExtractClassName(dirtyClassName); // Clean class name

                // Skip any entries with the class name "0"
                if (cleanClassName == "0")
                {
                    continue;
                }

                int count = entry.Value;

                // Calculate percentage
                double percentage = totalGazePointsOnObjects > 0 ? (double)count / totalGazePointsOnObjects * 100 : 0;

                // Log each class count and percentage for debugging
                Console.WriteLine($"Class: {cleanClassName}, Count: {count}, Percentage: {percentage:F2}%");

                string imagePath = FindRepresentativeImage(dirtyClassName); // Use dirty class name for file matching
                Image classImage = imagePath != null ? Image.FromFile(imagePath) : defaultImage;

                // Create a PictureBox for the image
                PictureBox pictureBox = new PictureBox
                {
                    Image = classImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100), // Adjust size as needed
                    Margin = new Padding(10)
                };

                // Create a Label for the class name above the image
                Label nameLabel = new Label
                {
                    Text = cleanClassName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.TopCenter,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                // Create a Label for the count and percentage below the image
                Label countLabel = new Label
                {
                    Text = $"{count} times ({percentage:F2}%)",
                    TextAlign = ContentAlignment.TopCenter,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                // Create a panel to hold the labels and PictureBox
                FlowLayoutPanel itemPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Size = new Size(120, 200), // Adjust size as needed
                    Margin = new Padding(10)
                };
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(countLabel);

                // Add the item panel to the main flowLayoutPanel
                flowLayoutPanel1.Controls.Add(itemPanel);

                // Add data points to the series for the chart
                //series.Points.AddXY(cleanClassName, percentage);

                DataPoint dataPoint = new DataPoint
                {
                    AxisLabel = cleanClassName,
                    YValues = new double[] { percentage }
                };
                dataPoint.Label = $"{percentage:F2}%"; // Show percentage on the pie chart
                dataPoint.LegendText = cleanClassName; // Show class name in the legend
                series.Points.Add(dataPoint);

            }

            // Add the series to the chart
            chart1.Series.Add(series);
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true; // Enable 3D for a nicer look
            chart1.Legends[0].Enabled = true;
        }


        private string FindRepresentativeImage(string objectClass)
        {
            string cleanClassName = ExtractClassName(objectClass); // Clean the class name first

            // Scan the folder for image files
            var imageFiles = Directory.EnumerateFiles(detectedImagesFolderPath, "*.jpg", SearchOption.AllDirectories)
                              .Concat(Directory.EnumerateFiles(detectedImagesFolderPath, "*.png", SearchOption.AllDirectories));

            foreach (string imagePath in imageFiles)
            {
                // Split the filename to extract parts
                string filename = Path.GetFileNameWithoutExtension(imagePath);
                var parts = filename.Split('_');

                // Check if any part of the filename matches the cleaned object class
                foreach (var part in parts)
                {
                    if (part.Equals(cleanClassName, StringComparison.OrdinalIgnoreCase))
                    {
                        return imagePath; // Return the first image found that matches the class
                    }
                }
            }
            return null; // Return null if no matching image is found
        }

        private string ExtractClassName(string dirtyClassName)
        {
            int atIndex = dirtyClassName.IndexOf(" at ");
            if (atIndex != -1)
            {
                return dirtyClassName.Substring(0, atIndex); // Extract up to " at "
            }
            return dirtyClassName; // Return as is if the expected format is not found
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
