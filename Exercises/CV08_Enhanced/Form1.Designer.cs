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
            this.temperatures = new System.Windows.Forms.TextBox();
            this.averageTemperatures = new System.Windows.Forms.TextBox();
            this.calibratedTemperatures = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.calibrateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.calConstantMenu = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConstantMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.temperatures, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.averageTemperatures, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.calibratedTemperatures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
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
            // temperatures
            // 
            this.temperatures.AccessibleDescription = "";
            this.temperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatures.Enabled = false;
            this.temperatures.Location = new System.Drawing.Point(3, 3);
            this.temperatures.Multiline = true;
            this.temperatures.Name = "temperatures";
            this.temperatures.ReadOnly = true;
            this.temperatures.Size = new System.Drawing.Size(632, 223);
            this.temperatures.TabIndex = 8;
            // 
            // averageTemperatures
            // 
            this.averageTemperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTemperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.averageTemperatures.Enabled = false;
            this.averageTemperatures.Location = new System.Drawing.Point(641, 3);
            this.averageTemperatures.Multiline = true;
            this.averageTemperatures.Name = "averageTemperatures";
            this.averageTemperatures.ReadOnly = true;
            this.averageTemperatures.Size = new System.Drawing.Size(420, 223);
            this.averageTemperatures.TabIndex = 5;
            this.averageTemperatures.TextChanged += new System.EventHandler(this.averageTemperatures_TextChanged);
            // 
            // calibratedTemperatures
            // 
            this.calibratedTemperatures.AccessibleDescription = "";
            this.calibratedTemperatures.AccessibleName = "";
            this.calibratedTemperatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibratedTemperatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibratedTemperatures.Enabled = false;
            this.calibratedTemperatures.Location = new System.Drawing.Point(3, 232);
            this.calibratedTemperatures.Multiline = true;
            this.calibratedTemperatures.Name = "calibratedTemperatures";
            this.calibratedTemperatures.ReadOnly = true;
            this.calibratedTemperatures.Size = new System.Drawing.Size(632, 223);
            this.calibratedTemperatures.TabIndex = 4;
            // 
            // buttons
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttons, 2);
            this.buttons.Controls.Add(this.saveButton);
            this.buttons.Controls.Add(this.loadButton);
            this.buttons.Controls.Add(this.calibrateButton);
            this.buttons.Controls.Add(this.exitButton);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttons.Location = new System.Drawing.Point(3, 461);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(1058, 46);
            this.buttons.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(961, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(861, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(94, 29);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(761, 3);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(94, 29);
            this.calibrateButton.TabIndex = 1;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(661, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(641, 232);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(420, 223);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.calConstantMenu);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calibration constant:";
            // 
            // calConstantMenu
            // 
            this.calConstantMenu.DecimalPlaces = 2;
            this.calConstantMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calConstantMenu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.calConstantMenu.Location = new System.Drawing.Point(3, 23);
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
            this.calConstantMenu.Size = new System.Drawing.Size(170, 27);
            this.calConstantMenu.TabIndex = 2;
            this.calConstantMenu.Tag = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 114);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(204, 106);
            this.flowLayoutPanel2.TabIndex = 1;
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
            this.tableLayoutPanel1.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConstantMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel buttons;
        private Button loadButton;
        private Button calibrateButton;
        private Button exitButton;
        private TextBox calibratedTemperatures;
        private TextBox averageTemperatures;
        private Button saveButton;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private NumericUpDown calConstantMenu;
        private TextBox temperatures;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}