using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCalculator
{
    public partial class Form3 : Form
    {

        double resultValue = 0;
        string oprationPerformed = "";
        bool isOprationPerformed = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || isOprationPerformed)
            {
                textBox_Result.Clear();
            }
            isOprationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {

                if (!textBox_Result.Text.Contains(","))
                {
                    textBox_Result.Text += button.Text;

                }


            }
            else
            {

                textBox_Result.Text += button.Text;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonEcual_Click(object sender, EventArgs e)
        {
            switch (oprationPerformed) 
            {
                case "x²":
                    textBox_Result.Text = (Math.Pow(double.Parse(textBox_Result.Text), 2)).ToString();
                    break;
                case "√x":
                    textBox_Result.Text = (Math.Sqrt(double.Parse(textBox_Result.Text))).ToString();
                    break;
                case "x^y":
                    textBox_Result.Text = Math.Pow(resultValue, double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "logx":
                    textBox_Result.Text = Math.Log10(double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;




            }
            resultValue = double.Parse(textBox_Result.Text);
            labelCurrent_Operation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEcual.PerformClick();
                oprationPerformed = button.Text;
                labelCurrent_Operation.Text = resultValue + " " + oprationPerformed;
                isOprationPerformed = true;
            }
            else
            {
                oprationPerformed = button.Text;
                resultValue = double.Parse(textBox_Result.Text);
                labelCurrent_Operation.Text = resultValue + " " + oprationPerformed;
                isOprationPerformed = true;
            }
        }
    }
}
