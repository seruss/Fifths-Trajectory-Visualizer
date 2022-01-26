using System;
using System.Drawing;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT

                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var side = Math.Min(Width, Height);
            DrawingUtils.DrawLabels(e.Graphics, side);
            BackColor = Color.Transparent;
        }
    }
}