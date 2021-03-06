﻿using System;
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
