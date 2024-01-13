using Microsoft.ML.Transforms.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_EMGUCVBase.Models
{
    public class WineInput
    {

        [ImageType(ImageSettings.imageHeight, ImageSettings.imageWidth)]

        public Bitmap Image { get; set; }

    }
}
