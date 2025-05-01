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
    public partial class frmTempConvert : Form
    {
        public double result = 0;
        public frmTempConvert()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            double num1 = (double)numOperTemp.Value;
            double num2 = (double)numOperAumento.Value;
            result = num1 + (num1 * (num2 / 100));
            lblTempFinal.Text = result.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair?",
                                   "Calculo da Média",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
