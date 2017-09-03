using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Calculadora
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

        private void soma_Click(object sender, EventArgs e)
        {
            somar();
        }

        private void somar()
        {
            Double vl1 = Double.Parse(vl.Text);
            Double vl22 = Double.Parse(vl2.Text);
            Double calc = vl1 + vl22;
            label.Text = Convert.ToString(calc);
            

        }
    }
}
