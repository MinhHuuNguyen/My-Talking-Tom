using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyTalkingTom
{
    class RoundPictureBox : PictureBox
    {
        public RoundPictureBox()
        {
            BackColor = Color.DarkGray;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
                Region = new Region(graphicsPath);
            }
        }
    }
}
