using App_Project_Management.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Project_Management.Model;

namespace App_Project_Management.Views
{
    public partial class frmLogin : Form
    {
        string err = "";
        public static AccountModel account = null;
        public static bool isLoginSuccess = false;

        public frmLogin()
        {
            InitializeComponent();
            account = new AccountModel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string err = "";
            isLoginSuccess = account.Login(txbUserName.Text, txbPassword.Text);
            if (!isLoginSuccess)
            {
                MessageBox.Show("Login faild");
                txbPassword.Clear();
                txbUserName.Clear();
                txbUserName.Focus();
            }
            else
            {
                Hide();
                Form mainControl = new frmMain();
                mainControl.ShowDialog();
                txbPassword.Clear();
                txbUserName.Clear();
                txbUserName.Focus();
                ShowForm();
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowForm()
        {
            Visible = true;
        }
    }
}
