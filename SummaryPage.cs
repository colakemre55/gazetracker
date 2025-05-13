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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_EMGUCVBase
{
    

    public partial class SummaryPage : UserControl
    {
        private FlowLayoutPanel panel;
        private Image defaultImage = Image.FromFile("C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\Assets\\gaze.png");
        private string detectedImagesFolderPath = "C:\\Users\\colak\\source\\repos\\WindowsFormsApp_EMGUCVBase\\OutputFrames\\";
        private Dictionary<string, int> objectCounts = new Dictionary<string, int>();
        private List<GazePoint> gazePoints = new List<GazePoint>();

        public SummaryPage()
        {
            InitializeComponent();
            //InitializeFlowLayout();
            AddHeaderLabel();
            //ConfigureFlowLayoutPanel();
        }
        public void SetGazePoints(List<GazePoint> gazePointsList) // Add a method to set gaze points
        {
            gazePoints = gazePointsList;
        }
        public void SetObjectCounts(Dictionary<string, int> object2)
        {
            objectCounts = object2;
        }

        public void InitializeMethods()
        {
            UpdateObjectCounts();
            PopulateScatterPlot(gazePoints);
            textBox1.Font = new System.Drawing.Font("Calibri", 14, FontStyle.Regular);
            textBox2.Font = new System.Drawing.Font("Calibri", 14, FontStyle.Regular);
            textBox3.Font = new System.Drawing.Font("Calibri", 14, FontStyle.Regular);
            string backColor = "#FAFAFA";
            panel2.BackColor = ColorTranslator.FromHtml(backColor);
            panel3.BackColor = ColorTranslator.FromHtml(backColor);
            panel4.BackColor = ColorTranslator.FromHtml(backColor);
            textBox1.BackColor = ColorTranslator.FromHtml(backColor);
            textBox2.BackColor = ColorTranslator.FromHtml(backColor);
            textBox3.BackColor = ColorTranslator.FromHtml(backColor);
            flowLayoutPanel2.BackColor = ColorTranslator.FromHtml(backColor);
        }

        private void AddHeaderLabel()
        {
            Label headerLabel = new Label
            {
                Text = "Summary",
                Font = new Font("Calibri", 16, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10)
            };
            flowLayoutPanel2.Controls.Add(headerLabel);
        }

        public void UpdateObjectCounts()
        {
            flowLayoutPanel1.Controls.Clear();
            chart1.Series.Clear();

            int totalGazePointsOnObjects = objectCounts.Values.Sum();
            Series series = new Series
            {
                Name = "GazeDistribution",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Pie
            };

            var sortedObjectCounts = objectCounts
                .Select(entry => new
                {
                    ClassName = entry.Key,
                    Count = entry.Value,
                    Percentage = totalGazePointsOnObjects > 0 ? (double)entry.Value / totalGazePointsOnObjects * 100 : 0
                })
                .OrderByDescending(entry => entry.Percentage)
                .ToList();

            double otherPercentage = 0;
            int otherCount = 0;

            foreach (var entry in sortedObjectCounts)
            {
                string dirtyClassName = entry.ClassName;
                string cleanClassName = ExtractClassName(dirtyClassName);

                // Show all images in picture boxes regardless of their percentage
                if (cleanClassName == "0")
                {
                    continue;
                }

                int count = entry.Count;
                double percentage = entry.Percentage;

                Console.WriteLine($"Class: {cleanClassName}, Count: {count}, Percentage: {percentage:F2}%");

                string imagePath = FindRepresentativeImage(dirtyClassName);
                Image classImage = imagePath != null ? Image.FromFile(imagePath) : defaultImage;

                PictureBox pictureBox = new PictureBox
                {
                    Image = classImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100),
                    Margin = new Padding(10)
                };

                Label nameLabel = new Label
                {
                    Text = cleanClassName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.TopCenter,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                Label countLabel = new Label
                {
                    Text = $"{count} times ({percentage:F2}%)",
                    TextAlign = ContentAlignment.TopCenter,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                FlowLayoutPanel itemPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Size = new Size(120, 200),
                    Margin = new Padding(10)
                };
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(countLabel);

                flowLayoutPanel1.Controls.Add(itemPanel);

                // Group objects with less than or equal to 2% into "Others" for the pie chart
                if (percentage <= 2)
                {
                    otherPercentage += percentage;
                    otherCount += count;
                }
                else
                {
                    series.Points.AddXY(cleanClassName, percentage);
                }
            }

            if (otherCount > 0)
            {
                series.Points.AddXY("Others", otherPercentage);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Legends[0].Enabled = true;
        }

        private string FindRepresentativeImage(string objectClass)
        {
            string cleanClassName = ExtractClassName(objectClass);

            var imageFiles = Directory.EnumerateFiles(detectedImagesFolderPath, "*.jpg", SearchOption.AllDirectories)
                              .Concat(Directory.EnumerateFiles(detectedImagesFolderPath, "*.png", SearchOption.AllDirectories));

            foreach (string imagePath in imageFiles)
            {
                string filename = Path.GetFileNameWithoutExtension(imagePath);
                var parts = filename.Split('_');

                foreach (var part in parts)
                {
                    if (part.Equals(cleanClassName, StringComparison.OrdinalIgnoreCase))
                    {
                        return imagePath;
                    }
                }
            }
            return null;
        }

        private string ExtractClassName(string dirtyClassName)
        {
            int atIndex = dirtyClassName.IndexOf(" at ");
            if (atIndex != -1)
            {
                return dirtyClassName.Substring(0, atIndex);
            }
            return dirtyClassName;
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

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void PopulateScatterPlot(List<GazePoint> gazePoints)
        {
            // Clear previous series
            chart3.Series.Clear();

            // Create a new series for the scatter plot
            Series scatterSeries = new Series
            {
                Name = "GazePoints",
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                Color = Color.Red
            };

            // Add the gaze points to the series
            foreach (var point in gazePoints)
            {
                scatterSeries.Points.AddXY(point.X, point.Y);
            }

            // Add the series to the chart
            chart3.Series.Add(scatterSeries);

            // Configure chart area
            chart3.ChartAreas[0].AxisX.Title = "X";
            chart3.ChartAreas[0].AxisY.Title = "Y";
            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Maximum = 1920; // Assuming 1920x1080 resolution, adjust as needed
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Maximum = 1080; // Assuming 1920x1080 resolution, adjust as needed
        }

    }
}
