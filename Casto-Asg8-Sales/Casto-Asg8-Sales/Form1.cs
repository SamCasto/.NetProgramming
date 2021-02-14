using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Casto_Asg8_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //all label names use the naming convention of column initial 
        //followed by a row tag declaring which row it the label is in
        //ie the commission column uses the initial C and the Smallest Value
        //row uses the tag SV. For the Commission Smallest Value label, 
        //the label name will be labelDisplayCSV.
        
        //tag list: Largest Value = LV, Total = Total, Smallest Value = SV
        //column initial list: Commission = C, Net Sales = NS, there is no value for the 
        //first column as that is 'unfiltered' data



        //field level variables
        const int SALES_COUNT = 25;
        double[] arraySalesData = new double[SALES_COUNT];

        //methods to get our commissions and net sales
        private double calculateCommission(double sale, double commissionRate)
        {
            double commissionValue = 0;
            commissionValue = sale * commissionRate;
            return commissionValue;
        }
        
        //methods for our array processing
        private void loadSalesDataIntoArray()
        {
            StreamReader inputReader = new StreamReader("sales.txt");
            for (int i=0; i < SALES_COUNT; i++)
            {
                if (!inputReader.EndOfStream)
                    arraySalesData[i] = double.Parse(inputReader.ReadLine());
            }
        }
        private void loadArrayIntoListBox()
        {
            foreach (double value in arraySalesData)
            {
                listBoxSalesData.Items.Add(value);
            }
        }
        private double getSmallestSale()
        {
            double smallestValue = arraySalesData[0];
            for (int index=0; index < arraySalesData.Length; index++)
            {
                if (arraySalesData[index] < smallestValue)
                {
                    smallestValue = arraySalesData[index];
                }
            }
            return smallestValue;
        }
        private double getLargestSale()
        {
            double largestValue = 0;
            for (int index=0; index < arraySalesData.Length; index++)
            {
                if (arraySalesData[index] > largestValue)
                {
                    largestValue = arraySalesData[index];
                }
            }
            return largestValue;
        }
        private double getTotalSales()
        {
            double totalSales = 0;
            for (int index = 0; index < arraySalesData.Length; index++)
            {
                totalSales += arraySalesData[index];
            }
            return totalSales;
        }
        //method for clearing out labels
        private void clearSalesDataLabels()
        {
            labelDisplayAV.Text = "";
            labelDisplayCSV.Text = "";
            labelDisplayLV.Text = "";
            labelDisplaySV.Text = "";
            labelDisplayTotal.Text = "";
            labelDisplayCLV.Text = "";
            labelDisplayNSAV.Text = "";
            labelDisplayNSLV.Text = "";
            labelDisplayNSSV.Text = "";
            labelDisplayCAV.Text = "";
            labelDisplayCLV.Text = "";
            labelDisplayCTotal.Text = "";
            labelDisplayNSTotal.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadSalesDataIntoArray();
            loadArrayIntoListBox();

            groupBoxSalesData.Text = "Sales Data: " + listBoxSalesData.Items.Count.ToString() +
                " Records";

        }


        private void buttonCalculateValues_Click(object sender, EventArgs e)
        {
            clearSalesDataLabels();
            //getting the first column of value
            double smallestSale = getSmallestSale();
            double largestSale = getLargestSale();
            double totalSales = getTotalSales();
            double averageSales = totalSales / SALES_COUNT;
            //put the values into their labels
            labelDisplayAV.Text = averageSales.ToString("c");
            labelDisplaySV.Text = smallestSale.ToString("c");
            labelDisplayTotal.Text = totalSales.ToString("c");
            labelDisplayLV.Text = largestSale.ToString("c");
            //getting the commission rate from the upDown control
            //preemptively making the commissionrate a decimal value
            double commissionRate = (double)numericUpDownCommissionRate.Value / 100;
            //getting the commission values from the sales
            double smallestCommission = calculateCommission(smallestSale, commissionRate);
            double largestCommission = calculateCommission(largestSale, commissionRate);
            double averageCommission = calculateCommission(averageSales, commissionRate);
            double totalCommission = calculateCommission(totalSales, commissionRate);
            //displaying our commission values
            labelDisplayCSV.Text = smallestCommission.ToString("C");
            labelDisplayCAV.Text = averageCommission.ToString("C");
            labelDisplayCLV.Text = largestCommission.ToString("C");
            labelDisplayCTotal.Text = totalCommission.ToString("C");
            //getting our net sales values
            double smallestNetSale = smallestSale - smallestCommission;
            double largestNetSale = largestSale - largestCommission;
            double averageNetSale = averageSales - averageCommission;
            double totalNetSale = totalSales - totalCommission;
            //displaying our net sales values
            labelDisplayNSAV.Text = averageNetSale.ToString("C");
            labelDisplayNSLV.Text = largestNetSale.ToString("C");
            labelDisplayNSSV.Text = smallestNetSale.ToString("C");
            labelDisplayNSTotal.Text = totalNetSale.ToString("C");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
