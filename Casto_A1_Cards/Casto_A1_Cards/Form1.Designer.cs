
namespace Casto_A1_Cards
{
    partial class cardIdentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardIdentifier));
            this.diamondKing = new System.Windows.Forms.PictureBox();
            this.spadeAce = new System.Windows.Forms.PictureBox();
            this.diamondSeven = new System.Windows.Forms.PictureBox();
            this.clubThree = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.heartNine = new System.Windows.Forms.PictureBox();
            this.titleInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diamondKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadeAce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartNine)).BeginInit();
            this.SuspendLayout();
            // 
            // diamondKing
            // 
            this.diamondKing.Image = ((System.Drawing.Image)(resources.GetObject("diamondKing.Image")));
            this.diamondKing.Location = new System.Drawing.Point(12, 25);
            this.diamondKing.Name = "diamondKing";
            this.diamondKing.Size = new System.Drawing.Size(120, 260);
            this.diamondKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diamondKing.TabIndex = 0;
            this.diamondKing.TabStop = false;
            this.diamondKing.Click += new System.EventHandler(this.diamondKing_Click);
            // 
            // spadeAce
            // 
            this.spadeAce.Image = ((System.Drawing.Image)(resources.GetObject("spadeAce.Image")));
            this.spadeAce.Location = new System.Drawing.Point(174, 25);
            this.spadeAce.Name = "spadeAce";
            this.spadeAce.Size = new System.Drawing.Size(120, 260);
            this.spadeAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spadeAce.TabIndex = 1;
            this.spadeAce.TabStop = false;
            this.spadeAce.Click += new System.EventHandler(this.spadeAce_Click);
            // 
            // diamondSeven
            // 
            this.diamondSeven.Image = ((System.Drawing.Image)(resources.GetObject("diamondSeven.Image")));
            this.diamondSeven.Location = new System.Drawing.Point(652, 25);
            this.diamondSeven.Name = "diamondSeven";
            this.diamondSeven.Size = new System.Drawing.Size(120, 260);
            this.diamondSeven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diamondSeven.TabIndex = 2;
            this.diamondSeven.TabStop = false;
            this.diamondSeven.Click += new System.EventHandler(this.diamondSeven_Click);
            // 
            // clubThree
            // 
            this.clubThree.Image = ((System.Drawing.Image)(resources.GetObject("clubThree.Image")));
            this.clubThree.Location = new System.Drawing.Point(326, 25);
            this.clubThree.Name = "clubThree";
            this.clubThree.Size = new System.Drawing.Size(120, 260);
            this.clubThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clubThree.TabIndex = 4;
            this.clubThree.TabStop = false;
            this.clubThree.Click += new System.EventHandler(this.clubThree_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(323, 401);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cardNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameLabel.Location = new System.Drawing.Point(174, 324);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(431, 54);
            this.cardNameLabel.TabIndex = 6;
            this.cardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heartNine
            // 
            this.heartNine.Image = ((System.Drawing.Image)(resources.GetObject("heartNine.Image")));
            this.heartNine.Location = new System.Drawing.Point(485, 25);
            this.heartNine.Name = "heartNine";
            this.heartNine.Size = new System.Drawing.Size(120, 260);
            this.heartNine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heartNine.TabIndex = 7;
            this.heartNine.TabStop = false;
            this.heartNine.Click += new System.EventHandler(this.heartNine_Click);
            // 
            // titleInstructions
            // 
            this.titleInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInstructions.Location = new System.Drawing.Point(187, 9);
            this.titleInstructions.Name = "titleInstructions";
            this.titleInstructions.Size = new System.Drawing.Size(404, 48);
            this.titleInstructions.TabIndex = 8;
            this.titleInstructions.Text = "Click a Card to See Its Name";
            this.titleInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.titleInstructions);
            this.Controls.Add(this.heartNine);
            this.Controls.Add(this.cardNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clubThree);
            this.Controls.Add(this.diamondSeven);
            this.Controls.Add(this.spadeAce);
            this.Controls.Add(this.diamondKing);
            this.Name = "cardIdentifier";
            this.Text = "Card Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diamondKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadeAce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartNine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox diamondKing;
        private System.Windows.Forms.PictureBox spadeAce;
        private System.Windows.Forms.PictureBox diamondSeven;
        private System.Windows.Forms.PictureBox clubThree;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.PictureBox heartNine;
        private System.Windows.Forms.Label titleInstructions;
    }
}

