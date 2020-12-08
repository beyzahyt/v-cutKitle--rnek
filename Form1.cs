using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vücutKitle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            if (boy > 3)
            {
                boy = boy / 100;
            }
            vki = kilo / (boy * boy);
            
            label3.Text = vki.ToString();

            if (vki<18)
            {
                label4.Text = "zayıf";
            }
            else if(vki >=18 && vki < 25)
            {
                label4.Text = "normal";
            }
            else if(vki >=25 && vki < 30)
            {
                label4.Text = "şişman";
            }
            else if(vki >=30 && vki <35)
            {
                label4.Text = "çok şişman";
            }
            else
            {
                label4.Text = "çok çok şişman";
            }

        }

        
    }
}
