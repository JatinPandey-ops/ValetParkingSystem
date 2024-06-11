using System;
using System.Windows.Forms;

namespace ValetParkingSystem
{
    public partial class Form2 : Form
    {
        public Form2(string vehicleNumber, int hoursParked, string parkingType, string parkingClass, double fee, string longestParkedVehicle, double averageFee)
        {
            InitializeComponent();

            // Display parking details
            vehicleNumberLabel.Text = $"Vehicle Number: {vehicleNumber}";
            hoursParkedLabel.Text = $"Hours Parked: {hoursParked}";
            parkingTypeLabel.Text = $"Type of Parking: {parkingType}";
            parkingClassLabel.Text = $"Parking Class: {parkingClass}";
            totalFeeLabel.Text = $"Total Fee: RM{fee}";

            // Display statistics
            longestParkedLabel.Text = $"Vehicle with the Longest Parking: {longestParkedVehicle}";
            averageFeeLabel.Text = $"Average Parking Fee: RM{averageFee}";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
