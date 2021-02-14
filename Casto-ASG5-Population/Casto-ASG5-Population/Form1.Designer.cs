
namespace Casto_ASG5_Population
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
            this.listBoxPopulation = new System.Windows.Forms.ListBox();
            this.labelStartingOrganism = new System.Windows.Forms.Label();
            this.labelDailyIncrease = new System.Windows.Forms.Label();
            this.labelDaysToMultiply = new System.Windows.Forms.Label();
            this.textBoxStartingOrganisms = new System.Windows.Forms.TextBox();
            this.textBoxDailyIncrease = new System.Windows.Forms.TextBox();
            this.textBoxDaysToMultiply = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPopulation
            // 
            this.listBoxPopulation.FormattingEnabled = true;
            this.listBoxPopulation.ItemHeight = 20;
            this.listBoxPopulation.Location = new System.Drawing.Point(499, 48);
            this.listBoxPopulation.Name = "listBoxPopulation";
            this.listBoxPopulation.Size = new System.Drawing.Size(586, 344);
            this.listBoxPopulation.TabIndex = 0;
            // 
            // labelStartingOrganism
            // 
            this.labelStartingOrganism.Location = new System.Drawing.Point(76, 71);
            this.labelStartingOrganism.Name = "labelStartingOrganism";
            this.labelStartingOrganism.Size = new System.Drawing.Size(232, 25);
            this.labelStartingOrganism.TabIndex = 1;
            this.labelStartingOrganism.Text = "Starting Number of Organisms: ";
            // 
            // labelDailyIncrease
            // 
            this.labelDailyIncrease.Location = new System.Drawing.Point(76, 126);
            this.labelDailyIncrease.Name = "labelDailyIncrease";
            this.labelDailyIncrease.Size = new System.Drawing.Size(232, 25);
            this.labelDailyIncrease.TabIndex = 2;
            this.labelDailyIncrease.Text = "Average Daily Increase: ";
            // 
            // labelDaysToMultiply
            // 
            this.labelDaysToMultiply.Location = new System.Drawing.Point(76, 184);
            this.labelDaysToMultiply.Name = "labelDaysToMultiply";
            this.labelDaysToMultiply.Size = new System.Drawing.Size(232, 25);
            this.labelDaysToMultiply.TabIndex = 3;
            this.labelDaysToMultiply.Text = "Number of Days to Multiply:";
            // 
            // textBoxStartingOrganisms
            // 
            this.textBoxStartingOrganisms.Location = new System.Drawing.Point(324, 71);
            this.textBoxStartingOrganisms.Name = "textBoxStartingOrganisms";
            this.textBoxStartingOrganisms.Size = new System.Drawing.Size(118, 26);
            this.textBoxStartingOrganisms.TabIndex = 4;
            // 
            // textBoxDailyIncrease
            // 
            this.textBoxDailyIncrease.Location = new System.Drawing.Point(324, 126);
            this.textBoxDailyIncrease.Name = "textBoxDailyIncrease";
            this.textBoxDailyIncrease.Size = new System.Drawing.Size(118, 26);
            this.textBoxDailyIncrease.TabIndex = 5;
            // 
            // textBoxDaysToMultiply
            // 
            this.textBoxDaysToMultiply.Location = new System.Drawing.Point(324, 184);
            this.textBoxDaysToMultiply.Name = "textBoxDaysToMultiply";
            this.textBoxDaysToMultiply.Size = new System.Drawing.Size(118, 26);
            this.textBoxDaysToMultiply.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(105, 275);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(143, 58);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxDaysToMultiply);
            this.Controls.Add(this.textBoxDailyIncrease);
            this.Controls.Add(this.textBoxStartingOrganisms);
            this.Controls.Add(this.labelDaysToMultiply);
            this.Controls.Add(this.labelDailyIncrease);
            this.Controls.Add(this.labelStartingOrganism);
            this.Controls.Add(this.listBoxPopulation);
            this.Name = "Form1";
            this.Text = "Casto ASG5 Population";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPopulation;
        private System.Windows.Forms.Label labelStartingOrganism;
        private System.Windows.Forms.Label labelDailyIncrease;
        private System.Windows.Forms.Label labelDaysToMultiply;
        private System.Windows.Forms.TextBox textBoxStartingOrganisms;
        private System.Windows.Forms.TextBox textBoxDailyIncrease;
        private System.Windows.Forms.TextBox textBoxDaysToMultiply;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

