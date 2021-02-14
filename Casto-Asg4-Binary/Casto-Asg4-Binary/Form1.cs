using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg4_Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxBinary1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int sumOfBits = 0;
            String hexValue = "";
            labelDecimalResult.Text = "(Label Results Decimal)";
            labelHexadecimalResult.Text = "(Label Results Hexadecimal)";

            //addition of checked boxes for our decimal number

            if (checkBoxBinary1.Checked)
                sumOfBits = sumOfBits + 1;

            if (checkBoxBinary2.Checked)
                sumOfBits = sumOfBits + 2;

            if (checkBoxBinary3.Checked)
                sumOfBits = sumOfBits + 4;

            if (checkBoxBinary4.Checked)
                sumOfBits = sumOfBits + 8;

            if (checkBoxBinary5.Checked)
                sumOfBits = sumOfBits + 16;

            if (checkBoxBinary6.Checked)
                sumOfBits = sumOfBits + 32;

            if (checkBoxBinary7.Checked)
                sumOfBits = sumOfBits + 64;

            if (checkBoxBinary8.Checked)
                sumOfBits = sumOfBits + 128;

            //converting bits to hexadecimal
            hexValue = sumOfBits.ToString("X");
            
            //if statements to determine which radio button is selected

            if (radioButtonDecimal.Checked)
            {
                labelDecimalResult.Text = sumOfBits.ToString();
                labelHexadecimalResult.Text = "";
            }
            else if (radioButtonHexadecimal.Checked)
            {
                labelHexadecimalResult.Text = hexValue;
                labelDecimalResult.Text = "";
            }
            else if (radioButtonDecAndHex.Checked)
            {
                labelDecimalResult.Text = sumOfBits.ToString();
                labelHexadecimalResult.Text = hexValue;
            }
            else
            {
                MessageBox.Show("Please select a conversion type");
            }
            



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            int sumOfBits = 0;
            String hexValue = "";
            labelDecimalResult.Text = "";
            labelHexadecimalResult.Text = "";
        }

        private void listBoxTestValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedTestValueAsString = "";

            //checking to make sure something is selected in the list box
            if (listBoxTestValues.SelectedIndex > -1)
            {
                //getting the text of what was selected 
                selectedTestValueAsString = listBoxTestValues.SelectedItem.ToString();

                //clearing the binary check boxes so only what is selected will be checked
                checkBoxBinary1.Checked = false;
                checkBoxBinary2.Checked = false;
                checkBoxBinary3.Checked = false;
                checkBoxBinary4.Checked = false;
                checkBoxBinary5.Checked = false;
                checkBoxBinary6.Checked = false;
                checkBoxBinary7.Checked = false;
                checkBoxBinary8.Checked = false;

                //switch statement to switch to the correct binary check box
                //based off what was selected in the list box
                switch (selectedTestValueAsString)
                {
                    case "1":
                        checkBoxBinary1.Checked = true;
                        break;

                    case "2":
                        checkBoxBinary2.Checked = true;
                        break;


                    case "4":
                        checkBoxBinary3.Checked = true;
                        break;

                    case "8":
                        checkBoxBinary4.Checked = true;
                        break;

                    case "16":
                        checkBoxBinary5.Checked = true;
                        break;

                    case "32":
                        checkBoxBinary6.Checked = true;
                        break;
                    case "64":
                        checkBoxBinary7.Checked = true;
                        break;

                    case "128":
                        checkBoxBinary8.Checked = true;
                        break;

                    case "255":
                        checkBoxBinary1.Checked = true;
                        checkBoxBinary2.Checked = true;
                        checkBoxBinary3.Checked = true;
                        checkBoxBinary4.Checked = true;
                        checkBoxBinary5.Checked = true;
                        checkBoxBinary6.Checked = true;
                        checkBoxBinary7.Checked = true;
                        checkBoxBinary8.Checked = true;
                        break;




                }//end of switch
            }
        }
    }
}
