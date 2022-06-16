using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm.Show();
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            label1.Text = ("Resolution: " + screenWidth + "x" + screenHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm.BackgroundImage = Properties.Resources.chevron_big;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.BackgroundImage = Properties.Resources.cross_dot;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.BackgroundImage = Properties.Resources.chevron_small;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm.BackgroundImage = Properties.Resources.dot_2x2;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            Text = ("Resolution: " + screenWidth + "x" + screenHeight);
        }
    }
}
