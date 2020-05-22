using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationCurrent="";
        bool opPerformed = false;
        List<String> ans = new List<String>() { "0" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0"|| opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            opPerformed = false;
            resultValue = 0;
            textBox_Result.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox_Result.Text == "0")
            {
                textBox_Result.Text = "0";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length-1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || opPerformed)
            {
                textBox_Result.Clear();
            }
            opPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            opPerformed = false;
            if (!textBox_Result.Text.Contains("."))
            {
                textBox_Result.Text = textBox_Result.Text + ".";
            }
            else
            {
                textBox_Result.Text = ("SYNTAX Error");               
                resultValue = 0;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultValue = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = textBox_Result.Text + button.Text;
            operationCurrent = button.Text;           
            label_op.Text = resultValue + " " + operationCurrent;
            opPerformed = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationCurrent)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    ans.Add(textBox_Result.Text);
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    ans.Add(textBox_Result.Text);
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    ans.Add(textBox_Result.Text);
                    break;
                case "/":
                    if (textBox_Result.Text != "0")
                    {
                        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                        ans.Add(textBox_Result.Text);
                    }
                    else
                    {
                        textBox_Result.Text = ("MATH Error");
                    }
                    break;
                default:
                    break;
            }
        }

        private void click_ans(object sender, EventArgs e)
        {
            textBox_Result.Text = ans.Last();
        }
    }
}
