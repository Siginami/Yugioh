using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yugioh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 nova = new Form3();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 nova2 = new Form4();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 nova3 = new Form5();
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 nova4 = new Form6();
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 nova4 = new Form7();
            Close();
        }
    }
}
