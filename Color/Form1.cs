using CSharpColorSpaceConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
namespace Color
{
    public partial class Form1 : Form
    {
        Thread pollThead;
        int x, y;

        System.Drawing.Color color;
        private delegate void UpdateFormDelegate();
        private UpdateFormDelegate updateFormDelegate;

        private delegate void UpdateMixerDelegate();
        private UpdateMixerDelegate updateMixerDelegate;

        System.Drawing.Color namedColorRGB;
        string namedColor = "";
        string[] names;
        int[] r, g, b;

        public Form1()
        {
            InitializeComponent();
            updateFormDelegate = new UpdateFormDelegate(UpdateForm);
            updateMixerDelegate = new UpdateMixerDelegate(UpdateMixer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pollThead = new Thread(new ThreadStart(GetColor));
            pollThead.IsBackground = true;
            pollThead.Start();
        }

        private void GetColor()
        {
            while (true)
            {
                x = Cursor.Position.X;
                y = Cursor.Position.Y;

                // BEGIN COORDINATE CORRECTION CODE
                // still haven't taken the time to figure this out.
                // it calculates the position different on different computers (different screens)
                // the problem is the value that gets sent to  Win32.GetPixelColor. it wants them in "logical units" https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-getpixel
                // apparently you can get that with dptolp but the code is gibirish to me (and i think wrong) https://www.pinvoke.net/default.aspx/gdi32/DPtoLP.html
                // the magic google was "c# convert to logical units" https://stackoverflow.com/questions/30424985/how-to-convert-a-wpf-inch-unit-to-winforms-pixels-and-vice-versa
                // additional reading https://stackoverflow.com/questions/422296/how-do-i-determine-the-true-pixel-size-of-my-monitor-in-net
                // why the * 2? well that is a GREAT question.
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        PointF dpi = PointF.Empty;
                        using (Graphics g = this.CreateGraphics())
                        {
                            dpi.X = g.DpiX;
                            dpi.Y = g.DpiY;
                            //x = Convert.ToInt32(x * 72 / dpi.X) * 1;
                            //y = Convert.ToInt32(y * 72 / dpi.Y) * 1;
                        }
                    }));
                }
                catch { }
                // END COORDINATE CORRECTION CODE

                color = Win32.GetPixelColor(x, y);
                panColor.BackColor = color;
                panNamedColor.BackColor = namedColorRGB;
                namedColor = ColorSpaceConverter.RGBToNamedColor(color.R, color.G, color.B, true);
                panNamedColor.BackColor = System.Drawing.Color.FromArgb(color.R, color.G, color.B);
                try
                {
                    this.Invoke(updateFormDelegate);
                }
                catch { }
                Thread.Sleep(50);
            }
        }

        private void UpdateForm()
        {
            //lblCoords.Text = "(" + x + ", " + y + ")";
            lblRed.Text = color.R.ToString();
            lblGreen.Text = color.G.ToString();
            lblBlue.Text = color.B.ToString();

            string hex = "#" + ColorSpaceConverter.RGBToHex(color.R, color.G, color.B);
            lblHex.Text = hex;

            lblNamedColor.Text = namedColor;

            var hsl = ColorSpaceConverter.RGBToHSL(color.R, color.G, color.B);
            lblHSL.Text = $"hsl({Convert.ToInt32(hsl[0])},{Convert.ToInt32(hsl[1])},{Convert.ToInt32(hsl[2])})";

            var hsv = ColorSpaceConverter.RGBToHSV(color.R, color.G, color.B);
            lblHSV.Text = $"hsv({Convert.ToInt32(hsv[0])},{Convert.ToInt32(hsv[1])},{Convert.ToInt32(hsv[2])})";
        }


        private void cbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTop.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void mixerChange(object sender, EventArgs e)
        {
            try
            {
                this.Invoke(updateMixerDelegate);
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                Bitmap img = (Bitmap)hslPictureBox.Image;

                form.StartPosition = FormStartPosition.CenterScreen;
                //form.Size = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }

        private void UpdateMixer()
        {
            int r = sliderRed.Value;
            int g = sliderGreen.Value;
            int b = sliderBlue.Value;
            System.Drawing.Color mixColor = System.Drawing.Color.FromArgb(r, g, b);
            string hex = ColorSpaceConverter.RGBToHex(r, g, b);
            if (hex.Length == 6)
            {
                lblRedHexSlider.Text = hex.Substring(0, 2);
                lblGreenHexSlider.Text = hex.Substring(2, 2);
                lblBlueHexSlider.Text = hex.Substring(4, 2);
            }
            else
            {
                lblRedHexSlider.Text = "";
                lblGreenHexSlider.Text = "";
                lblBlueHexSlider.Text = "";
            }
            lblRedSlider.Text = r + "";
            lblGreenSlider.Text = g + "";
            lblBlueSlider.Text = b + "";

            panMixer.BackColor = mixColor;
        }

        private void btnWhatIs_Click(object sender, EventArgs e)
        {
            string whatIs = txtWhatIs.Text;
            try
            {
                System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#" + whatIs);
                panWhatIs.BackColor = col;
            }
            catch
            {
                MessageBox.Show("Not a color");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    // http://stackoverflow.com/questions/753132/how-do-i-get-the-colour-of-a-pixel-at-x-y-using-c
    sealed class Win32
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            System.Drawing.Color color = System.Drawing.Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }
}

