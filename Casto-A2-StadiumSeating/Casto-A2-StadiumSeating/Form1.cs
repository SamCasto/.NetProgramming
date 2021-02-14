using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_A2_StadiumSeating
{
    public partial class Form1 : Form
    {
        const int CLASS_A_VALUE = 15;
        const int CLASS_B_VALUE = 12;
        const int CLASS_C_VALUE = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {
            //try method to catch non int inputs
            try
            { 
            //declare variables
            int classATickets;
            int classBTickets;
            int classCTickets;
            int classATotal;
            int classBTotal;
            int classCTotal;
            int grandTotal;
            //assign the variables to the user input
            classATickets = int.Parse(classATextBox.Text);
            classBTickets = int.Parse(classBTextBox.Text);
            classCTickets = int.Parse(classCTextBox.Text);
            //perform the calculations to get our totals
            classATotal = classATickets * CLASS_A_VALUE;
            classBTotal = classBTickets * CLASS_B_VALUE;
            classCTotal = classCTickets * CLASS_C_VALUE;
            grandTotal = classATotal + classBTotal + classCTotal;
            //convert our totals to strings formatted for currency
            //and display them in the appropriate labels
            classARevenueTotalLabel.Text = classATotal.ToString("c");
            classBRevenueTotalLabel.Text = classBTotal.ToString("c");
            classCRevenueTotalLabel.Text = classCTotal.ToString("c");
            totalRevenueLabel.Text = grandTotal.ToString("c");
            }
            catch
            {
                //display an error message
                MessageBox.Show("Error. Non-int input detected.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the input and output labels
            classARevenueTotalLabel.Text = "";
            classBRevenueTotalLabel.Text = "";
            classCRevenueTotalLabel.Text = "";
            totalRevenueLabel.Text = "";
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }
    }
}
