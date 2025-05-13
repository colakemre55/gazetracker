using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_EMGUCVBase.lib
{
    internal class Summary
    {
        private List<Detection> detections = new List<Detection>();
        private List<GazePoint> gazePoints = new List<GazePoint>();
        private Dictionary<string, int> gazeDuration = new Dictionary<string, int>();

        public Summary() { }
         
        public int GetLength()
        {
            return detections.Count;
        }
        public List<GazePoint> GetGazePoints()
        {
            return gazePoints;
        }
        public void AddDetection(Detection detection)
        {
            // Video frame capture ederken 1920x1080 alınamıyor
            // O kısmı düzeltince burayı sil
            //detection.xMin *= 1920 / 1280;
            detection.xMax *= 1920 / 1280;
            //detection.yMin *= 1080 / 720;
            detection.yMax *= 1080 / 720;

            detections.Add(detection);
        }

        public void AddGazePoint(GazePoint gazePoint)
        {
            gazePoints.Add(gazePoint);
        }

        public void ProcessGazeDetections()
        {
            foreach (var gazePoint in gazePoints)
            {
                foreach (var detection in detections)
                {
                    if (detection.frameNumber != gazePoint.frameNumber)
                    {
                        continue;
                    }
                    if (IsGazeOnObject(gazePoint, detection))
                    {
                        // Use class name as the key instead of specific coordinates
                        string key = detection.className;
                        if (gazeDuration.ContainsKey(key))
                            gazeDuration[key]++;
                        else
                            gazeDuration[key] = 1;
                    }
                }
            }
        }

        private bool IsGazeOnObject(GazePoint gaze, Detection detection)
        {
            return gaze.X >= detection.xMin && gaze.X <= (detection.xMax) &&
                  gaze.Y >= detection.yMin && gaze.Y <= (detection.yMax);
        }

        public Dictionary<string, int> GetGazeDuration()
        {
            return gazeDuration;
        }
    }
    // Double değerler float olabilir
    public class Detection
    {
        [JsonProperty("frame_number")]
        public int frameNumber { get; set; }

        [JsonProperty("class")]
        public string className { get; set; }


        public double xMin { get; set; }
        public double yMin { get; set; }
        public double xMax { get; set; }
        public double yMax { get; set; }
    }

    public class GazePoint
    {
        public int frameNumber { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
