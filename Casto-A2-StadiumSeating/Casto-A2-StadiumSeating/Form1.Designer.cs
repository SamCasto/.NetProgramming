
namespace Casto_A2_StadiumSeating
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
            this.ticketsSold = new System.Windows.Forms.GroupBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.ticketInstructionsLabel = new System.Windows.Forms.Label();
            this.classCLabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classALabel = new System.Windows.Forms.Label();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.classCRevenueTotalLabel = new System.Windows.Forms.Label();
            this.classBRevenueTotalLabel = new System.Windows.Forms.Label();
            this.classARevenueTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.classCTotalLabel = new System.Windows.Forms.Label();
            this.classBTotalLabel = new System.Windows.Forms.Label();
            this.classATotalLabel = new System.Windows.Forms.Label();
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSold.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSold
            // 
            this.ticketsSold.Controls.Add(this.classCTextBox);
            this.ticketsSold.Controls.Add(this.classBTextBox);
            this.ticketsSold.Controls.Add(this.classATextBox);
            this.ticketsSold.Controls.Add(this.ticketInstructionsLabel);
            this.ticketsSold.Controls.Add(this.classCLabel);
            this.ticketsSold.Controls.Add(this.classBLabel);
            this.ticketsSold.Controls.Add(this.classALabel);
            this.ticketsSold.Location = new System.Drawing.Point(56, 86);
            this.ticketsSold.Name = "ticketsSold";
            this.ticketsSold.Size = new System.Drawing.Size(313, 241);
            this.ticketsSold.TabIndex = 0;
            this.ticketsSold.TabStop = false;
            this.ticketsSold.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(145, 187);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(100, 26);
            this.classCTextBox.TabIndex = 6;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(145, 135);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(100, 26);
            this.classBTextBox.TabIndex = 5;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(145, 86);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(100, 26);
            this.classATextBox.TabIndex = 4;
            // 
            // ticketInstructionsLabel
            // 
            this.ticketInstructionsLabel.Location = new System.Drawing.Point(15, 22);
            this.ticketInstructionsLabel.Name = "ticketInstructionsLabel";
            this.ticketInstructionsLabel.Size = new System.Drawing.Size(249, 53);
            this.ticketInstructionsLabel.TabIndex = 3;
            this.ticketInstructionsLabel.Text = "Enter the number of tikets sold for each class of seats.";
            // 
            // classCLabel
            // 
            this.classCLabel.AutoSize = true;
            this.classCLabel.Location = new System.Drawing.Point(72, 193);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(67, 20);
            this.classCLabel.TabIndex = 2;
            this.classCLabel.Text = "Class C:";
            // 
            // classBLabel
            // 
            this.classBLabel.AutoSize = true;
            this.classBLabel.Location = new System.Drawing.Point(72, 141);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(67, 20);
            this.classBLabel.TabIndex = 1;
            this.classBLabel.Text = "Class B:";
            // 
            // classALabel
            // 
            this.classALabel.AutoSize = true;
            this.classALabel.Location = new System.Drawing.Point(72, 92);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(67, 20);
            this.classALabel.TabIndex = 0;
            this.classALabel.Text = "Class A:";
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevenueTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBRevenueTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevenueTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.totalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classATotalLabel);
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(528, 86);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(316, 241);
            this.revenueGeneratedGroupBox.TabIndex = 1;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenueLabel.Location = new System.Drawing.Point(116, 193);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(126, 20);
            this.totalRevenueLabel.TabIndex = 7;
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCRevenueTotalLabel
            // 
            this.classCRevenueTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevenueTotalLabel.Location = new System.Drawing.Point(116, 141);
            this.classCRevenueTotalLabel.Name = "classCRevenueTotalLabel";
            this.classCRevenueTotalLabel.Size = new System.Drawing.Size(126, 20);
            this.classCRevenueTotalLabel.TabIndex = 6;
            this.classCRevenueTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classBRevenueTotalLabel
            // 
            this.classBRevenueTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevenueTotalLabel.Location = new System.Drawing.Point(116, 92);
            this.classBRevenueTotalLabel.Name = "classBRevenueTotalLabel";
            this.classBRevenueTotalLabel.Size = new System.Drawing.Size(126, 20);
            this.classBRevenueTotalLabel.TabIndex = 5;
            this.classBRevenueTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classARevenueTotalLabel
            // 
            this.classARevenueTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevenueTotalLabel.Location = new System.Drawing.Point(116, 46);
            this.classARevenueTotalLabel.Name = "classARevenueTotalLabel";
            this.classARevenueTotalLabel.Size = new System.Drawing.Size(126, 20);
            this.classARevenueTotalLabel.TabIndex = 4;
            this.classARevenueTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(62, 193);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total:";
            // 
            // classCTotalLabel
            // 
            this.classCTotalLabel.AutoSize = true;
            this.classCTotalLabel.Location = new System.Drawing.Point(43, 141);
            this.classCTotalLabel.Name = "classCTotalLabel";
            this.classCTotalLabel.Size = new System.Drawing.Size(67, 20);
            this.classCTotalLabel.TabIndex = 2;
            this.classCTotalLabel.Text = "Class C:";
            this.classCTotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // classBTotalLabel
            // 
            this.classBTotalLabel.AutoSize = true;
            this.classBTotalLabel.Location = new System.Drawing.Point(43, 92);
            this.classBTotalLabel.Name = "classBTotalLabel";
            this.classBTotalLabel.Size = new System.Drawing.Size(67, 20);
            this.classBTotalLabel.TabIndex = 1;
            this.classBTotalLabel.Text = "Class B:";
            this.classBTotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // classATotalLabel
            // 
            this.classATotalLabel.AutoSize = true;
            this.classATotalLabel.Location = new System.Drawing.Point(43, 46);
            this.classATotalLabel.Name = "classATotalLabel";
            this.classATotalLabel.Size = new System.Drawing.Size(67, 20);
            this.classATotalLabel.TabIndex = 0;
            this.classATotalLabel.Text = "Class A:";
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(201, 367);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(100, 66);
            this.calculateRevenueButton.TabIndex = 2;
            this.calculateRevenueButton.Text = "Calculate Revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.calculateRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(371, 367);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 66);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(551, 367);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 66);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenueButton);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSold);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSold.ResumeLayout(false);
            this.ticketsSold.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSold;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label ticketInstructionsLabel;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.Label classCTotalLabel;
        private System.Windows.Forms.Label classBTotalLabel;
        private System.Windows.Forms.Label classATotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label classCRevenueTotalLabel;
        private System.Windows.Forms.Label classBRevenueTotalLabel;
        private System.Windows.Forms.Label classARevenueTotalLabel;
        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

