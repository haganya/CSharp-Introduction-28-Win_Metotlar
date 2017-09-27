using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170812_2Win_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue;
            numericUpDown1.Minimum = 0;
        }

        // bir ismi birden fazla metot paylaşıyorsa buna metot overload denir. Aynı metotun farklı çalışma şekillerini ifade eder.
        //metota girilen parametrelerin türü veya sayısı değişirse metot değişmiş olur. değişmişse overload edilmiş olur.

        decimal KDV(decimal para)
        {
            return para * 0.18m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sonuc = KDV(numericUpDown1.Value);
            //MessageBox.Show(sonuc.ToString());

            double d = Topla(Carp(Bol(4, 2), Cikar(5, 2)), Topla(Cikar(6, 4), Carp(2, 3)));
            //MessageBox.Show(d.ToString());

            double sonuc2 = Topla("4", "5");
        }

       
        double Topla(int s1, int s2)
        {
            return (double)s1 + (double)s2;
        }

        double Topla(double s1, double s2)
        {
            return s1 + s2;
        }
        
        //3 tane double alan Toplam metot overloadı yazınız.
        double Topla(double s1, double s2, double s3)
        {
            return s1 + s2 + s3;
        }
        //2 tane string alan Toplam metot overloadı yazınız
        double Topla(string s1 , string s2)
        {
            return int.Parse(s1) + int.Parse(s2);
        }


        double Cikar(double a, double b)
        {
            return a - b;
        }
        double Carp(double c, double d)
        {
            return c * d;
        }
        double Bol(double e, double f)
        {
            if (f == 0)
            {
                return 0;
            }
            else
            {
                return e / f;
            }
        }

        
    }
}
