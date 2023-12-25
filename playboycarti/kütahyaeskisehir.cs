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
    public partial class kütahyaeskisehir : Form
    {
        public kütahyaeskisehir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Projemi Değerlendirdiğin İçin Teşekkürler Tekrar Denemek İstiyor Musun?","thx",MessageBoxButtons.YesNoCancel);
        }
    }
}
