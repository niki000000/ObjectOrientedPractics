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

        private List<Customer> items = new();

        private AddressControl addressControl;

        private ValueValidator validator = new ValueValidator();

        public CustomersTab()
        {
            InitializeComponent();
            addressControl = new AddressControl();
            textID.ReadOnly = true;
        }

        private void groupBoxCustomers_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxSelectedCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedItem is Customer selectedItem)
            {
                textID.Text = selectedItem.Id.ToString();
                textFullName.Text = selectedItem.FullName;
                
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullName = textFullName.Text;
            Address address = new Address();
            

            
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Введите полное имя.");
                return;
            }

            try
            {
                Address newAddress = new Address();
                Customer newCustomer = new Customer(fullName, address);
                items.Add(newCustomer);
                UpdateListBox();
                ClearFields();
                addressControl.ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void  UpdateListBox()
        {
            listBoxCustomer.DataSource = null;
            listBoxCustomer.DataSource = items;
            listBoxCustomer.DisplayMember = "Display";
        }

        public void ClearFields()
        {
            textID.Clear();
            textFullName.Clear();
            
        }
        private void duttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedItem is Customer selectedItem)
            {
                items.Remove(selectedItem);
                UpdateListBox();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}


