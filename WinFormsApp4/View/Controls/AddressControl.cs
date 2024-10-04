using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();


        public AddressControl()
        {
            InitializeComponent();
            UpdateAddress();
            int index = int.Parse(InputIndex.Text);
            string country = InputCountry.Text;
            string city = InputCity.Text;
            string street = InputStreet.Text;
            string building = InputBuilding.Text;
            string apartment = InputApartment.Text;
            Address address = new Address(index, country, city, street, building, apartment);
        }

        private Address Address
        {
            get
            {

                return _address;
            }
            set
            {

                _address = value ?? new Address();
                UpdateAddress();
            }
        }
        public void Address1()
        {
            int index = int.Parse(InputIndex.Text);
            string country = InputCountry.Text;
            string city = InputCity.Text;
            string street = InputStreet.Text;
            string building = InputBuilding.Text;
            string apartment = InputApartment.Text;
            Address address = new Address(index, country, city, street, building, apartment);
        }



        public void UpdateAddress()
        {
            InputIndex.Text = _address.Index.ToString();
            InputCountry.Text = _address.Country;
            InputCity.Text = _address.City;
            InputStreet.Text = _address.Street;
            InputBuilding.Text = _address.Building;
            InputApartment.Text = _address.Apartment;

        } 

        public void ClearField()
        {
            InputIndex.Text = "";
            InputCountry.Text = "";
            InputCity.Text = "";
            InputStreet.Text = "";
            InputBuilding.Text = "";
            InputApartment.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void InputCountry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputBuilding_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputApartment_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void groupBoxAddress_Enter(object sender, EventArgs e)
        {

        }

        private void InputIndex_TextChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
