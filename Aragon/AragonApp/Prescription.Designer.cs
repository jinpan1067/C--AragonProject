
namespace AragonApp
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbxCustInfo = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastNM = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstNM = new System.Windows.Forms.Label();
            this.lbxPrep = new System.Windows.Forms.ListBox();
            this.lblPrepList = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.gbxCustInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataSource = typeof(AragonClassLibrary.tblCustomer);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(26, 72);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(93, 13);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(134, 69);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(251, 69);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gbxCustInfo
            // 
            this.gbxCustInfo.Controls.Add(this.textBox4);
            this.gbxCustInfo.Controls.Add(this.textBox3);
            this.gbxCustInfo.Controls.Add(this.textBox2);
            this.gbxCustInfo.Controls.Add(this.textBox1);
            this.gbxCustInfo.Controls.Add(this.lblAddress);
            this.gbxCustInfo.Controls.Add(this.lblLastNM);
            this.gbxCustInfo.Controls.Add(this.lblPhone);
            this.gbxCustInfo.Controls.Add(this.lblFirstNM);
            this.gbxCustInfo.Location = new System.Drawing.Point(381, 28);
            this.gbxCustInfo.Name = "gbxCustInfo";
            this.gbxCustInfo.Size = new System.Drawing.Size(395, 100);
            this.gbxCustInfo.TabIndex = 4;
            this.gbxCustInfo.TabStop = false;
            this.gbxCustInfo.Text = "Customer Infomation";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustLast", true));
            this.textBox4.Location = new System.Drawing.Point(261, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "tblHousehold.Address", true));
            this.textBox3.Location = new System.Drawing.Point(220, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Phone", true));
            this.textBox2.Location = new System.Drawing.Point(53, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CustFirst", true));
            this.textBox1.Location = new System.Drawing.Point(72, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(166, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblLastNM
            // 
            this.lblLastNM.AutoSize = true;
            this.lblLastNM.Location = new System.Drawing.Point(194, 31);
            this.lblLastNM.Name = "lblLastNM";
            this.lblLastNM.Size = new System.Drawing.Size(61, 13);
            this.lblLastNM.TabIndex = 2;
            this.lblLastNM.Text = "Last Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 68);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFirstNM
            // 
            this.lblFirstNM.AutoSize = true;
            this.lblFirstNM.Location = new System.Drawing.Point(6, 31);
            this.lblFirstNM.Name = "lblFirstNM";
            this.lblFirstNM.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNM.TabIndex = 0;
            this.lblFirstNM.Text = "First Name:";
            // 
            // lbxPrep
            // 
            this.lbxPrep.FormattingEnabled = true;
            this.lbxPrep.Location = new System.Drawing.Point(29, 169);
            this.lbxPrep.Name = "lbxPrep";
            this.lbxPrep.Size = new System.Drawing.Size(297, 134);
            this.lbxPrep.TabIndex = 5;
            // 
            // lblPrepList
            // 
            this.lblPrepList.AutoSize = true;
            this.lblPrepList.Location = new System.Drawing.Point(29, 150);
            this.lblPrepList.Name = "lblPrepList";
            this.lblPrepList.Size = new System.Drawing.Size(81, 13);
            this.lblPrepList.TabIndex = 6;
            this.lblPrepList.Text = "Prescription List";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(29, 321);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(113, 23);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Purchase Total:";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(148, 323);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblPrepList);
            this.Controls.Add(this.lbxPrep);
            this.Controls.Add(this.gbxCustInfo);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblEnter);
            this.Name = "Prescription";
            this.Text = "Prescription";
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.gbxCustInfo.ResumeLayout(false);
            this.gbxCustInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbxCustInfo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastNM;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstNM;
        private System.Windows.Forms.ListBox lbxPrep;
        private System.Windows.Forms.Label lblPrepList;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}