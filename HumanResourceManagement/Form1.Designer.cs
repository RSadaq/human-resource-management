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
            ((System.ComponentModel.ISupportInitialize)(this.NoOfShiftsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsComboBox
            // 
            this.jobsComboBox.FormattingEnabled = true;
            this.jobsComboBox.Items.AddRange(new object[] {
            "Tills",
            "Stocking shelves",
            "Internet shopping",
            "Customer Services",
            "Meat",
            "Bakery"});
            this.jobsComboBox.Location = new System.Drawing.Point(344, 156);
            this.jobsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobsComboBox.Name = "jobsComboBox";
            this.jobsComboBox.Size = new System.Drawing.Size(112, 21);
            this.jobsComboBox.TabIndex = 0;
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsLabel.Location = new System.Drawing.Point(112, 157);
            this.jobsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(31, 17);
            this.jobsLabel.TabIndex = 1;
            this.jobsLabel.Text = "Job";
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsLabel.Location = new System.Drawing.Point(112, 258);
            this.shiftsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(113, 17);
            this.shiftsLabel.TabIndex = 2;
            this.shiftsLabel.Text = "Number of Shifts";
            // 
            // NoOfShiftsNumericUpDown
            // 
            this.NoOfShiftsNumericUpDown.Location = new System.Drawing.Point(354, 258);
            this.NoOfShiftsNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoOfShiftsNumericUpDown.Name = "NoOfShiftsNumericUpDown";
            this.NoOfShiftsNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.NoOfShiftsNumericUpDown.TabIndex = 3;
            // 
            // assignJobButton
            // 
            this.assignJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignJobButton.Location = new System.Drawing.Point(736, 134);
            this.assignJobButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(115, 62);
            this.assignJobButton.TabIndex = 4;
            this.assignJobButton.Text = "Assign Job";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // jobsAssignedTextBox
            // 
            this.jobsAssignedTextBox.Location = new System.Drawing.Point(28, 396);
            this.jobsAssignedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobsAssignedTextBox.Multiline = true;
            this.jobsAssignedTextBox.Name = "jobsAssignedTextBox";
            this.jobsAssignedTextBox.Size = new System.Drawing.Size(1191, 415);
            this.jobsAssignedTextBox.TabIndex = 5;
            // 
            // AvlbleEmplysLabel
            // 
            this.AvlbleEmplysLabel.AutoSize = true;
            this.AvlbleEmplysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvlbleEmplysLabel.Location = new System.Drawing.Point(102, 42);
            this.AvlbleEmplysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvlbleEmplysLabel.Name = "AvlbleEmplysLabel";
            this.AvlbleEmplysLabel.Size = new System.Drawing.Size(138, 17);
            this.AvlbleEmplysLabel.TabIndex = 6;
            this.AvlbleEmplysLabel.Text = "Available Employees";
            // 
            // AvlbleEmplsComboBox
            // 
            this.AvlbleEmplsComboBox.FormattingEnabled = true;
            this.AvlbleEmplsComboBox.Location = new System.Drawing.Point(339, 43);
            this.AvlbleEmplsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvlbleEmplsComboBox.Name = "AvlbleEmplsComboBox";
            this.AvlbleEmplsComboBox.Size = new System.Drawing.Size(190, 21);
            this.AvlbleEmplsComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 863);
            this.Controls.Add(this.AvlbleEmplsComboBox);
            this.Controls.Add(this.AvlbleEmplysLabel);
            this.Controls.Add(this.jobsAssignedTextBox);
            this.Controls.Add(this.assignJobButton);
            this.Controls.Add(this.NoOfShiftsNumericUpDown);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

