using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        string Totale;
        int N1;
        int N2;
        string Option;
        int resultat;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Btn_Num0_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num0.Text;
        }
        
        private void Btn_Num1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num1.Text;
        }

        private void Btn_Num2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num2.Text;
        }

        private void Btn_Num3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num3.Text;
        }

        private void Btn_Num4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num4.Text;
        }

        private void Btn_Num5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num5.Text;
        }
        private void Btn_Num6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num6.Text;
        }
        private void Btn_Num7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num7.Text;
        }
        private void Btn_Num8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num8.Text;
        }
        private void Btn_Num9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Num9.Text;
        }
        private void Btn_Addition_Click(object sender, EventArgs e)
        {
            Option = "+";
            N1 = int.Parse(TxtDisplay.Text);
            TxtDisplay.Clear();
        }

        private void Btn_Sustraction_Click(object sender, EventArgs e)
        {
            Option = "-";
            N1 = int.Parse(TxtDisplay.Text);
            TxtDisplay.Clear();
        }
        private void Btn_Multiplication_Click(object sender, EventArgs e)
        {
            Option = "x";
            N1 = int.Parse(TxtDisplay.Text);
            TxtDisplay.Clear();
        }
        private void Btn_Division_Click(object sender, EventArgs e)
        {
            Option = "÷";
            N1 = int.Parse(TxtDisplay.Text);
           
            TxtDisplay.Clear();
        }
        private void Btn_Egale_Click(object sender, EventArgs e)
        {
           
            N2 = int.Parse(TxtDisplay.Text);

            if (Option.Equals("+"))
                resultat = N1 + N2;

            if(Option.Equals("-"))
                resultat = N1 - N2;

            if (Option.Equals("x"))
                resultat = N1 * N2;

            if (Option.Equals("÷"))
                resultat = N1 / N2;

            TxtDisplay.Text = "= " + resultat;

        }

        private void Btn_Vergule_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Btn_Vergule.Text;
        }

        private void Btn_Plus_Sub_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Modulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            resultat = 0;
            N1 = 0;
            N2 = 0;

        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
