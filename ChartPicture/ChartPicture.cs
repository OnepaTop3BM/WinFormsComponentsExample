using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace WinFormsComponentsExample
{
    [DataContract()]
    public class ChartPicture : PictureBox
    {
        private String _formula;
        private String _imagePath;
        private bool _enable = true;
        private bool _visible = true;

        public ChartPicture(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            Visible = true;
            Enabled = true;
        }

        [DataMember]
        public new bool Enabled
        {
            get { return _enable; } 
            set { _enable = value; }
        }

        [DataMember]
        public new bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        [DataMember]
        public int X
        {
            get { return base.Left; }
            set
            {
                if (base.Left != value)
                {
                    base.Left = value;
                    Redraw();
                }
            }
        }

        [DataMember]
        public int Y
        {
            get { return base.Top; }
            set
            {
                if (base.Top != value)
                {
                    base.Top = value;
                }
            }
        }

        [DataMember]
        public new int Width
        {
            get { return base.Width; }
            set
            {
                if (base.Width != value)
                {
                    base.Width = value;
                }
            }
        }

        [DataMember]
        public new int Height
        {
            get { return base.Height; }
            set
            {
                if (base.Height != value)
                {
                    base.Height = value;
                }
            }
        }

        [DataMember]
        public String Formula
        {
            get { return _formula; }
            set
            {
                if (_formula != value)
                {
                    _formula = value;
                }
            }
        }

        [DataMember]
        public String ImagePath
        {
            get { return _imagePath; }
            set
            {
                if (_imagePath != value)
                {
                    _imagePath = value;
                }
            }
        }

        private void Redraw()
        {
            Invalidate(true);
            if (String.IsNullOrEmpty(ImagePath))
            {
                Image = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(Image);
                //Brush brush = new HatchBrush(HatchStyle.Percent05, Color.Gray);
                Brush brush = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Gray);
                Pen pen = new Pen(brush, 2F);
                Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
                g.FillRectangle(brush, rect);
                g.Dispose();
            }
        }

        public void Update()
        {
            Redraw();
        }
    }
}