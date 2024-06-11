using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ValetParkingSystem
{
    public partial class Form1 : Form
    {
        // List to store parking records
        private List<ParkingRecord> parkingRecords = new List<ParkingRecord>();

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateFeeButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form
            string vehicleNumber = vehicleNumberTextBox.Text;
            int hoursParked = int.Parse(hoursParkedTextBox.Text);
            string parkingType = parkingTypeComboBox.SelectedItem.ToString();
            string parkingClass = parkingClassComboBox.SelectedItem.ToString();

            // Calculate the fee
            double fee = CalculateParkingFee(hoursParked, parkingType, parkingClass);

            // Store parking record
            parkingRecords.Add(new ParkingRecord(vehicleNumber, hoursParked, parkingType, parkingClass, fee));

            // Show the result form with statistics
            Form2 resultForm = new Form2(vehicleNumber, hoursParked, parkingType, parkingClass, fee, GetLongestParkedVehicle(), GetAverageFee());
            resultForm.Show();
        }

        private double CalculateParkingFee(int hours, string type, string parkingClass)
        {
            double fee = 0;
            double firstHourRate = 0;
            double subsequentHourRate = 0;
            double overnightRate = 50.00;

            // Determine rates based on parking type and class
            if (type == "Weekday")
            {
                if (parkingClass == "Premier")
                {
                    firstHourRate = 5.00;
                    subsequentHourRate = 3.00;
                }
                else if (parkingClass == "VIP")
                {
                    firstHourRate = 15.00;
                    subsequentHourRate = 10.00;
                }
            }
            else if (type == "Weekend")
            {
                if (parkingClass == "Premier")
                {
                    firstHourRate = 10.00;
                    subsequentHourRate = 6.00;
                }
                else if (parkingClass == "VIP")
                {
                    firstHourRate = 20.00;
                    subsequentHourRate = 10.00;
                }
            }

            // Calculate fee for hours below 24
            if (hours < 24)
            {
                fee += firstHourRate; // Add the first hour rate
                hours--; // Decrement hours as the first hour has been counted
                fee += Math.Max(0, hours) * subsequentHourRate; // Add subsequent hour rates
            }
            else
            {
                // Calculate fee for the first 24 hours
                fee += overnightRate;
                hours -= 24;

                // Calculate fee for additional hours
                fee += (hours / 24) * overnightRate;
                hours %= 24;

                // Calculate fee for remaining hours after the first 24 hours
                fee += firstHourRate; // Add the first hour rate
                hours--; // Decrement hours as the first hour has been counted
                fee += Math.Max(0, hours) * subsequentHourRate; // Add subsequent hour rates
            }

            return fee;
        }

        private string GetLongestParkedVehicle()
        {
            // Logic to find the vehicle with the longest parking hours
            ParkingRecord longestParkedVehicle = parkingRecords.OrderByDescending(record => record.HoursParked).FirstOrDefault();
            return longestParkedVehicle != null ? longestParkedVehicle.VehicleNumber : "No records yet";
        }

        private double GetAverageFee()
        {
            // Logic to calculate the average parking fee
            return parkingRecords.Count > 0 ? parkingRecords.Average(record => record.Fee) : 0;
        }
    }

    // Class to represent a parking record
    public class ParkingRecord
    {
        public string VehicleNumber { get; }
        public int HoursParked { get; }
        public string ParkingType { get; }
        public string ParkingClass { get; }
        public double Fee { get; }

        public ParkingRecord(string vehicleNumber, int hoursParked, string parkingType, string parkingClass, double fee)
        {
            VehicleNumber = vehicleNumber;
            HoursParked = hoursParked;
            ParkingType = parkingType;
            ParkingClass = parkingClass;
            Fee = fee;
        }
    }
}
