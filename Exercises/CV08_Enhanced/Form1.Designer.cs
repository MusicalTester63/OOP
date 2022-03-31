namespace CV08_Enhanced
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.averageTemperatures = new System.Windows.Forms.TextBox();
            this.averageTemperaturesLabel = new System.Windows.Forms.Label();
            this.searchCalTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchResultTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchSubmitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.calPanel = new System.Windows.Forms.Panel();
            this.calConstantMenu = new System.Windows.Forms.NumericUpDown();
            this.calibrateButton = new System.Windows.Forms.Button();
            this.calibrationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.temperatures = new System.Windows.Forms.TextBox();
            this.temperaturesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.calibratedTemperatures = new System.Windows.Forms.TextBox();
            this.calibratedTemperaturesLabel = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.searchCalTablePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.calPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConstantMenu)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.buttons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchCalTablePanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttons, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.averageTemperatures, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.averageTemperaturesLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(641, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(420, 223);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // averageTemperatures
            // 
            this.averageTemperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTemperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.averageTemperatures.Enabled = false;
            this.averageTemperatures.Location = new System.Drawing.Point(3, 25);
            this.averageTemperatures.Multiline = true;
            this.averageTemperatures.Name = "averageTemperatures";
            this.averageTemperatures.ReadOnly = true;
            this.averageTemperatures.Size = new System.Drawing.Size(414, 195);
            this.averageTemperatures.TabIndex = 6;
            // 
            // averageTemperaturesLabel
            // 
            this.averageTemperaturesLabel.AutoSize = true;
            this.averageTemperaturesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.averageTemperaturesLabel.Location = new System.Drawing.Point(3, 2);
            this.averageTemperaturesLabel.Name = "averageTemperaturesLabel";
            this.averageTemperaturesLabel.Size = new System.Drawing.Size(414, 20);
            this.averageTemperaturesLabel.TabIndex = 0;
            this.averageTemperaturesLabel.Text = "Average temperatures:";
            // 
            // searchCalTablePanel
            // 
            this.searchCalTablePanel.ColumnCount = 2;
            this.searchCalTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchCalTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchCalTablePanel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.searchCalTablePanel.Controls.Add(this.panel1, 0, 0);
            this.searchCalTablePanel.Controls.Add(this.calPanel, 1, 0);
            this.searchCalTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCalTablePanel.Location = new System.Drawing.Point(641, 232);
            this.searchCalTablePanel.Name = "searchCalTablePanel";
            this.searchCalTablePanel.RowCount = 2;
            this.searchCalTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchCalTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.searchCalTablePanel.Size = new System.Drawing.Size(420, 223);
            this.searchCalTablePanel.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.searchCalTablePanel.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.searchLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchResultTextBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 139);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(96, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search result:";
            // 
            // searchResultTextBox
            // 
            this.searchResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultTextBox.Enabled = false;
            this.searchResultTextBox.Location = new System.Drawing.Point(3, 30);
            this.searchResultTextBox.Multiline = true;
            this.searchResultTextBox.Name = "searchResultTextBox";
            this.searchResultTextBox.ReadOnly = true;
            this.searchResultTextBox.Size = new System.Drawing.Size(408, 106);
            this.searchResultTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchSubmitButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchBoxLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 72);
            this.panel1.TabIndex = 2;
            // 
            // searchSubmitButton
            // 
            this.searchSubmitButton.Location = new System.Drawing.Point(3, 36);
            this.searchSubmitButton.Name = "searchSubmitButton";
            this.searchSubmitButton.Size = new System.Drawing.Size(201, 33);
            this.searchSubmitButton.TabIndex = 2;
            this.searchSubmitButton.Text = "Submit";
            this.searchSubmitButton.UseVisualStyleBackColor = true;
            this.searchSubmitButton.Click += new System.EventHandler(this.searchSubmitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(57, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(147, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Location = new System.Drawing.Point(1, 6);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(56, 20);
            this.searchBoxLabel.TabIndex = 0;
            this.searchBoxLabel.Text = "Search:";
            // 
            // calPanel
            // 
            this.calPanel.Controls.Add(this.calConstantMenu);
            this.calPanel.Controls.Add(this.calibrateButton);
            this.calPanel.Controls.Add(this.calibrationLabel);
            this.calPanel.Location = new System.Drawing.Point(213, 3);
            this.calPanel.Name = "calPanel";
            this.calPanel.Size = new System.Drawing.Size(204, 72);
            this.calPanel.TabIndex = 3;
            // 
            // calConstantMenu
            // 
            this.calConstantMenu.DecimalPlaces = 2;
            this.calConstantMenu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.calConstantMenu.Location = new System.Drawing.Point(144, 4);
            this.calConstantMenu.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.calConstantMenu.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.calConstantMenu.Name = "calConstantMenu";
            this.calConstantMenu.Size = new System.Drawing.Size(54, 27);
            this.calConstantMenu.TabIndex = 6;
            this.calConstantMenu.Tag = "";
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(3, 36);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(195, 33);
            this.calibrateButton.TabIndex = 1;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            // 
            // calibrationLabel
            // 
            this.calibrationLabel.AutoSize = true;
            this.calibrationLabel.Location = new System.Drawing.Point(0, 6);
            this.calibrationLabel.Name = "calibrationLabel";
            this.calibrationLabel.Size = new System.Drawing.Size(145, 20);
            this.calibrationLabel.TabIndex = 0;
            this.calibrationLabel.Text = "Calibration constant:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.temperatures, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.temperaturesLabel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(632, 223);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // temperatures
            // 
            this.temperatures.AccessibleDescription = "";
            this.temperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatures.Enabled = false;
            this.temperatures.Location = new System.Drawing.Point(3, 25);
            this.temperatures.Multiline = true;
            this.temperatures.Name = "temperatures";
            this.temperatures.ReadOnly = true;
            this.temperatures.Size = new System.Drawing.Size(626, 195);
            this.temperatures.TabIndex = 10;
            // 
            // temperaturesLabel
            // 
            this.temperaturesLabel.AutoSize = true;
            this.temperaturesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.temperaturesLabel.Location = new System.Drawing.Point(3, 2);
            this.temperaturesLabel.Name = "temperaturesLabel";
            this.temperaturesLabel.Size = new System.Drawing.Size(626, 20);
            this.temperaturesLabel.TabIndex = 0;
            this.temperaturesLabel.Text = "Temperatures:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.calibratedTemperatures, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.calibratedTemperaturesLabel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 232);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(632, 223);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // calibratedTemperatures
            // 
            this.calibratedTemperatures.AccessibleDescription = "";
            this.calibratedTemperatures.AccessibleName = "";
            this.calibratedTemperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibratedTemperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibratedTemperatures.Enabled = false;
            this.calibratedTemperatures.Location = new System.Drawing.Point(3, 25);
            this.calibratedTemperatures.Multiline = true;
            this.calibratedTemperatures.Name = "calibratedTemperatures";
            this.calibratedTemperatures.ReadOnly = true;
            this.calibratedTemperatures.Size = new System.Drawing.Size(626, 195);
            this.calibratedTemperatures.TabIndex = 5;
            // 
            // calibratedTemperaturesLabel
            // 
            this.calibratedTemperaturesLabel.AutoSize = true;
            this.calibratedTemperaturesLabel.Location = new System.Drawing.Point(3, 0);
            this.calibratedTemperaturesLabel.Name = "calibratedTemperaturesLabel";
            this.calibratedTemperaturesLabel.Size = new System.Drawing.Size(173, 20);
            this.calibratedTemperaturesLabel.TabIndex = 0;
            this.calibratedTemperaturesLabel.Text = "Calibrated temperatures:";
            // 
            // buttons
            // 
            this.buttons.Controls.Add(this.saveButton);
            this.buttons.Controls.Add(this.loadButton);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttons.Location = new System.Drawing.Point(641, 461);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(420, 46);
            this.buttons.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(323, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(223, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(94, 29);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 461);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 46);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Temperatures";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.searchCalTablePanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.calPanel.ResumeLayout(false);
            this.calPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConstantMenu)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button calibrateButton;
        private TableLayoutPanel searchCalTablePanel;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox averageTemperatures;
        private Label averageTemperaturesLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox temperatures;
        private Label temperaturesLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label searchLabel;
        private TextBox searchResultTextBox;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox calibratedTemperatures;
        private Label calibratedTemperaturesLabel;
        private Label calibrationLabel;
        private Panel panel1;
        private TextBox searchTextBox;
        private Label searchBoxLabel;
        private Button searchSubmitButton;
        private Panel calPanel;
        private NumericUpDown calConstantMenu;
        private FlowLayoutPanel buttons;
        private Button saveButton;
        private Button loadButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button exitButton;
    }
}