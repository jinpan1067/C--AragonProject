
namespace AragonApp
{
    partial class ChildFormCustomer
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
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label planIDLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label daysLabel;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label planIDLabel1;
            System.Windows.Forms.Label planNameLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label webSiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFormCustomer));
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.custFirstTextBox = new System.Windows.Forms.TextBox();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.custLastTextBox = new System.Windows.Forms.TextBox();
            this.dOBTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.headHHCheckBox = new System.Windows.Forms.CheckBox();
            this.houseIDTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.planIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.planIDTextBox1 = new System.Windows.Forms.TextBox();
            this.planNameTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.webSiteTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSavebtn = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorUpdate = new System.Windows.Forms.BindingNavigator(this.components);
            custFirstLabel = new System.Windows.Forms.Label();
            custIDLabel = new System.Windows.Forms.Label();
            custLastLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            headHHLabel = new System.Windows.Forms.Label();
            houseIDLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            planIDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            daysLabel = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            planIDLabel1 = new System.Windows.Forms.Label();
            planNameLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            webSiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUpdate)).BeginInit();
            this.bindingNavigatorUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataSource = typeof(AragonClassLibrary.tblCustomer);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(263, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Data Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custFirstLabel
            // 
            custFirstLabel.AutoSize = true;
            custFirstLabel.Location = new System.Drawing.Point(98, 207);
            custFirstLabel.Name = "custFirstLabel";
            custFirstLabel.Size = new System.Drawing.Size(53, 13);
            custFirstLabel.TabIndex = 7;
            custFirstLabel.Text = "Cust First:";
            // 
            // custFirstTextBox
            // 
            this.custFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustFirst", true));
            this.custFirstTextBox.Location = new System.Drawing.Point(182, 204);
            this.custFirstTextBox.Name = "custFirstTextBox";
            this.custFirstTextBox.Size = new System.Drawing.Size(165, 20);
            this.custFirstTextBox.TabIndex = 8;
            // 
            // custIDLabel
            // 
            custIDLabel.AutoSize = true;
            custIDLabel.Location = new System.Drawing.Point(98, 174);
            custIDLabel.Name = "custIDLabel";
            custIDLabel.Size = new System.Drawing.Size(45, 13);
            custIDLabel.TabIndex = 9;
            custIDLabel.Text = "Cust ID:";
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustID", true));
            this.custIDTextBox.Location = new System.Drawing.Point(182, 171);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.Size = new System.Drawing.Size(165, 20);
            this.custIDTextBox.TabIndex = 10;
            // 
            // custLastLabel
            // 
            custLastLabel.AutoSize = true;
            custLastLabel.Location = new System.Drawing.Point(98, 240);
            custLastLabel.Name = "custLastLabel";
            custLastLabel.Size = new System.Drawing.Size(54, 13);
            custLastLabel.TabIndex = 11;
            custLastLabel.Text = "Cust Last:";
            // 
            // custLastTextBox
            // 
            this.custLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustLast", true));
            this.custLastTextBox.Location = new System.Drawing.Point(182, 237);
            this.custLastTextBox.Name = "custLastTextBox";
            this.custLastTextBox.Size = new System.Drawing.Size(165, 20);
            this.custLastTextBox.TabIndex = 12;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(98, 273);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 13;
            dOBLabel.Text = "DOB:";
            // 
            // dOBTextBox
            // 
            this.dOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "DOB", true));
            this.dOBTextBox.Location = new System.Drawing.Point(182, 270);
            this.dOBTextBox.Name = "dOBTextBox";
            this.dOBTextBox.Size = new System.Drawing.Size(165, 20);
            this.dOBTextBox.TabIndex = 14;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(98, 306);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(182, 303);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(165, 20);
            this.genderTextBox.TabIndex = 16;
            // 
            // headHHLabel
            // 
            headHHLabel.AutoSize = true;
            headHHLabel.Location = new System.Drawing.Point(98, 342);
            headHHLabel.Name = "headHHLabel";
            headHHLabel.Size = new System.Drawing.Size(55, 13);
            headHHLabel.TabIndex = 17;
            headHHLabel.Text = "Head HH:";
            // 
            // headHHCheckBox
            // 
            this.headHHCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCustomerBindingSource, "HeadHH", true));
            this.headHHCheckBox.Location = new System.Drawing.Point(182, 336);
            this.headHHCheckBox.Name = "headHHCheckBox";
            this.headHHCheckBox.Size = new System.Drawing.Size(165, 24);
            this.headHHCheckBox.TabIndex = 18;
            this.headHHCheckBox.Text = "checkBox1";
            this.headHHCheckBox.UseVisualStyleBackColor = true;
            // 
            // houseIDLabel
            // 
            houseIDLabel.AutoSize = true;
            houseIDLabel.Location = new System.Drawing.Point(98, 375);
            houseIDLabel.Name = "houseIDLabel";
            houseIDLabel.Size = new System.Drawing.Size(55, 13);
            houseIDLabel.TabIndex = 19;
            houseIDLabel.Text = "House ID:";
            // 
            // houseIDTextBox
            // 
            this.houseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "HouseID", true));
            this.houseIDTextBox.Location = new System.Drawing.Point(182, 373);
            this.houseIDTextBox.Name = "houseIDTextBox";
            this.houseIDTextBox.Size = new System.Drawing.Size(165, 20);
            this.houseIDTextBox.TabIndex = 20;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(98, 408);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(182, 406);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(165, 20);
            this.phoneTextBox.TabIndex = 22;
            // 
            // planIDLabel
            // 
            planIDLabel.AutoSize = true;
            planIDLabel.Location = new System.Drawing.Point(98, 441);
            planIDLabel.Name = "planIDLabel";
            planIDLabel.Size = new System.Drawing.Size(45, 13);
            planIDLabel.TabIndex = 23;
            planIDLabel.Text = "Plan ID:";
            // 
            // planIDTextBox
            // 
            this.planIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "PlanID", true));
            this.planIDTextBox.Location = new System.Drawing.Point(182, 439);
            this.planIDTextBox.Name = "planIDTextBox";
            this.planIDTextBox.Size = new System.Drawing.Size(165, 20);
            this.planIDTextBox.TabIndex = 24;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(391, 173);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(464, 171);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(273, 20);
            this.addressTextBox.TabIndex = 26;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(391, 207);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.City", true));
            this.cityTextBox.Location = new System.Drawing.Point(464, 205);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(273, 20);
            this.cityTextBox.TabIndex = 28;
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Location = new System.Drawing.Point(391, 241);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new System.Drawing.Size(34, 13);
            daysLabel.TabIndex = 29;
            daysLabel.Text = "Days:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Days", true));
            this.daysTextBox.Location = new System.Drawing.Point(464, 235);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(273, 20);
            this.daysTextBox.TabIndex = 30;
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(391, 275);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 31;
            phoneLabel1.Text = "Phone:";
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(464, 273);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(273, 20);
            this.phoneTextBox1.TabIndex = 32;
            // 
            // planIDLabel1
            // 
            planIDLabel1.AutoSize = true;
            planIDLabel1.Location = new System.Drawing.Point(391, 309);
            planIDLabel1.Name = "planIDLabel1";
            planIDLabel1.Size = new System.Drawing.Size(45, 13);
            planIDLabel1.TabIndex = 33;
            planIDLabel1.Text = "Plan ID:";
            // 
            // planIDTextBox1
            // 
            this.planIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.PlanID", true));
            this.planIDTextBox1.Location = new System.Drawing.Point(464, 307);
            this.planIDTextBox1.Name = "planIDTextBox1";
            this.planIDTextBox1.Size = new System.Drawing.Size(273, 20);
            this.planIDTextBox1.TabIndex = 34;
            // 
            // planNameLabel
            // 
            planNameLabel.AutoSize = true;
            planNameLabel.Location = new System.Drawing.Point(391, 343);
            planNameLabel.Name = "planNameLabel";
            planNameLabel.Size = new System.Drawing.Size(62, 13);
            planNameLabel.TabIndex = 35;
            planNameLabel.Text = "Plan Name:";
            // 
            // planNameTextBox
            // 
            this.planNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.PlanName", true));
            this.planNameTextBox.Location = new System.Drawing.Point(464, 340);
            this.planNameTextBox.Name = "planNameTextBox";
            this.planNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.planNameTextBox.TabIndex = 36;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(391, 377);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 37;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(464, 372);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(273, 20);
            this.postalCodeTextBox.TabIndex = 38;
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(391, 411);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(52, 13);
            provinceLabel.TabIndex = 39;
            provinceLabel.Text = "Province:";
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.Province", true));
            this.provinceTextBox.Location = new System.Drawing.Point(464, 406);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(273, 20);
            this.provinceTextBox.TabIndex = 40;
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.Location = new System.Drawing.Point(391, 445);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(54, 13);
            webSiteLabel.TabIndex = 41;
            webSiteLabel.Text = "Web Site:";
            // 
            // webSiteTextBox
            // 
            this.webSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHealthPlan.WebSite", true));
            this.webSiteTextBox.Location = new System.Drawing.Point(464, 440);
            this.webSiteTextBox.Name = "webSiteTextBox";
            this.webSiteTextBox.Size = new System.Drawing.Size(273, 20);
            this.webSiteTextBox.TabIndex = 42;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // bindingNavigatorSavebtn
            // 
            this.bindingNavigatorSavebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSavebtn.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSavebtn.Image")));
            this.bindingNavigatorSavebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSavebtn.Name = "bindingNavigatorSavebtn";
            this.bindingNavigatorSavebtn.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSavebtn.Text = "buttonSave";
            this.bindingNavigatorSavebtn.Click += new System.EventHandler(this.bindingNavigatorSavebtn_Click);
            // 
            // bindingNavigatorUpdate
            // 
            this.bindingNavigatorUpdate.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorUpdate.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUpdate.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorSavebtn});
            this.bindingNavigatorUpdate.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorUpdate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUpdate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUpdate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUpdate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUpdate.Name = "bindingNavigatorUpdate";
            this.bindingNavigatorUpdate.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUpdate.Size = new System.Drawing.Size(817, 25);
            this.bindingNavigatorUpdate.TabIndex = 53;
            this.bindingNavigatorUpdate.Text = "bindingNavigator1";
            // 
            // ChildFormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 881);
            this.Controls.Add(this.bindingNavigatorUpdate);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(daysLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(planIDLabel1);
            this.Controls.Add(this.planIDTextBox1);
            this.Controls.Add(planNameLabel);
            this.Controls.Add(this.planNameTextBox);
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
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(planIDLabel);
            this.Controls.Add(this.planIDTextBox);
            this.Controls.Add(this.lblTitle);
            this.Name = "ChildFormCustomer";
            this.Text = "ChildFormCustomer";
            this.Load += new System.EventHandler(this.ChildFormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUpdate)).EndInit();
            this.bindingNavigatorUpdate.ResumeLayout(false);
            this.bindingNavigatorUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox custFirstTextBox;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox custLastTextBox;
        private System.Windows.Forms.TextBox dOBTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.CheckBox headHHCheckBox;
        private System.Windows.Forms.TextBox houseIDTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox planIDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox planIDTextBox1;
        private System.Windows.Forms.TextBox planNameTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox webSiteTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSavebtn;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUpdate;
    }
}