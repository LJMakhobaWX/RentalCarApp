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
                var TypeOfCar = cmbTypeOfCar.Text;
                double Cost = Convert.ToDouble(txtCost.Text);
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(TypeOfCar))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }
                

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(TypeOfCar))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                    //MessageBox.Show("Please fill in all fields");
                }

                if (DateRented > DateReturned)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection.\n\r";
                }

                //if (isValid == true)
                if(isValid)
                {
                    MessageBox.Show($"Thank you {CustomerName} for renting with us!\n\r" + 
                        $"Pick up date: {DateRented}\n\r" + 
                        $"Vehicle return date: {DateReturned}\n\r" + 
                        $"Vehicle rented: {TypeOfCar}\n" + 
                        $"Cost: {Cost}\n" + 
                        $"Thank you for your support!!");
                }
                else
                {
                    MessageBox.Show(errorMessage);
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
