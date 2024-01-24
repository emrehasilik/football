using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mustafa;
using Kaleci;
using Stoper;
using OnLibero;
using Ortasaha;
using Santrofor;


namespace Futbol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
    
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "zayıf";
            label7.Text = "mükemmel";
            label8.Text = "zayıf";
            label9.Text = "mükemmel";
            label10.Text = "kale";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "mükemmel";
            label7.Text = "güzel";
            label8.Text = "vasatın üstü";
            label9.Text = "zayıf";
            label10.Text = "stoper";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "iyi";
            label7.Text = "iyi";
            label8.Text = "vasatın üstü";
            label9.Text = "kötü";
            label10.Text = "ön libero";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Text = "Güzel";
            label7.Text = "mükemmel";
            label8.Text = "kötü";
            label9.Text = "kötü";
            label10.Text = "orta saha";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label6.Text = "Güzel";
            label7.Text = "güzel";
            label8.Text = "iyi";
            label9.Text = "zayıf";
            label10.Text = "forvet";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label6.Text = "mükemmel";
            label7.Text = "vasatın üstü";
            label8.Text = "mükemmel";
            label9.Text = "zayıf";
            label10.Text = "santrofor";

        }
    }
}
