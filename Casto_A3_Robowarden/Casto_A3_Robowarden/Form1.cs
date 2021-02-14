using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_A3_Robowarden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void legalFishingCheckButton_Click(object sender, EventArgs e)
        {
            //declare needed variables
            bool isFreeWeekend = false;
            bool isUnder16 = false;
            bool hasFishingLicense = false;
            bool isLegalToFish = false;
            int userAge;
            DateTime dateToday;

            //setting dateToday to today's date and making each part
            //of the date an int variable to be able to compare the date
            //that will be input by the user
            dateToday = pickerTodaysDate.Value.Date;
            int todayMonth = 0;
            int todayYear = 0;
            int todayDay = 0;
            //storing the new values for month/day/year
            todayMonth = dateToday.Month;
            todayYear = dateToday.Year;
            todayDay = dateToday.Day;
            //checking to make sure the user entered an int
            try
            {
                userAge = int.Parse(textBoxYourAge.Text);


                //performing the actual logic for checking if someone can legally fish
                if ((todayMonth == 6 && todayYear == 2021 && todayDay == 5) || (todayMonth == 6 && todayYear == 2021 && todayDay == 6)) {
                    isFreeWeekend = true;
                    isLegalToFish = true;
                }
                if (userAge < 16)
                {
                    isUnder16 = true;
                    isLegalToFish = true;
                }
                if (checkBoxHasFishingLicense.Checked)
                {
                    hasFishingLicense = true;
                    isLegalToFish = true;
                }
                if (isLegalToFish)
                {
                    labelLegalToFishAnswer.Text = "Good luck citizen";
                }
                else
                {
                    labelLegalToFishAnswer.Text = "You are under arrest criminal";
                }

            }
            catch
            {
                MessageBox.Show("Please enter an int for your age");
            }
        }
    }
}
