
namespace Casto_Asg9_SP
{
    partial class frmTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextEditor));
            this.groupBoxAddText = new System.Windows.Forms.GroupBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.textBoxInputEnd = new System.Windows.Forms.TextBox();
            this.textBoxInputBeginning = new System.Windows.Forms.TextBox();
            this.labelEnding = new System.Windows.Forms.Label();
            this.labelBeginning = new System.Windows.Forms.Label();
            this.groupBoxSearchAndReplace = new System.Windows.Forms.GroupBox();
            this.groupBoxSpecialChars = new System.Windows.Forms.GroupBox();
            this.buttonCLRF = new System.Windows.Forms.Button();
            this.buttonTab = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.groupBoxMatching = new System.Windows.Forms.GroupBox();
            this.checkBoxNotMatching = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.groupBoxUndoRedo = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.checkBoxNoDupes = new System.Windows.Forms.CheckBox();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonAsc = new System.Windows.Forms.Button();
            this.groupBoxSQL = new System.Windows.Forms.GroupBox();
            this.buttonSQLNoQuotes = new System.Windows.Forms.Button();
            this.buttonSQLQuotes = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddFind = new System.Windows.Forms.TabPage();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageSortSql = new System.Windows.Forms.TabPage();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxInputRemove = new System.Windows.Forms.TextBox();
            this.checkBoxRemoveAfter = new System.Windows.Forms.CheckBox();
            this.groupBoxAddText.SuspendLayout();
            this.groupBoxSearchAndReplace.SuspendLayout();
            this.groupBoxSpecialChars.SuspendLayout();
            this.groupBoxMatching.SuspendLayout();
            this.groupBoxUndoRedo.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxSQL.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAddFind.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageSortSql.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddText
            // 
            this.groupBoxAddText.Controls.Add(this.buttonAddText);
            this.groupBoxAddText.Controls.Add(this.textBoxInputEnd);
            this.groupBoxAddText.Controls.Add(this.textBoxInputBeginning);
            this.groupBoxAddText.Controls.Add(this.labelEnding);
            this.groupBoxAddText.Controls.Add(this.labelBeginning);
            this.groupBoxAddText.Location = new System.Drawing.Point(3, 6);
            this.groupBoxAddText.Name = "groupBoxAddText";
            this.groupBoxAddText.Size = new System.Drawing.Size(665, 143);
            this.groupBoxAddText.TabIndex = 0;
            this.groupBoxAddText.TabStop = false;
            this.groupBoxAddText.Text = "Add to Beginning/ End of each line";
            // 
            // buttonAddText
            // 
            this.buttonAddText.Location = new System.Drawing.Point(536, 41);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(113, 66);
            this.buttonAddText.TabIndex = 4;
            this.buttonAddText.Text = "Add Text";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // textBoxInputEnd
            // 
            this.textBoxInputEnd.Location = new System.Drawing.Point(127, 81);
            this.textBoxInputEnd.Name = "textBoxInputEnd";
            this.textBoxInputEnd.Size = new System.Drawing.Size(385, 26);
            this.textBoxInputEnd.TabIndex = 3;
            this.textBoxInputEnd.Text = "End";
            // 
            // textBoxInputBeginning
            // 
            this.textBoxInputBeginning.Location = new System.Drawing.Point(127, 38);
            this.textBoxInputBeginning.Name = "textBoxInputBeginning";
            this.textBoxInputBeginning.Size = new System.Drawing.Size(385, 26);
            this.textBoxInputBeginning.TabIndex = 2;
            this.textBoxInputBeginning.Text = "Beg";
            // 
            // labelEnding
            // 
            this.labelEnding.Location = new System.Drawing.Point(27, 84);
            this.labelEnding.Name = "labelEnding";
            this.labelEnding.Size = new System.Drawing.Size(94, 28);
            this.labelEnding.TabIndex = 1;
            this.labelEnding.Text = "End:";
            // 
            // labelBeginning
            // 
            this.labelBeginning.Location = new System.Drawing.Point(27, 41);
            this.labelBeginning.Name = "labelBeginning";
            this.labelBeginning.Size = new System.Drawing.Size(94, 28);
            this.labelBeginning.TabIndex = 0;
            this.labelBeginning.Text = "Beginning:";
            // 
            // groupBoxSearchAndReplace
            // 
            this.groupBoxSearchAndReplace.Controls.Add(this.groupBoxSpecialChars);
            this.groupBoxSearchAndReplace.Controls.Add(this.buttonReplace);
            this.groupBoxSearchAndReplace.Controls.Add(this.textBoxReplace);
            this.groupBoxSearchAndReplace.Controls.Add(this.textBoxSearch);
            this.groupBoxSearchAndReplace.Controls.Add(this.labelReplace);
            this.groupBoxSearchAndReplace.Controls.Add(this.labelSearch);
            this.groupBoxSearchAndReplace.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchAndReplace.Name = "groupBoxSearchAndReplace";
            this.groupBoxSearchAndReplace.Size = new System.Drawing.Size(665, 292);
            this.groupBoxSearchAndReplace.TabIndex = 5;
            this.groupBoxSearchAndReplace.TabStop = false;
            this.groupBoxSearchAndReplace.Text = "Search and Replace:";
            // 
            // groupBoxSpecialChars
            // 
            this.groupBoxSpecialChars.Controls.Add(this.buttonCLRF);
            this.groupBoxSpecialChars.Controls.Add(this.buttonTab);
            this.groupBoxSpecialChars.Location = new System.Drawing.Point(31, 142);
            this.groupBoxSpecialChars.Name = "groupBoxSpecialChars";
            this.groupBoxSpecialChars.Size = new System.Drawing.Size(618, 100);
            this.groupBoxSpecialChars.TabIndex = 5;
            this.groupBoxSpecialChars.TabStop = false;
            this.groupBoxSpecialChars.Text = "Copy these special chars to the clipboard for copy/paste";
            // 
            // buttonCLRF
            // 
            this.buttonCLRF.Location = new System.Drawing.Point(286, 30);
            this.buttonCLRF.Name = "buttonCLRF";
            this.buttonCLRF.Size = new System.Drawing.Size(107, 54);
            this.buttonCLRF.TabIndex = 1;
            this.buttonCLRF.Text = "[CLRF]";
            this.buttonCLRF.UseVisualStyleBackColor = true;
            this.buttonCLRF.Click += new System.EventHandler(this.buttonCLRF_Click);
            // 
            // buttonTab
            // 
            this.buttonTab.Location = new System.Drawing.Point(83, 30);
            this.buttonTab.Name = "buttonTab";
            this.buttonTab.Size = new System.Drawing.Size(107, 54);
            this.buttonTab.TabIndex = 0;
            this.buttonTab.Text = "[TAB]";
            this.buttonTab.UseVisualStyleBackColor = true;
            this.buttonTab.Click += new System.EventHandler(this.buttonTab_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(536, 41);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(113, 66);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(127, 81);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(385, 26);
            this.textBoxReplace.TabIndex = 3;
            this.textBoxReplace.Text = "Replace";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(127, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(385, 26);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Search";
            // 
            // labelReplace
            // 
            this.labelReplace.Location = new System.Drawing.Point(27, 84);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(94, 28);
            this.labelReplace.TabIndex = 1;
            this.labelReplace.Text = "Replace:";
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(27, 41);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(94, 28);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // groupBoxMatching
            // 
            this.groupBoxMatching.Controls.Add(this.checkBoxNotMatching);
            this.groupBoxMatching.Controls.Add(this.buttonFind);
            this.groupBoxMatching.Controls.Add(this.textBoxFind);
            this.groupBoxMatching.Controls.Add(this.labelFind);
            this.groupBoxMatching.Location = new System.Drawing.Point(674, 11);
            this.groupBoxMatching.Name = "groupBoxMatching";
            this.groupBoxMatching.Size = new System.Drawing.Size(605, 138);
            this.groupBoxMatching.TabIndex = 6;
            this.groupBoxMatching.TabStop = false;
            this.groupBoxMatching.Text = "Find Lines Matching or Not Matching:";
            // 
            // checkBoxNotMatching
            // 
            this.checkBoxNotMatching.AutoSize = true;
            this.checkBoxNotMatching.Location = new System.Drawing.Point(127, 83);
            this.checkBoxNotMatching.Name = "checkBoxNotMatching";
            this.checkBoxNotMatching.Size = new System.Drawing.Size(160, 24);
            this.checkBoxNotMatching.TabIndex = 5;
            this.checkBoxNotMatching.Text = "Exclude Matching";
            this.checkBoxNotMatching.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(455, 36);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(113, 66);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(127, 38);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(282, 26);
            this.textBoxFind.TabIndex = 2;
            this.textBoxFind.Text = "Line";
            // 
            // labelFind
            // 
            this.labelFind.Location = new System.Drawing.Point(27, 41);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(94, 28);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "Find:";
            // 
            // groupBoxUndoRedo
            // 
            this.groupBoxUndoRedo.Controls.Add(this.buttonClear);
            this.groupBoxUndoRedo.Controls.Add(this.buttonUndo);
            this.groupBoxUndoRedo.Controls.Add(this.buttonRedo);
            this.groupBoxUndoRedo.Location = new System.Drawing.Point(1354, 24);
            this.groupBoxUndoRedo.Name = "groupBoxUndoRedo";
            this.groupBoxUndoRedo.Size = new System.Drawing.Size(191, 280);
            this.groupBoxUndoRedo.TabIndex = 7;
            this.groupBoxUndoRedo.TabStop = false;
            this.groupBoxUndoRedo.Text = "Undo / Redo";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(32, 199);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 64);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(32, 113);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(132, 64);
            this.buttonUndo.TabIndex = 1;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(32, 29);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(132, 64);
            this.buttonRedo.TabIndex = 0;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.checkBoxNoDupes);
            this.groupBoxSort.Controls.Add(this.buttonDesc);
            this.groupBoxSort.Controls.Add(this.buttonAsc);
            this.groupBoxSort.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(191, 224);
            this.groupBoxSort.TabIndex = 8;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort Results:";
            // 
            // checkBoxNoDupes
            // 
            this.checkBoxNoDupes.AutoSize = true;
            this.checkBoxNoDupes.Location = new System.Drawing.Point(44, 183);
            this.checkBoxNoDupes.Name = "checkBoxNoDupes";
            this.checkBoxNoDupes.Size = new System.Drawing.Size(106, 24);
            this.checkBoxNoDupes.TabIndex = 2;
            this.checkBoxNoDupes.Text = "No Dupes";
            this.checkBoxNoDupes.UseVisualStyleBackColor = true;
            // 
            // buttonDesc
            // 
            this.buttonDesc.Location = new System.Drawing.Point(32, 113);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(132, 64);
            this.buttonDesc.TabIndex = 1;
            this.buttonDesc.Text = "Descending";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonAsc
            // 
            this.buttonAsc.Location = new System.Drawing.Point(32, 29);
            this.buttonAsc.Name = "buttonAsc";
            this.buttonAsc.Size = new System.Drawing.Size(132, 64);
            this.buttonAsc.TabIndex = 0;
            this.buttonAsc.Text = "Ascending";
            this.buttonAsc.UseVisualStyleBackColor = true;
            this.buttonAsc.Click += new System.EventHandler(this.buttonAsc_Click);
            // 
            // groupBoxSQL
            // 
            this.groupBoxSQL.Controls.Add(this.buttonSQLNoQuotes);
            this.groupBoxSQL.Controls.Add(this.buttonSQLQuotes);
            this.groupBoxSQL.Location = new System.Drawing.Point(200, 3);
            this.groupBoxSQL.Name = "groupBoxSQL";
            this.groupBoxSQL.Size = new System.Drawing.Size(191, 224);
            this.groupBoxSQL.TabIndex = 9;
            this.groupBoxSQL.TabStop = false;
            this.groupBoxSQL.Text = "Make SQL IN:";
            // 
            // buttonSQLNoQuotes
            // 
            this.buttonSQLNoQuotes.Location = new System.Drawing.Point(32, 113);
            this.buttonSQLNoQuotes.Name = "buttonSQLNoQuotes";
            this.buttonSQLNoQuotes.Size = new System.Drawing.Size(132, 64);
            this.buttonSQLNoQuotes.TabIndex = 1;
            this.buttonSQLNoQuotes.Text = "No Quotes";
            this.buttonSQLNoQuotes.UseVisualStyleBackColor = true;
            this.buttonSQLNoQuotes.Click += new System.EventHandler(this.buttonSQLNoQuotes_Click);
            // 
            // buttonSQLQuotes
            // 
            this.buttonSQLQuotes.Location = new System.Drawing.Point(32, 29);
            this.buttonSQLQuotes.Name = "buttonSQLQuotes";
            this.buttonSQLQuotes.Size = new System.Drawing.Size(132, 64);
            this.buttonSQLQuotes.TabIndex = 0;
            this.buttonSQLQuotes.Text = "With Quotes";
            this.buttonSQLQuotes.UseVisualStyleBackColor = true;
            this.buttonSQLQuotes.Click += new System.EventHandler(this.buttonSQLQuotes_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(12, 319);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(1336, 513);
            this.textBoxData.TabIndex = 10;
            this.textBoxData.Text = "aaa\r\nbbb\r\nccc\r\nddd\r\naabb\r\naacc\r\nccdd\r\nline 1\r\nline 2\r\nline 3\r\nlast line";
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(1386, 760);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(138, 64);
            this.buttonCopyToClipboard.TabIndex = 11;
            this.buttonCopyToClipboard.Text = "Copy Data to Clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddFind);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageSortSql);
            this.tabControl1.Controls.Add(this.tabPageReplace);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1336, 291);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageAddFind
            // 
            this.tabPageAddFind.Controls.Add(this.groupBoxAddText);
            this.tabPageAddFind.Controls.Add(this.groupBoxMatching);
            this.tabPageAddFind.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddFind.Name = "tabPageAddFind";
            this.tabPageAddFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddFind.Size = new System.Drawing.Size(1328, 258);
            this.tabPageAddFind.TabIndex = 0;
            this.tabPageAddFind.Text = "Add / Find";
            this.tabPageAddFind.UseVisualStyleBackColor = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBoxSearchAndReplace);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 29);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1328, 258);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search / Replace";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageSortSql
            // 
            this.tabPageSortSql.Controls.Add(this.groupBoxSort);
            this.tabPageSortSql.Controls.Add(this.groupBoxSQL);
            this.tabPageSortSql.Location = new System.Drawing.Point(4, 29);
            this.tabPageSortSql.Name = "tabPageSortSql";
            this.tabPageSortSql.Size = new System.Drawing.Size(1328, 258);
            this.tabPageSortSql.TabIndex = 2;
            this.tabPageSortSql.Text = "Sort / SQL IN";
            this.tabPageSortSql.UseVisualStyleBackColor = true;
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.groupBox1);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 29);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Size = new System.Drawing.Size(1328, 258);
            this.tabPageReplace.TabIndex = 3;
            this.tabPageReplace.Text = "Replace Special";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRemoveAfter);
            this.groupBox1.Controls.Add(this.textBoxInputRemove);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Before/After:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(390, 25);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 66);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxInputRemove
            // 
            this.textBoxInputRemove.Location = new System.Drawing.Point(128, 45);
            this.textBoxInputRemove.Name = "textBoxInputRemove";
            this.textBoxInputRemove.Size = new System.Drawing.Size(206, 26);
            this.textBoxInputRemove.TabIndex = 1;
            // 
            // checkBoxRemoveAfter
            // 
            this.checkBoxRemoveAfter.AutoSize = true;
            this.checkBoxRemoveAfter.Location = new System.Drawing.Point(156, 84);
            this.checkBoxRemoveAfter.Name = "checkBoxRemoveAfter";
            this.checkBoxRemoveAfter.Size = new System.Drawing.Size(133, 24);
            this.checkBoxRemoveAfter.TabIndex = 2;
            this.checkBoxRemoveAfter.Text = "Remove After";
            this.checkBoxRemoveAfter.UseVisualStyleBackColor = true;
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.groupBoxUndoRedo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTextEditor";
            this.Text = "Casto Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAddText.ResumeLayout(false);
            this.groupBoxAddText.PerformLayout();
            this.groupBoxSearchAndReplace.ResumeLayout(false);
            this.groupBoxSearchAndReplace.PerformLayout();
            this.groupBoxSpecialChars.ResumeLayout(false);
            this.groupBoxMatching.ResumeLayout(false);
            this.groupBoxMatching.PerformLayout();
            this.groupBoxUndoRedo.ResumeLayout(false);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxSQL.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddFind.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSortSql.ResumeLayout(false);
            this.tabPageReplace.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddText;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.TextBox textBoxInputEnd;
        private System.Windows.Forms.TextBox textBoxInputBeginning;
        private System.Windows.Forms.Label labelEnding;
        private System.Windows.Forms.Label labelBeginning;
        private System.Windows.Forms.GroupBox groupBoxSearchAndReplace;
        private System.Windows.Forms.GroupBox groupBoxSpecialChars;
        private System.Windows.Forms.Button buttonCLRF;
        private System.Windows.Forms.Button buttonTab;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.GroupBox groupBoxMatching;
        private System.Windows.Forms.CheckBox checkBoxNotMatching;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.GroupBox groupBoxUndoRedo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.CheckBox checkBoxNoDupes;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonAsc;
        private System.Windows.Forms.GroupBox groupBoxSQL;
        private System.Windows.Forms.Button buttonSQLNoQuotes;
        private System.Windows.Forms.Button buttonSQLQuotes;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddFind;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageSortSql;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRemoveAfter;
        private System.Windows.Forms.TextBox textBoxInputRemove;
        private System.Windows.Forms.Button buttonRemove;
    }
}

