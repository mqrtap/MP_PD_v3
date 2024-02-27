using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_PD_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void summa_TextChanged(object sender, EventArgs e)
        {

        }
        private void Aprekini(string prec_noss, int prec_cenas, int prec_daudzs)
        {
            

            int summa;
            summa = prec_cenas * prec_daudzs;
            //Console.WriteLine("Kopējā summa ir" + summa);
            txt_summa.Text = summa.ToString();
        }

        private void aprekinat_btn_Click(object sender, EventArgs e)
        {
            int prec_cenina = Convert.ToInt32(prec_cena.Text);
            double daudz = Convert.ToInt32(prec_daud.Value);

            Aprekini(prec_nos.Text, prec_cenina, (int)daudz);
        }
    }
}
