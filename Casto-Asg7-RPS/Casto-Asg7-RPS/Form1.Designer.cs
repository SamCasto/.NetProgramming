
namespace Casto_Asg7_RPS
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
            this.groupBoxDisplayChoices = new System.Windows.Forms.GroupBox();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.labelTextPlayersChoice = new System.Windows.Forms.Label();
            this.labelTextCompChoice = new System.Windows.Forms.Label();
            this.labelTextWinner = new System.Windows.Forms.Label();
            this.labelPlayersChoice = new System.Windows.Forms.Label();
            this.labelCompChoice = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelTextTotalGames = new System.Windows.Forms.Label();
            this.labelTextPlayersWins = new System.Windows.Forms.Label();
            this.labelTextCompWins = new System.Windows.Forms.Label();
            this.labelTextTotalTies = new System.Windows.Forms.Label();
            this.labelTotalGames = new System.Windows.Forms.Label();
            this.labelPlayerWins = new System.Windows.Forms.Label();
            this.labelCompWins = new System.Windows.Forms.Label();
            this.labelTotalTies = new System.Windows.Forms.Label();
            this.buttonResetTotals = new System.Windows.Forms.Button();
            this.groupBoxDisplayChoices.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDisplayChoices
            // 
            this.groupBoxDisplayChoices.Controls.Add(this.labelWinner);
            this.groupBoxDisplayChoices.Controls.Add(this.labelCompChoice);
            this.groupBoxDisplayChoices.Controls.Add(this.labelPlayersChoice);
            this.groupBoxDisplayChoices.Controls.Add(this.labelTextWinner);
            this.groupBoxDisplayChoices.Controls.Add(this.labelTextCompChoice);
            this.groupBoxDisplayChoices.Controls.Add(this.labelTextPlayersChoice);
            this.groupBoxDisplayChoices.Location = new System.Drawing.Point(28, 34);
            this.groupBoxDisplayChoices.Name = "groupBoxDisplayChoices";
            this.groupBoxDisplayChoices.Size = new System.Drawing.Size(369, 281);
            this.groupBoxDisplayChoices.TabIndex = 0;
            this.groupBoxDisplayChoices.TabStop = false;
            this.groupBoxDisplayChoices.Text = "Play Game:";
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.Controls.Add(this.labelTotalTies);
            this.groupBoxTotals.Controls.Add(this.labelCompWins);
            this.groupBoxTotals.Controls.Add(this.labelPlayerWins);
            this.groupBoxTotals.Controls.Add(this.labelTotalGames);
            this.groupBoxTotals.Controls.Add(this.labelTextTotalTies);
            this.groupBoxTotals.Controls.Add(this.labelTextCompWins);
            this.groupBoxTotals.Controls.Add(this.labelTextPlayersWins);
            this.groupBoxTotals.Controls.Add(this.labelTextTotalGames);
            this.groupBoxTotals.Location = new System.Drawing.Point(499, 34);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(289, 281);
            this.groupBoxTotals.TabIndex = 1;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Totals:";
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(117, 348);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(101, 61);
            this.buttonRock.TabIndex = 2;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(296, 348);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(101, 61);
            this.buttonPaper.TabIndex = 3;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(483, 348);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(101, 61);
            this.buttonScissors.TabIndex = 4;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // labelTextPlayersChoice
            // 
            this.labelTextPlayersChoice.Location = new System.Drawing.Point(29, 32);
            this.labelTextPlayersChoice.Name = "labelTextPlayersChoice";
            this.labelTextPlayersChoice.Size = new System.Drawing.Size(161, 34);
            this.labelTextPlayersChoice.TabIndex = 0;
            this.labelTextPlayersChoice.Text = "Player\'s Choice:";
            this.labelTextPlayersChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTextCompChoice
            // 
            this.labelTextCompChoice.Location = new System.Drawing.Point(29, 78);
            this.labelTextCompChoice.Name = "labelTextCompChoice";
            this.labelTextCompChoice.Size = new System.Drawing.Size(161, 34);
            this.labelTextCompChoice.TabIndex = 1;
            this.labelTextCompChoice.Text = "Computer\'s Choice:";
            this.labelTextCompChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTextWinner
            // 
            this.labelTextWinner.Location = new System.Drawing.Point(29, 124);
            this.labelTextWinner.Name = "labelTextWinner";
            this.labelTextWinner.Size = new System.Drawing.Size(161, 34);
            this.labelTextWinner.TabIndex = 2;
            this.labelTextWinner.Text = "Winner:";
            this.labelTextWinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayersChoice
            // 
            this.labelPlayersChoice.Location = new System.Drawing.Point(196, 32);
            this.labelPlayersChoice.Name = "labelPlayersChoice";
            this.labelPlayersChoice.Size = new System.Drawing.Size(161, 34);
            this.labelPlayersChoice.TabIndex = 3;
            this.labelPlayersChoice.Text = "labelPlayersChoice";
            this.labelPlayersChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCompChoice
            // 
            this.labelCompChoice.Location = new System.Drawing.Point(196, 78);
            this.labelCompChoice.Name = "labelCompChoice";
            this.labelCompChoice.Size = new System.Drawing.Size(161, 34);
            this.labelCompChoice.TabIndex = 4;
            this.labelCompChoice.Text = "labelCompChoice";
            this.labelCompChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWinner
            // 
            this.labelWinner.Location = new System.Drawing.Point(196, 124);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(161, 34);
            this.labelWinner.TabIndex = 5;
            this.labelWinner.Text = "labelWinner";
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTextTotalGames
            // 
            this.labelTextTotalGames.AutoSize = true;
            this.labelTextTotalGames.Location = new System.Drawing.Point(42, 39);
            this.labelTextTotalGames.Name = "labelTextTotalGames";
            this.labelTextTotalGames.Size = new System.Drawing.Size(104, 20);
            this.labelTextTotalGames.TabIndex = 0;
            this.labelTextTotalGames.Text = "Total Games:";
            // 
            // labelTextPlayersWins
            // 
            this.labelTextPlayersWins.AutoSize = true;
            this.labelTextPlayersWins.Location = new System.Drawing.Point(51, 85);
            this.labelTextPlayersWins.Name = "labelTextPlayersWins";
            this.labelTextPlayersWins.Size = new System.Drawing.Size(95, 20);
            this.labelTextPlayersWins.TabIndex = 1;
            this.labelTextPlayersWins.Text = "Player Wins:";
            // 
            // labelTextCompWins
            // 
            this.labelTextCompWins.AutoSize = true;
            this.labelTextCompWins.Location = new System.Drawing.Point(24, 131);
            this.labelTextCompWins.Name = "labelTextCompWins";
            this.labelTextCompWins.Size = new System.Drawing.Size(122, 20);
            this.labelTextCompWins.TabIndex = 2;
            this.labelTextCompWins.Text = "Computer Wins:";
            // 
            // labelTextTotalTies
            // 
            this.labelTextTotalTies.AutoSize = true;
            this.labelTextTotalTies.Location = new System.Drawing.Point(65, 178);
            this.labelTextTotalTies.Name = "labelTextTotalTies";
            this.labelTextTotalTies.Size = new System.Drawing.Size(81, 20);
            this.labelTextTotalTies.TabIndex = 3;
            this.labelTextTotalTies.Text = "Total Ties:";
            // 
            // labelTotalGames
            // 
            this.labelTotalGames.AutoSize = true;
            this.labelTotalGames.Location = new System.Drawing.Point(152, 39);
            this.labelTotalGames.Name = "labelTotalGames";
            this.labelTotalGames.Size = new System.Drawing.Size(129, 20);
            this.labelTotalGames.TabIndex = 4;
            this.labelTotalGames.Text = "labelTotalGames";
            // 
            // labelPlayerWins
            // 
            this.labelPlayerWins.AutoSize = true;
            this.labelPlayerWins.Location = new System.Drawing.Point(152, 85);
            this.labelPlayerWins.Name = "labelPlayerWins";
            this.labelPlayerWins.Size = new System.Drawing.Size(120, 20);
            this.labelPlayerWins.TabIndex = 5;
            this.labelPlayerWins.Text = "labelPlayerWins";
            // 
            // labelCompWins
            // 
            this.labelCompWins.AutoSize = true;
            this.labelCompWins.Location = new System.Drawing.Point(152, 131);
            this.labelCompWins.Name = "labelCompWins";
            this.labelCompWins.Size = new System.Drawing.Size(119, 20);
            this.labelCompWins.TabIndex = 6;
            this.labelCompWins.Text = "labelCompWins";
            // 
            // labelTotalTies
            // 
            this.labelTotalTies.AutoSize = true;
            this.labelTotalTies.Location = new System.Drawing.Point(152, 178);
            this.labelTotalTies.Name = "labelTotalTies";
            this.labelTotalTies.Size = new System.Drawing.Size(106, 20);
            this.labelTotalTies.TabIndex = 7;
            this.labelTotalTies.Text = "labelTotalTies";
            // 
            // buttonResetTotals
            // 
            this.buttonResetTotals.Location = new System.Drawing.Point(655, 348);
            this.buttonResetTotals.Name = "buttonResetTotals";
            this.buttonResetTotals.Size = new System.Drawing.Size(101, 61);
            this.buttonResetTotals.TabIndex = 5;
            this.buttonResetTotals.Text = "Reset Totals";
            this.buttonResetTotals.UseVisualStyleBackColor = true;
            this.buttonResetTotals.Click += new System.EventHandler(this.buttonResetTotals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResetTotals);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.groupBoxTotals);
            this.Controls.Add(this.groupBoxDisplayChoices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDisplayChoices.ResumeLayout(false);
            this.groupBoxTotals.ResumeLayout(false);
            this.groupBoxTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDisplayChoices;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Label labelTextCompChoice;
        private System.Windows.Forms.Label labelTextPlayersChoice;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label labelCompChoice;
        private System.Windows.Forms.Label labelPlayersChoice;
        private System.Windows.Forms.Label labelTextWinner;
        private System.Windows.Forms.Label labelTextTotalTies;
        private System.Windows.Forms.Label labelTextCompWins;
        private System.Windows.Forms.Label labelTextPlayersWins;
        private System.Windows.Forms.Label labelTextTotalGames;
        private System.Windows.Forms.Label labelTotalGames;
        private System.Windows.Forms.Label labelTotalTies;
        private System.Windows.Forms.Label labelCompWins;
        private System.Windows.Forms.Label labelPlayerWins;
        private System.Windows.Forms.Button buttonResetTotals;
    }
}

