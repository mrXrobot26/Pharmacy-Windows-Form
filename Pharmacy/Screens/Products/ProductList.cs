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
    public partial class ProductList : Form
    {
        pharmacyEntities db = new pharmacyEntities();
        string oldPath = "";
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x=>x.Code == txt_parcode.Text 
            || x.Name.Contains(txt_name.Text)).ToList();

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var foundedProduct = db.Products.FirstOrDefault(x => x.Id == id);
            if (foundedProduct != null)
            {
                txt_edit_name.Text = foundedProduct.Name;
                txt_note.Text = foundedProduct.Notes;
                txt_edt_parcode.Text = foundedProduct.Code;
                txt_price.Text = foundedProduct.price.ToString();
                txt_qyt.Text = foundedProduct.quantity.ToString();
                pic_product.ImageLocation = foundedProduct.Image;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var foundedProduct = db.Products.FirstOrDefault(x => x.Id == id);

                if (foundedProduct != null)
                {
                    foundedProduct.Name = txt_edit_name.Text;
                    foundedProduct.Notes = txt_note.Text;
                    foundedProduct.Code = txt_edt_parcode.Text;
                    foundedProduct.price = decimal.Parse(txt_price.Text);
                    foundedProduct.quantity = int.Parse(txt_qyt.Text);
                    foundedProduct.Image = pic_product.ImageLocation;

                   

                    string newPath = $@"{Environment.CurrentDirectory}\Images\Products\{Guid.NewGuid()}.jpg";
                    File.Copy(oldPath, newPath);

                    foundedProduct.Image = newPath;
                    db.SaveChanges();

                    dataGridView1.DataSource = db.Products.ToList();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var foundedProduct = db.Products.FirstOrDefault(x => x.Id == id);
            db.Products.Remove( foundedProduct );
            db.SaveChanges();
            btn_reload_Click(sender, e);

        }

        private void pic_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                oldPath = openFileDialog.FileName;
                pic_product.ImageLocation = openFileDialog.FileName;
            }
        }

        private void EditSection_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
