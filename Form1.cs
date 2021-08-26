using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bit3rdSemester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation = "";
        decimal old_value = 0;
        private void Button_one_Click(object sender, EventArgs e)
        {
            setValue("1");
        }

        private void setValue(string data)
        {
            if (textBox_result.Text == "+" || textBox_result.Text == "-" || textBox_result.Text == "*" || textBox_result.Text == "/")
            {
                textBox_result.Text = "";
            }
            string number = data;
            textBox_result.Text = textBox_result.Text + number;
        }

        private void Button_two_Click(object sender, EventArgs e)
        {
            setValue("2");
        }

        private void Button_three_Click(object sender, EventArgs e)
        {
            setValue("3");
        }

        private void Button_four_Click(object sender, EventArgs e)
        {
            setValue("4");
        }

        private void Button_five_Click(object sender, EventArgs e)
        {
            setValue("5");
        }

        private void Button_six_Click(object sender, EventArgs e)
        {
            setValue("6");
        }

        private void Button_seven_Click(object sender, EventArgs e)
        {
            setValue("7");
        }

        private void Button_eight_Click(object sender, EventArgs e)
        {
            setValue("8");
        }

        private void Button_nine_Click(object sender, EventArgs e)
        {
            setValue("9");
        }

        private void Button_zero_Click(object sender, EventArgs e)
        {
            setValue("0");
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            string current_val = textBox_result.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "+";
            textBox_result.Text = oper;
            operation = oper;
        }

        private void Button_sub_Click(object sender, EventArgs e)
        {
            string current_val = textBox_result.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "-";
            textBox_result.Text = oper;
            operation = oper;
        }

        private void Button_mul_Click(object sender, EventArgs e)
        {
            string current_val = textBox_result.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "*";
            textBox_result.Text = oper;
            operation = oper;
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            string current_val = textBox_result.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "/";
            textBox_result.Text = oper;
            operation = oper;
        }

        private void Button_equalto_Click(object sender, EventArgs e)
        {
            string new_val = textBox_result.Text;
            decimal new_value = Convert.ToDecimal(new_val);

            switch(operation)
            {
                case "+":
                    decimal added_value = old_value + new_value;
                    old_value = added_value;
                    textBox_result.Text = added_value.ToString();
                    break;
                case "-":
                    decimal subtracted_value = old_value - new_value;
                    old_value = subtracted_value;
                    textBox_result.Text = subtracted_value.ToString();
                    break;
                case "*":
                    decimal multiplied_value = old_value * new_value;
                    old_value = multiplied_value;
                    textBox_result.Text = multiplied_value.ToString();
                    break;
                case "/":
                    if(new_value==0)
                    {
                        MessageBox.Show("cannot divide by zero");
                    }
                    else
                    {
                        decimal divided_value = old_value / new_value;
                        old_value = divided_value;
                        textBox_result.Text = divided_value.ToString();

                    }
                    break;
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            old_value = 0;
            textBox_result.Text = "";
            operation = "";
        }

        private void Button_squarerrot_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(textBox_result.Text);
            sq = Math.Sqrt(sq);
            textBox_result.Text = System.Convert.ToString(sq);
        }

        private void Button_square_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox_result.Text) * Convert.ToDouble(textBox_result.Text);
            textBox_result.Text = System.Convert.ToString(a);
        }
    }
}
