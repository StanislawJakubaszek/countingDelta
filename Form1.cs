using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_projekt
{
    public partial class Form : System.Windows.Forms.Form
    {
        string LiczbaA = "A";
        string LiczbaB = "B";
        string LiczbaC = "C";
        char A = 'N';
        char B = 'N';
        char C = 'N';
        public Form()
        {
            InitializeComponent();
            textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
            textBox1.Text += "*" + LiczbaC;
            textBox1.Text += " = ";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            if (LiczbaA != "A" && LiczbaB != "B" && LiczbaC != "C")
            {
                textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
                textBox1.Text += "*" + LiczbaC;
                textBox1.Text += " = ";
                textBox1.Text += int.Parse(LiczbaB)*int.Parse(LiczbaB) - 4*int.Parse(LiczbaA)*int.Parse(LiczbaC);
            }
            else
            {
                textBox2.Text = "Proszę podać wszystkie dane!!!!!!!!!";
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Oblicz(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oblicz(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oblicz(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oblicz(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Oblicz(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Oblicz(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Oblicz(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Oblicz(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Oblicz(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oblicz(1);
        }

        private void Oblicz(int liczba)
        {
            textBox2.Text = " ";
            if (A == 'Y' && B!='Y' && C!='Y')
            {
                if(LiczbaA=="A")
                {
                    LiczbaA = null;
                }
                LiczbaA += liczba;
                textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
                textBox1.Text += "*" + LiczbaC;
                textBox1.Text += " = ";
            }
            else if (B == 'Y' && A != 'Y' && C != 'Y')
            {
                if (LiczbaB == "B")
                {
                    LiczbaB = null;
                }
                LiczbaB += liczba;
                textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
                textBox1.Text += "*" + LiczbaC;
                textBox1.Text += " = ";
            }
            else if (C == 'Y' && B != 'Y' && A != 'Y')
            {
                if (LiczbaC == "C")
                {
                    LiczbaC = null;
                }
                LiczbaC += liczba;
                textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
                textBox1.Text += "*" + LiczbaC;
                textBox1.Text += " = ";
            }
            else
            {
                textBox2.Text = "Proszę zaznaczyć tylko jedno pole z danymi: A, B lub C!!!!!!!!!!";
            }
        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            if (B == 'N')
            {
                B = 'Y'; 
            }
            else {
                    B = 'N'; 
                 }
        }

        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {
            if (A == 'N')
            {
                A = 'Y';
            }
            else
            {
                A = 'N';
            }
        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if (C == 'N')
            {
                C = 'Y';
            }
            else
            {
                C = 'N';
            }
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            LiczbaA = "A";
            LiczbaB = "B";
            LiczbaC = "C";
            textBox1.Text = LiczbaB + "^2 - 4*" + LiczbaA;
            textBox1.Text += "*" + LiczbaC;
            textBox1.Text += " = ";
            textBox2.Text = "Dane wyczyszczono";
        }

    }
}
