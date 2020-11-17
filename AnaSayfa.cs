using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu oyunda, sağ panelde bulunan 12 adet sayıyı size verilen sürede, eksiksiz bir şekilde kutucuklara yazmalısınız. Her el için bir beş saniye daha ipucu olarak sayıları görebilirsiniz. Eğer sayıları eksiksiz ve doğru biçimde girerseniz eli kazanırsınız.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
