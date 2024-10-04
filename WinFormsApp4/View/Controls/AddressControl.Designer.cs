namespace ObjectOrientedPractics.View.Tabs
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxAddress = new GroupBox();
            InputApartment = new TextBox();
            labelApartment = new Label();
            InputCity = new TextBox();
            labelCity = new Label();
            InputBuilding = new TextBox();
            InputStreet = new TextBox();
            InputCountry = new TextBox();
            InputIndex = new TextBox();
            labelBuilding = new Label();
            labelStreet = new Label();
            labelCountry = new Label();
            labelIndex = new Label();
            groupBoxAddress.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddress
            // 
            groupBoxAddress.Controls.Add(InputApartment);
            groupBoxAddress.Controls.Add(labelApartment);
            groupBoxAddress.Controls.Add(InputCity);
            groupBoxAddress.Controls.Add(labelCity);
            groupBoxAddress.Controls.Add(InputBuilding);
            groupBoxAddress.Controls.Add(InputStreet);
            groupBoxAddress.Controls.Add(InputCountry);
            groupBoxAddress.Controls.Add(InputIndex);
            groupBoxAddress.Controls.Add(labelBuilding);
            groupBoxAddress.Controls.Add(labelStreet);
            groupBoxAddress.Controls.Add(labelCountry);
            groupBoxAddress.Controls.Add(labelIndex);
            groupBoxAddress.Dock = DockStyle.Fill;
            groupBoxAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxAddress.Location = new Point(0, 0);
            groupBoxAddress.Name = "groupBoxAddress";
            groupBoxAddress.Size = new Size(661, 219);
            groupBoxAddress.TabIndex = 0;
            groupBoxAddress.TabStop = false;
            groupBoxAddress.Text = "Delivery Address";
            groupBoxAddress.Enter += groupBoxAddress_Enter;
            // 
            // InputApartment
            // 
            InputApartment.Location = new Point(272, 165);
            InputApartment.Name = "InputApartment";
            InputApartment.Size = new Size(79, 27);
            InputApartment.TabIndex = 11;
            InputApartment.TextChanged += InputApartment_TextChanged;
            // 
            // labelApartment
            // 
            labelApartment.AutoSize = true;
            labelApartment.Font = new Font("Segoe UI", 9F);
            labelApartment.Location = new Point(188, 168);
            labelApartment.Name = "labelApartment";
            labelApartment.Size = new Size(78, 20);
            labelApartment.TabIndex = 10;
            labelApartment.Text = "Apartmen:";
            // 
            // InputCity
            // 
            InputCity.Location = new Point(315, 89);
            InputCity.Name = "InputCity";
            InputCity.Size = new Size(135, 27);
            InputCity.TabIndex = 9;
            InputCity.TextChanged += textBox5_TextChanged;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 9F);
            labelCity.Location = new Point(272, 92);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(37, 20);
            labelCity.TabIndex = 8;
            labelCity.Text = "City:";
            // 
            // InputBuilding
            // 
            InputBuilding.Location = new Point(102, 165);
            InputBuilding.Name = "InputBuilding";
            InputBuilding.Size = new Size(80, 27);
            InputBuilding.TabIndex = 7;
            InputBuilding.TextChanged += InputBuilding_TextChanged;
            // 
            // InputStreet
            // 
            InputStreet.Location = new Point(102, 125);
            InputStreet.Name = "InputStreet";
            InputStreet.Size = new Size(348, 27);
            InputStreet.TabIndex = 6;
            InputStreet.TextChanged += textBox3_TextChanged;
            // 
            // InputCountry
            // 
            InputCountry.Location = new Point(102, 89);
            InputCountry.Name = "InputCountry";
            InputCountry.Size = new Size(164, 27);
            InputCountry.TabIndex = 5;
            InputCountry.TextChanged += InputCountry_TextChanged;
            // 
            // InputIndex
            // 
            InputIndex.Location = new Point(102, 51);
            InputIndex.Name = "InputIndex";
            InputIndex.Size = new Size(125, 27);
            InputIndex.TabIndex = 4;
            InputIndex.TextChanged += InputIndex_TextChanged;
            // 
            // labelBuilding
            // 
            labelBuilding.AutoSize = true;
            labelBuilding.Font = new Font("Segoe UI", 9F);
            labelBuilding.Location = new Point(17, 165);
            labelBuilding.Name = "labelBuilding";
            labelBuilding.Size = new Size(67, 20);
            labelBuilding.TabIndex = 3;
            labelBuilding.Text = "Building:";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Font = new Font("Segoe UI", 9F);
            labelStreet.Location = new Point(17, 125);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(51, 20);
            labelStreet.TabIndex = 2;
            labelStreet.Text = "Street:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 9F);
            labelCountry.Location = new Point(17, 89);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(63, 20);
            labelCountry.TabIndex = 1;
            labelCountry.Text = "Country:";
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Font = new Font("Segoe UI", 9F);
            labelIndex.Location = new Point(17, 51);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(79, 20);
            labelIndex.TabIndex = 0;
            labelIndex.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAddress);
            Name = "AddressControl";
            Size = new Size(661, 219);
            groupBoxAddress.ResumeLayout(false);
            groupBoxAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddress;
        private Label labelBuilding;
        private Label labelStreet;
        private Label labelCountry;
        private Label labelIndex;
        private TextBox InputCity;
        private Label labelCity;
        private TextBox InputBuilding;
        private TextBox InputStreet;
        private TextBox InputCountry;
        private TextBox InputIndex;
        private Label labelApartment;
        private TextBox InputApartment;
    }
}
