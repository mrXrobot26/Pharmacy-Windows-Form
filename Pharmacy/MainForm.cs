using Pharmacy.Screens;
using Pharmacy.Screens.Customers;
using Pharmacy.Screens.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
        }

        private void listOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products addProduct = new Products();
            addProduct.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMangment customerMangment = new CustomerMangment();
            customerMangment.Show();
        }
    }
}
