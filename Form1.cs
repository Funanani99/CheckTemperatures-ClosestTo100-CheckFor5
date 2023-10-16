using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckTemperatures__ClosestTo100___CheckFor5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Disable other buttons
            button2.Enabled = false;
            button3.Enabled = false;

            int temp1 = int.Parse(txtTemp1.Text);
            int temp2 = int.Parse(txtTemp2.Text);
            bool result = CheckTemperatures(temp1, temp2);
            lblResultTemperatures.Text = "Result: " + result;
        }

        private bool CheckTemperatures(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100;
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = ClosestTo100(num1, num2);
            lblResultClosestTo100.Text = "Result: " + result;
        }

        private int ClosestTo100(int num1, int num2)
        {
            // Disable other buttons
            button1.Enabled = false;

            int diff1 = Math.Abs(100 - num1);
            int diff2 = Math.Abs(100 - num2);

            if (diff1 == diff2)  
                return 0;
            else if (diff1 < diff2)
                return num1;
            else
                return num2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Disable other buttons
            button1.Enabled = false;
            
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            bool result = CheckFor5(num1, num2);
            lblResultCheckFor5.Text = "Result: " + (result ? "True" : "False");
        }

        private bool CheckFor5(int num1, int num2)
        {
            return num1 == 5 || num2 == 5 || num1 + num2 == 5 || Math.Abs(num1 - num2) == 5;
        }
    }
}
