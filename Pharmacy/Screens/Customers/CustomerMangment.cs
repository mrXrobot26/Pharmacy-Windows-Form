using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Screens.Customers
{
    public partial class CustomerMangment : Form
    {
        pharmacyEntities db = new pharmacyEntities();   
        public CustomerMangment()
        {
            InitializeComponent();
        }

        private void CustomerMangment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pharmacyDataSet1.Customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var foundedCustomer = db.Customers.FirstOrDefault(x => x.Id == id);
            if (foundedCustomer != null)
            {
                txt_customerName.Text = foundedCustomer.Name;
                txt_customerPhone.Text = foundedCustomer.phone;
                txt_customerEmail.Text = foundedCustomer.email;
                txt_CustomerAddres.Text = foundedCustomer.addres;
                txt_customerCompany.Text = foundedCustomer.Company;
                txt_CoustomerNote.Text = foundedCustomer.Notes;
                pic_Customer.ImageLocation = foundedCustomer.Image;
                chkBx_IsActive.Checked = (bool)foundedCustomer.isActive;
            }
        }
    }
}
