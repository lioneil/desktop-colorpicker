using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Unity3.Eyedropper
{
    public class EyeDropper : Control
    {
        public event EventHandler SelectedColorChanged;

        public event EventHandler BeginScreenCapture;
        protected void OnBeginScreenCapture()
        {
            if (BeginScreenCapture != null)
                BeginScreenCapture(this, null);
        }

        public delegate void ScreenCapturedArgs(Bitmap capturedPixels, Color capturedColor);
        public event ScreenCapturedArgs ScreenCaptured;
        protected void OnScreenCaptured()
        {
            if (ScreenCaptured != null)
                ScreenCaptured(bmpScreenCapture, _SelectedColor);
        }

        public event EventHandler EndScreenCapture;
        protected void OnEndScreenCapture()
        {
            if (EndScreenCapture != null)
                EndScreenCapture(this, null);
        }

        Bitmap bmpScreenCapture;

        private PixelZoom pixelZoom;

        public enum ePreviewPositionStyle
        {
            Manual = 0,
            Centered = 1,
            TopLeft = 2,
            TopCenter = 3,
            TopRight = 4,
            BottomLeft = 5,
            BottomCenter = 6,
            BottomRight = 7
        }


        private float _Zoom = 4;
        [DefaultValue((float)4)]
        public float PixelPreviewZoom
        {
            get { return _Zoom; }
            set
            {
                _Zoom = value;
                RecalcSnapshotSize();
            }
        }

        Color _SelectedColor;
        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set
            {
                if (_SelectedColor == value)
                    return;
            }
        }

        private Size _PixelPreviewSize = new Size(100, 50);
        public Size PixelPreviewSize
        {
            get { return _PixelPreviewSize; }
            set
            {
                _PixelPreviewSize = value;
                RecalcSnapshotSize();
            }
        }

        private bool _ShowPixelPreview = true;
        /// <summary>
        /// Gets or sets a value indicating if the the pop up 
        /// preview will show the captured pixel(s).
        /// </summary>
        [DefaultValue(true)]
        public bool ShowPixelPreview
        {
            get { return _ShowPixelPreview; }
            set { _ShowPixelPreview = value; }
        }

        private bool _ShowColorPreview = true;
        /// <summary>
        /// Gets or sets a value indicating if the the pop up 
        /// preview will show the captured color.
        /// </summary>
        [DefaultValue(true)]
        public bool ShowColorPreview
        {
            get { return _ShowColorPreview; }
            set { _ShowColorPreview = value; }
        }

        private Point _PreviewLocation;
        /// <summary>
        /// Gets ot sets the upper-left coordinates of the pop up 
        /// preview's location relative to the eyedropper control.
        /// Note: This value is ignored if the PreviewPositionStyle is not set to: Manual
        /// </summary>
        public Point PreviewLocation
        {
            get { return _PreviewLocation; }
            set { _PreviewLocation = value; }
        }

        private ePreviewPositionStyle _PreviewPositionStyle;
        /// <summary>
        /// Gets or sets the popup style.
        /// </summary>
        public ePreviewPositionStyle PreviewPositionStyle
        {
            get { return _PreviewPositionStyle; }
            set { _PreviewPositionStyle = value; }
        }


        private Cursor curDropper;
        private Bitmap bmpDropper;

        public EyeDropper()
        {
            this.Size = new Size(22, 22);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            bmpDropper = new Bitmap(Properties.Resources.eyedropper);
            bmpDropper.MakeTransparent(Color.White);

            curDropper = Unity3.EyeDropper.CursorHandler.LoadCursor("Unity3.Eyedropper.Resources.eyeDropper.cur");
            RecalcSnapshotSize();
        }

        public override Size MaximumSize
        {
            get
            {
                return base.MaximumSize;
            }
        }

        public override Size MinimumSize
        {
            get
            {
                return base.MinimumSize;
            }
        }

        bool iscapturing = false;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Cursor = curDropper;
                Cursor.Position = this.Parent.PointToScreen(new Point(this.Left + 2, this.Bottom - 4));
                iscapturing = true;
                OnBeginScreenCapture();
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!iscapturing)
                e.Graphics.DrawImage(bmpDropper, (this.Width - bmpDropper.Width) / 2, (this.Height - bmpDropper.Height) / 2);
            Rectangle r = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //e.Graphics.DrawRectangle(SystemPens.ControlDark, r);
            //e.Graphics.DrawLine(SystemPens.ControlLightLight, 0, r.Bottom, r.Right, r.Bottom);
            //e.Graphics.DrawLine(SystemPens.ControlLightLight, r.Right, 0, r.Right, r.Bottom);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iscapturing)
                captureScreen();

        }


        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            {
                Cursor = Cursors.Hand;
                iscapturing = false;
                if (pixelZoom != null)
                {
                    pixelZoom.Close();
                    pixelZoom.Dispose();
                    pixelZoom = null;
                }
                this.Invalidate();
                this.OnEndScreenCapture();
            }
        }


        private void captureScreen()
        {
            Point p = Control.MousePosition;
            p.X -= bmpScreenCapture.Width / 2;
            p.Y -= bmpScreenCapture.Height / 2;

            using (System.Drawing.Graphics dc = System.Drawing.Graphics.FromImage(bmpScreenCapture))
            {
                dc.CopyFromScreen(p, new Point(0, 0), bmpScreenCapture.Size);

                Color c = bmpScreenCapture.GetPixel(
                    (int)(bmpScreenCapture.Size.Width / 2.0F),
                    (int)(bmpScreenCapture.Size.Height / 2.0F));
                if (c != _SelectedColor)
                {
                    _SelectedColor = c;
                    if (SelectedColorChanged != null)
                        SelectedColorChanged(this, null);
                }

                if (_ShowPixelPreview || _ShowColorPreview)
                {
                    if (pixelZoom == null)
                        pixelZoom = new PixelZoom(this);
                    pixelZoom.PaintScreenCapture(bmpScreenCapture);
                }
                OnScreenCaptured();
            }
        }

        void RecalcSnapshotSize()
        {
            if (bmpScreenCapture != null)
                bmpScreenCapture.Dispose();
            Size r = _PixelPreviewSize;
            int w = (int)(Math.Floor(r.Width / PixelPreviewZoom));
            int h = (int)(Math.Floor(r.Height / PixelPreviewZoom));
            bmpScreenCapture = new Bitmap(w, h);
        }

        internal class PixelZoom : Form
        {
            private EyeDropper parent;

            Rectangle rectColor;
            Rectangle rectScreen;
            byte shadow = 6;
            public PixelZoom(EyeDropper parent)
            {
                this.parent = parent;
                this.ShowInTaskbar = false;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.StartPosition = FormStartPosition.Manual;
                //We intentionally set the bounds after showing the form.
                //This bypasses a bug in the Form class when setting the 
                //bounds internally before calling the Show() method. 
                this.Show();
                setBounds();

                //Paint the bounds as a rounded rectangle...
                System.Drawing.Graphics g = this.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath gpArea = this.BuildRoundedRectangle(new Rectangle(shadow, shadow, this.Width - shadow, this.Height - shadow), 20);
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(150, Color.Black)))
                { g.FillPath(sb, gpArea); }
                g.TranslateTransform(-shadow, -shadow);
                g.FillPath(Brushes.WhiteSmoke, gpArea);
                g.DrawPath(Pens.Black, gpArea);
                g.Dispose();
                gpArea.Dispose();
            }

            private void setBounds()
            {
                Size parentHalf = new Size(parent.Width / 2, parent.Height / 2);
                Point pntScreen = parent.Parent.PointToScreen(parent.Location);
                Rectangle rBounds;

                if (parent.ShowColorPreview && parent.ShowPixelPreview)
                    rBounds = new Rectangle(0, 0, parent.PixelPreviewSize.Width + 20 + shadow, parent.PixelPreviewSize.Height * 2 + 25 + shadow);
                else
                    rBounds = new Rectangle(0, 0, parent.PixelPreviewSize.Width + 20 + shadow, parent.PixelPreviewSize.Height + 20 + shadow);

                switch (parent.PreviewPositionStyle)
                {
                    case ePreviewPositionStyle.Manual:
                        rBounds.Location = new Point(pntScreen.X + parent.PreviewLocation.X, pntScreen.Y + parent.PreviewLocation.Y);
                        break;
                    case ePreviewPositionStyle.TopLeft:
                        rBounds.Location = pntScreen;
                        break;
                    case ePreviewPositionStyle.TopCenter:
                        rBounds.Location = new Point(
                            pntScreen.X - ((parent.PixelPreviewSize.Width + 20 - parent.Size.Width) / 2),
                            pntScreen.Y);
                        break;
                    case ePreviewPositionStyle.TopRight:
                        rBounds.Location = new Point(
                            pntScreen.X + parent.Width,
                            pntScreen.Y);
                        break;
                    case ePreviewPositionStyle.BottomLeft:
                        rBounds.Location = new Point(
                            pntScreen.X,
                            pntScreen.Y + parent.Height);
                        break;
                    case ePreviewPositionStyle.BottomCenter:
                        rBounds.Location = new Point(
                            pntScreen.X - ((parent.PixelPreviewSize.Width + 20 - parent.Size.Width) / 2),
                            pntScreen.Y + parent.Height);
                        break;
                    case ePreviewPositionStyle.BottomRight:
                        rBounds.Location = new Point(
                            pntScreen.X + parent.Width,
                            pntScreen.Y + parent.Height);
                        break;
                    case ePreviewPositionStyle.Centered:
                        rBounds.Location = new Point(
                        pntScreen.X - ((parent.PixelPreviewSize.Width + 20 - parent.Size.Width) / 2),
                        pntScreen.Y - (((parent.PixelPreviewSize.Height * 2) + 25 - parent.Size.Height) / 2));
                        break;
                }
                this.Bounds = rBounds;
                if (parent.ShowColorPreview && parent.ShowPixelPreview)
                {
                    rectColor = new Rectangle(10, 10, parent.PixelPreviewSize.Width, parent.PixelPreviewSize.Height);
                    rectScreen = new Rectangle(10, parent.PixelPreviewSize.Height + 15, parent.PixelPreviewSize.Width, parent.PixelPreviewSize.Height);
                }
                else
                {
                    if (parent.ShowColorPreview)
                        rectColor = new Rectangle(10, 10, parent.PixelPreviewSize.Width, parent.PixelPreviewSize.Height);
                    else
                        rectScreen = new Rectangle(10, 10, parent.PixelPreviewSize.Width, parent.PixelPreviewSize.Height);
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                //base.OnPaint(e);
                //No painting is done here or in the OnPaintBackground
                //method so the screen real estate will remain the same.
                //We will create a device context ourselves to do the painting.
            }

            protected override void OnPaintBackground(PaintEventArgs e)
            {
                //base.OnPaintBackground(e);
            }

            public void PaintScreenCapture(System.Drawing.Bitmap screenCapture)
            {
                //create a device context to the form
                System.Drawing.Graphics g = this.CreateGraphics();

                if (parent.ShowColorPreview)
                {
                    //paints the selected pixel color from the screen
                    using (SolidBrush sb = new SolidBrush(parent.SelectedColor))
                    {
                        g.FillRectangle(sb, rectColor);
                        g.DrawRectangle(Pens.Black, rectColor);
                    }
                }

                if (parent.ShowPixelPreview && screenCapture != null)
                {
                    //paints the selected pixels from the screen
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(screenCapture, rectScreen);
                    Color color = parent.SelectedColor;
                    bool useBlack = (color.R + color.G + color.B > 128 * 3 ? true : false);
                    g.DrawRectangle(useBlack ? Pens.Black : Pens.White, new Rectangle(
                        rectScreen.X + (rectScreen.Width / 2) - 2,
                        rectScreen.Y + (rectScreen.Height / 2) - 2, 4, 4));
                    g.DrawRectangle(Pens.Black, rectScreen);
                }
                //dispose the device context
                g.Dispose();
            }

            internal GraphicsPath BuildRoundedRectangle(Rectangle bounds, byte roundness)
            {
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                if (roundness < 0)
                    throw new ArgumentException("Roundess value must be greater than -1!");
                if (roundness == 0)
                {
                    gp.AddRectangle(bounds);
                }
                else
                {
                    gp.AddArc(bounds.Right - roundness, bounds.Top, roundness, roundness, 0, 0); // 270, 90
                    gp.AddArc(bounds.Right - roundness, bounds.Bottom - roundness, roundness, roundness, 0, 0); // 0, 90
                    gp.AddArc(bounds.Left, bounds.Bottom - roundness, roundness, roundness, 0, 0); // 90, 90
                    gp.AddArc(bounds.Left, bounds.Top, roundness, roundness, 0, 0); // 180, 90
                    gp.CloseAllFigures();
                }

                return gp;
            }
        }
    }
}
