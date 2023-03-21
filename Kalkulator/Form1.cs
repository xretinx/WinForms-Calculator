using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }
        char separator = Char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        string entered_number="";
        List<double> numbers = new List<double>();
        List<string> operations = new List<string>();
        bool divide_by_zero = false;
        private void button_Number_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "0" && entered_number == "0")
            {
                foreach (char ch in entered_number)
                {
                    if (ch == '0') return;
                }
            }
            textBox_equation.Text += s;
            entered_number += s;
            if(operations.Count > 0)
            {
                calculate_result();
            }
        }

        private void calculate_result()
        {
            divide_by_zero = false;
            if(entered_number.Length > 0)
            {
                numbers.Add(Double.Parse(entered_number));
            }
            Stack<double> nums = new Stack<double>( new[] { numbers[0] } );
            Stack<string> ops = new Stack<string>();
            for(int i=1; i<numbers.Count; i++)
            {
                if(operations[i-1] == "*" || operations[i-1] == "/")
                {
                    switch (operations[i - 1])
                    {
                        case "*":
                            double num = nums.Pop() * numbers[i];
                            nums.Push(num);
                            break;
                        case "/":
                            if(numbers[i] == 0)
                            {
                                textBox_result.Text = "";
                                divide_by_zero = true;
                                if (entered_number.Length > 0)
                                {
                                    numbers.RemoveAt(numbers.Count - 1);
                                }
                                return;
                            }
                            num = nums.Pop() / numbers[i];
                            nums.Push(num);
                            break;
                    }
                } else
                {
                    if(ops.Count > 0)
                    {
                        switch (ops.Pop())
                        {
                            case "+":
                                double num = nums.Pop();
                                num = nums.Pop() + num;
                                nums.Push(num);
                                break;
                            case "-":
                                num = nums.Pop();
                                num = nums.Pop() - num;
                                nums.Push(num);
                                break;
                        }
                        ops.Push(operations[i - 1]);
                        nums.Push(numbers[i]);
                    } else
                    {
                        ops.Push(operations[i - 1]);
                        nums.Push(numbers[i]);
                    }
                }
                if (i == numbers.Count - 1 && ops.Count > 0)
                {
                    switch (ops.Pop())
                    {
                        case "+":
                            double num = nums.Pop();
                            num = nums.Pop() + num;
                            nums.Push(num);
                            break;
                        case "-":
                            num = nums.Pop();
                            num = nums.Pop() - num;
                            nums.Push(num);
                            break;
                    }
                }
            }
            textBox_result.Text = nums.Pop().ToString();
            if(entered_number.Length > 0)
            {
                numbers.RemoveAt(numbers.Count - 1);
            }
            
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(entered_number, out double new_num))
            {
                textBox_equation.Text += " + ";
                entered_number = "";
                textBox_result.Text = "";
                numbers.Add(new_num);
                operations.Add("+");
            } else if(operations.Count > 0)
            {
                textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - 3) + " + ";
                operations.RemoveAt(operations.Count - 1);
                operations.Add("+");
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if(divide_by_zero == true)
            {
                MessageBox.Show("Nie można dzielić przez 0!");
                return;
            }
            if(Double.TryParse(entered_number, out double _) && operations.Count > 0)
            {
                operations.Clear();
                numbers.Clear();
                textBox_history.Text = textBox_equation.Text + " = ";
                textBox_equation.Text = textBox_result.Text;
                textBox_result.Text = "";
                entered_number = textBox_equation.Text;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(entered_number, out double new_num))
            {
                textBox_equation.Text += " - ";
                entered_number = "";
                textBox_result.Text = "";
                numbers.Add(new_num);
                operations.Add("-");
            }
            else if (operations.Count > 0)
            {
                textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - 3) + " - ";
                operations.RemoveAt(operations.Count - 1);
                operations.Add("-");
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(entered_number, out double new_num))
            {
                textBox_equation.Text += " * ";
                entered_number = "";
                textBox_result.Text = "";
                numbers.Add(new_num);
                operations.Add("*");
            }
            else if (operations.Count > 0)
            {
                textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - 3) + " * ";
                operations.RemoveAt(operations.Count - 1);
                operations.Add("*");
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(entered_number, out double new_num))
            {
                textBox_equation.Text += " / ";
                entered_number = "";
                textBox_result.Text = "";
                numbers.Add(new_num);
                operations.Add("/");
            }
            else if (operations.Count > 0)
            {
                textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - 3) + " / ";
                operations.RemoveAt(operations.Count - 1);
                operations.Add("/");
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            entered_number = "";
            numbers.Clear();
            operations.Clear();
            textBox_equation.Text = "";
            textBox_result.Text = "";
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if(entered_number.Length > 0 || numbers.Count > operations.Count)
            {
                if(entered_number.Length == 0)
                {
                    entered_number = numbers.Last().ToString();
                    numbers.RemoveAt(numbers.Count - 1);
                }
                entered_number = entered_number.Remove(entered_number.Length-1);
                textBox_result.Text = "";
                string s = textBox_equation.Text; 
                if(entered_number == "-")
                {
                    entered_number = "";
                    textBox_equation.Text = s.Substring(0, s.Length - 2);
                }
                else if(entered_number.Length > 0 && operations.Count > 0)
                {
                    textBox_equation.Text = s.Substring(0, s.Length - 1);
                    calculate_result();
                } else
                {
                    textBox_equation.Text = s.Substring(0, s.Length - 1);
                }
            } else if(operations.Count > 0)
            {
                operations.RemoveAt(operations.Count - 1);
                string s = textBox_equation.Text;
                textBox_equation.Text = s.Substring(0, s.Length - 3);
                if(operations.Count > 0)
                {
                    calculate_result();
                }
                entered_number = numbers.Last().ToString();
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            foreach (char ch in entered_number)
            {
                if (ch == separator) return;
            }
            if(entered_number == "")
            {
                entered_number += "0" + separator;
                textBox_equation.Text += "0" + separator;
            }else
            {
                entered_number += separator;
                textBox_equation.Text += separator;
            }
            
        }

        private void button_signChange_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(entered_number, out double tmp) && tmp != 0)
            {
                if(tmp > 0)
                {
                    textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - entered_number.Length);
                    entered_number = "-" + entered_number;
                    textBox_equation.Text += entered_number;
                    if(operations.Count > 0)
                    {
                        calculate_result();
                    }

                } else
                {
                    textBox_equation.Text = textBox_equation.Text.Substring(0, textBox_equation.Text.Length - entered_number.Length);
                    entered_number = entered_number.Substring(1);
                    textBox_equation.Text += entered_number;
                    if (operations.Count > 0)
                    {
                        calculate_result();
                    }
                }
                
            }
        }

        private void textBox_equation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_history_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
