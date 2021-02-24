
namespace Casto_Asg11_Structures
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
            this.groupBoxCourses = new System.Windows.Forms.GroupBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxDisplayNumber = new System.Windows.Forms.TextBox();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.textBoxDisplayCredits = new System.Windows.Forms.TextBox();
            this.textBoxDisplayGrade = new System.Windows.Forms.TextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCourses
            // 
            this.groupBoxCourses.Controls.Add(this.textBoxDisplayGrade);
            this.groupBoxCourses.Controls.Add(this.textBoxDisplayCredits);
            this.groupBoxCourses.Controls.Add(this.textBoxDisplayName);
            this.groupBoxCourses.Controls.Add(this.textBoxDisplayNumber);
            this.groupBoxCourses.Controls.Add(this.labelGrade);
            this.groupBoxCourses.Controls.Add(this.labelCredits);
            this.groupBoxCourses.Controls.Add(this.labelName);
            this.groupBoxCourses.Controls.Add(this.labelNumber);
            this.groupBoxCourses.Location = new System.Drawing.Point(73, 47);
            this.groupBoxCourses.Name = "groupBoxCourses";
            this.groupBoxCourses.Size = new System.Drawing.Size(665, 318);
            this.groupBoxCourses.TabIndex = 0;
            this.groupBoxCourses.TabStop = false;
            this.groupBoxCourses.Text = "WITC Courses";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(51, 87);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(124, 20);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Course Number:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 149);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Course Name:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(60, 209);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(115, 20);
            this.labelCredits.TabIndex = 2;
            this.labelCredits.Text = "Credit Number:";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(117, 277);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(58, 20);
            this.labelGrade.TabIndex = 3;
            this.labelGrade.Text = "Grade:";
            // 
            // textBoxDisplayNumber
            // 
            this.textBoxDisplayNumber.Location = new System.Drawing.Point(203, 81);
            this.textBoxDisplayNumber.Name = "textBoxDisplayNumber";
            this.textBoxDisplayNumber.Size = new System.Drawing.Size(330, 26);
            this.textBoxDisplayNumber.TabIndex = 4;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(203, 146);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(330, 26);
            this.textBoxDisplayName.TabIndex = 5;
            // 
            // textBoxDisplayCredits
            // 
            this.textBoxDisplayCredits.Location = new System.Drawing.Point(203, 203);
            this.textBoxDisplayCredits.Name = "textBoxDisplayCredits";
            this.textBoxDisplayCredits.Size = new System.Drawing.Size(70, 26);
            this.textBoxDisplayCredits.TabIndex = 6;
            // 
            // textBoxDisplayGrade
            // 
            this.textBoxDisplayGrade.Location = new System.Drawing.Point(203, 274);
            this.textBoxDisplayGrade.Name = "textBoxDisplayGrade";
            this.textBoxDisplayGrade.Size = new System.Drawing.Size(70, 26);
            this.textBoxDisplayGrade.TabIndex = 7;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(90, 385);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(130, 47);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "< Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(311, 385);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(130, 47);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(544, 385);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 47);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.groupBoxCourses);
            this.Name = "Form1";
            this.Text = "Sam Casto Asg 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCourses.ResumeLayout(false);
            this.groupBoxCourses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCourses;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxDisplayCredits;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.TextBox textBoxDisplayNumber;
        private System.Windows.Forms.TextBox textBoxDisplayGrade;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
    }
}

