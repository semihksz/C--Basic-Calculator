using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //We are defining our first issue and the transaction we will make in the global field.
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we create a query on the 0 button.
            //If the number written in TextBox1 is 0, we want it to write 0 to the textbox,
            //if not, we want it to write 0 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //we create a query on the 1 button.
            //If the number written in TextBox1 is 0, we want it to write 1 to the textbox,
            //if not, we want it to write 1 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //we create a query on the 2 button.
            //If the number written in TextBox1 is 0, we want it to write 2 to the textbox,
            //if not, we want it to write 2 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //we create a query on the 3 button.
            //If the number written in TextBox1 is 0, we want it to write 3 to the textbox,
            //if not, we want it to write 3 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //we create a query on the 4 button.
            //If the number written in TextBox1 is 0, we want it to write 4 to the textbox,
            //if not, we want it to write 4 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //we create a query on the 5 button.
            //If the number written in TextBox1 is 0, we want it to write 5 to the textbox,
            //if not, we want it to write 5 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //we create a query on the 6 button.
            //If the number written in TextBox1 is 0, we want it to write 6 to the textbox,
            //if not, we want it to write 6 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //we create a query on the 7 button.
            //If the number written in TextBox1 is 0, we want it to write 7 to the textbox,
            //if not, we want it to write 7 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //we create a query on the 8 button.
            //If the number written in TextBox1 is 0, we want it to write 8 to the textbox,
            //if not, we want it to write 8 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //we create a query on the 9 button.
            //If the number written in TextBox1 is 0, we want it to write 9 to the textbox,
            //if not, we want it to write 9 together with the typed number.
            //thus, we can write numbers with more than one digit.
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //in the button where we will do the collection process,
            //we first convert what is written to TextBox1 to the double type and transfer it to the variable we define in the global field.
            //Then we empty the value of TextBox1 and assign a value to our operation variable.
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "+";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //In the button where we will perform the extraction process, 
            //we first convert what is written to TextBox1 to the double type and transfer it to the variable we define in the global field.
            //Then we empty the value of TextBox1 and assign a value to our operation variable.
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //In the button where we will do the multiplication operation,
            //we first convert what is written to TextBox1 to the double type and transfer it to the variable we define in the global field.
            //Then we empty the value of TextBox1 and assign a value to our operation variable.
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //In the button where we will do the splitting operation,
            //we first convert what is written to TextBox1 to the double type and transfer it to the variable we define in the global field.
            //Then we empty the value of TextBox1 and assign a value to our operation variable.
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on the button where we will put a comma, we just throw the typed number and the comma value.
            textBox1.Text = textBox1.Text + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // we define the SecondNumber and the result variable in the calculate button.
            // then we convert the value typed into TextBox1 to the double type and transfer it to the SecondNumber variable we created.
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(textBox1.Text);
            //we create a query about the values we assign to the operations variable and type the operation we want to do with the first number
            //and the SecondNumber and transfer it to the result variable.
            //we convert the result variable to string type and show it in TextBox1.
            //Then we add all the variables to the LISTBOX.
            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                listBox1.Items.Add(FirstNumber + " " + Operation + " " + SecondNumber + " = " + Result);

            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                listBox1.Items.Add(FirstNumber + " " + Operation + " " + SecondNumber + " = " + Result);

            }

            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                listBox1.Items.Add(FirstNumber + " " + Operation + " " + SecondNumber + " = " + Result);

            }

            if (Operation == "/")
            {
                //if the second number entered in the division operation is 0,
                //we write an invalid value, if it is not 0, we do the normal operation.
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Invalid value";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    listBox1.Items.Add(FirstNumber + " " + Operation + " " + SecondNumber + " = " + Result);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //we reset the value of the TEXTBOX on the reset button.
            textBox1.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //we close the application.
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
