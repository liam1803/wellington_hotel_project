using Hotel_project_design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_project_design
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "administrator";
                string password = "1234";


                if ((this.txtUser.Text == username) & (this.txtPass.Text == password))
                {
                    MessageBox.Show("Login Successful");
                    frmMenu frm = new frmMenu();
                    frm.Show();
                    this.Hide();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Input the correct information");
            }
                return;
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 