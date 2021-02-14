using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_ASG5_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listBoxPopulation.Items.Clear();
            
            int numberOfDays ;//number of days to compute
            double numberOfOrganisms;//starting number of organisms
            double percentIncrease;//percent increase each day
            int counter = 1;//loop counter initialized to 1
            //validating user input for each variabel
            if (int.TryParse(textBoxDaysToMultiply.Text, out numberOfDays))
            {
                if(double.TryParse(textBoxStartingOrganisms.Text, out numberOfOrganisms))
                {
                    if(double.TryParse(textBoxDailyIncrease.Text, out percentIncrease))
                    {
                        //stating new input numbers
                        listBoxPopulation.Items.Add("Population Start: " + numberOfOrganisms +
                        "   Daily % Increase: " + percentIncrease + "   Number of Days: "
                        + numberOfDays);
                        //output column headings
                        listBoxPopulation.Items.Add("Day     Total");
                        //code for looping
                        do
                        {
                            listBoxPopulation.Items.Add("  " + counter + "        " +
                                numberOfOrganisms);
                            numberOfOrganisms = (numberOfOrganisms * percentIncrease) / 100 + numberOfOrganisms;
                            counter++;
                        } while (counter <= numberOfDays);
                    }//end of if percent increase check
                    else
                    {
                        MessageBox.Show("Please enter a valid percent increase");
                    }//end of else percent increase check
                }//end of if number of organisms check
                else
                {
                    MessageBox.Show("Please enter a valid number of organisms");
                }//end of else number of organisms check
            }//end of if number of days check
            else
            {
                MessageBox.Show("Please enter a valid number of days");
            }//end of else day check
            

            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this is how I interpreted your instructions for "defaulting"
            //the number values for the variable
            int numberOfDays = 5;//number of days to compute
            double numberOfOrganisms = 1000;//starting number of organisms
            double percentIncrease = 10;//percent increase each day
            int counter = 1;//loop counter
            listBoxPopulation.Items.Add("Population Start: " + numberOfOrganisms +
                "   Daily % Increase: " + percentIncrease + "   Number of Days: "
                + numberOfDays);
            listBoxPopulation.Items.Add("Day     Total");
            do
            {
                listBoxPopulation.Items.Add("  " + counter + "        " + numberOfOrganisms);
                numberOfOrganisms = (numberOfOrganisms * percentIncrease) / 100 + numberOfOrganisms;
                counter++;
            } while (counter <= numberOfDays);
        }
    }
}
