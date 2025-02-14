using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaPhatApp.UserControls
{
    class ProgressBarEx : ProgressBar
    {
        private bool showBorder = false;
        private Color borderColor = Color.Black;

        public bool ShowBorder { get => showBorder; set { showBorder = value; Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

        public ProgressBarEx()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ForeColor = Color.Gray;
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rec = e.ClipRectangle;

            using (var backgroundBrush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(backgroundBrush, rec);

            var progressBarWidth = (int)(rec.Width * ((double)Value / Maximum));
            var progressBarHeight = rec.Height;

            using (var barBrush = new SolidBrush(ForeColor))
                e.Graphics.FillRectangle(barBrush, 0, 0, progressBarWidth, progressBarHeight);

            if (showBorder)
            {
                using (var pen = new Pen(borderColor))
                    e.Graphics.DrawRectangle(pen, rec.X, rec.Y, rec.Width - 1, rec.Height - 1);
            }
        }
    }
}
