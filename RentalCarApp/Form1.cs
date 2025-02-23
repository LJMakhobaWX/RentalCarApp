using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                /*MessageBox.Show($"Thank you {txtCName.Text} for renting"+'\n'+$"Pick up date:{dtpDateRented.Text}"+'\n'+$"Vehicle return date:{dtpDateReturned.Text}"+'\n'+$"Vehicle rented:{cmbTypeOfCar.Text}");*/
                String CustomerName = txtCName.Text;
                var DateRented = dtpDateRented.Value;
                var DateReturned = dtpDateReturned.Value;
                var TypeOfCar = cmbTypeOfCar.SelectedItem.ToString();
                double Cost = Convert.ToDouble(txtCost.Text);
                var isValid = true;

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(TypeOfCar))
                {
                    isValid = false;
                    MessageBox.Show("Please fill in all fields");
                }

                if (DateRented > DateReturned)
                {
                    isValid = false;
                    MessageBox.Show("Invalid date selection");
                }

                if (isValid == true)
                {
                    MessageBox.Show($"Thank you {CustomerName} for renting with us!\n\r" + $"Pick up date: {DateRented}\n\r" + $"Vehicle return date: {DateReturned}\n\r" + $"Vehicle rented: {TypeOfCar}\n" + $"Cost: {Cost}\n" + $"Thank you for your support!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
