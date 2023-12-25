using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playboycarti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inönü1s ss = new inönü1s();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inönü2s sa = new inönü2s();
            sa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            büyükttt sas = new büyükttt();
            sas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gedizm sasa = new gedizm();
            sasa.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kütahyaeskisehir sasas = new kütahyaeskisehir();
            sasas.Show();
        }
    }
}
