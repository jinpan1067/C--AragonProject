
namespace AragonApp
{
    partial class AragonApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUpdatePrep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPres = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTrainning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVerticle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSales,
            this.tsManage,
            this.tsWindow,
            this.tsAbout,
            this.tsExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsSales
            // 
            this.tsSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCustomer,
            this.tsPres,
            this.tsDoc});
            this.tsSales.Name = "tsSales";
            this.tsSales.Size = new System.Drawing.Size(111, 20);
            this.tsSales.Text = "Sales Department";
            // 
            // tsCustomer
            // 
            this.tsCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUpdate,
            this.tsUpdatePrep});
            this.tsCustomer.Name = "tsCustomer";
            this.tsCustomer.Size = new System.Drawing.Size(180, 22);
            this.tsCustomer.Text = "Customer";
            // 
            // tsUpdate
            // 
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(178, 22);
            this.tsUpdate.Text = "Search Customer";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // tsUpdatePrep
            // 
            this.tsUpdatePrep.Name = "tsUpdatePrep";
            this.tsUpdatePrep.Size = new System.Drawing.Size(178, 22);
            this.tsUpdatePrep.Text = "Update Prescription";
            this.tsUpdatePrep.Click += new System.EventHandler(this.tsUpdatePrep_Click);
            // 
            // tsPres
            // 
            this.tsPres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReport});
            this.tsPres.Name = "tsPres";
            this.tsPres.Size = new System.Drawing.Size(180, 22);
            this.tsPres.Text = "Prescription";
            // 
            // tsDoc
            // 
            this.tsDoc.Name = "tsDoc";
            this.tsDoc.Size = new System.Drawing.Size(180, 22);
            this.tsDoc.Text = "Doctor";
            // 
            // tsManage
            // 
            this.tsManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmp,
            this.tsDrug});
            this.tsManage.Name = "tsManage";
            this.tsManage.Size = new System.Drawing.Size(156, 20);
            this.tsManage.Text = "Management Department";
            // 
            // tsEmp
            // 
            this.tsEmp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTrainning});
            this.tsEmp.Name = "tsEmp";
            this.tsEmp.Size = new System.Drawing.Size(126, 22);
            this.tsEmp.Text = "Employee";
            // 
            // tsTrainning
            // 
            this.tsTrainning.Name = "tsTrainning";
            this.tsTrainning.Size = new System.Drawing.Size(124, 22);
            this.tsTrainning.Text = "Trainning";
            this.tsTrainning.Click += new System.EventHandler(this.tsTrainning_Click);
            // 
            // tsDrug
            // 
            this.tsDrug.Name = "tsDrug";
            this.tsDrug.Size = new System.Drawing.Size(126, 22);
            this.tsDrug.Text = "Drug";
            // 
            // tsWindow
            // 
            this.tsWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCascade,
            this.tsHorizontal,
            this.tsVerticle,
            this.toolStripSeparator1});
            this.tsWindow.Name = "tsWindow";
            this.tsWindow.Size = new System.Drawing.Size(63, 20);
            this.tsWindow.Text = "Window";
            // 
            // tsCascade
            // 
            this.tsCascade.Name = "tsCascade";
            this.tsCascade.Size = new System.Drawing.Size(129, 22);
            this.tsCascade.Text = "Cascade";
            this.tsCascade.Click += new System.EventHandler(this.tsCascade_Click);
            // 
            // tsHorizontal
            // 
            this.tsHorizontal.Name = "tsHorizontal";
            this.tsHorizontal.Size = new System.Drawing.Size(129, 22);
            this.tsHorizontal.Text = "Horizontal";
            this.tsHorizontal.Click += new System.EventHandler(this.tsHorizontal_Click);
            // 
            // tsVerticle
            // 
            this.tsVerticle.Name = "tsVerticle";
            this.tsVerticle.Size = new System.Drawing.Size(129, 22);
            this.tsVerticle.Text = "Vertical";
            this.tsVerticle.Click += new System.EventHandler(this.tsVerticle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "About";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(37, 20);
            this.tsExit.Text = "E&xit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsReport
            // 
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(180, 22);
            this.tsReport.Text = "2021 Report";
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // AragonApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AragonApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AragonApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsSales;
        private System.Windows.Forms.ToolStripMenuItem tsCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsPres;
        private System.Windows.Forms.ToolStripMenuItem tsDoc;
        private System.Windows.Forms.ToolStripMenuItem tsManage;
        private System.Windows.Forms.ToolStripMenuItem tsEmp;
        private System.Windows.Forms.ToolStripMenuItem tsDrug;
        private System.Windows.Forms.ToolStripMenuItem tsWindow;
        private System.Windows.Forms.ToolStripMenuItem tsCascade;
        private System.Windows.Forms.ToolStripMenuItem tsHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsVerticle;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsUpdatePrep;
        private System.Windows.Forms.ToolStripMenuItem tsTrainning;
        private System.Windows.Forms.ToolStripMenuItem tsReport;
    }
}

