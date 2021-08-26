
namespace AragonApp
{
    partial class Customer
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
            System.Windows.Forms.Label custFirstLabel;
            System.Windows.Forms.Label custIDLabel;
            System.Windows.Forms.Label custLastLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label headHHLabel;
            System.Windows.Forms.Label houseIDLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label planIDLabel1;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label webSiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCustomerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.custFirstTextBox = new System.Windows.Forms.TextBox();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.custLastTextBox = new System.Windows.Forms.TextBox();
            this.dOBTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.headHHCheckBox = new System.Windows.Forms.CheckBox();
            this.houseIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.planIDTextBox1 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.webSiteTextBox = new System.Windows.Forms.TextBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.lblSearchChoice = new System.Windows.Forms.Label();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            custFirstLabel = new System.Windows.Forms.Label();
            custIDLabel = new System.Windows.Forms.Label();
            custLastLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            headHHLabel = new System.Windows.Forms.Label();
            houseIDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            planIDLabel1 = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            webSiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingNavigator)).BeginInit();
            this.tblCustomerBindingNavigator.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // custFirstLabel
            // 
            custFirstLabel.AutoSize = true;
            custFirstLabel.Location = new System.Drawing.Point(87, 176);
            custFirstLabel.Name = "custFirstLabel";
            custFirstLabel.Size = new System.Drawing.Size(53, 13);
            custFirstLabel.TabIndex = 8;
            custFirstLabel.Text = "Cust First:";
            // 
            // custIDLabel
            // 
            custIDLabel.AutoSize = true;
            custIDLabel.Location = new System.Drawing.Point(87, 147);
            custIDLabel.Name = "custIDLabel";
            custIDLabel.Size = new System.Drawing.Size(45, 13);
            custIDLabel.TabIndex = 10;
            custIDLabel.Text = "Cust ID:";
            // 
            // custLastLabel
            // 
            custLastLabel.AutoSize = true;
            custLastLabel.Location = new System.Drawing.Point(87, 204);
            custLastLabel.Name = "custLastLabel";
            custLastLabel.Size = new System.Drawing.Size(54, 13);
            custLastLabel.TabIndex = 12;
            custLastLabel.Text = "Cust Last:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(87, 230);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 14;
            dOBLabel.Text = "DOB:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(87, 256);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // headHHLabel
            // 
            headHHLabel.AutoSize = true;
            headHHLabel.Location = new System.Drawing.Point(87, 284);
            headHHLabel.Name = "headHHLabel";
            headHHLabel.Size = new System.Drawing.Size(55, 13);
            headHHLabel.TabIndex = 18;
            headHHLabel.Text = "Head HH:";
            // 
            // houseIDLabel
            // 
            houseIDLabel.AutoSize = true;
            houseIDLabel.Location = new System.Drawing.Point(87, 314);
            houseIDLabel.Name = "houseIDLabel";
            houseIDLabel.Size = new System.Drawing.Size(55, 13);
            houseIDLabel.TabIndex = 20;
            houseIDLabel.Text = "House ID:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(394, 147);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 26;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(394, 173);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 28;
            cityLabel.Text = "City:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(394, 202);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 32;
            phoneLabel1.Text = "Phone:";
            // 
            // planIDLabel1
            // 
            planIDLabel1.AutoSize = true;
            planIDLabel1.Location = new System.Drawing.Point(394, 228);
            planIDLabel1.Name = "planIDLabel1";
            planIDLabel1.Size = new System.Drawing.Size(45, 13);
            planIDLabel1.TabIndex = 34;
            planIDLabel1.Text = "Plan ID:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(394, 257);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 38;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(394, 283);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(52, 13);
            provinceLabel.TabIndex = 40;
            provinceLabel.Text = "Province:";
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.Location = new System.Drawing.Point(394, 314);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(54, 13);
            webSiteLabel.TabIndex = 42;
            webSiteLabel.Text = "Web Site:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(259, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Data Entry";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataSource = typeof(AragonClassLibrary.tblCustomer);
            // 
            // tblCustomerBindingNavigator
            // 
            this.tblCustomerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCustomerBindingNavigator.BindingSource = this.tblCustomerBindingSource;
            this.tblCustomerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCustomerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCustomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblCustomerBindingNavigatorSaveItem});
            this.tblCustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCustomerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCustomerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCustomerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCustomerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCustomerBindingNavigator.Name = "tblCustomerBindingNavigator";
            this.tblCustomerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCustomerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblCustomerBindingNavigator.TabIndex = 1;
            this.tblCustomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblCustomerBindingNavigatorSaveItem
            // 
            this.tblCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCustomerBindingNavigatorSaveItem.Enabled = false;
            this.tblCustomerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCustomerBindingNavigatorSaveItem.Image")));
            this.tblCustomerBindingNavigatorSaveItem.Name = "tblCustomerBindingNavigatorSaveItem";
            this.tblCustomerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCustomerBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // custFirstTextBox
            // 
            this.custFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustFirst", true));
            this.custFirstTextBox.Location = new System.Drawing.Point(172, 173);
            this.custFirstTextBox.Name = "custFirstTextBox";
            this.custFirstTextBox.Size = new System.Drawing.Size(146, 20);
            this.custFirstTextBox.TabIndex = 9;
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustID", true));
            this.custIDTextBox.Location = new System.Drawing.Point(172, 147);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.ReadOnly = true;
            this.custIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.custIDTextBox.TabIndex = 11;
            // 
            // custLastTextBox
            // 
            this.custLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustLast", true));
            this.custLastTextBox.Location = new System.Drawing.Point(172, 201);
            this.custLastTextBox.Name = "custLastTextBox";
            this.custLastTextBox.Size = new System.Drawing.Size(146, 20);
            this.custLastTextBox.TabIndex = 13;
            // 
            // dOBTextBox
            // 
            this.dOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "DOB", true));
            this.dOBTextBox.Location = new System.Drawing.Point(172, 227);
            this.dOBTextBox.Name = "dOBTextBox";
            this.dOBTextBox.Size = new System.Drawing.Size(146, 20);
            this.dOBTextBox.TabIndex = 15;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(172, 253);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(146, 20);
            this.genderTextBox.TabIndex = 17;
            // 
            // headHHCheckBox
            // 
            this.headHHCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCustomerBindingSource, "HeadHH", true));
            this.headHHCheckBox.Location = new System.Drawing.Point(172, 279);
            this.headHHCheckBox.Name = "headHHCheckBox";
            this.headHHCheckBox.Size = new System.Drawing.Size(146, 24);
            this.headHHCheckBox.TabIndex = 19;
            this.headHHCheckBox.Text = "checkBox1";
            this.headHHCheckBox.UseVisualStyleBackColor = true;
            // 
            // houseIDTextBox
            // 
            this.houseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "HouseID", true));
            this.houseIDTextBox.Location = new System.Drawing.Point(172, 307);
            this.houseIDTextBox.Name = "houseIDTextBox";
            this.houseIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.houseIDTextBox.TabIndex = 21;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(467, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(270, 20);
            this.addressTextBox.TabIndex = 27;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.City", true));
            this.cityTextBox.Location = new System.Drawing.Point(467, 173);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(270, 20);
            this.cityTextBox.TabIndex = 29;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(467, 199);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(270, 20);
            this.phoneTextBox1.TabIndex = 33;
            // 
            // planIDTextBox1
            // 
            this.planIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.PlanID", true));
            this.planIDTextBox1.Location = new System.Drawing.Point(467, 225);
            this.planIDTextBox1.Name = "planIDTextBox1";
            this.planIDTextBox1.Size = new System.Drawing.Size(270, 20);
            this.planIDTextBox1.TabIndex = 35;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(467, 254);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(270, 20);
            this.postalCodeTextBox.TabIndex = 39;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Province", true));
            this.provinceTextBox.Location = new System.Drawing.Point(467, 280);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(270, 20);
            this.provinceTextBox.TabIndex = 41;
            // 
            // webSiteTextBox
            // 
            this.webSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.WebSite", true));
            this.webSiteTextBox.Location = new System.Drawing.Point(467, 307);
            this.webSiteTextBox.Name = "webSiteTextBox";
            this.webSiteTextBox.Size = new System.Drawing.Size(270, 20);
            this.webSiteTextBox.TabIndex = 43;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.txtSearchInput);
            this.gbxSearch.Controls.Add(this.lblSearchChoice);
            this.gbxSearch.Controls.Add(this.cbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearchBy);
            this.gbxSearch.Location = new System.Drawing.Point(90, 360);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(399, 115);
            this.gbxSearch.TabIndex = 44;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Section";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(126, 77);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(146, 20);
            this.txtSearchInput.TabIndex = 3;
            // 
            // lblSearchChoice
            // 
            this.lblSearchChoice.AutoSize = true;
            this.lblSearchChoice.Location = new System.Drawing.Point(15, 80);
            this.lblSearchChoice.Name = "lblSearchChoice";
            this.lblSearchChoice.Size = new System.Drawing.Size(105, 13);
            this.lblSearchChoice.TabIndex = 2;
            this.lblSearchChoice.Text = "Enter your input here";
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "1. Customer\'s First Name",
            "2. Customer\'s Last Name",
            "3. Customer\'s Date Of Birth"});
            this.cbxSearch.Location = new System.Drawing.Point(82, 40);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(190, 21);
            this.cbxSearch.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(15, 43);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(62, 13);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By :";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(planIDLabel1);
            this.Controls.Add(this.planIDTextBox1);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(provinceLabel);
            this.Controls.Add(this.provinceTextBox);
            this.Controls.Add(webSiteLabel);
            this.Controls.Add(this.webSiteTextBox);
            this.Controls.Add(custFirstLabel);
            this.Controls.Add(this.custFirstTextBox);
            this.Controls.Add(custIDLabel);
            this.Controls.Add(this.custIDTextBox);
            this.Controls.Add(custLastLabel);
            this.Controls.Add(this.custLastTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(headHHLabel);
            this.Controls.Add(this.headHHCheckBox);
            this.Controls.Add(houseIDLabel);
            this.Controls.Add(this.houseIDTextBox);
            this.Controls.Add(this.tblCustomerBindingNavigator);
            this.Controls.Add(this.lblTitle);
            this.Name = "Customer";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingNavigator)).EndInit();
            this.tblCustomerBindingNavigator.ResumeLayout(false);
            this.tblCustomerBindingNavigator.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.BindingNavigator tblCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCustomerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox custFirstTextBox;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox custLastTextBox;
        private System.Windows.Forms.TextBox dOBTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.CheckBox headHHCheckBox;
        private System.Windows.Forms.TextBox houseIDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox planIDTextBox1;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox webSiteTextBox;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Label lblSearchChoice;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.Label lblSearchBy;
    }
}