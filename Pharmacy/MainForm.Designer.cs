namespace Pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_suppliers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_suppliers = new System.Windows.Forms.Label();
            this.lbl_purchases = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.lbl_Clients = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.lbl_reports = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.invoicsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUserToolStripMenuItem.Image")));
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.mangeProductsToolStripMenuItem,
            this.listOfProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productsToolStripMenuItem.Image")));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addProductToolStripMenuItem.Image")));
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // mangeProductsToolStripMenuItem
            // 
            this.mangeProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mangeProductsToolStripMenuItem.Image")));
            this.mangeProductsToolStripMenuItem.Name = "mangeProductsToolStripMenuItem";
            this.mangeProductsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mangeProductsToolStripMenuItem.Text = "Mange Products";
            // 
            // listOfProductsToolStripMenuItem
            // 
            this.listOfProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listOfProductsToolStripMenuItem.Image")));
            this.listOfProductsToolStripMenuItem.Name = "listOfProductsToolStripMenuItem";
            this.listOfProductsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfProductsToolStripMenuItem.Text = "List Of Products";
            this.listOfProductsToolStripMenuItem.Click += new System.EventHandler(this.listOfProductsToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsToolStripMenuItem.Image")));
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersToolStripMenuItem.Image")));
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // invoicsToolStripMenuItem
            // 
            this.invoicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchasesBillToolStripMenuItem,
            this.salesBillToolStripMenuItem});
            this.invoicsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicsToolStripMenuItem.Image")));
            this.invoicsToolStripMenuItem.Name = "invoicsToolStripMenuItem";
            this.invoicsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.invoicsToolStripMenuItem.Text = "Invoics";
            // 
            // purchasesBillToolStripMenuItem
            // 
            this.purchasesBillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchasesBillToolStripMenuItem.Image")));
            this.purchasesBillToolStripMenuItem.Name = "purchasesBillToolStripMenuItem";
            this.purchasesBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.purchasesBillToolStripMenuItem.Text = "Purchases bill";
            // 
            // salesBillToolStripMenuItem
            // 
            this.salesBillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesBillToolStripMenuItem.Image")));
            this.salesBillToolStripMenuItem.Name = "salesBillToolStripMenuItem";
            this.salesBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salesBillToolStripMenuItem.Text = "sales bill";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.BackColor = System.Drawing.Color.Transparent;
            this.btn_suppliers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.BackgroundImage")));
            this.btn_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_suppliers.FlatAppearance.BorderSize = 0;
            this.btn_suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppliers.Location = new System.Drawing.Point(627, 63);
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.Size = new System.Drawing.Size(195, 167);
            this.btn_suppliers.TabIndex = 1;
            this.btn_suppliers.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(348, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 167);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(56, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 167);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(336, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 167);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(627, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 167);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(56, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 167);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_suppliers
            // 
            this.lbl_suppliers.AutoSize = true;
            this.lbl_suppliers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_suppliers.Location = new System.Drawing.Point(647, 233);
            this.lbl_suppliers.Name = "lbl_suppliers";
            this.lbl_suppliers.Size = new System.Drawing.Size(150, 36);
            this.lbl_suppliers.TabIndex = 9;
            this.lbl_suppliers.Text = "Suppliers";
            // 
            // lbl_purchases
            // 
            this.lbl_purchases.AutoSize = true;
            this.lbl_purchases.BackColor = System.Drawing.Color.Transparent;
            this.lbl_purchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchases.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_purchases.Location = new System.Drawing.Point(354, 462);
            this.lbl_purchases.Name = "lbl_purchases";
            this.lbl_purchases.Size = new System.Drawing.Size(216, 36);
            this.lbl_purchases.TabIndex = 13;
            this.lbl_purchases.Text = "Purchases bill";
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sales.Location = new System.Drawing.Point(657, 462);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(140, 36);
            this.lbl_sales.TabIndex = 14;
            this.lbl_sales.Text = "sales bill";
            // 
            // lbl_Clients
            // 
            this.lbl_Clients.AutoSize = true;
            this.lbl_Clients.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Clients.Location = new System.Drawing.Point(389, 244);
            this.lbl_Clients.Name = "lbl_Clients";
            this.lbl_Clients.Size = new System.Drawing.Size(113, 36);
            this.lbl_Clients.TabIndex = 15;
            this.lbl_Clients.Text = "Clients";
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Products.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Products.Location = new System.Drawing.Point(76, 233);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(142, 36);
            this.lbl_Products.TabIndex = 16;
            this.lbl_Products.Text = "Products";
            // 
            // lbl_reports
            // 
            this.lbl_reports.AutoSize = true;
            this.lbl_reports.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_reports.Location = new System.Drawing.Point(76, 462);
            this.lbl_reports.Name = "lbl_reports";
            this.lbl_reports.Size = new System.Drawing.Size(127, 36);
            this.lbl_reports.TabIndex = 17;
            this.lbl_reports.Text = "Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 525);
            this.Controls.Add(this.lbl_reports);
            this.Controls.Add(this.lbl_Products);
            this.Controls.Add(this.lbl_Clients);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.lbl_purchases);
            this.Controls.Add(this.lbl_suppliers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_suppliers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesBillToolStripMenuItem;
        private System.Windows.Forms.Button btn_suppliers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_suppliers;
        private System.Windows.Forms.Label lbl_purchases;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.Label lbl_Clients;
        private System.Windows.Forms.Label lbl_Products;
        private System.Windows.Forms.Label lbl_reports;
    }
}