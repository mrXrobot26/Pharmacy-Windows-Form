namespace Pharmacy.Screens.Customers
{
    partial class CustomerMangment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMangment));
            this.btn_delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_CoustomerNote = new System.Windows.Forms.TextBox();
            this.lbl_note = new System.Windows.Forms.Label();
            this.txt_CustomerAddres = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_customerPhone = new System.Windows.Forms.TextBox();
            this.pic_Customer = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_customers = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.lbl_nameSearch = new System.Windows.Forms.Label();
            this.txt_searchPhone = new System.Windows.Forms.TextBox();
            this.lbl_phoneNumSrearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditSection = new System.Windows.Forms.GroupBox();
            this.btn_addNewCustomer = new System.Windows.Forms.Button();
            this.txt_customerCompany = new System.Windows.Forms.TextBox();
            this.txt_customerEmail = new System.Windows.Forms.TextBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Pharmacy.pharmacyDataSet1TableAdapters.CustomerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBx_IsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EditSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(1435, 438);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 45);
            this.btn_delete.TabIndex = 72;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1383, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 71;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txt_CoustomerNote
            // 
            this.txt_CoustomerNote.Location = new System.Drawing.Point(1220, 107);
            this.txt_CoustomerNote.Multiline = true;
            this.txt_CoustomerNote.Name = "txt_CoustomerNote";
            this.txt_CoustomerNote.Size = new System.Drawing.Size(296, 118);
            this.txt_CoustomerNote.TabIndex = 70;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.Location = new System.Drawing.Point(469, 128);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(78, 32);
            this.lbl_note.TabIndex = 69;
            this.lbl_note.Text = "Note";
            // 
            // txt_CustomerAddres
            // 
            this.txt_CustomerAddres.Location = new System.Drawing.Point(793, 328);
            this.txt_CustomerAddres.Multiline = true;
            this.txt_CustomerAddres.Name = "txt_CustomerAddres";
            this.txt_CustomerAddres.Size = new System.Drawing.Size(296, 38);
            this.txt_CustomerAddres.TabIndex = 66;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_address.Location = new System.Drawing.Point(17, 298);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(125, 32);
            this.lbl_address.TabIndex = 65;
            this.lbl_address.Text = "Address";
            // 
            // txt_customerPhone
            // 
            this.txt_customerPhone.Location = new System.Drawing.Point(793, 216);
            this.txt_customerPhone.Multiline = true;
            this.txt_customerPhone.Name = "txt_customerPhone";
            this.txt_customerPhone.Size = new System.Drawing.Size(296, 38);
            this.txt_customerPhone.TabIndex = 64;
            // 
            // pic_Customer
            // 
            this.pic_Customer.Location = new System.Drawing.Point(1220, 231);
            this.pic_Customer.Name = "pic_Customer";
            this.pic_Customer.Size = new System.Drawing.Size(296, 174);
            this.pic_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Customer.TabIndex = 63;
            this.pic_Customer.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(1272, 438);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 45);
            this.btn_edit.TabIndex = 62;
            this.btn_edit.TabStop = false;
            this.btn_edit.Text = "Edit ";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.Color.Transparent;
            this.lbl_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_image.Location = new System.Drawing.Point(469, 263);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(97, 32);
            this.lbl_image.TabIndex = 61;
            this.lbl_image.Text = "Image";
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customers.Location = new System.Drawing.Point(1010, 37);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(222, 46);
            this.lbl_customers.TabIndex = 60;
            this.lbl_customers.Text = "Customers";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(1220, 438);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(46, 45);
            this.btn_login.TabIndex = 59;
            this.btn_login.TabStop = false;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(793, 115);
            this.txt_customerName.Multiline = true;
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(296, 38);
            this.txt_customerName.TabIndex = 58;
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_phoneNumber.Location = new System.Drawing.Point(31, 186);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(102, 32);
            this.lbl_phoneNumber.TabIndex = 57;
            this.lbl_phoneNumber.Text = "Phone";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.Location = new System.Drawing.Point(31, 85);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(93, 32);
            this.lbl_customerName.TabIndex = 56;
            this.lbl_customerName.Text = "Name";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.Transparent;
            this.btn_reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reload.BackgroundImage")));
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.FlatAppearance.BorderSize = 0;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Location = new System.Drawing.Point(521, 65);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(47, 46);
            this.btn_reload.TabIndex = 55;
            this.btn_reload.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(440, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 54;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(295, 74);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(128, 22);
            this.txt_SearchName.TabIndex = 53;
            // 
            // lbl_nameSearch
            // 
            this.lbl_nameSearch.AutoSize = true;
            this.lbl_nameSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameSearch.Location = new System.Drawing.Point(237, 74);
            this.lbl_nameSearch.Name = "lbl_nameSearch";
            this.lbl_nameSearch.Size = new System.Drawing.Size(57, 20);
            this.lbl_nameSearch.TabIndex = 52;
            this.lbl_nameSearch.Text = "Name";
            // 
            // txt_searchPhone
            // 
            this.txt_searchPhone.Location = new System.Drawing.Point(96, 74);
            this.txt_searchPhone.Name = "txt_searchPhone";
            this.txt_searchPhone.Size = new System.Drawing.Size(128, 22);
            this.txt_searchPhone.TabIndex = 51;
            // 
            // lbl_phoneNumSrearch
            // 
            this.lbl_phoneNumSrearch.AutoSize = true;
            this.lbl_phoneNumSrearch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phoneNumSrearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNumSrearch.Location = new System.Drawing.Point(38, 74);
            this.lbl_phoneNumSrearch.Name = "lbl_phoneNumSrearch";
            this.lbl_phoneNumSrearch.Size = new System.Drawing.Size(61, 20);
            this.lbl_phoneNumSrearch.TabIndex = 50;
            this.lbl_phoneNumSrearch.Text = "Phone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 117);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 423);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // EditSection
            // 
            this.EditSection.BackColor = System.Drawing.Color.Transparent;
            this.EditSection.Controls.Add(this.chkBx_IsActive);
            this.EditSection.Controls.Add(this.lbl_email);
            this.EditSection.Controls.Add(this.lbl_Company);
            this.EditSection.Controls.Add(this.txt_customerCompany);
            this.EditSection.Controls.Add(this.lbl_note);
            this.EditSection.Controls.Add(this.txt_customerEmail);
            this.EditSection.Controls.Add(this.btn_addNewCustomer);
            this.EditSection.Controls.Add(this.lbl_customerName);
            this.EditSection.Controls.Add(this.lbl_image);
            this.EditSection.Controls.Add(this.lbl_address);
            this.EditSection.Controls.Add(this.lbl_phoneNumber);
            this.EditSection.Location = new System.Drawing.Point(645, 30);
            this.EditSection.Name = "EditSection";
            this.EditSection.Size = new System.Drawing.Size(905, 565);
            this.EditSection.TabIndex = 73;
            this.EditSection.TabStop = false;
            // 
            // btn_addNewCustomer
            // 
            this.btn_addNewCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addNewCustomer.FlatAppearance.BorderSize = 0;
            this.btn_addNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_addNewCustomer.Location = new System.Drawing.Point(581, 491);
            this.btn_addNewCustomer.Name = "btn_addNewCustomer";
            this.btn_addNewCustomer.Size = new System.Drawing.Size(310, 45);
            this.btn_addNewCustomer.TabIndex = 49;
            this.btn_addNewCustomer.TabStop = false;
            this.btn_addNewCustomer.Text = "Add New Customer";
            this.btn_addNewCustomer.UseVisualStyleBackColor = false;
            // 
            // txt_customerCompany
            // 
            this.txt_customerCompany.Location = new System.Drawing.Point(148, 472);
            this.txt_customerCompany.Multiline = true;
            this.txt_customerCompany.Name = "txt_customerCompany";
            this.txt_customerCompany.Size = new System.Drawing.Size(296, 38);
            this.txt_customerCompany.TabIndex = 74;
            // 
            // txt_customerEmail
            // 
            this.txt_customerEmail.Location = new System.Drawing.Point(148, 378);
            this.txt_customerEmail.Multiline = true;
            this.txt_customerEmail.Name = "txt_customerEmail";
            this.txt_customerEmail.Size = new System.Drawing.Size(296, 38);
            this.txt_customerEmail.TabIndex = 75;
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Company.Location = new System.Drawing.Point(0, 478);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(142, 32);
            this.lbl_Company.TabIndex = 76;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(31, 384);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(91, 32);
            this.lbl_email.TabIndex = 77;
            this.lbl_email.Text = "Email";
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet1";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "addres";
            this.addresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            this.addresDataGridViewTextBoxColumn.ReadOnly = true;
            this.addresDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Visible = false;
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // chkBx_IsActive
            // 
            this.chkBx_IsActive.AutoSize = true;
            this.chkBx_IsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_IsActive.Location = new System.Drawing.Point(245, 533);
            this.chkBx_IsActive.Name = "chkBx_IsActive";
            this.chkBx_IsActive.Size = new System.Drawing.Size(87, 26);
            this.chkBx_IsActive.TabIndex = 78;
            this.chkBx_IsActive.Text = "Active";
            this.chkBx_IsActive.UseVisualStyleBackColor = true;
            // 
            // CustomerMangment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1586, 625);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_CoustomerNote);
            this.Controls.Add(this.txt_CustomerAddres);
            this.Controls.Add(this.txt_customerPhone);
            this.Controls.Add(this.pic_Customer);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_customers);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.lbl_nameSearch);
            this.Controls.Add(this.txt_searchPhone);
            this.Controls.Add(this.lbl_phoneNumSrearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditSection);
            this.Name = "CustomerMangment";
            this.Text = "CustomerMangment";
            this.Load += new System.EventHandler(this.CustomerMangment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EditSection.ResumeLayout(false);
            this.EditSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_CoustomerNote;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.TextBox txt_CustomerAddres;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_customerPhone;
        private System.Windows.Forms.PictureBox pic_Customer;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Label lbl_nameSearch;
        private System.Windows.Forms.TextBox txt_searchPhone;
        private System.Windows.Forms.Label lbl_phoneNumSrearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox EditSection;
        private System.Windows.Forms.Button btn_addNewCustomer;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txt_customerCompany;
        private System.Windows.Forms.TextBox txt_customerEmail;
        private pharmacyDataSet1 pharmacyDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private pharmacyDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkBx_IsActive;
    }
}