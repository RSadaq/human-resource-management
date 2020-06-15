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
            this.jobsComboBox.Location = new System.Drawing.Point(309, 135);
            this.jobsComboBox.Name = "jobsComboBox";
            this.jobsComboBox.Size = new System.Drawing.Size(220, 33);
            this.jobsComboBox.TabIndex = 0;
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsLabel.Location = new System.Drawing.Point(210, 135);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(58, 31);
            this.jobsLabel.TabIndex = 1;
            this.jobsLabel.Text = "Job";
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsLabel.Location = new System.Drawing.Point(1181, 143);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(216, 31);
            this.shiftsLabel.TabIndex = 2;
            this.shiftsLabel.Text = "Number of Shifts";
            // 
            // NoOfShiftsNumericUpDown
            // 
            this.NoOfShiftsNumericUpDown.Location = new System.Drawing.Point(1461, 143);
            this.NoOfShiftsNumericUpDown.Name = "NoOfShiftsNumericUpDown";
            this.NoOfShiftsNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.NoOfShiftsNumericUpDown.TabIndex = 3;
            // 
            // assignJobButton
            // 
            this.assignJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignJobButton.Location = new System.Drawing.Point(752, 415);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(230, 120);
            this.assignJobButton.TabIndex = 4;
            this.assignJobButton.Text = "Assign Job";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // jobsAssignedTextBox
            // 
            this.jobsAssignedTextBox.Location = new System.Drawing.Point(55, 761);
            this.jobsAssignedTextBox.Multiline = true;
            this.jobsAssignedTextBox.Name = "jobsAssignedTextBox";
            this.jobsAssignedTextBox.Size = new System.Drawing.Size(2378, 794);
            this.jobsAssignedTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2487, 1629);
            this.Controls.Add(this.jobsAssignedTextBox);
            this.Controls.Add(this.assignJobButton);
            this.Controls.Add(this.NoOfShiftsNumericUpDown);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsComboBox);
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
    }
}

