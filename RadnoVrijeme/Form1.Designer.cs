namespace RadnoVrijeme
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
            this.CreateReport = new System.Windows.Forms.Button();
            this.CurrentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddVacationButton = new System.Windows.Forms.Button();
            this.AddTripButton = new System.Windows.Forms.Button();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VacationListBox = new System.Windows.Forms.ListBox();
            this.TripListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(329, 152);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(121, 23);
            this.CreateReport.TabIndex = 0;
            this.CreateReport.Text = "Create";
            this.CreateReport.UseVisualStyleBackColor = true;
            this.CreateReport.Click += new System.EventHandler(this.CreateReport_Click);
            // 
            // CurrentDatePicker
            // 
            this.CurrentDatePicker.Location = new System.Drawing.Point(28, 30);
            this.CurrentDatePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.CurrentDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.CurrentDatePicker.Name = "CurrentDatePicker";
            this.CurrentDatePicker.Size = new System.Drawing.Size(157, 20);
            this.CurrentDatePicker.TabIndex = 1;
            this.CurrentDatePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of report";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(28, 96);
            this.StartDatePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(129, 20);
            this.StartDatePicker.TabIndex = 3;
            this.StartDatePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(178, 96);
            this.EndDatePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(129, 20);
            this.EndDatePicker.TabIndex = 4;
            this.EndDatePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Data range";
            // 
            // AddVacationButton
            // 
            this.AddVacationButton.Location = new System.Drawing.Point(329, 96);
            this.AddVacationButton.Name = "AddVacationButton";
            this.AddVacationButton.Size = new System.Drawing.Size(106, 23);
            this.AddVacationButton.TabIndex = 6;
            this.AddVacationButton.Text = "Add Vacation";
            this.AddVacationButton.UseVisualStyleBackColor = true;
            this.AddVacationButton.Click += new System.EventHandler(this.AddVacationButton_Click);
            // 
            // AddTripButton
            // 
            this.AddTripButton.Location = new System.Drawing.Point(450, 96);
            this.AddTripButton.Name = "AddTripButton";
            this.AddTripButton.Size = new System.Drawing.Size(106, 24);
            this.AddTripButton.TabIndex = 7;
            this.AddTripButton.Text = "Add Trip";
            this.AddTripButton.UseVisualStyleBackColor = true;
            this.AddTripButton.Click += new System.EventHandler(this.AddTripButton_Click);
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Items.AddRange(new object[] {
            "Vatroslav Bodrožić"});
            this.EmployeeComboBox.Location = new System.Drawing.Point(208, 30);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(348, 21);
            this.EmployeeComboBox.TabIndex = 8;
            this.EmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee";
            // 
            // VacationListBox
            // 
            this.VacationListBox.FormattingEnabled = true;
            this.VacationListBox.Location = new System.Drawing.Point(28, 152);
            this.VacationListBox.Name = "VacationListBox";
            this.VacationListBox.Size = new System.Drawing.Size(129, 199);
            this.VacationListBox.TabIndex = 10;
            // 
            // TripListBox
            // 
            this.TripListBox.FormattingEnabled = true;
            this.TripListBox.Location = new System.Drawing.Point(178, 152);
            this.TripListBox.Name = "TripListBox";
            this.TripListBox.Size = new System.Drawing.Size(129, 199);
            this.TripListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 370);
            this.Controls.Add(this.TripListBox);
            this.Controls.Add(this.VacationListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.AddTripButton);
            this.Controls.Add(this.AddVacationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentDatePicker);
            this.Controls.Add(this.CreateReport);
            this.Name = "Form1";
            this.Text = "Work hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateReport;
        private System.Windows.Forms.DateTimePicker CurrentDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddVacationButton;
        private System.Windows.Forms.Button AddTripButton;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox VacationListBox;
        private System.Windows.Forms.ListBox TripListBox;
    }
}

