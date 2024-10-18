using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Позволяет добавлять, удалять и отображать товары.
    /// </summary>
    /// 
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список элементов класса <see cref="Item"/>
        /// </summary>
        private List<Item> items = new();

        /// <summary>
        /// Переменная класса <see cref="ValueValidator"/>, хранящего метод валидации строк.
        /// </summary>
        private ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ItemsTab"/> и настраивает события.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            listCategory.DataSource = Enum.GetValues(typeof(Category));
            inputID.ReadOnly = true;
        }



        

            private void listItems(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem is Item selectedItem)
            {
                inputID.Text = selectedItem.Id.ToString();
                inputName.Text = selectedItem.Name;
                inputDescription.Text = selectedItem.Info;
                inputCost.Text = selectedItem.Cost.ToString();
                listCategory.SelectedItem = selectedItem.Category;
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem is Item selectedItem)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double cost;
            string name;
            string info;

            
            name = inputName.Text;
            info = inputDescription.Text;

            try
            {

                if (!double.TryParse(inputCost.Text, out cost) || !CostValid(cost))
                {
                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
                }
                Category category = (Category) listCategory.SelectedItem;
                Item newItem = new Item(name, info, cost, category);
                
                items.Add(newItem);
                UpdateListBox();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректную стоимость.");
            }


        }

        /// <summary>
        /// Обновляет список товаров в ListBox.
        /// </summary>
        public void UpdateListBox()
        {
            itemsListBox.DataSource = null;
            itemsListBox.DataSource = items;
            itemsListBox.DisplayMember = "Display";
        }


        /// <summary>
        /// Очищает поля ввода.
        /// </summary>
        public void ClearFields()
        {
            inputID.Clear();
            inputName.Clear();
            inputCost.Clear();
            inputDescription.Clear();
            listCategory.SelectedIndex = -1;

        }

        /// <summary>
        /// Проверяет введенное значение Cost.
        /// </summary>
        /// <param name="value">Введенное значение.</param>
        /// <returns>Если стоимость товара допустима, True, иначе False.
        /// </returns>
        private bool CostValid(double value)
        {
            return value > 0.0 && value < 100000.0;
        }

        private void textBoxInputName(object sender, EventArgs e)
        {
            ValidName();
        }

        private void textBoxInputDescription(object sender, EventArgs e)
        {
            ValidInfo();
        }

        /// <summary>
        /// Проверяет количество символов в поле Name.
        /// </summary>
        private void ValidName()
        {
            try
            {
                validator.AssertStringOnLength(inputName.Text, 200, nameof(inputName));
                inputName.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException ex)
            {
                inputName.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Name должно быть меньше 200 символов.");
            }
        }

        /// <summary>
        /// Проверяет количество символов в поле Info.
        /// </summary>
        private void ValidInfo()
        {
            try
            {
                validator.AssertStringOnLength(inputDescription.Text, 1000, nameof(inputDescription));
                inputDescription.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException ex)
            {
                inputDescription.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Info должно быть меньше 200 символов.");
            }
        }


        private void ListCategory_SelectedIndexChanget(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem is Item selectedItem && listCategory.SelectedItem is Category selectedCategory)
            {
                selectedItem.Category = selectedCategory;
            }
        }
    }
}
