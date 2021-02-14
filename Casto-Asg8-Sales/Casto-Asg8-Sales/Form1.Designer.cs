
namespace Casto_Asg8_Sales
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSalesData = new System.Windows.Forms.GroupBox();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.listBoxSalesData = new System.Windows.Forms.ListBox();
            this.labelCommissionPercent = new System.Windows.Forms.Label();
            this.labelSmallestValue = new System.Windows.Forms.Label();
            this.labelLargestValue = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCommission = new System.Windows.Forms.Label();
            this.labelNetSale = new System.Windows.Forms.Label();
            this.labelDisplaySV = new System.Windows.Forms.Label();
            this.labelDisplayLV = new System.Windows.Forms.Label();
            this.labelDisplayAV = new System.Windows.Forms.Label();
            this.labelDisplayNSTotal = new System.Windows.Forms.Label();
            this.labelDisplayCAV = new System.Windows.Forms.Label();
            this.labelDisplayCTotal = new System.Windows.Forms.Label();
            this.labelDisplayCLV = new System.Windows.Forms.Label();
            this.labelDisplayCSV = new System.Windows.Forms.Label();
            this.labelDisplayNSAV = new System.Windows.Forms.Label();
            this.labelDisplayNSLV = new System.Windows.Forms.Label();
            this.labelDisplayNSSV = new System.Windows.Forms.Label();
            this.labelDisplayTotal = new System.Windows.Forms.Label();
            this.buttonCalculateValues = new System.Windows.Forms.Button();
            this.numericUpDownCommissionRate = new System.Windows.Forms.NumericUpDown();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxSalesData.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommissionRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSalesData
            // 
            this.groupBoxSalesData.Controls.Add(this.listBoxSalesData);
            this.groupBoxSalesData.Location = new System.Drawing.Point(43, 46);
            this.groupBoxSalesData.Name = "groupBoxSalesData";
            this.groupBoxSalesData.Size = new System.Drawing.Size(326, 663);
            this.groupBoxSalesData.TabIndex = 0;
            this.groupBoxSalesData.TabStop = false;
            this.groupBoxSalesData.Text = "Sales Data: ";
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.Controls.Add(this.buttonExit);
            this.groupBoxTotals.Controls.Add(this.numericUpDownCommissionRate);
            this.groupBoxTotals.Controls.Add(this.buttonCalculateValues);
            this.groupBoxTotals.Controls.Add(this.labelDisplayTotal);
            this.groupBoxTotals.Controls.Add(this.labelDisplayNSSV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayNSLV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayNSAV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayCSV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayCLV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayCTotal);
            this.groupBoxTotals.Controls.Add(this.labelDisplayCAV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayNSTotal);
            this.groupBoxTotals.Controls.Add(this.labelDisplayAV);
            this.groupBoxTotals.Controls.Add(this.labelDisplayLV);
            this.groupBoxTotals.Controls.Add(this.labelDisplaySV);
            this.groupBoxTotals.Controls.Add(this.labelNetSale);
            this.groupBoxTotals.Controls.Add(this.labelCommission);
            this.groupBoxTotals.Controls.Add(this.labelTotal);
            this.groupBoxTotals.Controls.Add(this.labelAverage);
            this.groupBoxTotals.Controls.Add(this.labelLargestValue);
            this.groupBoxTotals.Controls.Add(this.labelSmallestValue);
            this.groupBoxTotals.Controls.Add(this.labelCommissionPercent);
            this.groupBoxTotals.Location = new System.Drawing.Point(454, 46);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(660, 499);
            this.groupBoxTotals.TabIndex = 0;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Totals and Commissions";
            // 
            // listBoxSalesData
            // 
            this.listBoxSalesData.FormattingEnabled = true;
            this.listBoxSalesData.ItemHeight = 20;
            this.listBoxSalesData.Location = new System.Drawing.Point(24, 39);
            this.listBoxSalesData.Name = "listBoxSalesData";
            this.listBoxSalesData.Size = new System.Drawing.Size(275, 604);
            this.listBoxSalesData.TabIndex = 0;
            // 
            // labelCommissionPercent
            // 
            this.labelCommissionPercent.AutoSize = true;
            this.labelCommissionPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommissionPercent.Location = new System.Drawing.Point(40, 82);
            this.labelCommissionPercent.Name = "labelCommissionPercent";
            this.labelCommissionPercent.Size = new System.Drawing.Size(135, 20);
            this.labelCommissionPercent.TabIndex = 0;
            this.labelCommissionPercent.Text = "Commission %: ";
            // 
            // labelSmallestValue
            // 
            this.labelSmallestValue.AutoSize = true;
            this.labelSmallestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmallestValue.Location = new System.Drawing.Point(41, 149);
            this.labelSmallestValue.Name = "labelSmallestValue";
            this.labelSmallestValue.Size = new System.Drawing.Size(134, 20);
            this.labelSmallestValue.TabIndex = 1;
            this.labelSmallestValue.Text = "Smallest Value:";
            // 
            // labelLargestValue
            // 
            this.labelLargestValue.AutoSize = true;
            this.labelLargestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLargestValue.Location = new System.Drawing.Point(49, 209);
            this.labelLargestValue.Name = "labelLargestValue";
            this.labelLargestValue.Size = new System.Drawing.Size(126, 20);
            this.labelLargestValue.TabIndex = 2;
            this.labelLargestValue.Text = "Largest Value:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.Location = new System.Drawing.Point(95, 265);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(80, 20);
            this.labelAverage.TabIndex = 3;
            this.labelAverage.Text = "Average:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(121, 335);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 20);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total:";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommission.Location = new System.Drawing.Point(323, 82);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(115, 20);
            this.labelCommission.TabIndex = 5;
            this.labelCommission.Text = "Commission: ";
            // 
            // labelNetSale
            // 
            this.labelNetSale.AutoSize = true;
            this.labelNetSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetSale.Location = new System.Drawing.Point(519, 82);
            this.labelNetSale.Name = "labelNetSale";
            this.labelNetSale.Size = new System.Drawing.Size(83, 20);
            this.labelNetSale.TabIndex = 6;
            this.labelNetSale.Text = "Net Sale:";
            // 
            // labelDisplaySV
            // 
            this.labelDisplaySV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplaySV.Location = new System.Drawing.Point(181, 148);
            this.labelDisplaySV.Name = "labelDisplaySV";
            this.labelDisplaySV.Size = new System.Drawing.Size(119, 23);
            this.labelDisplaySV.TabIndex = 7;
            this.labelDisplaySV.Text = "labelDisplaySV";
            // 
            // labelDisplayLV
            // 
            this.labelDisplayLV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayLV.Location = new System.Drawing.Point(181, 208);
            this.labelDisplayLV.Name = "labelDisplayLV";
            this.labelDisplayLV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayLV.TabIndex = 8;
            this.labelDisplayLV.Text = "labelDisplayLV";
            // 
            // labelDisplayAV
            // 
            this.labelDisplayAV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayAV.Location = new System.Drawing.Point(181, 264);
            this.labelDisplayAV.Name = "labelDisplayAV";
            this.labelDisplayAV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayAV.TabIndex = 9;
            this.labelDisplayAV.Text = "labelDisplayAV";
            // 
            // labelDisplayNSTotal
            // 
            this.labelDisplayNSTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayNSTotal.Location = new System.Drawing.Point(514, 334);
            this.labelDisplayNSTotal.Name = "labelDisplayNSTotal";
            this.labelDisplayNSTotal.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayNSTotal.TabIndex = 10;
            this.labelDisplayNSTotal.Text = "labelDisplayNSTotal";
            // 
            // labelDisplayCAV
            // 
            this.labelDisplayCAV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayCAV.Location = new System.Drawing.Point(327, 265);
            this.labelDisplayCAV.Name = "labelDisplayCAV";
            this.labelDisplayCAV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayCAV.TabIndex = 11;
            this.labelDisplayCAV.Text = "labelDisplayCAV";
            // 
            // labelDisplayCTotal
            // 
            this.labelDisplayCTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayCTotal.Location = new System.Drawing.Point(327, 334);
            this.labelDisplayCTotal.Name = "labelDisplayCTotal";
            this.labelDisplayCTotal.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayCTotal.TabIndex = 12;
            this.labelDisplayCTotal.Text = "labelDisplayCTotal";
            // 
            // labelDisplayCLV
            // 
            this.labelDisplayCLV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayCLV.Location = new System.Drawing.Point(327, 208);
            this.labelDisplayCLV.Name = "labelDisplayCLV";
            this.labelDisplayCLV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayCLV.TabIndex = 13;
            this.labelDisplayCLV.Text = "labelDisplayCLV";
            // 
            // labelDisplayCSV
            // 
            this.labelDisplayCSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayCSV.Location = new System.Drawing.Point(327, 148);
            this.labelDisplayCSV.Name = "labelDisplayCSV";
            this.labelDisplayCSV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayCSV.TabIndex = 14;
            this.labelDisplayCSV.Text = "labelDisplayCSV";
            // 
            // labelDisplayNSAV
            // 
            this.labelDisplayNSAV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayNSAV.Location = new System.Drawing.Point(514, 264);
            this.labelDisplayNSAV.Name = "labelDisplayNSAV";
            this.labelDisplayNSAV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayNSAV.TabIndex = 15;
            this.labelDisplayNSAV.Text = "labelDisplayAV";
            // 
            // labelDisplayNSLV
            // 
            this.labelDisplayNSLV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayNSLV.Location = new System.Drawing.Point(514, 208);
            this.labelDisplayNSLV.Name = "labelDisplayNSLV";
            this.labelDisplayNSLV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayNSLV.TabIndex = 16;
            this.labelDisplayNSLV.Text = "labelDisplayNSLV";
            // 
            // labelDisplayNSSV
            // 
            this.labelDisplayNSSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayNSSV.Location = new System.Drawing.Point(514, 148);
            this.labelDisplayNSSV.Name = "labelDisplayNSSV";
            this.labelDisplayNSSV.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayNSSV.TabIndex = 17;
            this.labelDisplayNSSV.Text = "labelDisplayNSSV";
            // 
            // labelDisplayTotal
            // 
            this.labelDisplayTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayTotal.Location = new System.Drawing.Point(181, 335);
            this.labelDisplayTotal.Name = "labelDisplayTotal";
            this.labelDisplayTotal.Size = new System.Drawing.Size(119, 20);
            this.labelDisplayTotal.TabIndex = 18;
            this.labelDisplayTotal.Text = "labelDisplayTotal";
            // 
            // buttonCalculateValues
            // 
            this.buttonCalculateValues.Location = new System.Drawing.Point(153, 399);
            this.buttonCalculateValues.Name = "buttonCalculateValues";
            this.buttonCalculateValues.Size = new System.Drawing.Size(170, 68);
            this.buttonCalculateValues.TabIndex = 20;
            this.buttonCalculateValues.Text = "Calculate Values";
            this.buttonCalculateValues.UseVisualStyleBackColor = true;
            this.buttonCalculateValues.Click += new System.EventHandler(this.buttonCalculateValues_Click);
            // 
            // numericUpDownCommissionRate
            // 
            this.numericUpDownCommissionRate.Location = new System.Drawing.Point(181, 76);
            this.numericUpDownCommissionRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCommissionRate.Name = "numericUpDownCommissionRate";
            this.numericUpDownCommissionRate.Size = new System.Drawing.Size(119, 26);
            this.numericUpDownCommissionRate.TabIndex = 21;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(414, 399);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 68);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.groupBoxTotals);
            this.Controls.Add(this.groupBoxSalesData);
            this.Name = "Form1";
            this.Text = "Casto-Asg8-Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSalesData.ResumeLayout(false);
            this.groupBoxTotals.ResumeLayout(false);
            this.groupBoxTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommissionRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSalesData;
        private System.Windows.Forms.ListBox listBoxSalesData;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelLargestValue;
        private System.Windows.Forms.Label labelSmallestValue;
        private System.Windows.Forms.Label labelCommissionPercent;
        private System.Windows.Forms.Label labelDisplayTotal;
        private System.Windows.Forms.Label labelDisplayNSSV;
        private System.Windows.Forms.Label labelDisplayNSLV;
        private System.Windows.Forms.Label labelDisplayNSAV;
        private System.Windows.Forms.Label labelDisplayCSV;
        private System.Windows.Forms.Label labelDisplayCLV;
        private System.Windows.Forms.Label labelDisplayCTotal;
        private System.Windows.Forms.Label labelDisplayCAV;
        private System.Windows.Forms.Label labelDisplayNSTotal;
        private System.Windows.Forms.Label labelDisplayAV;
        private System.Windows.Forms.Label labelDisplayLV;
        private System.Windows.Forms.Label labelDisplaySV;
        private System.Windows.Forms.Label labelNetSale;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalculateValues;
        private System.Windows.Forms.NumericUpDown numericUpDownCommissionRate;
        private System.Windows.Forms.Button buttonExit;
    }
}

