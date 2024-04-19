using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public double a=0, b=0;
        public int oper=1;
        bool zn = true;
        bool isoper = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isoper) { textBox1.Text = ""; isoper = false; }
            if(textBox1.Text=="0") textBox1.Text = "";
            Button x=sender as Button;
            textBox1.Text += x.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (zn)
            {
                double.TryParse(textBox1.Text, out a);
                zn = false;
            }
            else double.TryParse(textBox1.Text, out b);
            if (!isoper) calulation();
            Button x=sender as Button;
            if(x.Text=="+") oper = 1;
            if (x.Text == "-") oper = 2;
            if (x.Text == "x") oper = 3;
            if (x.Text == "/") oper = 4;
            isoper = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!isoper)
            {
                double.TryParse(textBox1.Text, out b);
                isoper = true;
                calulation();
            }
            else calulation();
        }
        private void calulation()
        {
            if (oper == 1) a += b;
            else if (oper == 2) a -= b;
            else if (oper == 3) a *= b;
            else if (oper == 4)
            {
                if(b==0)
                {
                    MessageBox.Show("На 0 делить нельзя!!!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }
                a /= b;
            }
            textBox1.Text = a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            a = 0;
            b = 0;
            zn = false;
            oper = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            for(int i=0;i<text.Length;i++)
            {
                if (text[i] == ',') return;
            }    
            textBox1.Text += ',';
        }
    }
}
