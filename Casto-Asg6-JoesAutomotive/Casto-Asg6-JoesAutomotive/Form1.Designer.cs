
namespace Casto_Asg6_JoesAutomotive
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
            this.groupBoxOilAndLube = new System.Windows.Forms.GroupBox();
            this.groupBoxFlushes = new System.Windows.Forms.GroupBox();
            this.checkBoxOilChange = new System.Windows.Forms.CheckBox();
            this.checkBoxLubeJob = new System.Windows.Forms.CheckBox();
            this.checkBoxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxInspection = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.checkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.groupBoxLabor = new System.Windows.Forms.GroupBox();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.textBoxLaborHours = new System.Windows.Forms.TextBox();
            this.labelPartsForTextBox = new System.Windows.Forms.Label();
            this.labelLaborHours = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelServiceAndLabor = new System.Windows.Forms.Label();
            this.labelPartsSummary = new System.Windows.Forms.Label();
            this.labelTaxOnParts = new System.Windows.Forms.Label();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.labelDisplayServiceAndLabor = new System.Windows.Forms.Label();
            this.labelDisplayPartsSummary = new System.Windows.Forms.Label();
            this.labelDisplayTaxOnParts = new System.Windows.Forms.Label();
            this.labelDisplayTotalFees = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.labelLaborPrice = new System.Windows.Forms.Label();
            this.labelDisplayLaborCost = new System.Windows.Forms.Label();
            this.labelLaborHoursCost = new System.Windows.Forms.Label();
            this.groupBoxOilAndLube.SuspendLayout();
            this.groupBoxFlushes.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.groupBoxLabor.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.groupBoxParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOilAndLube
            // 
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxLubeJob);
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxOilChange);
            this.groupBoxOilAndLube.Location = new System.Drawing.Point(12, 40);
            this.groupBoxOilAndLube.Name = "groupBoxOilAndLube";
            this.groupBoxOilAndLube.Size = new System.Drawing.Size(320, 144);
            this.groupBoxOilAndLube.TabIndex = 0;
            this.groupBoxOilAndLube.TabStop = false;
            this.groupBoxOilAndLube.Text = "Oil and Lube";
            // 
            // groupBoxFlushes
            // 
            this.groupBoxFlushes.Controls.Add(this.checkBoxTransmissionFlush);
            this.groupBoxFlushes.Controls.Add(this.checkBoxRadiatorFlush);
            this.groupBoxFlushes.Location = new System.Drawing.Point(468, 40);
            this.groupBoxFlushes.Name = "groupBoxFlushes";
            this.groupBoxFlushes.Size = new System.Drawing.Size(320, 144);
            this.groupBoxFlushes.TabIndex = 1;
            this.groupBoxFlushes.TabStop = false;
            this.groupBoxFlushes.Text = "Flushes";
            // 
            // checkBoxOilChange
            // 
            this.checkBoxOilChange.AutoSize = true;
            this.checkBoxOilChange.Location = new System.Drawing.Point(30, 48);
            this.checkBoxOilChange.Name = "checkBoxOilChange";
            this.checkBoxOilChange.Size = new System.Drawing.Size(176, 24);
            this.checkBoxOilChange.TabIndex = 2;
            this.checkBoxOilChange.Text = "Oil Change ($26.00)";
            this.checkBoxOilChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxLubeJob
            // 
            this.checkBoxLubeJob.AutoSize = true;
            this.checkBoxLubeJob.Location = new System.Drawing.Point(30, 98);
            this.checkBoxLubeJob.Name = "checkBoxLubeJob";
            this.checkBoxLubeJob.Size = new System.Drawing.Size(159, 24);
            this.checkBoxLubeJob.TabIndex = 3;
            this.checkBoxLubeJob.Text = "Lube job ($18.00)";
            this.checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadiatorFlush
            // 
            this.checkBoxRadiatorFlush.AutoSize = true;
            this.checkBoxRadiatorFlush.Location = new System.Drawing.Point(39, 48);
            this.checkBoxRadiatorFlush.Name = "checkBoxRadiatorFlush";
            this.checkBoxRadiatorFlush.Size = new System.Drawing.Size(202, 24);
            this.checkBoxRadiatorFlush.TabIndex = 0;
            this.checkBoxRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.checkBoxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransmissionFlush
            // 
            this.checkBoxTransmissionFlush.AutoSize = true;
            this.checkBoxTransmissionFlush.Location = new System.Drawing.Point(39, 98);
            this.checkBoxTransmissionFlush.Name = "checkBoxTransmissionFlush";
            this.checkBoxTransmissionFlush.Size = new System.Drawing.Size(234, 24);
            this.checkBoxTransmissionFlush.TabIndex = 1;
            this.checkBoxTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.checkBoxTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.checkBoxTireRotation);
            this.groupBoxMisc.Controls.Add(this.checkBoxReplaceMuffler);
            this.groupBoxMisc.Controls.Add(this.checkBoxInspection);
            this.groupBoxMisc.Location = new System.Drawing.Point(12, 221);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(320, 188);
            this.groupBoxMisc.TabIndex = 2;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // checkBoxInspection
            // 
            this.checkBoxInspection.AutoSize = true;
            this.checkBoxInspection.Location = new System.Drawing.Point(30, 47);
            this.checkBoxInspection.Name = "checkBoxInspection";
            this.checkBoxInspection.Size = new System.Drawing.Size(172, 24);
            this.checkBoxInspection.TabIndex = 0;
            this.checkBoxInspection.Text = "Inspection ($15.00)";
            this.checkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceMuffler
            // 
            this.checkBoxReplaceMuffler.AutoSize = true;
            this.checkBoxReplaceMuffler.Location = new System.Drawing.Point(30, 99);
            this.checkBoxReplaceMuffler.Name = "checkBoxReplaceMuffler";
            this.checkBoxReplaceMuffler.Size = new System.Drawing.Size(219, 24);
            this.checkBoxReplaceMuffler.TabIndex = 1;
            this.checkBoxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.checkBoxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // checkBoxTireRotation
            // 
            this.checkBoxTireRotation.AutoSize = true;
            this.checkBoxTireRotation.Location = new System.Drawing.Point(30, 143);
            this.checkBoxTireRotation.Name = "checkBoxTireRotation";
            this.checkBoxTireRotation.Size = new System.Drawing.Size(189, 24);
            this.checkBoxTireRotation.TabIndex = 2;
            this.checkBoxTireRotation.Text = "Tire Rotation ($20.00)";
            this.checkBoxTireRotation.UseVisualStyleBackColor = true;
            // 
            // groupBoxLabor
            // 
            this.groupBoxLabor.Controls.Add(this.labelLaborHoursCost);
            this.groupBoxLabor.Controls.Add(this.labelDisplayLaborCost);
            this.groupBoxLabor.Controls.Add(this.labelLaborPrice);
            this.groupBoxLabor.Controls.Add(this.labelLaborHours);
            this.groupBoxLabor.Controls.Add(this.textBoxLaborHours);
            this.groupBoxLabor.Location = new System.Drawing.Point(468, 221);
            this.groupBoxLabor.Name = "groupBoxLabor";
            this.groupBoxLabor.Size = new System.Drawing.Size(320, 188);
            this.groupBoxLabor.TabIndex = 3;
            this.groupBoxLabor.TabStop = false;
            this.groupBoxLabor.Text = "Labor:";
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(131, 40);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(100, 26);
            this.textBoxParts.TabIndex = 0;
            // 
            // textBoxLaborHours
            // 
            this.textBoxLaborHours.Location = new System.Drawing.Point(148, 44);
            this.textBoxLaborHours.Name = "textBoxLaborHours";
            this.textBoxLaborHours.Size = new System.Drawing.Size(100, 26);
            this.textBoxLaborHours.TabIndex = 1;
            // 
            // labelPartsForTextBox
            // 
            this.labelPartsForTextBox.Location = new System.Drawing.Point(26, 40);
            this.labelPartsForTextBox.Name = "labelPartsForTextBox";
            this.labelPartsForTextBox.Size = new System.Drawing.Size(99, 26);
            this.labelPartsForTextBox.TabIndex = 2;
            this.labelPartsForTextBox.Text = "Parts Total:";
            // 
            // labelLaborHours
            // 
            this.labelLaborHours.Location = new System.Drawing.Point(35, 47);
            this.labelLaborHours.Name = "labelLaborHours";
            this.labelLaborHours.Size = new System.Drawing.Size(107, 26);
            this.labelLaborHours.TabIndex = 3;
            this.labelLaborHours.Text = "Labor Hours:";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelDisplayTotalFees);
            this.groupBoxSummary.Controls.Add(this.labelDisplayTaxOnParts);
            this.groupBoxSummary.Controls.Add(this.labelDisplayPartsSummary);
            this.groupBoxSummary.Controls.Add(this.labelDisplayServiceAndLabor);
            this.groupBoxSummary.Controls.Add(this.labelTotalFees);
            this.groupBoxSummary.Controls.Add(this.labelTaxOnParts);
            this.groupBoxSummary.Controls.Add(this.labelPartsSummary);
            this.groupBoxSummary.Controls.Add(this.labelServiceAndLabor);
            this.groupBoxSummary.Location = new System.Drawing.Point(12, 519);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(776, 322);
            this.groupBoxSummary.TabIndex = 4;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // labelServiceAndLabor
            // 
            this.labelServiceAndLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceAndLabor.Location = new System.Drawing.Point(63, 62);
            this.labelServiceAndLabor.Name = "labelServiceAndLabor";
            this.labelServiceAndLabor.Size = new System.Drawing.Size(234, 39);
            this.labelServiceAndLabor.TabIndex = 0;
            this.labelServiceAndLabor.Text = "Service and Labor";
            this.labelServiceAndLabor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPartsSummary
            // 
            this.labelPartsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartsSummary.Location = new System.Drawing.Point(124, 114);
            this.labelPartsSummary.Name = "labelPartsSummary";
            this.labelPartsSummary.Size = new System.Drawing.Size(173, 39);
            this.labelPartsSummary.TabIndex = 1;
            this.labelPartsSummary.Text = "Parts";
            this.labelPartsSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTaxOnParts
            // 
            this.labelTaxOnParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxOnParts.Location = new System.Drawing.Point(124, 172);
            this.labelTaxOnParts.Name = "labelTaxOnParts";
            this.labelTaxOnParts.Size = new System.Drawing.Size(173, 39);
            this.labelTaxOnParts.TabIndex = 2;
            this.labelTaxOnParts.Text = "Tax (on parts)";
            this.labelTaxOnParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFees.Location = new System.Drawing.Point(124, 233);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(173, 39);
            this.labelTotalFees.TabIndex = 3;
            this.labelTotalFees.Text = "Total Fees";
            this.labelTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDisplayServiceAndLabor
            // 
            this.labelDisplayServiceAndLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayServiceAndLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayServiceAndLabor.Location = new System.Drawing.Point(369, 62);
            this.labelDisplayServiceAndLabor.Name = "labelDisplayServiceAndLabor";
            this.labelDisplayServiceAndLabor.Size = new System.Drawing.Size(173, 39);
            this.labelDisplayServiceAndLabor.TabIndex = 4;
            this.labelDisplayServiceAndLabor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDisplayPartsSummary
            // 
            this.labelDisplayPartsSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayPartsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayPartsSummary.Location = new System.Drawing.Point(369, 114);
            this.labelDisplayPartsSummary.Name = "labelDisplayPartsSummary";
            this.labelDisplayPartsSummary.Size = new System.Drawing.Size(173, 39);
            this.labelDisplayPartsSummary.TabIndex = 5;
            this.labelDisplayPartsSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDisplayTaxOnParts
            // 
            this.labelDisplayTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayTaxOnParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTaxOnParts.Location = new System.Drawing.Point(369, 172);
            this.labelDisplayTaxOnParts.Name = "labelDisplayTaxOnParts";
            this.labelDisplayTaxOnParts.Size = new System.Drawing.Size(173, 39);
            this.labelDisplayTaxOnParts.TabIndex = 6;
            this.labelDisplayTaxOnParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDisplayTotalFees
            // 
            this.labelDisplayTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTotalFees.Location = new System.Drawing.Point(369, 233);
            this.labelDisplayTotalFees.Name = "labelDisplayTotalFees";
            this.labelDisplayTotalFees.Size = new System.Drawing.Size(173, 39);
            this.labelDisplayTotalFees.TabIndex = 7;
            this.labelDisplayTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(128, 871);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(133, 61);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 871);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(133, 61);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(537, 871);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 61);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.Controls.Add(this.labelPartsForTextBox);
            this.groupBoxParts.Controls.Add(this.textBoxParts);
            this.groupBoxParts.Location = new System.Drawing.Point(12, 424);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(776, 89);
            this.groupBoxParts.TabIndex = 8;
            this.groupBoxParts.TabStop = false;
            this.groupBoxParts.Text = "Parts:";
            // 
            // labelLaborPrice
            // 
            this.labelLaborPrice.AutoSize = true;
            this.labelLaborPrice.Location = new System.Drawing.Point(89, 86);
            this.labelLaborPrice.Name = "labelLaborPrice";
            this.labelLaborPrice.Size = new System.Drawing.Size(159, 20);
            this.labelLaborPrice.TabIndex = 4;
            this.labelLaborPrice.Text = "Labor is $50 per hour";
            // 
            // labelDisplayLaborCost
            // 
            this.labelDisplayLaborCost.Location = new System.Drawing.Point(148, 140);
            this.labelDisplayLaborCost.Name = "labelDisplayLaborCost";
            this.labelDisplayLaborCost.Size = new System.Drawing.Size(107, 23);
            this.labelDisplayLaborCost.TabIndex = 5;
            // 
            // labelLaborHoursCost
            // 
            this.labelLaborHoursCost.Location = new System.Drawing.Point(35, 140);
            this.labelLaborHoursCost.Name = "labelLaborHoursCost";
            this.labelLaborHoursCost.Size = new System.Drawing.Size(107, 26);
            this.labelLaborHoursCost.TabIndex = 6;
            this.labelLaborHoursCost.Text = "Labor Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.groupBoxParts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxLabor);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.groupBoxFlushes);
            this.Controls.Add(this.groupBoxOilAndLube);
            this.Name = "Form1";
            this.Text = "Casto Asg6 JoesAutomotive";
            this.groupBoxOilAndLube.ResumeLayout(false);
            this.groupBoxOilAndLube.PerformLayout();
            this.groupBoxFlushes.ResumeLayout(false);
            this.groupBoxFlushes.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.groupBoxLabor.ResumeLayout(false);
            this.groupBoxLabor.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOilAndLube;
        private System.Windows.Forms.CheckBox checkBoxLubeJob;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.GroupBox groupBoxFlushes;
        private System.Windows.Forms.CheckBox checkBoxTransmissionFlush;
        private System.Windows.Forms.CheckBox checkBoxRadiatorFlush;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox checkBoxTireRotation;
        private System.Windows.Forms.CheckBox checkBoxReplaceMuffler;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.GroupBox groupBoxLabor;
        private System.Windows.Forms.Label labelLaborHours;
        private System.Windows.Forms.Label labelPartsForTextBox;
        private System.Windows.Forms.TextBox textBoxLaborHours;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelDisplayTotalFees;
        private System.Windows.Forms.Label labelDisplayTaxOnParts;
        private System.Windows.Forms.Label labelDisplayPartsSummary;
        private System.Windows.Forms.Label labelDisplayServiceAndLabor;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label labelTaxOnParts;
        private System.Windows.Forms.Label labelPartsSummary;
        private System.Windows.Forms.Label labelServiceAndLabor;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelLaborHoursCost;
        private System.Windows.Forms.Label labelDisplayLaborCost;
        private System.Windows.Forms.Label labelLaborPrice;
        private System.Windows.Forms.GroupBox groupBoxParts;
    }
}

