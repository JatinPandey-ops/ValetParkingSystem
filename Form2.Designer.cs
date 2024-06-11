namespace ValetParkingSystem
{
    partial class Form2
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
            vehicleNumberLabel = new Label();
            hoursParkedLabel = new Label();
            parkingTypeLabel = new Label();
            parkingClassLabel = new Label();
            totalFeeLabel = new Label();
            longestParkedLabel = new Label();
            averageFeeLabel = new Label();
            returnButton = new Button();
            resultsLabel = new Label();
            parkingDetailsLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();

            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            titleLabel.Location = new Point(27, 66);
            titleLabel.Name = "parkingDetailsLabel";
            titleLabel.Size = new Size(132, 23);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Results";
            // 
            // vehicleNumberLabel
            // 
            vehicleNumberLabel.AutoSize = true;
            vehicleNumberLabel.Location = new Point(27, 98);
            vehicleNumberLabel.Name = "vehicleNumberLabel";
            vehicleNumberLabel.Size = new Size(117, 20);
            vehicleNumberLabel.TabIndex = 0;
            vehicleNumberLabel.Text = "Vehicle Number:";
            // 
            // hoursParkedLabel
            // 
            hoursParkedLabel.AutoSize = true;
            hoursParkedLabel.Location = new Point(27, 127);
            hoursParkedLabel.Name = "hoursParkedLabel";
            hoursParkedLabel.Size = new Size(99, 20);
            hoursParkedLabel.TabIndex = 1;
            hoursParkedLabel.Text = "Hours Parked:";
            // 
            // parkingTypeLabel
            // 
            parkingTypeLabel.AutoSize = true;
            parkingTypeLabel.Location = new Point(27, 156);
            parkingTypeLabel.Name = "parkingTypeLabel";
            parkingTypeLabel.Size = new Size(113, 20);
            parkingTypeLabel.TabIndex = 2;
            parkingTypeLabel.Text = "Type of Parking:";
            // 
            // parkingClassLabel
            // 
            parkingClassLabel.AutoSize = true;
            parkingClassLabel.Location = new Point(27, 185);
            parkingClassLabel.Name = "parkingClassLabel";
            parkingClassLabel.Size = new Size(97, 20);
            parkingClassLabel.TabIndex = 3;
            parkingClassLabel.Text = "Parking Class:";
            // 
            // totalFeeLabel
            // 
            totalFeeLabel.AutoSize = true;
            totalFeeLabel.Location = new Point(27, 214);
            totalFeeLabel.Name = "totalFeeLabel";
            totalFeeLabel.Size = new Size(72, 20);
            totalFeeLabel.TabIndex = 4;
            totalFeeLabel.Text = "Total Fee:";
            // 
            // longestParkedLabel
            // 
            longestParkedLabel.AutoSize = true;
            longestParkedLabel.Location = new Point(27, 300);
            longestParkedLabel.Name = "longestParkedLabel";
            longestParkedLabel.Size = new Size(215, 20);
            longestParkedLabel.TabIndex = 5;
            longestParkedLabel.Text = "Vehicle(s) with Longest Parking:";
            // 
            // averageFeeLabel
            // 
            averageFeeLabel.AutoSize = true;
            averageFeeLabel.Location = new Point(27, 331);
            averageFeeLabel.Name = "averageFeeLabel";
            averageFeeLabel.Size = new Size(146, 20);
            averageFeeLabel.TabIndex = 6;
            averageFeeLabel.Text = "Average Parking Fee:";
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(0, 192, 192);
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(246, 379);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(133, 40);
            returnButton.TabIndex = 7;
            returnButton.Text = "Return Home";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resultsLabel.Location = new Point(27, 261);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(391, 28);
            resultsLabel.TabIndex = 8;
            resultsLabel.Text = "Longest parking and average fee details";
            resultsLabel.Click += resultsLabel_Click;
            // 
            // parkingDetailsLabel
            // 
            parkingDetailsLabel.AutoSize = true;
            parkingDetailsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            parkingDetailsLabel.Location = new Point(27, 66);
            parkingDetailsLabel.Name = "parkingDetailsLabel";
            parkingDetailsLabel.Size = new Size(132, 23);
            parkingDetailsLabel.TabIndex = 9;
            parkingDetailsLabel.Text = "Parking Details";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(637, 442);
            Controls.Add(returnButton);
            Controls.Add(averageFeeLabel);
            Controls.Add(longestParkedLabel);
            Controls.Add(totalFeeLabel);
            Controls.Add(parkingClassLabel);
            Controls.Add(parkingTypeLabel);
            Controls.Add(hoursParkedLabel);
            Controls.Add(vehicleNumberLabel);
            Controls.Add(parkingDetailsLabel);
            Controls.Add(resultsLabel);
            Name = "Form2";
            Text = "Hotel Valet Parking System Result";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label vehicleNumberLabel;
        private System.Windows.Forms.Label hoursParkedLabel;
        private System.Windows.Forms.Label parkingTypeLabel;
        private System.Windows.Forms.Label parkingClassLabel;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Label longestParkedLabel;
        private System.Windows.Forms.Label averageFeeLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label parkingDetailsLabel;
    }
}
