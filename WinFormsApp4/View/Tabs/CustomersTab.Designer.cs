namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            splitContainerCustomers = new SplitContainer();
            groupBoxCustomers = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdd = new Button();
            duttonRemove = new Button();
            listBoxCustomer = new ListBox();
            groupBoxSelectedCustomer = new GroupBox();
            textAddress = new TextBox();
            textFullName = new TextBox();
            textID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainerCustomers).BeginInit();
            splitContainerCustomers.Panel1.SuspendLayout();
            splitContainerCustomers.Panel2.SuspendLayout();
            splitContainerCustomers.SuspendLayout();
            groupBoxCustomers.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxSelectedCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerCustomers
            // 
            splitContainerCustomers.Dock = DockStyle.Fill;
            splitContainerCustomers.Location = new Point(0, 0);
            splitContainerCustomers.Name = "splitContainerCustomers";
            // 
            // splitContainerCustomers.Panel1
            // 
            splitContainerCustomers.Panel1.Controls.Add(groupBoxCustomers);
            splitContainerCustomers.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainerCustomers.Panel2
            // 
            splitContainerCustomers.Panel2.Controls.Add(panel1);
            splitContainerCustomers.Panel2.Controls.Add(groupBoxSelectedCustomer);
            splitContainerCustomers.Size = new Size(753, 533);
            splitContainerCustomers.SplitterDistance = 284;
            splitContainerCustomers.TabIndex = 0;
            // 
            // groupBoxCustomers
            // 
            groupBoxCustomers.Controls.Add(tableLayoutPanel1);
            groupBoxCustomers.Controls.Add(listBoxCustomer);
            groupBoxCustomers.Dock = DockStyle.Fill;
            groupBoxCustomers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxCustomers.Location = new Point(0, 0);
            groupBoxCustomers.Name = "groupBoxCustomers";
            groupBoxCustomers.Size = new Size(284, 533);
            groupBoxCustomers.TabIndex = 0;
            groupBoxCustomers.TabStop = false;
            groupBoxCustomers.Text = "Customers";
            groupBoxCustomers.Enter += groupBoxCustomers_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.484848F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.515152F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(duttonRemove, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 476);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(272, 54);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 9F);
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 48);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // duttonRemove
            // 
            duttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            duttonRemove.Font = new Font("Segoe UI", 9F);
            duttonRemove.Location = new Point(94, 3);
            duttonRemove.Name = "duttonRemove";
            duttonRemove.Size = new Size(90, 48);
            duttonRemove.TabIndex = 1;
            duttonRemove.Text = "Remove";
            duttonRemove.UseVisualStyleBackColor = true;
            duttonRemove.Click += duttonRemove_Click;
            // 
            // listBoxCustomer
            // 
            listBoxCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCustomer.Font = new Font("Segoe UI", 9F);
            listBoxCustomer.FormattingEnabled = true;
            listBoxCustomer.Location = new Point(6, 26);
            listBoxCustomer.Name = "listBoxCustomer";
            listBoxCustomer.Size = new Size(272, 444);
            listBoxCustomer.TabIndex = 0;
            listBoxCustomer.SelectedIndexChanged += listBoxCustomer_SelectedIndexChanged;
            // 
            // groupBoxSelectedCustomer
            // 
            groupBoxSelectedCustomer.BackColor = SystemColors.ControlLightLight;
            groupBoxSelectedCustomer.Controls.Add(textAddress);
            groupBoxSelectedCustomer.Controls.Add(textFullName);
            groupBoxSelectedCustomer.Controls.Add(textID);
            groupBoxSelectedCustomer.Controls.Add(label3);
            groupBoxSelectedCustomer.Controls.Add(label2);
            groupBoxSelectedCustomer.Controls.Add(label1);
            groupBoxSelectedCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxSelectedCustomer.Location = new Point(3, 3);
            groupBoxSelectedCustomer.Name = "groupBoxSelectedCustomer";
            groupBoxSelectedCustomer.Size = new Size(459, 288);
            groupBoxSelectedCustomer.TabIndex = 0;
            groupBoxSelectedCustomer.TabStop = false;
            groupBoxSelectedCustomer.Text = "Selected Customer";
            groupBoxSelectedCustomer.Enter += groupBoxSelectedCustomer_Enter;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(18, 135);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(435, 144);
            textAddress.TabIndex = 5;
            textAddress.TextChanged += textAddress_TextChanged;
            // 
            // textFullName
            // 
            textFullName.Location = new Point(100, 74);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(253, 27);
            textFullName.TabIndex = 4;
            textFullName.TextChanged += textFullName_TextChanged;
            // 
            // textID
            // 
            textID.Location = new Point(100, 32);
            textID.Name = "textID";
            textID.Size = new Size(125, 27);
            textID.TabIndex = 3;
            textID.TextChanged += textID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(18, 112);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(3, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 242);
            panel1.TabIndex = 1;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerCustomers);
            Name = "CustomersTab";
            Size = new Size(753, 533);
            splitContainerCustomers.Panel1.ResumeLayout(false);
            splitContainerCustomers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerCustomers).EndInit();
            splitContainerCustomers.ResumeLayout(false);
            groupBoxCustomers.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxSelectedCustomer.ResumeLayout(false);
            groupBoxSelectedCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerCustomers;
        private GroupBox groupBoxCustomers;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private ListBox listBoxCustomer;
        private Button duttonRemove;
        private GroupBox groupBoxSelectedCustomer;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textAddress;
        private TextBox textFullName;
        private TextBox textID;
        private Panel panel1;
    }
}
