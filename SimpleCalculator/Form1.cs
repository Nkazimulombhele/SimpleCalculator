using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String op = "";
        Boolean isOp = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void no_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOp))
                textBox.Clear();
            isOp = false;
            Button no = (Button)sender;
            if (no.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + no.Text;
            }
            else
            {

                textBox.Text = textBox.Text + no.Text;
            }

        }

        private void op_click(object sender, EventArgs e)
        {
            Button no = (Button)sender;
            if (result != 0)
            {
                noequal.PerformClick();
                op = no.Text;
                CurrentOperation.Text = result + " " + op;
                isOp = true;
            }
            else
            {

                op = no.Text;
                result = Double.Parse(textBox.Text);
                CurrentOperation.Text = result + " " + op;
                isOp = true;
            }
          
        }

        private void noCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            CurrentOperation.Text = "";

        }

        private void noC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void noequal_Click(object sender, EventArgs e)
        {

            if(textBox.Text == ".")
                textBox.Text = "0";
            switch (op)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            result = Double.Parse(textBox.Text);
            CurrentOperation.Text = "";
        
           
        }
    }
}
