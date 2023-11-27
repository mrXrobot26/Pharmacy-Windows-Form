namespace Pharmacy.Screens.Products
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.lbl_image = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_parcode = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qyt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_product
            // 
            this.pic_product.Location = new System.Drawing.Point(619, 194);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(296, 174);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 23;
            this.pic_product.TabStop = false;
            this.pic_product.Click += new System.EventHandler(this.pic_product_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_addProduct.Location = new System.Drawing.Point(691, 411);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(170, 45);
            this.btn_addProduct.TabIndex = 22;
            this.btn_addProduct.TabStop = false;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.Color.Transparent;
            this.lbl_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_image.Location = new System.Drawing.Point(483, 256);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(97, 32);
            this.lbl_image.TabIndex = 21;
            this.lbl_image.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 46);
            this.label3.TabIndex = 20;
            this.label3.Text = "Add New Product";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(652, 411);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(46, 45);
            this.btn_login.TabIndex = 19;
            this.btn_login.TabStop = false;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_parcode
            // 
            this.txt_parcode.Location = new System.Drawing.Point(140, 76);
            this.txt_parcode.Multiline = true;
            this.txt_parcode.Name = "txt_parcode";
            this.txt_parcode.Size = new System.Drawing.Size(296, 38);
            this.txt_parcode.TabIndex = 17;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_password.Location = new System.Drawing.Point(32, 177);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(93, 32);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "Name";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(0, 76);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(144, 32);
            this.lbl_userName.TabIndex = 15;
            this.lbl_userName.Text = "Paercode";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(140, 177);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(296, 38);
            this.txt_name.TabIndex = 24;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(140, 289);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(296, 38);
            this.txt_price.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Price";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(140, 399);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(296, 123);
            this.txt_note.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Note";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_qyt
            // 
            this.txt_qyt.Location = new System.Drawing.Point(619, 76);
            this.txt_qyt.Multiline = true;
            this.txt_qyt.Name = "txt_qyt";
            this.txt_qyt.Size = new System.Drawing.Size(296, 38);
            this.txt_qyt.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(619, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 45);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "Show All Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_qyt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pic_product);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_parcode);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userName);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_parcode;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qyt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}