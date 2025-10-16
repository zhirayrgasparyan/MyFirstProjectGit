namespace WinFormsAppCalculator
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string oprationPerformed = "";
        bool isOprationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString(); break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString(); break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString(); break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString(); break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox_Result.Text);
            labelCurrent_Operation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
              
        }
    }
}
