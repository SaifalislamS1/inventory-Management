using System;

namespace POSDemo1
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProdcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProdcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listprodcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قائمةالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قائمةالموردونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردونToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.prodcutToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.الموردونToolStripMenuItem,
            this.الفاتورةToolStripMenuItem,
            this.تقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.usersToolStripMenuItem.Text = "users";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addUsersToolStripMenuItem.Text = "add users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.AddUsersToolStripMenuItem_Click);
            // 
            // prodcutToolStripMenuItem
            // 
            this.prodcutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProdcutToolStripMenuItem,
            this.editProdcutToolStripMenuItem,
            this.listprodcutToolStripMenuItem});
            this.prodcutToolStripMenuItem.Name = "prodcutToolStripMenuItem";
            this.prodcutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.prodcutToolStripMenuItem.Text = "Prodcut";
            // 
            // addProdcutToolStripMenuItem
            // 
            this.addProdcutToolStripMenuItem.Name = "addProdcutToolStripMenuItem";
            this.addProdcutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addProdcutToolStripMenuItem.Text = "Add prodcut";
            this.addProdcutToolStripMenuItem.Click += new System.EventHandler(this.AddProdcutToolStripMenuItem_Click);
            // 
            // editProdcutToolStripMenuItem
            // 
            this.editProdcutToolStripMenuItem.Name = "editProdcutToolStripMenuItem";
            this.editProdcutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editProdcutToolStripMenuItem.Text = "manange prodcut";
            this.editProdcutToolStripMenuItem.Click += new System.EventHandler(this.editProdcutToolStripMenuItem_Click);
            // 
            // listprodcutToolStripMenuItem
            // 
            this.listprodcutToolStripMenuItem.Name = "listprodcutToolStripMenuItem";
            this.listprodcutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listprodcutToolStripMenuItem.Text = "list_prodcut";
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.قائمةالعملاءToolStripMenuItem});
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // قائمةالعملاءToolStripMenuItem
            // 
            this.قائمةالعملاءToolStripMenuItem.Name = "قائمةالعملاءToolStripMenuItem";
            this.قائمةالعملاءToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.قائمةالعملاءToolStripMenuItem.Text = "قائمة العملاء";
            this.قائمةالعملاءToolStripMenuItem.Click += new System.EventHandler(this.قائمةالعملاءToolStripMenuItem_Click);
            // 
            // الموردونToolStripMenuItem
            // 
            this.الموردونToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.قائمةالموردونToolStripMenuItem,
            this.الموردونToolStripMenuItem1});
            this.الموردونToolStripMenuItem.Name = "الموردونToolStripMenuItem";
            this.الموردونToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.الموردونToolStripMenuItem.Text = "الموردون";
            // 
            // قائمةالموردونToolStripMenuItem
            // 
            this.قائمةالموردونToolStripMenuItem.Name = "قائمةالموردونToolStripMenuItem";
            this.قائمةالموردونToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.قائمةالموردونToolStripMenuItem.Text = "قائمة الموردون";
            this.قائمةالموردونToolStripMenuItem.Click += new System.EventHandler(this.قائمةالموردونToolStripMenuItem_Click);
            // 
            // الفاتورةToolStripMenuItem
            // 
            this.الفاتورةToolStripMenuItem.Name = "الفاتورةToolStripMenuItem";
            this.الفاتورةToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.الفاتورةToolStripMenuItem.Text = "الفاتورة";
            // 
            // تقاريرToolStripMenuItem
            // 
            this.تقاريرToolStripMenuItem.Name = "تقاريرToolStripMenuItem";
            this.تقاريرToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.تقاريرToolStripMenuItem.Text = "تقارير";
            // 
            // الموردونToolStripMenuItem1
            // 
            this.الموردونToolStripMenuItem1.Name = "الموردونToolStripMenuItem1";
            this.الموردونToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.الموردونToolStripMenuItem1.Text = "الموردون";
            this.الموردونToolStripMenuItem1.Click += new System.EventHandler(this.الموردونToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::POSDemo1.Properties.Resources.factory_workers_handshaking_each_other_production_line_1160x773;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Tomato;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void editProdcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProdcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProdcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listprodcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قائمةالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قائمةالموردونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردونToolStripMenuItem1;
    }
}