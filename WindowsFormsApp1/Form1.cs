using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MathNet.Numerics;

namespace IntersectColorChanger
{
    public partial class Form1 : Form
    {
        private Bitmap leftBitmap;
        private Bitmap rightBitmap;
        private Bitmap formBitmap;
        private static float lineWidth = 10;
        private Pen redPen = new Pen(Color.FromArgb(255, 255, 0, 0), lineWidth);
        private Pen invertPen = new Pen(Color.FromArgb(255, 0, 255, 255), lineWidth);
        private Pen whitePen = new Pen(Color.FromArgb(255, 255, 255, 255), lineWidth);
        public Form1()
        {
            InitializeComponent();

        }

        private void RefreshGraphics()
        {
            this.BackgroundImage = formBitmap;
            this.Refresh();

            redPictureBox.BackgroundImage = leftBitmap;
            redPictureBox.Refresh();

            invertPictureBox.BackgroundImage = rightBitmap;
            invertPictureBox.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formBitmap = new Bitmap(this.Width, this.Height);
            var g = Graphics.FromImage(formBitmap);
            g.Clear(Color.Black);


            leftBitmap = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(leftBitmap);
            g.Clear(Color.Black);


            rightBitmap = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(rightBitmap);
            g.Clear(Color.Black);


            RefreshGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawLine(new Point(0, 0), new Point(Width, Height));
        }


        private void DrawLine(Point a, Point b)
        {
            Graphics g;

            g = Graphics.FromImage(leftBitmap);
            g.FillRectangle(Brushes.Red, new Rectangle(new Point(0, 0), new Size(Width / 2,  Height / 3)));
            g.DrawLine(redPen, a, b);

            g = Graphics.FromImage(rightBitmap);
            g.DrawLine(invertPen, a, new Point(b.X + 15, b.Y - 15));
            g.FillRectangle(Brushes.Aqua, new Rectangle(new Point(Width / 3, Height / 4), new Size(Width*2 / 3, Height*2 / 3)));


            using (var leftData = leftBitmap.Lock())
            {
                using (var rightData = rightBitmap.Lock())
                {
                    var rightMatrix = rightData.ToMatrix(GetColorType);
                    var leftMatrix = leftData.ToMatrix(GetColorType);
                    var mainMatrix = leftMatrix.Add(rightMatrix);
                    formBitmap = mainMatrix.ToBitmap(GetColorType);
                }
            }

            RefreshGraphics();
        }


        private static double GetColorType(Color color)
        {
            if (color.R == 0 && color.G == 0 && color.B == 0)
            {
                return 0;
            }

            if (color.R == 255 && color.G == 0 && color.B == 0)
            {
                return 1;
            }

            if (color.R == 0 && color.G == 255 && color.B == 255)
            {
                return 2;
            }

            if (color.R == 255 && color.G == 255 && color.B == 255)
            {
                return 3;
            }

            return 4;
        }


        private static Color GetColorType(double color)
        {
            switch ((int)color)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Aqua;
                case 3:
                    return Color.White;
                default:
                    return Color.DarkOrange;
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var red = false;
            var invert = false;
            switch (listBox1.SelectedIndex)
            {
                case 1:
                    red = true;
                    break;
                case 2:
                    invert = true;
                    break;
            }

            redPictureBox.Visible = red;
            invertPictureBox.Visible = invert;
            RefreshGraphics();
        }
    }
}
