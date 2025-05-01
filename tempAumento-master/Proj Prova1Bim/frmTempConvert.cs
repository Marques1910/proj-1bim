using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Prova1Bim
{
    public partial class tmpConvet : Form
    {
        public double result = 0;
        public tmpConvet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            double num1 = (double)numOperTemp.Value;
            double num2 = (double)numOperAumento.Value;
            result = num1 + (num1*(num2/100));
            lblTempFinal.Text=result.ToString();
        }

        private void lblTempFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
