using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        private double media, num1, num2, num3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num1 = (double)numMedia1.Value;
            num2 = (double)numMedia2.Value;
            num3 = (double)numMedia3.Value;
            mediaProva();
        }

        void mediaProva()
        {
            media = (num1 + num2 + num3) / 3;
            lblResult.Text = "A média é: " + media.ToString("F2");
        }
    }
}
