using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika13_var5
{
    public partial class Form1 : Form
    {
        Car c1 = new Car();
        public Form1()
        {
            InitializeComponent();
        }
        class Car
        {
            public double v;
            public double kol_benz;
            public double rashod_benz;
            public double probeg;
            

            public string GetInfo()
            {
                return ($"объем бака: {v}\nкол-во бензина в баке: {kol_benz}\nрасход бензина на 100км: {rashod_benz}\nпробег: {probeg}");
            }
            public double V
            {
                get{return v;}
                set{v = value; }
            }

            public double Kol_benz
            {
                get { return kol_benz; }
                set { kol_benz = value; }
            }

            public double Rashod_benz
            {
                get { return rashod_benz; }
                set { rashod_benz = value; }
            }

            public double Probeg
            {
                get { return probeg; }
                set { probeg = value; }
            }
            public double Zapravka()
            {
                  double benz = v - kol_benz;
                kol_benz = kol_benz + benz;
                  return  kol_benz;
               
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.v=(int)numericUpDown1.Value;
            c1.kol_benz= (int)numericUpDown2.Value;
            c1.rashod_benz = (int)numericUpDown3.Value;
            c1.probeg = (int)numericUpDown4.Value;
            MessageBox.Show(String.Format("объем бака{0}\nкол-во бензина в баке {1}\nрасход {2}\nпробег {3}\nбак после заправки {4}", c1.v, c1.kol_benz,c1.rashod_benz,c1.probeg,c1.Zapravka()), "info");
        }
    }
}
