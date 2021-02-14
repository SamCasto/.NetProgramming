
namespace Casto_A3_Robowarden
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
            this.checkBoxHasFishingLicense = new System.Windows.Forms.CheckBox();
            this.labelYourAge = new System.Windows.Forms.Label();
            this.textBoxYourAge = new System.Windows.Forms.TextBox();
            this.labelTodaysDate = new System.Windows.Forms.Label();
            this.pickerTodaysDate = new System.Windows.Forms.DateTimePicker();
            this.buttonLegalFishCheck = new System.Windows.Forms.Button();
            this.labelLegalToFishAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxHasFishingLicense
            // 
            this.checkBoxHasFishingLicense.AutoSize = true;
            this.checkBoxHasFishingLicense.Location = new System.Drawing.Point(306, 39);
            this.checkBoxHasFishingLicense.Name = "checkBoxHasFishingLicense";
            this.checkBoxHasFishingLicense.Size = new System.Drawing.Size(259, 24);
            this.checkBoxHasFishingLicense.TabIndex = 0;
            this.checkBoxHasFishingLicense.Text = "Do you have a Fishing License?";
            this.checkBoxHasFishingLicense.UseVisualStyleBackColor = true;
            // 
            // labelYourAge
            // 
            this.labelYourAge.AutoSize = true;
            this.labelYourAge.Location = new System.Drawing.Point(138, 140);
            this.labelYourAge.Name = "labelYourAge";
            this.labelYourAge.Size = new System.Drawing.Size(80, 20);
            this.labelYourAge.TabIndex = 1;
            this.labelYourAge.Text = "Your Age:";
            // 
            // textBoxYourAge
            // 
            this.textBoxYourAge.Location = new System.Drawing.Point(262, 134);
            this.textBoxYourAge.Name = "textBoxYourAge";
            this.textBoxYourAge.Size = new System.Drawing.Size(362, 26);
            this.textBoxYourAge.TabIndex = 2;
            // 
            // labelTodaysDate
            // 
            this.labelTodaysDate.AutoSize = true;
            this.labelTodaysDate.Location = new System.Drawing.Point(138, 211);
            this.labelTodaysDate.Name = "labelTodaysDate";
            this.labelTodaysDate.Size = new System.Drawing.Size(103, 20);
            this.labelTodaysDate.TabIndex = 3;
            this.labelTodaysDate.Text = "Todays Date:";
            // 
            // pickerTodaysDate
            // 
            this.pickerTodaysDate.Location = new System.Drawing.Point(262, 205);
            this.pickerTodaysDate.Name = "pickerTodaysDate";
            this.pickerTodaysDate.Size = new System.Drawing.Size(362, 26);
            this.pickerTodaysDate.TabIndex = 4;
            // 
            // buttonLegalFishCheck
            // 
            this.buttonLegalFishCheck.Location = new System.Drawing.Point(306, 280);
            this.buttonLegalFishCheck.Name = "buttonLegalFishCheck";
            this.buttonLegalFishCheck.Size = new System.Drawing.Size(259, 45);
            this.buttonLegalFishCheck.TabIndex = 5;
            this.buttonLegalFishCheck.Text = "Are You Legal to Fish";
            this.buttonLegalFishCheck.UseVisualStyleBackColor = true;
            this.buttonLegalFishCheck.Click += new System.EventHandler(this.legalFishingCheckButton_Click);
            // 
            // labelLegalToFishAnswer
            // 
            this.labelLegalToFishAnswer.Location = new System.Drawing.Point(292, 375);
            this.labelLegalToFishAnswer.Name = "labelLegalToFishAnswer";
            this.labelLegalToFishAnswer.Size = new System.Drawing.Size(283, 35);
            this.labelLegalToFishAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLegalToFishAnswer);
            this.Controls.Add(this.buttonLegalFishCheck);
            this.Controls.Add(this.pickerTodaysDate);
            this.Controls.Add(this.labelTodaysDate);
            this.Controls.Add(this.textBoxYourAge);
            this.Controls.Add(this.labelYourAge);
            this.Controls.Add(this.checkBoxHasFishingLicense);
            this.Name = "Form1";
            this.Text = "Asg 3 RoboWarden Samuel Casto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHasFishingLicense;
        private System.Windows.Forms.Label labelYourAge;
        private System.Windows.Forms.TextBox textBoxYourAge;
        private System.Windows.Forms.Label labelTodaysDate;
        private System.Windows.Forms.DateTimePicker pickerTodaysDate;
        private System.Windows.Forms.Button buttonLegalFishCheck;
        private System.Windows.Forms.Label labelLegalToFishAnswer;
    }
}

