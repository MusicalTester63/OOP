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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxAllFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSelection = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSelectedFiles = new System.Windows.Forms.TextBox();
            this.panelSelectFile = new System.Windows.Forms.Panel();
            this.labelFileSelection = new System.Windows.Forms.Label();
            this.panelWordCountNumber = new System.Windows.Forms.Panel();
            this.labelWords = new System.Windows.Forms.Label();
            this.numericUpDownWords = new System.Windows.Forms.NumericUpDown();
            this.baseTableLayout.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelSelectFile.SuspendLayout();
            this.panelWordCountNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWords)).BeginInit();
            this.SuspendLayout();
            // 
            // baseTableLayout
            // 
            this.baseTableLayout.ColumnCount = 2;
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.baseTableLayout.Controls.Add(this.panelFiles, 0, 0);
            this.baseTableLayout.Controls.Add(this.panel3, 1, 1);
            this.baseTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.baseTableLayout.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.baseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTableLayout.Location = new System.Drawing.Point(0, 0);
            this.baseTableLayout.Name = "baseTableLayout";
            this.baseTableLayout.RowCount = 3;
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.baseTableLayout.Size = new System.Drawing.Size(1357, 594);
            this.baseTableLayout.TabIndex = 0;
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.groupBoxFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(3, 3);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Padding = new System.Windows.Forms.Padding(10);
            this.baseTableLayout.SetRowSpan(this.panelFiles, 2);
            this.panelFiles.Size = new System.Drawing.Size(393, 452);
            this.panelFiles.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.checkedListBoxFiles);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(10, 10);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiles.Size = new System.Drawing.Size(373, 432);
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
            this.checkedListBoxFiles.Size = new System.Drawing.Size(343, 387);
            this.checkedListBoxFiles.TabIndex = 0;
            this.checkedListBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFiles_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxAllFiles);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(402, 232);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(926, 223);
            this.panel3.TabIndex = 4;
            // 
            // textBoxAllFiles
            // 
            this.textBoxAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAllFiles.Location = new System.Drawing.Point(10, 26);
            this.textBoxAllFiles.Multiline = true;
            this.textBoxAllFiles.Name = "textBoxAllFiles";
            this.textBoxAllFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllFiles.Size = new System.Drawing.Size(906, 187);
            this.textBoxAllFiles.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "All files:";
            // 
            // flowLayoutPanel1
            // 
            this.baseTableLayout.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.buttonAnalyze);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddFile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 458);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1331, 65);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnalyze.AutoSize = true;
            this.buttonAnalyze.Location = new System.Drawing.Point(1213, 13);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(95, 29);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFile.AutoSize = true;
            this.buttonAddFile.Location = new System.Drawing.Point(1112, 13);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(95, 29);
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
            // fileSelection
            // 
            this.fileSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelection.FormattingEnabled = true;
            this.fileSelection.Location = new System.Drawing.Point(3, 19);
            this.fileSelection.Name = "fileSelection";
            this.fileSelection.Size = new System.Drawing.Size(451, 24);
            this.fileSelection.TabIndex = 1;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(402, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 223);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // textBoxSelectedFiles
            // 
            this.textBoxSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxSelectedFiles, 2);
            this.textBoxSelectedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedFiles.Location = new System.Drawing.Point(3, 53);
            this.textBoxSelectedFiles.Multiline = true;
            this.textBoxSelectedFiles.Name = "textBoxSelectedFiles";
            this.textBoxSelectedFiles.ReadOnly = true;
            this.textBoxSelectedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSelectedFiles.Size = new System.Drawing.Size(920, 167);
            this.textBoxSelectedFiles.TabIndex = 2;
            // 
            // panelSelectFile
            // 
            this.panelSelectFile.Controls.Add(this.labelFileSelection);
            this.panelSelectFile.Controls.Add(this.fileSelection);
            this.panelSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectFile.Location = new System.Drawing.Point(3, 3);
            this.panelSelectFile.Name = "panelSelectFile";
            this.panelSelectFile.Size = new System.Drawing.Size(457, 44);
            this.panelSelectFile.TabIndex = 3;
            // 
            // labelFileSelection
            // 
            this.labelFileSelection.AutoSize = true;
            this.labelFileSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFileSelection.Location = new System.Drawing.Point(0, 0);
            this.labelFileSelection.Name = "labelFileSelection";
            this.labelFileSelection.Size = new System.Drawing.Size(79, 16);
            this.labelFileSelection.TabIndex = 2;
            this.labelFileSelection.Text = "Select a file:";
            // 
            // panelWordCountNumber
            // 
            this.panelWordCountNumber.Controls.Add(this.labelWords);
            this.panelWordCountNumber.Controls.Add(this.numericUpDownWords);
            this.panelWordCountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWordCountNumber.Location = new System.Drawing.Point(466, 3);
            this.panelWordCountNumber.Name = "panelWordCountNumber";
            this.panelWordCountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelWordCountNumber.Size = new System.Drawing.Size(457, 44);
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
            this.numericUpDownWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownWords.Location = new System.Drawing.Point(0, 18);
            this.numericUpDownWords.Name = "numericUpDownWords";
            this.numericUpDownWords.Size = new System.Drawing.Size(457, 22);
            this.numericUpDownWords.TabIndex = 1;
            this.numericUpDownWords.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 594);
            this.Controls.Add(this.baseTableLayout);
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.baseTableLayout.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelSelectFile.ResumeLayout(false);
            this.panelSelectFile.PerformLayout();
            this.panelWordCountNumber.ResumeLayout(false);
            this.panelWordCountNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseTableLayout;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAllFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelWordCountNumber;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.NumericUpDown numericUpDownWords;
        private System.Windows.Forms.TextBox textBoxSelectedFiles;
        private System.Windows.Forms.Panel panelSelectFile;
        private System.Windows.Forms.Label labelFileSelection;
        private System.Windows.Forms.ComboBox fileSelection;
    }
}

