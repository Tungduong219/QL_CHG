using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTL_QLCHG.Utils
{
    public class RoundPanel : Panel
    {
        public int BorderRadius { get; set; } = 15;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }
    }
}