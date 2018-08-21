![hesapla](https://user-images.githubusercontent.com/29266933/44431965-c4d23780-a5a8-11e8-8afe-f195dee1203f.gif)

# -----------------> Calculate Class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Hesapla
    {
        public Form1 frm1;

        public int topla(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger + gelendeger2;
            return sonuc;
        }
        public int cikar(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger - gelendeger2;
            return sonuc;
        }
        public int carp(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger * gelendeger2;
            return sonuc;
        }
        public int bol(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger / gelendeger2;
            return sonuc;
        }
    }
}

# -----------------> Form1 Class 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Hesapla hesapla;

        public Form1()
        {
            InitializeComponent();
            hesapla = new Hesapla(); hesapla.frm1 = this;
        }

        public int ilkdeger;

        public void temizle()
        {
            textBox2.Clear();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        textBox1.Clear();
                        label1.Text = textBox2.Text;
                        ilkdeger = Convert.ToInt32(label1.Text);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                textBox2.Focus();
            }
            else if (label1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        int sonuc = hesapla.topla(Convert.ToInt32(textBox2.Text));
                        textBox1.Text = sonuc.ToString();
                        ilkdeger = 0;
                        label1.Text = "";
                        textBox2.Clear();
                        textBox2.Focus(
                            );
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        textBox1.Clear();
                        label1.Text = textBox2.Text;
                        ilkdeger = Convert.ToInt32(label1.Text);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                textBox2.Focus();
            }
            else if (label1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        int sonuc = hesapla.carp(Convert.ToInt32(textBox2.Text));
                        textBox1.Text = sonuc.ToString();
                        ilkdeger = 0;
                        label1.Text = "";
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        textBox1.Clear();
                        label1.Text = textBox2.Text;
                        ilkdeger = Convert.ToInt32(label1.Text);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                textBox2.Focus();
            }
            else if (label1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        int sonuc = hesapla.cikar(Convert.ToInt32(textBox2.Text));
                        textBox1.Text = sonuc.ToString();
                        ilkdeger = 0;
                        label1.Text = "";
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        textBox1.Clear();
                        label1.Text = textBox2.Text;
                        ilkdeger = Convert.ToInt32(label1.Text);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                textBox2.Focus();
            }
            else if (label1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text != "0")
                    {
                        int sonuc = hesapla.bol(Convert.ToInt32(textBox2.Text));
                        textBox1.Text = sonuc.ToString();
                        ilkdeger = 0;
                        label1.Text = "";
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
        }
    }
}
