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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int sure = 5;

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            
            sure = 5;
            timer1.Start();
            btnBasla.Enabled = false;
            BtnTekrar.Enabled = true;
            BtnKontrol.Enabled = true;
            groupBox1.Visible = true;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;

            int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6, sayı7, sayı8, sayı9, sayı10, sayı11, sayı12;
            sayı1 = rand.Next(0, 51);
            sayı2 = rand.Next(0, 51);
            sayı3 = rand.Next(0, 51);
            sayı4 = rand.Next(0, 51);
            sayı5 = rand.Next(0, 51);
            sayı6 = rand.Next(0, 51);
            sayı7 = rand.Next(0, 51);
            sayı8 = rand.Next(0, 51);
            sayı9 = rand.Next(0, 51);
            sayı10 = rand.Next(0, 51);
            sayı11 = rand.Next(0, 51);
            sayı12 = rand.Next(0, 51);


            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();
            label6.Text = sayı6.ToString();
            label7.Text = sayı7.ToString();
            label8.Text = sayı8.ToString();
            label9.Text = sayı9.ToString();
            label10.Text = sayı10.ToString();
            label11.Text = sayı11.ToString();
            label12.Text = sayı12.ToString();
        
        }

        private void Renk()
        {
            if(textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.DarkSeaGreen;
            }

            if(textBox2.Text==label2.Text)
            {
                textBox2.BackColor = Color.DarkSeaGreen;
            }

            if(textBox3.Text==label3.Text)
            {
                textBox3.BackColor = Color.DarkSeaGreen;
            }

            if(textBox4.Text==label4.Text)
            {
                textBox4.BackColor = Color.DarkSeaGreen;
            }

            if(textBox5.Text==label5.Text)
            {
                textBox5.BackColor = Color.DarkSeaGreen;
            }

            if(textBox6.Text==label6.Text)
            {
                textBox6.BackColor = Color.DarkSeaGreen;
            }

            if (textBox7.Text == label7.Text)
            {
                textBox7.BackColor = Color.DarkSeaGreen;
            }

            if (textBox8.Text == label8.Text)
            {
                textBox8.BackColor = Color.DarkSeaGreen;
            }

            if (textBox9.Text == label9.Text)
            {
                textBox9.BackColor = Color.DarkSeaGreen;
            }

            if (textBox10.Text == label10.Text)
            {
                textBox10.BackColor = Color.DarkSeaGreen;
            }

            if (textBox11.Text == label11.Text)
            {
                textBox11.BackColor = Color.DarkSeaGreen;
            }

            if (textBox12.Text == label12.Text)
            {
                textBox12.BackColor = Color.DarkSeaGreen;
            }
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
           

            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text && label11.Text == textBox11.Text && label12.Text == textBox12.Text)
            {

                Renk();
                MessageBox.Show("Tebrikler, tüm sayıları doğru girdiniz. Elin galibi sizsiniz!");


            }

           

            else
            {
                Renk();
                MessageBox.Show("Üzgünüz, tüm sayıları doğru giremediniz. Eli kaybettiniz!");
                
            }
            btnBasla.Enabled = true;
            BtnKontrol.Enabled = false;
            BtnTekrar.Enabled = false;
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label15.Text = sure.ToString();

            if(sure==0)
            {
                timer1.Stop();
                label15.Text = sure.ToString();
                groupBox1.Visible = false;

            }
        }

        private void BtnTekrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            sure = 5;
            timer1.Start();
            BtnTekrar.Enabled = false;
        }
    }
}
