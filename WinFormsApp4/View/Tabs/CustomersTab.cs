using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {   
        private List<Customer> _customers = new List<Customer>();
        private Customer _actualCustomer;
        private List<string> CustomersListBoxItems = new List<string>();

        private ValueValidator validator = new ValueValidator();


        public CustomersTab()
        {
            InitializeComponent();
        }

        public List<Customer> Customer
        {
            get 
            {
                return _customers; 
            }
            set
            {
                _customers = value;

            }
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedIndex == -1 || listBoxCustomer.Items.Count == 0)
            {
                addressControl1.IsUpdatingFieldFlag = true;
                buttonAdd.Enabled = true;
                ClearFields();
            }
            else
            {
                addressControl1.IsUpdatingFieldFlag = false;
                buttonAdd.Enabled = false;
                int selectedIndex = listBoxCustomer.SelectedIndex;
                if (selectedIndex == -1) return;
                _actualCustomer = Customer[selectedIndex];
                textID.Text = _actualCustomer.Id.ToString();
                textFullName.Text = _actualCustomer.FullName;

                addressControl1.UpdateData(_actualCustomer.Address);

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFullName.Text) || addressControl1.AddressIsNull())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (IsNumeric(textFullName.Text))
            {
                MessageBox.Show("FullName имеет только строковой тип");
                return;
            }

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = textFullName.Text;
            NewCustomer.Address = addressControl1.ProvideValues();

            Customer.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()}. {NewCustomer.FullName}");
            listBoxCustomer.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            ClearFields();
        }


        public void ClearFields()
        {
            textID.Clear();
            textFullName.Clear();
            addressControl1.ClearField();
            textFullName.BackColor = Color.White;   
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCustomer.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                listBoxCustomer.Items.RemoveAt(selectedIndex);
                _actualCustomer = null;
                ClearFields();
            }
        }

        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true; // Если хотя бы один символ — цифра, возвращаем true
                }
            }
            return false; // Если нет цифр, возвращаем false
        }


        private void listBoxCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomer.IndexFromPoint(e.Location) == -1)
            {
                addressControl1.IsUpdatingFieldFlag = false;
                listBoxCustomer.ClearSelected();
                ClearFields();
            }
        }
    }
}


