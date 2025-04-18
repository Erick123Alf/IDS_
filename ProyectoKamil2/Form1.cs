using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Form6();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form7();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new Form10();
            frm.Show();
        }
    }
}
