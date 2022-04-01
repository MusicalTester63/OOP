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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSelectedFiles = new System.Windows.Forms.TextBox();
            this.labelSelectedFiles = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxAllFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWords = new System.Windows.Forms.Label();
            this.numericUpDownWords = new System.Windows.Forms.NumericUpDown();
            this.baseTableLayout.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWords)).BeginInit();
            this.SuspendLayout();
            // 
            // baseTableLayout
            // 
            this.baseTableLayout.ColumnCount = 2;
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.baseTableLayout.Controls.Add(this.panelFiles, 0, 0);
            this.baseTableLayout.Controls.Add(this.panel2, 1, 0);
            this.baseTableLayout.Controls.Add(this.panel3, 1, 1);
            this.baseTableLayout.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.baseTableLayout.Controls.Add(this.panel1, 0, 2);
            this.baseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTableLayout.Location = new System.Drawing.Point(0, 0);
            this.baseTableLayout.Name = "baseTableLayout";
            this.baseTableLayout.RowCount = 3;
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.91845F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.91845F));
            this.baseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16309F));
            this.baseTableLayout.Size = new System.Drawing.Size(990, 580);
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
            this.panelFiles.Size = new System.Drawing.Size(291, 490);
            this.panelFiles.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.checkedListBoxFiles);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(10, 10);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiles.Size = new System.Drawing.Size(271, 470);
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
            this.checkedListBoxFiles.Size = new System.Drawing.Size(241, 425);
            this.checkedListBoxFiles.TabIndex = 0;
            this.checkedListBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFiles_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSelectedFiles);
            this.panel2.Controls.Add(this.labelSelectedFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(687, 242);
            this.panel2.TabIndex = 3;
            // 
            // textBoxSelectedFiles
            // 
            this.textBoxSelectedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSelectedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSelectedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedFiles.Location = new System.Drawing.Point(10, 26);
            this.textBoxSelectedFiles.Multiline = true;
            this.textBoxSelectedFiles.Name = "textBoxSelectedFiles";
            this.textBoxSelectedFiles.ReadOnly = true;
            this.textBoxSelectedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSelectedFiles.Size = new System.Drawing.Size(667, 206);
            this.textBoxSelectedFiles.TabIndex = 0;
            // 
            // labelSelectedFiles
            // 
            this.labelSelectedFiles.AutoSize = true;
            this.labelSelectedFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelectedFiles.Location = new System.Drawing.Point(10, 10);
            this.labelSelectedFiles.Name = "labelSelectedFiles";
            this.labelSelectedFiles.Size = new System.Drawing.Size(91, 16);
            this.labelSelectedFiles.TabIndex = 0;
            this.labelSelectedFiles.Text = "Selected files:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxAllFiles);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 251);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(687, 242);
            this.panel3.TabIndex = 4;
            // 
            // textBoxAllFiles
            // 
            this.textBoxAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllFiles.Location = new System.Drawing.Point(10, 26);
            this.textBoxAllFiles.Multiline = true;
            this.textBoxAllFiles.Name = "textBoxAllFiles";
            this.textBoxAllFiles.Size = new System.Drawing.Size(667, 206);
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
            this.flowLayoutPanel1.Controls.Add(this.buttonAnalyze);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddFile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(312, 511);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(663, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.AutoSize = true;
            this.buttonAnalyze.Location = new System.Drawing.Point(565, 13);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(95, 29);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.AutoSize = true;
            this.buttonAddFile.Location = new System.Drawing.Point(464, 13);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(95, 29);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Add file";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWords);
            this.panel1.Controls.Add(this.numericUpDownWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 501);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(277, 69);
            this.panel1.TabIndex = 5;
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
            this.numericUpDownWords.Location = new System.Drawing.Point(0, 23);
            this.numericUpDownWords.Margin = new System.Windows.Forms.Padding(20);
            this.numericUpDownWords.Name = "numericUpDownWords";
            this.numericUpDownWords.Size = new System.Drawing.Size(277, 22);
            this.numericUpDownWords.TabIndex = 1;
            this.numericUpDownWords.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWords.ValueChanged += new System.EventHandler(this.numericUpDownWords_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 580);
            this.Controls.Add(this.baseTableLayout);
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.baseTableLayout.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numericUpDownWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSelectedFiles;
        private System.Windows.Forms.TextBox textBoxAllFiles;
    }
}

