namespace Lager_System
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerDBDataSet = new Lager_System.LagerDBDataSet();
            this.itemsTableAdapter = new Lager_System.LagerDBDataSetTableAdapters.ItemsTableAdapter();
            this.main_Menu = new System.Windows.Forms.TabControl();
            this.item_List = new System.Windows.Forms.TabPage();
            this.btn_ShowGroup = new System.Windows.Forms.Button();
            this.add_ItemGroup = new System.Windows.Forms.GroupBox();
            this.subCategoryMenu = new System.Windows.Forms.ComboBox();
            this.categoryMenu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemDescription_txtBox = new System.Windows.Forms.TextBox();
            this.itemLocation_txtBox = new System.Windows.Forms.TextBox();
            this.btn_CanelItemAdd = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.itemAmount_txtBox = new System.Windows.Forms.TextBox();
            this.itemName_txtBox = new System.Windows.Forms.TextBox();
            this.itemID_txtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Udlånte = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.afleveringer = new System.Windows.Forms.TabPage();
            this.create_User = new System.Windows.Forms.TabPage();
            this.efternavn_Label = new System.Windows.Forms.Label();
            this.txtBox_Efternavn = new System.Windows.Forms.TextBox();
            this.tlfNr_Label = new System.Windows.Forms.Label();
            this.txtBox_TlfNr = new System.Windows.Forms.TextBox();
            this.opret_Btn = new System.Windows.Forms.Button();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.txtBox_Uni = new System.Windows.Forms.TextBox();
            this.txtBox_Fornavn = new System.Windows.Forms.TextBox();
            this.email_Lable = new System.Windows.Forms.Label();
            this.uniLogin_Lable = new System.Windows.Forms.Label();
            this.fornavn_Lable = new System.Windows.Forms.Label();
            this.user_Tab = new System.Windows.Forms.TabPage();
            this.btn_hideUsers = new System.Windows.Forms.Button();
            this.btn_showUsers = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerDBDataSet1 = new Lager_System.LagerDBDataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Close2 = new System.Windows.Forms.Button();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Lager_System.LagerDBDataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSet)).BeginInit();
            this.main_Menu.SuspendLayout();
            this.item_List.SuspendLayout();
            this.add_ItemGroup.SuspendLayout();
            this.Udlånte.SuspendLayout();
            this.create_User.SuspendLayout();
            this.user_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            this.subCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.lagerDBDataSet;
            // 
            // lagerDBDataSet
            // 
            this.lagerDBDataSet.DataSetName = "LagerDBDataSet";
            this.lagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // main_Menu
            // 
            this.main_Menu.Controls.Add(this.item_List);
            this.main_Menu.Controls.Add(this.Udlånte);
            this.main_Menu.Controls.Add(this.afleveringer);
            this.main_Menu.Controls.Add(this.create_User);
            this.main_Menu.Controls.Add(this.user_Tab);
            this.main_Menu.Controls.Add(this.tabPage2);
            this.main_Menu.Location = new System.Drawing.Point(12, 12);
            this.main_Menu.Name = "main_Menu";
            this.main_Menu.SelectedIndex = 0;
            this.main_Menu.Size = new System.Drawing.Size(747, 544);
            this.main_Menu.TabIndex = 3;
            // 
            // item_List
            // 
            this.item_List.Controls.Add(this.btn_ShowGroup);
            this.item_List.Controls.Add(this.dataGridView1);
            this.item_List.Controls.Add(this.add_ItemGroup);
            this.item_List.Location = new System.Drawing.Point(4, 22);
            this.item_List.Name = "item_List";
            this.item_List.Padding = new System.Windows.Forms.Padding(3);
            this.item_List.Size = new System.Drawing.Size(739, 518);
            this.item_List.TabIndex = 0;
            this.item_List.Text = "Item";
            this.item_List.UseVisualStyleBackColor = true;
            this.item_List.Click += new System.EventHandler(this.Items_Click);
            // 
            // btn_ShowGroup
            // 
            this.btn_ShowGroup.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowGroup.Name = "btn_ShowGroup";
            this.btn_ShowGroup.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowGroup.TabIndex = 4;
            this.btn_ShowGroup.Text = "Add item";
            this.btn_ShowGroup.UseVisualStyleBackColor = true;
            this.btn_ShowGroup.Click += new System.EventHandler(this.btn_ShowGroup_Click);
            // 
            // add_ItemGroup
            // 
            this.add_ItemGroup.Controls.Add(this.subCategoryMenu);
            this.add_ItemGroup.Controls.Add(this.categoryMenu);
            this.add_ItemGroup.Controls.Add(this.label7);
            this.add_ItemGroup.Controls.Add(this.label6);
            this.add_ItemGroup.Controls.Add(this.label5);
            this.add_ItemGroup.Controls.Add(this.itemDescription_txtBox);
            this.add_ItemGroup.Controls.Add(this.itemLocation_txtBox);
            this.add_ItemGroup.Controls.Add(this.btn_CanelItemAdd);
            this.add_ItemGroup.Controls.Add(this.btn_addItem);
            this.add_ItemGroup.Controls.Add(this.itemAmount_txtBox);
            this.add_ItemGroup.Controls.Add(this.itemName_txtBox);
            this.add_ItemGroup.Controls.Add(this.itemID_txtBox);
            this.add_ItemGroup.Controls.Add(this.label4);
            this.add_ItemGroup.Controls.Add(this.label3);
            this.add_ItemGroup.Controls.Add(this.label2);
            this.add_ItemGroup.Controls.Add(this.label1);
            this.add_ItemGroup.Location = new System.Drawing.Point(6, 6);
            this.add_ItemGroup.Name = "add_ItemGroup";
            this.add_ItemGroup.Size = new System.Drawing.Size(258, 247);
            this.add_ItemGroup.TabIndex = 3;
            this.add_ItemGroup.TabStop = false;
            this.add_ItemGroup.Text = "Add item Menu";
            this.add_ItemGroup.Visible = false;
            this.add_ItemGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // subCategoryMenu
            // 
            this.subCategoryMenu.Enabled = false;
            this.subCategoryMenu.FormattingEnabled = true;
            this.subCategoryMenu.Items.AddRange(new object[] {
            "Motherboard",
            "CPU",
            "RAM",
            "GPU",
            "Cisco",
            "MTA",
            "CD/DVD"});
            this.subCategoryMenu.Location = new System.Drawing.Point(94, 115);
            this.subCategoryMenu.Name = "subCategoryMenu";
            this.subCategoryMenu.Size = new System.Drawing.Size(121, 21);
            this.subCategoryMenu.TabIndex = 5;
            // 
            // categoryMenu
            // 
            this.categoryMenu.FormattingEnabled = true;
            this.categoryMenu.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Bøger",
            "Andet",
            "Netværk"});
            this.categoryMenu.Location = new System.Drawing.Point(94, 93);
            this.categoryMenu.Name = "categoryMenu";
            this.categoryMenu.Size = new System.Drawing.Size(121, 21);
            this.categoryMenu.TabIndex = 4;
            this.categoryMenu.SelectedIndexChanged += new System.EventHandler(this.categoryMenu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sub category";
            // 
            // itemDescription_txtBox
            // 
            this.itemDescription_txtBox.Location = new System.Drawing.Point(94, 174);
            this.itemDescription_txtBox.Name = "itemDescription_txtBox";
            this.itemDescription_txtBox.Size = new System.Drawing.Size(100, 20);
            this.itemDescription_txtBox.TabIndex = 7;
            // 
            // itemLocation_txtBox
            // 
            this.itemLocation_txtBox.Location = new System.Drawing.Point(94, 147);
            this.itemLocation_txtBox.Name = "itemLocation_txtBox";
            this.itemLocation_txtBox.Size = new System.Drawing.Size(100, 20);
            this.itemLocation_txtBox.TabIndex = 6;
            // 
            // btn_CanelItemAdd
            // 
            this.btn_CanelItemAdd.Location = new System.Drawing.Point(175, 200);
            this.btn_CanelItemAdd.Name = "btn_CanelItemAdd";
            this.btn_CanelItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_CanelItemAdd.TabIndex = 9;
            this.btn_CanelItemAdd.Text = "Cancel";
            this.btn_CanelItemAdd.UseVisualStyleBackColor = true;
            this.btn_CanelItemAdd.Click += new System.EventHandler(this.btn_CanelItemAdd_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(94, 200);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 8;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // itemAmount_txtBox
            // 
            this.itemAmount_txtBox.Location = new System.Drawing.Point(94, 67);
            this.itemAmount_txtBox.Name = "itemAmount_txtBox";
            this.itemAmount_txtBox.Size = new System.Drawing.Size(100, 20);
            this.itemAmount_txtBox.TabIndex = 3;
            // 
            // itemName_txtBox
            // 
            this.itemName_txtBox.Location = new System.Drawing.Point(94, 38);
            this.itemName_txtBox.Name = "itemName_txtBox";
            this.itemName_txtBox.Size = new System.Drawing.Size(100, 20);
            this.itemName_txtBox.TabIndex = 2;
            // 
            // itemID_txtBox
            // 
            this.itemID_txtBox.Location = new System.Drawing.Point(94, 12);
            this.itemID_txtBox.Name = "itemID_txtBox";
            this.itemID_txtBox.Size = new System.Drawing.Size(100, 20);
            this.itemID_txtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // Udlånte
            // 
            this.Udlånte.Controls.Add(this.splitter1);
            this.Udlånte.Location = new System.Drawing.Point(4, 22);
            this.Udlånte.Name = "Udlånte";
            this.Udlånte.Padding = new System.Windows.Forms.Padding(3);
            this.Udlånte.Size = new System.Drawing.Size(739, 518);
            this.Udlånte.TabIndex = 1;
            this.Udlånte.Text = "Udlånt";
            this.Udlånte.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 512);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // afleveringer
            // 
            this.afleveringer.Location = new System.Drawing.Point(4, 22);
            this.afleveringer.Name = "afleveringer";
            this.afleveringer.Padding = new System.Windows.Forms.Padding(3);
            this.afleveringer.Size = new System.Drawing.Size(739, 518);
            this.afleveringer.TabIndex = 2;
            this.afleveringer.Text = "Afleveret";
            this.afleveringer.UseVisualStyleBackColor = true;
            // 
            // create_User
            // 
            this.create_User.Controls.Add(this.efternavn_Label);
            this.create_User.Controls.Add(this.txtBox_Efternavn);
            this.create_User.Controls.Add(this.tlfNr_Label);
            this.create_User.Controls.Add(this.txtBox_TlfNr);
            this.create_User.Controls.Add(this.opret_Btn);
            this.create_User.Controls.Add(this.txtBox_Email);
            this.create_User.Controls.Add(this.txtBox_Uni);
            this.create_User.Controls.Add(this.txtBox_Fornavn);
            this.create_User.Controls.Add(this.email_Lable);
            this.create_User.Controls.Add(this.uniLogin_Lable);
            this.create_User.Controls.Add(this.fornavn_Lable);
            this.create_User.Location = new System.Drawing.Point(4, 22);
            this.create_User.Name = "create_User";
            this.create_User.Padding = new System.Windows.Forms.Padding(3);
            this.create_User.Size = new System.Drawing.Size(739, 518);
            this.create_User.TabIndex = 3;
            this.create_User.Text = "Opret Kunde";
            this.create_User.UseVisualStyleBackColor = true;
            // 
            // efternavn_Label
            // 
            this.efternavn_Label.AutoSize = true;
            this.efternavn_Label.Location = new System.Drawing.Point(7, 46);
            this.efternavn_Label.Name = "efternavn_Label";
            this.efternavn_Label.Size = new System.Drawing.Size(53, 13);
            this.efternavn_Label.TabIndex = 10;
            this.efternavn_Label.Text = "Efternavn";
            // 
            // txtBox_Efternavn
            // 
            this.txtBox_Efternavn.Location = new System.Drawing.Point(81, 43);
            this.txtBox_Efternavn.Name = "txtBox_Efternavn";
            this.txtBox_Efternavn.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Efternavn.TabIndex = 2;
            // 
            // tlfNr_Label
            // 
            this.tlfNr_Label.AutoSize = true;
            this.tlfNr_Label.Location = new System.Drawing.Point(7, 125);
            this.tlfNr_Label.Name = "tlfNr_Label";
            this.tlfNr_Label.Size = new System.Drawing.Size(33, 13);
            this.tlfNr_Label.TabIndex = 8;
            this.tlfNr_Label.Text = "Tlf Nr";
            // 
            // txtBox_TlfNr
            // 
            this.txtBox_TlfNr.Location = new System.Drawing.Point(81, 122);
            this.txtBox_TlfNr.Name = "txtBox_TlfNr";
            this.txtBox_TlfNr.Size = new System.Drawing.Size(100, 20);
            this.txtBox_TlfNr.TabIndex = 5;
            // 
            // opret_Btn
            // 
            this.opret_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.opret_Btn.Location = new System.Drawing.Point(120, 148);
            this.opret_Btn.Name = "opret_Btn";
            this.opret_Btn.Size = new System.Drawing.Size(61, 47);
            this.opret_Btn.TabIndex = 6;
            this.opret_Btn.Text = "Opret";
            this.opret_Btn.UseVisualStyleBackColor = true;
            this.opret_Btn.Click += new System.EventHandler(this.opret_Btn_Click);
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(81, 96);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Email.TabIndex = 4;
            // 
            // txtBox_Uni
            // 
            this.txtBox_Uni.Location = new System.Drawing.Point(81, 69);
            this.txtBox_Uni.Name = "txtBox_Uni";
            this.txtBox_Uni.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Uni.TabIndex = 3;
            // 
            // txtBox_Fornavn
            // 
            this.txtBox_Fornavn.Location = new System.Drawing.Point(81, 16);
            this.txtBox_Fornavn.Name = "txtBox_Fornavn";
            this.txtBox_Fornavn.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Fornavn.TabIndex = 1;
            // 
            // email_Lable
            // 
            this.email_Lable.AutoSize = true;
            this.email_Lable.Location = new System.Drawing.Point(7, 99);
            this.email_Lable.Name = "email_Lable";
            this.email_Lable.Size = new System.Drawing.Size(51, 13);
            this.email_Lable.TabIndex = 2;
            this.email_Lable.Text = "Email Adr";
            // 
            // uniLogin_Lable
            // 
            this.uniLogin_Lable.AutoSize = true;
            this.uniLogin_Lable.Location = new System.Drawing.Point(7, 72);
            this.uniLogin_Lable.Name = "uniLogin_Lable";
            this.uniLogin_Lable.Size = new System.Drawing.Size(52, 13);
            this.uniLogin_Lable.TabIndex = 1;
            this.uniLogin_Lable.Text = "Uni Login";
            // 
            // fornavn_Lable
            // 
            this.fornavn_Lable.AutoSize = true;
            this.fornavn_Lable.Location = new System.Drawing.Point(7, 16);
            this.fornavn_Lable.Name = "fornavn_Lable";
            this.fornavn_Lable.Size = new System.Drawing.Size(46, 13);
            this.fornavn_Lable.TabIndex = 0;
            this.fornavn_Lable.Text = "Fornavn";
            // 
            // user_Tab
            // 
            this.user_Tab.Controls.Add(this.btn_hideUsers);
            this.user_Tab.Controls.Add(this.btn_showUsers);
            this.user_Tab.Controls.Add(this.btn_Refresh);
            this.user_Tab.Controls.Add(this.userDataGrid);
            this.user_Tab.Location = new System.Drawing.Point(4, 22);
            this.user_Tab.Name = "user_Tab";
            this.user_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.user_Tab.Size = new System.Drawing.Size(739, 518);
            this.user_Tab.TabIndex = 4;
            this.user_Tab.Text = "Users";
            this.user_Tab.UseVisualStyleBackColor = true;
            // 
            // btn_hideUsers
            // 
            this.btn_hideUsers.Location = new System.Drawing.Point(86, 7);
            this.btn_hideUsers.Name = "btn_hideUsers";
            this.btn_hideUsers.Size = new System.Drawing.Size(75, 23);
            this.btn_hideUsers.TabIndex = 3;
            this.btn_hideUsers.Text = "Hide users";
            this.btn_hideUsers.UseVisualStyleBackColor = true;
            this.btn_hideUsers.Visible = false;
            this.btn_hideUsers.Click += new System.EventHandler(this.btn_hideUsers_Click);
            // 
            // btn_showUsers
            // 
            this.btn_showUsers.Location = new System.Drawing.Point(4, 7);
            this.btn_showUsers.Name = "btn_showUsers";
            this.btn_showUsers.Size = new System.Drawing.Size(75, 23);
            this.btn_showUsers.TabIndex = 2;
            this.btn_showUsers.Text = "Show users";
            this.btn_showUsers.UseVisualStyleBackColor = true;
            this.btn_showUsers.Click += new System.EventHandler(this.btn_showUsers_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(658, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // userDataGrid
            // 
            this.userDataGrid.AutoGenerateColumns = false;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.uniloginDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.tlfNrDataGridViewTextBoxColumn});
            this.userDataGrid.DataSource = this.usersBindingSource;
            this.userDataGrid.Location = new System.Drawing.Point(0, 32);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.Size = new System.Drawing.Size(736, 480);
            this.userDataGrid.TabIndex = 0;
            this.userDataGrid.Visible = false;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // uniloginDataGridViewTextBoxColumn
            // 
            this.uniloginDataGridViewTextBoxColumn.DataPropertyName = "Unilogin";
            this.uniloginDataGridViewTextBoxColumn.HeaderText = "Unilogin";
            this.uniloginDataGridViewTextBoxColumn.Name = "uniloginDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tlfNrDataGridViewTextBoxColumn
            // 
            this.tlfNrDataGridViewTextBoxColumn.DataPropertyName = "TlfNr";
            this.tlfNrDataGridViewTextBoxColumn.HeaderText = "TlfNr";
            this.tlfNrDataGridViewTextBoxColumn.Name = "tlfNrDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.lagerDBDataSet1;
            // 
            // lagerDBDataSet1
            // 
            this.lagerDBDataSet1.DataSetName = "LagerDBDataSet1";
            this.lagerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 518);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lagerDBDataSetBindingSource
            // 
            this.lagerDBDataSetBindingSource.DataSource = this.lagerDBDataSet;
            this.lagerDBDataSetBindingSource.Position = 0;
            // 
            // btn_Close2
            // 
            this.btn_Close2.Location = new System.Drawing.Point(684, 6);
            this.btn_Close2.Name = "btn_Close2";
            this.btn_Close2.Size = new System.Drawing.Size(75, 22);
            this.btn_Close2.TabIndex = 4;
            this.btn_Close2.Text = "Close";
            this.btn_Close2.UseVisualStyleBackColor = false;
            this.btn_Close2.Click += new System.EventHandler(this.btn_Close2_Click);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.lagerDBDataSetBindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 558);
            this.Controls.Add(this.btn_Close2);
            this.Controls.Add(this.main_Menu);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSet)).EndInit();
            this.main_Menu.ResumeLayout(false);
            this.item_List.ResumeLayout(false);
            this.add_ItemGroup.ResumeLayout(false);
            this.add_ItemGroup.PerformLayout();
            this.Udlånte.ResumeLayout(false);
            this.create_User.ResumeLayout(false);
            this.create_User.PerformLayout();
            this.user_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LagerDBDataSet lagerDBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private LagerDBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl main_Menu;
        private System.Windows.Forms.TabPage item_List;
        private System.Windows.Forms.TabPage Udlånte;
        private System.Windows.Forms.Button btn_Close2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage afleveringer;
        private System.Windows.Forms.TabPage create_User;
        private System.Windows.Forms.Label fornavn_Lable;
        private System.Windows.Forms.Label email_Lable;
        private System.Windows.Forms.Label uniLogin_Lable;
        private System.Windows.Forms.Button opret_Btn;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.TextBox txtBox_Uni;
        private System.Windows.Forms.TextBox txtBox_Fornavn;
        private System.Windows.Forms.Label tlfNr_Label;
        private System.Windows.Forms.TextBox txtBox_TlfNr;
        private System.Windows.Forms.TabPage user_Tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label efternavn_Label;
        private System.Windows.Forms.TextBox txtBox_Efternavn;
        private System.Windows.Forms.BindingSource lagerDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private LagerDBDataSet1 lagerDBDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LagerDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox add_ItemGroup;
        private System.Windows.Forms.TextBox itemAmount_txtBox;
        private System.Windows.Forms.TextBox itemName_txtBox;
        private System.Windows.Forms.TextBox itemID_txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ShowGroup;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_CanelItemAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemDescription_txtBox;
        private System.Windows.Forms.TextBox itemLocation_txtBox;
        private System.Windows.Forms.Button btn_showUsers;
        private System.Windows.Forms.Button btn_hideUsers;
        private System.Windows.Forms.ComboBox subCategoryMenu;
        private System.Windows.Forms.ComboBox categoryMenu;
    }
}