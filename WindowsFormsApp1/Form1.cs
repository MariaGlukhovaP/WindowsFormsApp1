using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top = pictureBox3.Top + 5;
            pictureBox4.Top = pictureBox4.Top + 20;
            pictureBox5.Top = pictureBox5.Top + 10;

            if (pictureBox3.Top > 600) pictureBox3.Top = -100;
            if (pictureBox4.Top > 600) pictureBox4.Top = -100;
            if (pictureBox5.Top > 600) pictureBox5.Top = -100;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox2.Top = pictureBox2.Top - 10;
            if (e.KeyCode == Keys.Down) pictureBox2.Top = pictureBox2.Top + 10;
            if (e.KeyCode == Keys.Left) pictureBox2.Left = pictureBox2.Left - 10;
            if (e.KeyCode == Keys.Right) pictureBox2.Left = pictureBox2.Left + 10;

            if (pictureBox2.Top < 0) pictureBox2.Top = 0;
            if (pictureBox2.Left < 0) pictureBox2.Left = 0;
            if (pictureBox2.Top > 500) pictureBox2.Top = 500;

            if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds)) pictureBox2.Left = 0;
            if (pictureBox4.Bounds.IntersectsWith(pictureBox2.Bounds)) pictureBox2.Left = 0;
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds)) pictureBox2.Left = 0;
        }
    }
}
