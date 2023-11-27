using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Screens.Products
{
    public partial class Products : Form
    {
        pharmacyEntities db = new pharmacyEntities();
        string oldPath = "";
        public Products()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pic_product_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                oldPath = openFileDialog.FileName;
                pic_product.ImageLocation = openFileDialog.FileName;
            }
        }


        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int qty, price;
                Product product = new Product
                {
                    Name =txt_name.Text,
                    Code=txt_parcode.Text,
                    Notes =txt_note.Text,
                    price = decimal.Parse(txt_price.Text),
                    quantity =int.Parse(txt_qyt.Text)
                };

                if (product.Name != null && product.Code != null 
                    && product.quantity != null && product.price != null)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }

                string newPath = $@"{Environment.CurrentDirectory}\Images\Products\{product.Id}.jpg";
                File.Copy(oldPath, newPath);
                product.Image = newPath;
                if (product.Image != null && product.Image != string.Empty)
                {
                    db.SaveChanges();
                    MessageBox.Show("Product Add Sucesfuly");
                    txt_name.Text = "";
                    txt_parcode.Text = "";
                    txt_note.Text = "";
                    txt_price.Text = "";
                    txt_qyt.Text = "";
                    pic_product.ImageLocation = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();    
            productList.Show();
        }
    }
}
