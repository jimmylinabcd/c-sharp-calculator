using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        bool equal_pressed = false;

        private void resized(object sender, EventArgs e)
        {
            autosize();
        }

        private void win_load(object sender, EventArgs e)
        {
            autosize();
        }

        private void autosize()
        {
            int winheight = this.Height;
            //NOTE winwidth has -10
            int winwidth = this.Width - 10;
            display.Width = winwidth - 7;           
            toptext.Left = winwidth - 7 - toptext.Width;
            display.Font = new Font(display.Font.FontFamily, winheight * 0.061f);
            toptext.Font = new Font(toptext.Font.FontFamily, winheight * 0.031f);
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                int height = this.Height;
                btn.Font = new Font(btn.Font.FontFamily, height * 0.03f);
            }

            clear.Top = display.Top + display.Height;
            delete.Top = display.Top + display.Height;
            percent.Top = display.Top + display.Height;
            divide.Top = display.Top + display.Height;                
    
            int topp = clear.Top;
            //height
            // column 1
            clear.Height = winheight / 5 - 32;
            num7.Height = winheight / 5 - 30;
            num7.Top = clear.Height + topp;
            num4.Height = winheight / 5 - 30;
            num4.Top = num7.Top + num7.Height;
            num3.Height = winheight / 5 - 30;
            num3.Top = num4.Top + num3.Height;
            num0.Height = winheight / 5 - 30;
            num0.Top = num3.Top + num0.Height;
            // column 2
            delete.Height = winheight / 5 - 32;
            num8.Height = winheight / 5 - 30;
            num8.Top = delete.Height + topp;
            num5.Height = winheight / 5 - 30;
            num5.Top = num8.Top + num5.Height;
            num2.Height = winheight / 5 - 30;
            num2.Top = num5.Top + num2.Height;
            point.Height = winheight / 5 - 30;
            point.Top = num2.Top + point.Height;
            // column 3
            percent.Height = winheight / 5 - 32;
            num9.Height = winheight / 5 - 30;
            num9.Top = percent.Height + topp;
            num6.Height = winheight / 5 - 30;
            num6.Top = num9.Top + num6.Height;
            num1.Height = winheight / 5 - 30;
            num1.Top = num6.Top + num1.Height;
            // column 4
            divide.Height = winheight / 5 - 32;
            multiply.Height = winheight / 5 - 30;
            multiply.Top = divide.Height + topp;
            minus.Height = winheight / 5 - 30;
            minus.Top = multiply.Top + minus.Height;
            plus.Height = winheight / 5 - 30;
            plus.Top = minus.Top + plus.Height;
            equals.Height = winheight / 5 - 30;
            equals.Top = plus.Top + equals.Height;
            //width
            // row 1
            clear.Width = winwidth / 4;
            delete.Left = clear.Width;
            delete.Width = winwidth / 4;
            percent.Left = delete.Width + delete.Left;
            percent.Width = winwidth / 4;
            divide.Left = percent.Width + percent.Left;
            divide.Width = winwidth / 4;
            // row 2
            num7.Width = winwidth / 4;
            num8.Left = num7.Width;
            num8.Width = winwidth / 4;
            num9.Left = num8.Width + num8.Left;
            num9.Width = winwidth / 4;
            multiply.Left = num9.Width + num9.Left;
            multiply.Width = winwidth / 4;
            // row 3
            num4.Width = winwidth / 4;
            num5.Left = num4.Width;
            num5.Width = winwidth / 4;
            num6.Left = num5.Width + num5.Left;
            num6.Width = winwidth / 4;
            minus.Left = num6.Width + num6.Left;
            minus.Width = winwidth / 4;
            // row 4
            num3.Width = winwidth / 4;
            num2.Left = num3.Width;
            num2.Width = winwidth / 4;
            num1.Left = num2.Width + num2.Left;
            num1.Width = winwidth / 4;
            plus.Left = num1.Width + num1.Left;
            plus.Width = winwidth / 4;
            // row 5
            num0.Width = winwidth / 4;
            point.Left = num0.Width;
            point.Width = winwidth / 4;
            equals.Left = point.Width + point.Left;
            equals.Width = winwidth / 2;
        }
        private void Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            display.Text = (string)row["expression"];
            row.Delete();
        }

        private void button_press(string input)
        {

            string text = display.Text;
            if (equal_pressed == true)
            {
                int n;
                bool isnum = int.TryParse(input, out n);
                if (isnum == true)
                {
                    string oldans = display.Text;
                    display.Text = input;
                    toptext.Text = oldans;

                }
                else
                {
                    if (text == "0")
                    {
                        display.Text = input;
                    }
                    else
                    {
                        display.AppendText(input);
                    }
                }
            }
            else
            {
                if (text == "0")
                {
                    if (input == ".")
                    {
                        display.AppendText(".");
                    }
                    else 
                    {
                        display.Text = input;
                    }
                    
                }
                else if (input == "-")
                {
                    if (text == "0")
                    {
                        display.Text = "-";
                    }
                    else
                    {
                        display.AppendText("-");
                    }
                }
                else
                {
                    display.AppendText(input);
                }
            }

            equal_pressed = false;
            display.Focus();
        }

        private void calculate()
        {
            try
            {
                string calculate = display.Text;
                toptext.Text = calculate;
                calculate = calculate.Replace("×", "*").Replace("÷", "/");
                Evaluate(calculate);
            }
            catch
            {
                display.Text = "ERROR";
                toptext.Text = "ERROR";
            }
            equal_pressed = true;
        }

        private void nofocus(object sender, EventArgs e)
        {
            display.Select();
        }

        private void keypressed(object sender, KeyPressEventArgs e)
        {
            string code = "1234567890*×/÷+-()%.";
            if (e.KeyChar == '=')
            {
                calculate();
            }
            else if (e.KeyChar == (char)Keys.Return)
            {
                calculate();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                string text = display.Text;

                if (text.Length > 1)
                {
                    text = text.Substring(0, text.Length - 1);
                }
                else
                {
                    text = "0";
                }

                display.Text = text;
            }
            else
            {
                foreach (char c in code)
                {
                    if (e.KeyChar == c)
                    {
                        if (c == '*')
                        {
                            button_press("×");
                        }
                        else if (c == '/')
                        {
                            button_press("÷");
                        }
                        else
                        {
                            button_press(Char.ToString(c));
                        }

                    }
                }
            }
        }

        //buttons
        private void delete_Click(object sender, EventArgs e)
        {
            string text = display.Text;

            if (text.Length > 1)
            {
                text = text.Substring(0, text.Length - 1);
            }
            else
            {
                text = "0";
            }

            display.Text = text;
        }

        private void allclear_Click(object sender, EventArgs e)
        {
            if (equal_pressed == true)
            {
                toptext.Text = display.Text;
            }
            display.Text = "0";
        }
        private void percent_Click(object sender, EventArgs e)
        {
            button_press("%");
        }

        private void point_Click(object sender, EventArgs e)
        {
            button_press(".");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            button_press("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            button_press("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            button_press("×");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            button_press("÷");
        }

        private void equals_Click(object sender, EventArgs e)
        {
            calculate();
        }

        // number buttons

        private void num0_Click(object sender, EventArgs e)
        {
            button_press("0");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            button_press("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            button_press("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            button_press("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            button_press("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            button_press("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            button_press("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            button_press("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            button_press("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            button_press("9");
        }
        
        private void keydown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyData.ToString());
            switch (e.KeyData.ToString())
            {
                case "D1":
                    num1.BackColor = SystemColors.ButtonHighlight;
                    break;
            }
        }
    }
}