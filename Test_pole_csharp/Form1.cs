using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_pole_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int jaky_znak = 0;
                Random rnd_znak = new Random();
                if (radioButton_kratke.Checked == true)
                {
                    char[] pole = new char[8];
                    if (checkBox_cisla.Checked == true && checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 8; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_cisla.Checked == true)
                    {
                        for (int i = 0; i <= 8; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 8; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                }
                if (radioButton_stredni.Checked == true)
                {
                    char[] pole = new char[12];
                    if (checkBox_cisla.Checked == true && checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 12; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_cisla.Checked == true)
                    {
                        for (int i = 0; i <= 12; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 12; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                }
                if (radioButton_dlouhe.Checked == true)
                {
                    char[] pole = new char[16];
                    if (checkBox_cisla.Checked == true && checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 16; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_cisla.Checked == true)
                    {
                        for (int i = 0; i <= 16; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 2)
                            {
                                int znak = rnd_znak.Next(48, 58);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                    if (checkBox_znaky.Checked == true)
                    {
                        for (int i = 0; i <= 16; i++)
                        {
                            jaky_znak = rnd_znak.Next(1, 4);
                            if (jaky_znak == 1)
                            {
                                int znak = rnd_znak.Next(65, 123);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                            if (jaky_znak == 3)
                            {
                                int znak = rnd_znak.Next(33, 48);
                                pole[i] = Convert.ToChar(znak);
                                label_heslo.Text = new string(pole);
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Zadej prosím číslo!!"); }
        }
    }
}
