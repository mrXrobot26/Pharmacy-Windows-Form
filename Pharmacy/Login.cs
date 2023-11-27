using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Login : Form
    {
        pharmacyEntities db = new pharmacyEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text =="" || txt_username.Text == "")
                {
                    throw new InvalidCredentialsException("Filed empty");

                }
                else
                {
                    var foundedUser = db.Users.FirstOrDefault(x => x.UserName == txt_username.Text && x.Password == txt_password.Text);
                    if (foundedUser != null)
                    {
                        this.Close();
                        Thread th = new Thread(() => Application.Run(new MainForm()));
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        throw new InvalidCredentialsException("Try again password or user name not match");
                    }
                }

            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class InvalidCredentialsException : Exception
        {
            public InvalidCredentialsException(string message) : base(message)
            {
            }
        }


    }
}
