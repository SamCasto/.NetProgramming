using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg6_JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //method to calculate oil lube charges
        private double calculateOilLubeCharges(double charges)
        {
            //checking which check boxes are checked and 
            //adding the appropraite total to charges
            if (checkBoxOilChange.Checked)
                charges = charges + 26;
            if (checkBoxLubeJob.Checked)
                charges = charges + 18;

            return charges;
        }
        //not going to use this each time but here come
        //the rest of the methods to calculate charges
        private double calculateFlushCharges(double charges)
        {
            if (checkBoxRadiatorFlush.Checked)
                charges = charges + 30;
            if (checkBoxTransmissionFlush.Checked)
                charges = charges + 80;
            return charges;
        }
        private double calculateMiscCharges(double charges)
        {
            if (checkBoxInspection.Checked)
                charges = charges + 15;
            if (checkBoxReplaceMuffler.Checked)
                charges = charges + 100;
            if (checkBoxTireRotation.Checked)
                charges = charges + 20;
            return charges;
        }
        private double calculateLaborCharges(double charges)
        {
            charges = charges * 50;
            
            return charges;
        }
        private double calculatePartsCharges(double charges)
        {
            //this works but it feels too simple to be correct
            return charges;
        }
        private double calculateTaxCharges(double chargeableAmount)
        {
            double salesTax = 0;
            salesTax = chargeableAmount * 1.055 - chargeableAmount;
            return salesTax;
        }
        private double calculateTotalCharges(double miscCharges, double flushCharges,
            double oilAndLubeCharges, double taxCharges, double laborCharges,
            double partsCharges)
        {
            double totalCharges = 0;
            totalCharges = miscCharges + flushCharges + oilAndLubeCharges +
                taxCharges + laborCharges + partsCharges;
            return totalCharges;
        }
        private double calculateServiceAndLaborCharges(double miscCharges, double flushCharges,
            double oilAndLubeCharges, double laborCharges)
        {
            double serviceAndLaborCharges = 0;
            serviceAndLaborCharges = miscCharges + flushCharges + oilAndLubeCharges
                + laborCharges;
            return serviceAndLaborCharges;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to clear check boxes
        private void clearCheckBoxes()
        {
            checkBoxInspection.Checked = false;
            checkBoxLubeJob.Checked = false;
            checkBoxOilChange.Checked = false;
            checkBoxRadiatorFlush.Checked = false;
            checkBoxReplaceMuffler.Checked = false;
            checkBoxTireRotation.Checked = false;
            checkBoxTransmissionFlush.Checked = false;
            
        }
        //method to clear text boxes and labels
        private void clearTextAndLabels()
        {
            textBoxParts.Text = "";
            textBoxLaborHours.Text = "";
            labelDisplayPartsSummary.Text = "";
            labelDisplayServiceAndLabor.Text = "";
            labelDisplayTaxOnParts.Text = "";
            labelDisplayTotalFees.Text = "";
            labelDisplayLaborCost.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextAndLabels();
            clearCheckBoxes();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //declaring all my needed variabls
            double oilAndLubeCharges = 0;
            double flushCharges = 0;
            double miscCharges = 0;
            double laborCharges = 0;
            double partsCharges = 0;
            double taxCharges = 0;
            double totalCharges = 0;
            double serviceAndLaborCharges = 0;
            //calling calculate methods for check boxes
            oilAndLubeCharges = calculateOilLubeCharges(oilAndLubeCharges);
            flushCharges = calculateFlushCharges(flushCharges);
            miscCharges = calculateMiscCharges(miscCharges);
            
            //if statements to validate user input
            if (double.TryParse(textBoxParts.Text, out partsCharges))
            {
                partsCharges = calculatePartsCharges(partsCharges);
                if (double.TryParse(textBoxLaborHours.Text, out laborCharges))
                {
                    //performing final math operations before displaying
                    laborCharges = calculateLaborCharges(laborCharges);
                    taxCharges = calculateTaxCharges(partsCharges);
                    totalCharges = calculateTotalCharges(miscCharges, flushCharges,
                        oilAndLubeCharges, taxCharges, laborCharges, partsCharges);
                    serviceAndLaborCharges = calculateServiceAndLaborCharges(miscCharges, flushCharges,
                        oilAndLubeCharges, laborCharges);
                    //displaying correct totals in each label
                    labelDisplayLaborCost.Text = laborCharges.ToString("c");
                    labelDisplayTaxOnParts.Text = taxCharges.ToString("c");
                    labelDisplayPartsSummary.Text = partsCharges.ToString("c");
                    labelDisplayServiceAndLabor.Text = serviceAndLaborCharges.ToString("c");
                    labelDisplayTotalFees.Text = totalCharges.ToString("c");
                }//end of labor hours check if statement
                else
                {
                    MessageBox.Show("Please enter a valid number of labor hours");
                }//end of else for labor hours check
            }//end of parts check if statement
            else
            {
                MessageBox.Show("Please enter a valid parts cost");
            }//end of else for parts check


             

            
        }
    }
}
