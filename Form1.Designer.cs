namespace ValetParkingSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headlineLabel = new Label();
            vehicleNumberLabel = new Label();
            hoursParkedLabel = new Label();
            parkingTypeLabel = new Label();
            parkingClassLabel = new Label();
            calculateFeeButton = new Button();
            vehicleNumberTextBox = new TextBox();
            hoursParkedTextBox = new TextBox();
            parkingTypeComboBox = new ComboBox();
            parkingClassComboBox = new ComboBox();
            SuspendLayout();
            // 
            // headlineLabel
            // 
            headlineLabel.AutoSize = true;
            headlineLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            headlineLabel.Location = new Point(286, 21);
            headlineLabel.Name = "headlineLabel";
            headlineLabel.Size = new Size(420, 54);
            headlineLabel.TabIndex = 0;
            headlineLabel.Text = " Hotel Valet Parking System";
            // 
            // vehicleNumberLabel
            // 
            vehicleNumberLabel.AutoSize = true;
            vehicleNumberLabel.Location = new Point(114, 93);
            vehicleNumberLabel.Name = "vehicleNumberLabel";
            vehicleNumberLabel.Size = new Size(117, 20);
            vehicleNumberLabel.TabIndex = 1;
            vehicleNumberLabel.Text = "Vehicle Number:";
            // 
            // hoursParkedLabel
            // 
            hoursParkedLabel.AutoSize = true;
            hoursParkedLabel.Location = new Point(114, 155);
            hoursParkedLabel.Name = "hoursParkedLabel";
            hoursParkedLabel.Size = new Size(99, 20);
            hoursParkedLabel.TabIndex = 2;
            hoursParkedLabel.Text = "Hours Parked:";
            // 
            // parkingTypeLabel
            // 
            parkingTypeLabel.AutoSize = true;
            parkingTypeLabel.Location = new Point(114, 218);
            parkingTypeLabel.Name = "parkingTypeLabel";
            parkingTypeLabel.Size = new Size(95, 20);
            parkingTypeLabel.TabIndex = 3;
            parkingTypeLabel.Text = "Parking Type:";
            // 
            // parkingClassLabel
            // 
            parkingClassLabel.AutoSize = true;
            parkingClassLabel.Location = new Point(112, 282);
            parkingClassLabel.Name = "parkingClassLabel";
            parkingClassLabel.Size = new Size(97, 20);
            parkingClassLabel.TabIndex = 4;
            parkingClassLabel.Text = "Parking Class:";
            // 
            // calculateFeeButton
            // 
            calculateFeeButton.BackColor = Color.FromArgb(0, 192, 192);
            calculateFeeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            calculateFeeButton.ForeColor = Color.White;
            calculateFeeButton.Location = new Point(402, 375);
            calculateFeeButton.Name = "calculateFeeButton";
            calculateFeeButton.Size = new Size(178, 40);
            calculateFeeButton.TabIndex = 5;
            calculateFeeButton.Text = "Calculate Fee";
            calculateFeeButton.UseVisualStyleBackColor = false;
            calculateFeeButton.Click += calculateFeeButton_Click;
            // 
            // vehicleNumberTextBox
            // 
            vehicleNumberTextBox.Location = new Point(114, 116);
            vehicleNumberTextBox.Name = "vehicleNumberTextBox";
            vehicleNumberTextBox.Size = new Size(804, 27);
            vehicleNumberTextBox.TabIndex = 6;
            // 
            // hoursParkedTextBox
            // 
            hoursParkedTextBox.Location = new Point(114, 178);
            hoursParkedTextBox.Name = "hoursParkedTextBox";
            hoursParkedTextBox.Size = new Size(804, 27);
            hoursParkedTextBox.TabIndex = 7;
            // 
            // parkingTypeComboBox
            // 
            parkingTypeComboBox.FormattingEnabled = true;
            parkingTypeComboBox.Items.AddRange(new object[] { "Weekday", "Weekend" });
            parkingTypeComboBox.Location = new Point(114, 241);
            parkingTypeComboBox.Name = "parkingTypeComboBox";
            parkingTypeComboBox.Size = new Size(804, 28);
            parkingTypeComboBox.TabIndex = 8;
            // 
            // parkingClassComboBox
            // 
            parkingClassComboBox.FormattingEnabled = true;
            parkingClassComboBox.Items.AddRange(new object[] { "Premier", "VIP" });
            parkingClassComboBox.Location = new Point(114, 305);
            parkingClassComboBox.Name = "parkingClassComboBox";
            parkingClassComboBox.Size = new Size(804, 28);
            parkingClassComboBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 539);
            Controls.Add(parkingClassComboBox);
            Controls.Add(parkingTypeComboBox);
            Controls.Add(hoursParkedTextBox);
            Controls.Add(vehicleNumberTextBox);
            Controls.Add(calculateFeeButton);
            Controls.Add(parkingClassLabel);
            Controls.Add(parkingTypeLabel);
            Controls.Add(hoursParkedLabel);
            Controls.Add(vehicleNumberLabel);
            Controls.Add(headlineLabel);
            Name = "Form1";
            Text = "Hotel Valet Parking System";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label vehicleNumberLabel;
        private System.Windows.Forms.Label hoursParkedLabel;
        private System.Windows.Forms.Label parkingTypeLabel;
        private System.Windows.Forms.Label parkingClassLabel;
        private System.Windows.Forms.Button calculateFeeButton;
        private System.Windows.Forms.TextBox vehicleNumberTextBox;
        private System.Windows.Forms.TextBox hoursParkedTextBox;
        private System.Windows.Forms.ComboBox parkingTypeComboBox;
        private System.Windows.Forms.ComboBox parkingClassComboBox;
    }
}
