namespace HumanResourceManagement
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
            this.jobsComboBox = new System.Windows.Forms.ComboBox();
            this.jobsLabel = new System.Windows.Forms.Label();
            this.shiftsLabel = new System.Windows.Forms.Label();
            this.NoOfShiftsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.jobsAssignedTextBox = new System.Windows.Forms.TextBox();
            this.AvlbleEmplysLabel = new System.Windows.Forms.Label();
            this.AvlbleEmplsComboBox = new System.Windows.Forms.ComboBox();
            this.startShiftButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfShiftsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsComboBox
            // 
            this.jobsComboBox.FormattingEnabled = true;
            this.jobsComboBox.Items.AddRange(new object[] {
            "Tills",
            "Stocking_shelves",
            "Internet_shopping",
            "Customer_Services",
            "Meat",
            "Bakery"});
            this.jobsComboBox.Location = new System.Drawing.Point(630, 127);
            this.jobsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobsComboBox.Name = "jobsComboBox";
            this.jobsComboBox.Size = new System.Drawing.Size(220, 33);
            this.jobsComboBox.TabIndex = 0;
            this.jobsComboBox.SelectedIndexChanged += new System.EventHandler(this.jobsComboBox_SelectedIndexChanged);
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsLabel.Location = new System.Drawing.Point(224, 129);
            this.jobsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(58, 31);
            this.jobsLabel.TabIndex = 1;
            this.jobsLabel.Text = "Job";
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsLabel.Location = new System.Drawing.Point(224, 496);
            this.shiftsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(216, 31);
            this.shiftsLabel.TabIndex = 2;
            this.shiftsLabel.Text = "Number of Shifts";
            // 
            // NoOfShiftsNumericUpDown
            // 
            this.NoOfShiftsNumericUpDown.Location = new System.Drawing.Point(708, 496);
            this.NoOfShiftsNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.NoOfShiftsNumericUpDown.Name = "NoOfShiftsNumericUpDown";
            this.NoOfShiftsNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.NoOfShiftsNumericUpDown.TabIndex = 3;
            // 
            // assignJobButton
            // 
            this.assignJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignJobButton.Location = new System.Drawing.Point(1472, 258);
            this.assignJobButton.Margin = new System.Windows.Forms.Padding(4);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(230, 119);
            this.assignJobButton.TabIndex = 4;
            this.assignJobButton.Text = "Assign Job";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // jobsAssignedTextBox
            // 
            this.jobsAssignedTextBox.Location = new System.Drawing.Point(56, 762);
            this.jobsAssignedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobsAssignedTextBox.Multiline = true;
            this.jobsAssignedTextBox.Name = "jobsAssignedTextBox";
            this.jobsAssignedTextBox.Size = new System.Drawing.Size(2378, 794);
            this.jobsAssignedTextBox.TabIndex = 5;
            // 
            // AvlbleEmplysLabel
            // 
            this.AvlbleEmplysLabel.AutoSize = true;
            this.AvlbleEmplysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvlbleEmplysLabel.Location = new System.Drawing.Point(224, 302);
            this.AvlbleEmplysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvlbleEmplysLabel.Name = "AvlbleEmplysLabel";
            this.AvlbleEmplysLabel.Size = new System.Drawing.Size(265, 31);
            this.AvlbleEmplysLabel.TabIndex = 6;
            this.AvlbleEmplysLabel.Text = "Available Employees";
            // 
            // AvlbleEmplsComboBox
            // 
            this.AvlbleEmplsComboBox.FormattingEnabled = true;
            this.AvlbleEmplsComboBox.Location = new System.Drawing.Point(630, 305);
            this.AvlbleEmplsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AvlbleEmplsComboBox.Name = "AvlbleEmplsComboBox";
            this.AvlbleEmplsComboBox.Size = new System.Drawing.Size(376, 33);
            this.AvlbleEmplsComboBox.TabIndex = 7;
            // 
            // startShiftButton
            // 
            this.startShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShiftButton.Location = new System.Drawing.Point(1472, 450);
            this.startShiftButton.Margin = new System.Windows.Forms.Padding(6);
            this.startShiftButton.Name = "startShiftButton";
            this.startShiftButton.Size = new System.Drawing.Size(230, 125);
            this.startShiftButton.TabIndex = 8;
            this.startShiftButton.Text = "Start Shift!";
            this.startShiftButton.UseVisualStyleBackColor = true;
            this.startShiftButton.Click += new System.EventHandler(this.startShiftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2488, 1660);
            this.Controls.Add(this.startShiftButton);
            this.Controls.Add(this.AvlbleEmplsComboBox);
            this.Controls.Add(this.AvlbleEmplysLabel);
            this.Controls.Add(this.jobsAssignedTextBox);
            this.Controls.Add(this.assignJobButton);
            this.Controls.Add(this.NoOfShiftsNumericUpDown);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NoOfShiftsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jobsComboBox;
        private System.Windows.Forms.Label jobsLabel;
        private System.Windows.Forms.Label shiftsLabel;
        private System.Windows.Forms.NumericUpDown NoOfShiftsNumericUpDown;
        private System.Windows.Forms.Button assignJobButton;
        private System.Windows.Forms.TextBox jobsAssignedTextBox;
        private System.Windows.Forms.Label AvlbleEmplysLabel;
        private System.Windows.Forms.ComboBox AvlbleEmplsComboBox;
        private System.Windows.Forms.Button startShiftButton;
    }
}

