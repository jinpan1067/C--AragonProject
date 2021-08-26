
namespace AragonApp
{
    partial class Trainning
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empLastLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label empFirstLabel;
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label providerLabel;
            System.Windows.Forms.Label requiredLabel;
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empLastTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.gbxSelectSection = new System.Windows.Forms.GroupBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.rbtnClass = new System.Windows.Forms.RadioButton();
            this.rbtnEmp = new System.Windows.Forms.RadioButton();
            this.gbxResultClass = new System.Windows.Forms.GroupBox();
            this.lbxClass = new System.Windows.Forms.ListBox();
            this.empFirstTextBox = new System.Windows.Forms.TextBox();
            this.gbxResultEmp = new System.Windows.Forms.GroupBox();
            this.lbxEmp = new System.Windows.Forms.ListBox();
            this.requiredCheckBox = new System.Windows.Forms.CheckBox();
            this.tblEmployeeTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.classIDTextBox = new System.Windows.Forms.TextBox();
            empIDLabel = new System.Windows.Forms.Label();
            empLastLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            empFirstLabel = new System.Windows.Forms.Label();
            classIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            providerLabel = new System.Windows.Forms.Label();
            requiredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            this.gbxSelectSection.SuspendLayout();
            this.gbxResultClass.SuspendLayout();
            this.gbxResultEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeTrainingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(6, 31);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(67, 13);
            empIDLabel.TabIndex = 4;
            empIDLabel.Text = "Employee ID";
            // 
            // empLastLabel
            // 
            empLastLabel.AutoSize = true;
            empLastLabel.Location = new System.Drawing.Point(190, 57);
            empLastLabel.Name = "empLastLabel";
            empLastLabel.Size = new System.Drawing.Size(102, 13);
            empLastLabel.TabIndex = 6;
            empLastLabel.Text = "Employee Lastname";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(6, 57);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(47, 13);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Job Title";
            // 
            // empFirstLabel
            // 
            empFirstLabel.AutoSize = true;
            empFirstLabel.Location = new System.Drawing.Point(190, 31);
            empFirstLabel.Name = "empFirstLabel";
            empFirstLabel.Size = new System.Drawing.Size(101, 13);
            empFirstLabel.TabIndex = 9;
            empFirstLabel.Text = "Employee Firstname";
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(25, 31);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 0;
            classIDLabel.Text = "Class ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // providerLabel
            // 
            providerLabel.AutoSize = true;
            providerLabel.Location = new System.Drawing.Point(217, 58);
            providerLabel.Name = "providerLabel";
            providerLabel.Size = new System.Drawing.Size(49, 13);
            providerLabel.TabIndex = 6;
            providerLabel.Text = "Provider:";
            // 
            // requiredLabel
            // 
            requiredLabel.AutoSize = true;
            requiredLabel.Location = new System.Drawing.Point(217, 31);
            requiredLabel.Name = "requiredLabel";
            requiredLabel.Size = new System.Drawing.Size(53, 13);
            requiredLabel.TabIndex = 8;
            requiredLabel.Text = "Required:";
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataSource = typeof(AragonClassLibrary.tblEmployee);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(672, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(532, 18);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(73, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeBindingSource, "EmpID", true));
            this.empIDTextBox.Location = new System.Drawing.Point(74, 28);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.empIDTextBox.TabIndex = 5;
            // 
            // empLastTextBox
            // 
            this.empLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeBindingSource, "EmpLast", true));
            this.empLastTextBox.Location = new System.Drawing.Point(298, 54);
            this.empLastTextBox.Name = "empLastTextBox";
            this.empLastTextBox.Size = new System.Drawing.Size(123, 20);
            this.empLastTextBox.TabIndex = 7;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeBindingSource, "tblJobtitle.Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(59, 54);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(115, 20);
            this.titleTextBox.TabIndex = 9;
            // 
            // gbxSelectSection
            // 
            this.gbxSelectSection.Controls.Add(this.txtPrompt);
            this.gbxSelectSection.Controls.Add(this.rbtnClass);
            this.gbxSelectSection.Controls.Add(this.rbtnEmp);
            this.gbxSelectSection.Controls.Add(this.txtInput);
            this.gbxSelectSection.Location = new System.Drawing.Point(43, 13);
            this.gbxSelectSection.Name = "gbxSelectSection";
            this.gbxSelectSection.Size = new System.Drawing.Size(623, 53);
            this.gbxSelectSection.TabIndex = 10;
            this.gbxSelectSection.TabStop = false;
            this.gbxSelectSection.Text = "Select Section";
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(426, 18);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.ReadOnly = true;
            this.txtPrompt.Size = new System.Drawing.Size(100, 20);
            this.txtPrompt.TabIndex = 2;
            // 
            // rbtnClass
            // 
            this.rbtnClass.AutoSize = true;
            this.rbtnClass.Location = new System.Drawing.Point(237, 20);
            this.rbtnClass.Name = "rbtnClass";
            this.rbtnClass.Size = new System.Drawing.Size(162, 17);
            this.rbtnClass.TabIndex = 1;
            this.rbtnClass.TabStop = true;
            this.rbtnClass.Text = "List Employee Base On Class";
            this.rbtnClass.UseVisualStyleBackColor = true;
            this.rbtnClass.CheckedChanged += new System.EventHandler(this.rbtnClass_CheckedChanged);
            this.rbtnClass.Click += new System.EventHandler(this.rbtnClass_Click);
            // 
            // rbtnEmp
            // 
            this.rbtnEmp.AutoSize = true;
            this.rbtnEmp.Location = new System.Drawing.Point(22, 20);
            this.rbtnEmp.Name = "rbtnEmp";
            this.rbtnEmp.Size = new System.Drawing.Size(173, 17);
            this.rbtnEmp.TabIndex = 0;
            this.rbtnEmp.TabStop = true;
            this.rbtnEmp.Text = "List Classes Base On Employee";
            this.rbtnEmp.UseVisualStyleBackColor = true;
            this.rbtnEmp.CheckedChanged += new System.EventHandler(this.rbtnEmp_CheckedChanged);
            this.rbtnEmp.Click += new System.EventHandler(this.rbtnEmp_Click);
            // 
            // gbxResultClass
            // 
            this.gbxResultClass.Controls.Add(this.lbxClass);
            this.gbxResultClass.Controls.Add(empFirstLabel);
            this.gbxResultClass.Controls.Add(this.empFirstTextBox);
            this.gbxResultClass.Controls.Add(titleLabel);
            this.gbxResultClass.Controls.Add(this.empIDTextBox);
            this.gbxResultClass.Controls.Add(this.titleTextBox);
            this.gbxResultClass.Controls.Add(empIDLabel);
            this.gbxResultClass.Controls.Add(empLastLabel);
            this.gbxResultClass.Controls.Add(this.empLastTextBox);
            this.gbxResultClass.Location = new System.Drawing.Point(43, 96);
            this.gbxResultClass.Name = "gbxResultClass";
            this.gbxResultClass.Size = new System.Drawing.Size(427, 293);
            this.gbxResultClass.TabIndex = 11;
            this.gbxResultClass.TabStop = false;
            this.gbxResultClass.Text = "Result Section One";
            // 
            // lbxClass
            // 
            this.lbxClass.FormattingEnabled = true;
            this.lbxClass.Location = new System.Drawing.Point(9, 99);
            this.lbxClass.Name = "lbxClass";
            this.lbxClass.Size = new System.Drawing.Size(412, 173);
            this.lbxClass.TabIndex = 11;
            // 
            // empFirstTextBox
            // 
            this.empFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeBindingSource, "EmpFirst", true));
            this.empFirstTextBox.Location = new System.Drawing.Point(297, 28);
            this.empFirstTextBox.Name = "empFirstTextBox";
            this.empFirstTextBox.Size = new System.Drawing.Size(124, 20);
            this.empFirstTextBox.TabIndex = 10;
            // 
            // gbxResultEmp
            // 
            this.gbxResultEmp.Controls.Add(this.lbxEmp);
            this.gbxResultEmp.Controls.Add(requiredLabel);
            this.gbxResultEmp.Controls.Add(this.requiredCheckBox);
            this.gbxResultEmp.Controls.Add(providerLabel);
            this.gbxResultEmp.Controls.Add(this.providerTextBox);
            this.gbxResultEmp.Controls.Add(descriptionLabel);
            this.gbxResultEmp.Controls.Add(this.descriptionTextBox);
            this.gbxResultEmp.Controls.Add(classIDLabel);
            this.gbxResultEmp.Controls.Add(this.classIDTextBox);
            this.gbxResultEmp.Location = new System.Drawing.Point(494, 96);
            this.gbxResultEmp.Name = "gbxResultEmp";
            this.gbxResultEmp.Size = new System.Drawing.Size(400, 293);
            this.gbxResultEmp.TabIndex = 12;
            this.gbxResultEmp.TabStop = false;
            this.gbxResultEmp.Text = "Result Section Two";
            // 
            // lbxEmp
            // 
            this.lbxEmp.FormattingEnabled = true;
            this.lbxEmp.Location = new System.Drawing.Point(11, 99);
            this.lbxEmp.Name = "lbxEmp";
            this.lbxEmp.Size = new System.Drawing.Size(383, 173);
            this.lbxEmp.TabIndex = 12;
            // 
            // requiredCheckBox
            // 
            this.requiredCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblEmployeeTrainingBindingSource, "tblClass.Required", true));
            this.requiredCheckBox.Location = new System.Drawing.Point(276, 25);
            this.requiredCheckBox.Name = "requiredCheckBox";
            this.requiredCheckBox.Size = new System.Drawing.Size(104, 24);
            this.requiredCheckBox.TabIndex = 9;
            this.requiredCheckBox.Text = "checkBox1";
            this.requiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblEmployeeTrainingBindingSource
            // 
            this.tblEmployeeTrainingBindingSource.DataSource = typeof(AragonClassLibrary.tblEmployeeTraining);
            // 
            // providerTextBox
            // 
            this.providerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeTrainingBindingSource, "tblClass.Provider", true));
            this.providerTextBox.Location = new System.Drawing.Point(276, 51);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(100, 20);
            this.providerTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeTrainingBindingSource, "tblClass.Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(72, 55);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // classIDTextBox
            // 
            this.classIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeTrainingBindingSource, "ClassID", true));
            this.classIDTextBox.Location = new System.Drawing.Point(72, 29);
            this.classIDTextBox.Name = "classIDTextBox";
            this.classIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.classIDTextBox.TabIndex = 1;
            // 
            // Trainning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 668);
            this.Controls.Add(this.gbxResultEmp);
            this.Controls.Add(this.gbxResultClass);
            this.Controls.Add(this.gbxSelectSection);
            this.Controls.Add(this.btnSearch);
            this.Name = "Trainning";
            this.Text = "Trainning";
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            this.gbxSelectSection.ResumeLayout(false);
            this.gbxSelectSection.PerformLayout();
            this.gbxResultClass.ResumeLayout(false);
            this.gbxResultClass.PerformLayout();
            this.gbxResultEmp.ResumeLayout(false);
            this.gbxResultEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeTrainingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empLastTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox gbxSelectSection;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.RadioButton rbtnClass;
        private System.Windows.Forms.RadioButton rbtnEmp;
        private System.Windows.Forms.GroupBox gbxResultClass;
        private System.Windows.Forms.TextBox empFirstTextBox;
        private System.Windows.Forms.ListBox lbxClass;
        private System.Windows.Forms.GroupBox gbxResultEmp;
        private System.Windows.Forms.ListBox lbxEmp;
        private System.Windows.Forms.CheckBox requiredCheckBox;
        private System.Windows.Forms.BindingSource tblEmployeeTrainingBindingSource;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox classIDTextBox;
    }
}