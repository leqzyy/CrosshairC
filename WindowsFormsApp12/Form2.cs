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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;
            this.CenterToScreen();
            TransparencyKey = Color.AliceBlue;
            this.TopMost = true;
            this.Focus();
            this.TopMost = true;
        }
    }
}
