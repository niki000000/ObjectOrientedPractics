namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsTab));
            splitContainer1 = new SplitContainer();
            groupBoxItems = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonRemove = new Button();
            itemsListBox = new ListBox();
            groupBoxSelectedItem = new GroupBox();
            labelDescription = new Label();
            labelName = new Label();
            labelCost = new Label();
            labelID = new Label();
            inputDescription = new TextBox();
            inputName = new TextBox();
            inputCost = new TextBox();
            inputID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxItems.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxSelectedItem.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxItems);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxSelectedItem);
            // 
            // groupBoxItems
            // 
            resources.ApplyResources(groupBoxItems, "groupBoxItems");
            groupBoxItems.Controls.Add(tableLayoutPanel1);
            groupBoxItems.Controls.Add(itemsListBox);
            groupBoxItems.Name = "groupBoxItems";
            groupBoxItems.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRemove, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(buttonAdd, "buttonAdd");
            buttonAdd.Name = "buttonAdd";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            resources.ApplyResources(buttonRemove, "buttonRemove");
            buttonRemove.Name = "buttonRemove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // itemsListBox
            // 
            resources.ApplyResources(itemsListBox, "itemsListBox");
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Name = "itemsListBox";
            itemsListBox.SelectedIndexChanged += listItems;
            // 
            // groupBoxSelectedItem
            // 
            groupBoxSelectedItem.Controls.Add(labelDescription);
            groupBoxSelectedItem.Controls.Add(labelName);
            groupBoxSelectedItem.Controls.Add(labelCost);
            groupBoxSelectedItem.Controls.Add(labelID);
            groupBoxSelectedItem.Controls.Add(inputDescription);
            groupBoxSelectedItem.Controls.Add(inputName);
            groupBoxSelectedItem.Controls.Add(inputCost);
            groupBoxSelectedItem.Controls.Add(inputID);
            resources.ApplyResources(groupBoxSelectedItem, "groupBoxSelectedItem");
            groupBoxSelectedItem.Name = "groupBoxSelectedItem";
            groupBoxSelectedItem.TabStop = false;
            
            // 
            // labelDescription
            // 
            resources.ApplyResources(labelDescription, "labelDescription");
            labelDescription.Name = "labelDescription";
            // 
            // labelName
            // 
            resources.ApplyResources(labelName, "labelName");
            labelName.Name = "labelName";
            // 
            // labelCost
            // 
            resources.ApplyResources(labelCost, "labelCost");
            labelCost.Name = "labelCost";
            // 
            // labelID
            // 
            resources.ApplyResources(labelID, "labelID");
            labelID.Name = "labelID";
            // 
            // inputDescription
            // 
            resources.ApplyResources(inputDescription, "inputDescription");
            inputDescription.Name = "inputDescription";
            inputDescription.TextChanged += textBoxInputDescription;
            // 
            // inputName
            // 
            resources.ApplyResources(inputName, "inputName");
            inputName.Name = "inputName";
            inputName.TextChanged += textBoxInputName;
            // 
            // inputCost
            // 
            resources.ApplyResources(inputCost, "inputCost");
            inputCost.Name = "inputCost";
            inputCost.TextChanged += textBoxInputCost;
            // 
            // inputID
            // 
            resources.ApplyResources(inputID, "inputID");
            inputID.Name = "inputID";
            inputID.TextChanged += textBoxInputId;
            // 
            // ItemsTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxItems.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxSelectedItem.ResumeLayout(false);
            groupBoxSelectedItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox itemsListBox;
        private Button buttonAdd;
        private Button buttonRemove;
        internal GroupBox groupBoxItems;
        internal TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxSelectedItem;
        private Label labelDescription;
        private Label labelName;
        private Label labelCost;
        private Label labelID;
        private TextBox inputDescription;
        private TextBox inputName;
        private TextBox inputCost;
        private TextBox inputID;
    }
}
