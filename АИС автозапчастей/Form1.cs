using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Odin_Click(object sender, EventArgs e)
        {
            Text.Text += "1";
        }

        private void Dva_Click(object sender, EventArgs e)
        {
            Text.Text += "2";
        }

        private void Tri_Click(object sender, EventArgs e)
        {
            Text.Text += "3";
        }

        private void Nol_Click(object sender, EventArgs e)
        {
            Text.Text += "0";
        }

        private void Chetire_Click(object sender, EventArgs e)
        {
            Text.Text += "4";
        }

        private void Pat_Click(object sender, EventArgs e)
        {
            Text.Text += "5";
        }

        private void Shet_Click(object sender, EventArgs e)
        {
            Text.Text += "6";
        }

        private void Sem_Click(object sender, EventArgs e)
        {
            Text.Text += "7";
        }

        private void Vosem_Click(object sender, EventArgs e)
        {
            Text.Text += "8";
        }

        private void Devat_Click(object sender, EventArgs e)
        {
            Text.Text += "9";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Text.Text = "";
        }
    }
}
