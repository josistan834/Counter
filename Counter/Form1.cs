using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            int num1, num2;
            try
            {
                outputBox.Text = "";
                num1 = Convert.ToInt16(startInput.Text);
                num2 = Convert.ToInt16(endInput.Text);
                for (int i = num1;  i<=num2; i++)
                {
                    outputBox.Text += $"{i}, ";
                }

            }
            catch
            {
                outputBox.Text = "Please enter a valid input (Whole Numbers ONLY)";
            }
        }
    }
}
