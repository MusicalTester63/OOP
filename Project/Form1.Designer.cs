namespace Project
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
            this.baseTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.panelAllFiles = new System.Windows.Forms.Panel();
            this.textBoxAllFiles = new System.Windows.Forms.TextBox();
            this.labelAllFiles = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelWordCountNumber = new System.Windows.Forms.Panel();
            this.labelWords = new System.Windows.Forms.Label();
            this.numericUpDownWords = new System.Windows.Forms.NumericUpDown();
            this.textBoxSelectedFiles = new System.Windows.Forms.TextBox();
            this.panelSelectFile = new System.Windows.Forms.Panel();
            this.labelFileSelection = new System.Windows.Forms.Label();
            this.fileSelection = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.baseTableLayout.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.panelAllFiles.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelWordCountNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWords)).BeginInit();
            this.panelSelectFile.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTableLayout
            // 
            this.baseTableLayout.ColumnCount = 2;
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.baseTableLayout.Controls.Add(this.panelFiles, 0, 0);
            this.baseTableLayout.Controls.Add(this.panelAllFiles, 1, 1);
            this.baseTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.baseTableLayout.Controls.Add(this.flowLayoutPanelButtons, 0, 2);
            this.baseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTableLayout.Location = new System.Drawing.Point(0, 0);
            this.baseTableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baseTableLayout.Name = "baseTableLayout";
            this.baseTableLayout.Padding = new System.Windows.Forms.Padding(5);
            this.baseTableLayout.RowCount = 3;
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.baseTableLayout.Size = new System.Drawing.Size(1540, 489);
            this.baseTableLayout.TabIndex = 0;
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.groupBoxFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(5, 5);
            this.panelFiles.Margin = new System.Windows.Forms.Padding(0);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Padding = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.baseTableLayout.SetRowSpan(this.panelFiles, 2);
            this.panelFiles.Size = new System.Drawing.Size(459, 414);
            this.panelFiles.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.checkedListBoxFiles);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(11, 10);
            this.groupBoxFiles.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiles.Size = new System.Drawing.Size(437, 404);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files:";
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFiles.CheckOnClick = true;
            this.checkedListBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(15, 30);
            this.checkedListBoxFiles.Margin = new System.Windows.Forms.Padding(15);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(407, 359);
            this.checkedListBoxFiles.TabIndex = 0;
            this.checkedListBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFiles_SelectedIndexChanged);
            // 
            // panelAllFiles
            // 
            this.panelAllFiles.Controls.Add(this.textBoxAllFiles);
            this.panelAllFiles.Controls.Add(this.labelAllFiles);
            this.panelAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllFiles.Location = new System.Drawing.Point(464, 212);
            this.panelAllFiles.Margin = new System.Windows.Forms.Padding(0);
            this.panelAllFiles.Name = "panelAllFiles";
            this.panelAllFiles.Size = new System.Drawing.Size(1071, 207);
            this.panelAllFiles.TabIndex = 4;
            // 
            // textBoxAllFiles
            // 
            this.textBoxAllFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAllFiles.Location = new System.Drawing.Point(0, 16);
            this.textBoxAllFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAllFiles.Multiline = true;
            this.textBoxAllFiles.Name = "textBoxAllFiles";
            this.textBoxAllFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllFiles.Size = new System.Drawing.Size(1071, 191);
            this.textBoxAllFiles.TabIndex = 2;
            // 
            // labelAllFiles
            // 
            this.labelAllFiles.AutoSize = true;
            this.labelAllFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAllFiles.Location = new System.Drawing.Point(0, 0);
            this.labelAllFiles.Name = "labelAllFiles";
            this.labelAllFiles.Size = new System.Drawing.Size(52, 16);
            this.labelAllFiles.TabIndex = 0;
            this.labelAllFiles.Text = "All files:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelWordCountNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSelectedFiles, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelSelectFile, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(467, 7);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1065, 203);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panelWordCountNumber
            // 
            this.panelWordCountNumber.Controls.Add(this.labelWords);
            this.panelWordCountNumber.Controls.Add(this.numericUpDownWords);
            this.panelWordCountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWordCountNumber.Location = new System.Drawing.Point(532, 0);
            this.panelWordCountNumber.Margin = new System.Windows.Forms.Padding(0);
            this.panelWordCountNumber.Name = "panelWordCountNumber";
            this.panelWordCountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelWordCountNumber.Size = new System.Drawing.Size(533, 50);
            this.panelWordCountNumber.TabIndex = 6;
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.BackColor = System.Drawing.Color.Transparent;
            this.labelWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWords.Location = new System.Drawing.Point(0, 0);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(196, 15);
            this.labelWords.TabIndex = 2;
            this.labelWords.Text = "Word count(Longest and Shortest):";
            // 
            // numericUpDownWords
            // 
            this.numericUpDownWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownWords.Location = new System.Drawing.Point(0, 26);
            this.numericUpDownWords.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownWords.Name = "numericUpDownWords";
            this.numericUpDownWords.Size = new System.Drawing.Size(533, 22);
            this.numericUpDownWords.TabIndex = 1;
            this.numericUpDownWords.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWords.ValueChanged += new System.EventHandler(this.numericUpDownWords_ValueChanged);
            // 
            // textBoxSelectedFiles
            // 
            this.textBoxSelectedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxSelectedFiles, 2);
            this.textBoxSelectedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSelectedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedFiles.Location = new System.Drawing.Point(3, 52);
            this.textBoxSelectedFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSelectedFiles.Multiline = true;
            this.textBoxSelectedFiles.Name = "textBoxSelectedFiles";
            this.textBoxSelectedFiles.ReadOnly = true;
            this.textBoxSelectedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSelectedFiles.Size = new System.Drawing.Size(1059, 149);
            this.textBoxSelectedFiles.TabIndex = 2;
            // 
            // panelSelectFile
            // 
            this.panelSelectFile.Controls.Add(this.labelFileSelection);
            this.panelSelectFile.Controls.Add(this.fileSelection);
            this.panelSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectFile.Location = new System.Drawing.Point(0, 0);
            this.panelSelectFile.Margin = new System.Windows.Forms.Padding(0);
            this.panelSelectFile.Name = "panelSelectFile";
            this.panelSelectFile.Size = new System.Drawing.Size(532, 50);
            this.panelSelectFile.TabIndex = 3;
            // 
            // labelFileSelection
            // 
            this.labelFileSelection.AutoSize = true;
            this.labelFileSelection.BackColor = System.Drawing.Color.Transparent;
            this.labelFileSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFileSelection.Location = new System.Drawing.Point(0, 0);
            this.labelFileSelection.Name = "labelFileSelection";
            this.labelFileSelection.Size = new System.Drawing.Size(79, 16);
            this.labelFileSelection.TabIndex = 2;
            this.labelFileSelection.Text = "Select a file:";
            // 
            // fileSelection
            // 
            this.fileSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileSelection.FormattingEnabled = true;
            this.fileSelection.Location = new System.Drawing.Point(0, 26);
            this.fileSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileSelection.Name = "fileSelection";
            this.fileSelection.Size = new System.Drawing.Size(532, 24);
            this.fileSelection.TabIndex = 1;
            this.fileSelection.SelectedIndexChanged += new System.EventHandler(this.fileSelection_SelectedIndexChanged);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseTableLayout.SetColumnSpan(this.flowLayoutPanelButtons, 2);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAnalyze);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAddFile);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(5, 419);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(1530, 65);
            this.flowLayoutPanelButtons.TabIndex = 2;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnalyze.AutoSize = true;
            this.buttonAnalyze.Enabled = false;
            this.buttonAnalyze.Location = new System.Drawing.Point(1410, 12);
            this.buttonAnalyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(95, 32);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Visible = false;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFile.AutoSize = true;
            this.buttonAddFile.Location = new System.Drawing.Point(1309, 12);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(95, 32);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Add file";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt|All|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 489);
            this.Controls.Add(this.baseTableLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.baseTableLayout.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.panelAllFiles.ResumeLayout(false);
            this.panelAllFiles.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelWordCountNumber.ResumeLayout(false);
            this.panelWordCountNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWords)).EndInit();
            this.panelSelectFile.ResumeLayout(false);
            this.panelSelectFile.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseTableLayout;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Panel panelAllFiles;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label labelAllFiles;
        private System.Windows.Forms.TextBox textBoxAllFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelWordCountNumber;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.NumericUpDown numericUpDownWords;
        private System.Windows.Forms.Panel panelSelectFile;
        private System.Windows.Forms.Label labelFileSelection;
        private System.Windows.Forms.ComboBox fileSelection;
        private System.Windows.Forms.TextBox textBoxSelectedFiles;
    }
}

