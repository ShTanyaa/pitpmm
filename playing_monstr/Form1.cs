using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using монстр;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace playing_monstr
{
    public partial class Form1 : Form
    {
        Monstr m1 = new Monstr();
        Monstr m2 = new Monstr();
        int klik = 1;
        public Form1()
        {
            InitializeComponent();
            label4.Text= m2.name;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("заполните все поля");
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show(String.Format("Имя {0}\nБроня {1}\nОружие {2}", textBox1.Text, comboBox1.Text,comboBox2.Text),"Info");
                label7.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible=false;
                progressBar3.Visible = true;
                progressBar4.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
            }
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
                if (m1.get_hp() <= 0)
                {
                progressBar4.Value = 0;
                label12.Text = "0";
                MessageBox.Show($"выйграл {m2.name}", "вы проиграли:(");
                }
                else if (m2.get_hp() <= 0)
                {
                progressBar1.Value = 0;
                label9.Text = "0";
                MessageBox.Show("ВЫ ВЫЙГРАЛИ УРА", "ПОБЕДА");
                }
                if (m1.get_pr() < 3)
                {
                    progressBar1.Value= m2.set_hp(m1.get_hp());
                    label9.Text=m2.set_hp(m1.get_hp()).ToString();
                }
                else
                {
                    MessageBox.Show($"{textBox1.Text}  промахнулся");
                    
                }
                m2.DrawMonstr();
                
                if (m2.get_pr() < 3)
                {

                    progressBar4.Value= m1.set_hp(m2.get_hp());
                    label12.Text= m1.set_hp(m2.get_hp()).ToString();

                }
                else
                {
                    MessageBox.Show($"{m2.name}  промахнулся");
                    
                }
               m1.DrawMonstr();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            klik++;
            switch(klik)
            { 
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974519_3.jpg");
                    break;

                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\images.jpg");
                    break;

                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974541_1.jpg");
                    break;

                default:
                    klik = 1;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974519_3.jpg");
                    break;
            }
               

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974519_3.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\Без названия.jpg");
            label9.Text = m2.set_hp().ToString();
            label10.Text=m2.set_dm().ToString();
            label12.Text = m1.set_hp().ToString();
            label13.Text = m1.set_dm().ToString();
            progressBar1.Value = m2.get_hp();
            progressBar2.Value = m2.get_dm();
            progressBar4.Value = m1.get_hp();
            progressBar3.Value = m1.get_dm();

        }

        private void button3_Click(object sender, EventArgs e)
        {
             klik++;
            switch(klik)
            { 
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974519_3.jpg");
                    break;

                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\images.jpg");
                    break;

                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974541_1.jpg");
                    break;

                default:
                    klik = 1;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\325L-11\Desktop\шумкова пр-21\1587974519_3.jpg");
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
