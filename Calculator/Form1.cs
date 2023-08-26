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
    public partial class Form1 : Form
    {
        string Operation; // math operation + - * /
        string Number1;
        bool Number2 = false; //check number input
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e) // for number buttons
        {
            if (Number2)
            {
                Number2 = false;
                textBox1.Text = "";
            }
        Button button = (Button)sender;
            if(textBox1.Text == "0") textBox1.Text = button.Text;
            else textBox1.Text = textBox1.Text + button.Text;
        }

        private void button2_Click(object sender, EventArgs e) // for delete button
        {
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e) // for math operation buttons
        {
            Button button = (Button)sender;
            Operation = button.Text;
            Number1 = textBox1.Text;
            Number2 = true;
        }

        private void button24_Click(object sender, EventArgs e)  // for =
        {
            double double1, double2, result;
            result = 0;
            double1 = Convert.ToDouble(Number1);
            double2 = Convert.ToDouble(textBox1.Text);
            switch (Operation)
            {
                case "+":
                    result = double1 + double2;
                    break;
                case "-":
                    result = double1 - double2;
                    break;
                case "*":
                    result = double1 * double2;
                    break;
                case "/":
                    result = double1 / double2;
                    break;
                case "%":
                    result= double1 * double2 / 100;
                    break;
            }
            Operation = "=";
            Number2= true;
            textBox1.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e) // for √x
        {
            double db, res;
            db = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(db);
            textBox1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e) // for x^2
        {
            double db, res;
            db = Convert.ToDouble(textBox1.Text);
            res = db* db;
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e) // for 1/x
        {
            double db, res;
            db = Convert.ToDouble(textBox1.Text);
            res = 1/db;
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e) // for +/-
        {
            double db, res;
            db = Convert.ToDouble(textBox1.Text);
            res = -db;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e) // for ,
        {
            if(!textBox1.Text.Contains(",")) textBox1.Text = textBox1.Text + ",";
            
        }

        private void button4_Click(object sender, EventArgs e) // for <-
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
            if (textBox1.Text == "") textBox1.Text = "0";
        }
    }
}
