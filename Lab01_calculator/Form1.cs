namespace Lab01_calculator
{
    public partial class Form1 : Form
    {
        double input1 = 0.00;
        string operation = "";
        double input2 = 0.00;
        double result = 0.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "1";
                textdisplay1.Clear();
            }
            else
                input.Text += "1";
                textdisplay1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "2";
                textdisplay1.Clear();
            }
            else
                input.Text += "2";
                textdisplay1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "3";
                textdisplay1.Clear();
            }
            else
                input.Text += "3";
                textdisplay1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "4";
                textdisplay1.Clear();
            }
            else
                input.Text += "4";
                textdisplay1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "5";
                textdisplay1.Clear();
            }
            else
                input.Text += "5";
                textdisplay1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "6";
                textdisplay1.Clear();
            }
            else
                input.Text += "6";
                textdisplay1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "7";
                textdisplay1.Clear();
            }
            else
                input.Text += "7";
                textdisplay1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "8";
                textdisplay1.Clear();
            }
            else
                input.Text += "8";
                textdisplay1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "9";
                textdisplay1.Clear();
            }
            else
                input.Text += "9";
                textdisplay1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "0";
                textdisplay1.Clear();
            }
            else
                input.Text += "0";
                textdisplay1.Clear();
        }





        private void plus_Click(object sender, EventArgs e)
        {
            //บวก
            this.input1 = Double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "+";
            textdisplay1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            //ลบ
            this.input1 = Double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "-";
            textdisplay1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            //คูณ
            this.input1 = Double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "*";
            textdisplay1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            //หาร
            this.input1 = Double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "/";
            textdisplay1.Clear();
        }

        private void answer_Click(object sender, EventArgs e)
        {
            input2 = Double.Parse(this.input.Text);            
            if (this.operation == "+")           
            {
                result = input1 + input2;
                input.Text = result.ToString("#,###.#####");
                textdisplay1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
                input.Text = result.ToString("#,###.#####");
                textdisplay1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            if (this.operation == "*")
            {
                result = input1 * input2;
                input.Text = result.ToString("#,###.#####");
                textdisplay1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            if (this.operation == "/")
            {
                result = input1 / input2;
                input.Text = result.ToString("#,###.#####");
                textdisplay1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }

            result = double.Parse(this.input.Text);
            operation = String.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Clear();
            if (input.Text == String.Empty)
            {
                textdisplay1.Text = "Clear!";
                input.Text = "0";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            }
            if (input.Text == "")
            {
                input.Text = "0";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!input.Text.Contains("."))
            {
                input.Text += ".";
                textdisplay1.Clear();
            };
        }
    }
}