using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        ValueValidator validator = new ValueValidator();
        /// <summary>
        /// Поле, хранящее адрес.
        /// </summary>
        Address _address;

        /// <summary>
        /// Флаг для корректного обновления полей адреса.
        /// </summary>
        public bool IsUpdatingFieldFlag = false;

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        


        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void GenerateTooltip(TextBox textBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(textBox, errorMessage);
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    validator.AssertStringOnLength(InputCity.Text, 50, nameof(InputCity));
                    InputCity.ForeColor = System.Drawing.Color.Black;
                }
                catch (ArgumentException ex)
                {
                    InputCity.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("City должно быть меньше 50 символов.");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    validator.AssertStringOnLength(InputStreet.Text, 100, nameof(InputStreet));
                    InputStreet.ForeColor = System.Drawing.Color.Black;
                }
                catch (ArgumentException ex)
                {
                    InputStreet.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Street должно быть меньше 100 символов.");
                }
            }
        }
        private void InputCountry_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    validator.AssertStringOnLength(InputCountry.Text, 50, nameof(InputCountry));
                    InputCountry.ForeColor = System.Drawing.Color.Black;
                }
                catch (ArgumentException ex)
                {
                    InputCountry.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Country должно быть меньше 50 символов.");
                }
            }
        }

        private void InputBuilding_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    validator.AssertStringOnLength(InputBuilding.Text, 10, nameof(InputBuilding));
                    InputBuilding.ForeColor = System.Drawing.Color.Black;
                }
                catch (ArgumentException ex)
                {
                    InputBuilding.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Building должно быть меньше 10 символов.");
                }
            }
        }

        private void InputApartment_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    validator.AssertStringOnLength(InputApartment.Text, 10, nameof(InputApartment));
                    InputApartment.ForeColor = System.Drawing.Color.Black;
                }
                catch (ArgumentException ex)
                {
                    InputApartment.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Apartment должно быть меньше 10 символов.");
                }
            }
        }


        private void InputIndex_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(InputIndex.Text, out int index) || index < 100000 || index > 999999)
            {
                InputIndex.BackColor = Color.Red;
                GenerateTooltip(InputIndex, "Индекс почты должен быть числом в диапазоне от 100000 до 999999.");
                return;
            }

            try
            {
                InputIndex.BackColor = Color.White;
                NewAddress.Address.Index = index;
            }
            catch (ArgumentException error)
            {
                GenerateTooltip(InputIndex, error.Message);
                InputIndex.BackColor = Color.Red;
            }
        }

        public void ClearField()
        {
            InputIndex.Clear();
            InputCountry.Clear();
            InputCity.Clear();
            InputStreet.Clear();
            InputBuilding.Clear();
            InputApartment.Clear();
            InputIndex.BackColor = Color.White;
        }

        public AddressControl NewAddress;

        public void UpdateData(Address SomeAddress)
        {
            NewAddress.Address = SomeAddress;

            InputIndex.Text = NewAddress.Address.Index.ToString();
            InputCountry.Text = NewAddress.Address.Country.ToString();
            InputCity.Text = NewAddress.Address.City.ToString();
            InputStreet.Text = NewAddress.Address.Street.ToString();
            InputBuilding.Text = NewAddress.Address.Building.ToString();
            InputApartment.Text = NewAddress.Address.Apartment.ToString();
        }

        public Address ProvideValues()
        {
            return new Address(Convert.ToInt32(InputIndex.Text), InputCountry.Text, InputCity.Text, InputStreet.Text, InputBuilding.Text, InputApartment.Text);
        }

        public bool AddressIsNull()
        {
            if (string.IsNullOrEmpty(InputIndex.Text) ||
                string.IsNullOrEmpty(InputCountry.Text) ||
                string.IsNullOrEmpty(InputCity.Text) ||
                string.IsNullOrEmpty(InputStreet.Text) ||
                string.IsNullOrEmpty(InputBuilding.Text) ||
                string.IsNullOrEmpty(InputApartment.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
        }
    }
}
