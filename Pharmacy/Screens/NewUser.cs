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

namespace Pharmacy.Screens
{
    public partial class NewUser : Form
    {
        pharmacyEntities db = new pharmacyEntities();
        string oldPath="";
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User
                {
                    UserName = txt_username.Text,
                    Password = txt_password.Text
                };
                if (newUser.UserName != null && newUser.Password != null && newUser.UserName != string.Empty && newUser.Password != string.Empty)
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }

                string newPath = $@"{Environment.CurrentDirectory}\Images\Users\{newUser.Id}.jpg";
                File.Copy(oldPath, newPath);
                newUser.Image = newPath;
                if (newUser.Image != null && newUser.Image != string.Empty)
                {
                    db.SaveChanges();
                    MessageBox.Show("User Add Sucesfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pic_newUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                oldPath=dialog.FileName;
                pic_newUser.ImageLocation = dialog.FileName;

            }
        }
    }
}
