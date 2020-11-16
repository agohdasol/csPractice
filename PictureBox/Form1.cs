using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Graphics picGr;
            Pen penTmp;

            int i;
            int r, g, b;

            Random rnd = new Random();

            r = rnd.Next(256);
            g = rnd.Next(256);
            b = rnd.Next(256);

            penTmp = new Pen(Color.FromArgb(r, g, b), 1);

            picGr = pictureTest.CreateGraphics();

            for(i = 0; i < pictureTest.Width; i++)
            {
                picGr.DrawLine(penTmp, i, 0, i, pictureTest.Height);
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }
    }
}
