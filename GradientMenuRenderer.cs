using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace WindowsFormsApp_EMGUCVBase
{
    
    public class GradientMenuRenderer : ToolStripProfessionalRenderer
    {
        private Color color1;
        private Color color2;

        // Constructor to accept gradient colors
        public GradientMenuRenderer(string color1, string color2)
        {
            this.color1 = ColorTranslator.FromHtml(color1);
            this.color2 = ColorTranslator.FromHtml(color2);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);

            using (var brush = new LinearGradientBrush(e.AffectedBounds, color1, color2, 90))
            {
                e.Graphics.FillRectangle(brush, e.AffectedBounds);
            }
        }
    }
}
