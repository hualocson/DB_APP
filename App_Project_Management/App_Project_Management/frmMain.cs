﻿ using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Project_Management.Views;
using Bunifu.UI.WinForms;
using App_Project_Management.Model;

namespace App_Project_Management
{
    public partial class frmMain : Form
    {
        static public int activePage = 0;
        static public int currentProjectID = 0;
        private void changePage()
        {
            main.PageIndex = activePage;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            activePage = 0;
            changePage();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            activePage = 1;
            changePage();
        }
        private void btnMembers_Click(object sender, EventArgs e)
        {
            activePage = 2;
            changePage();
        }


        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            changePage();
            showUI();
            lbAcc.Text = $"{frmLogin.account.Name}, {frmLogin.account.Id}";
        }

        private void showUI()
        {
            switch (frmLogin.account.Role)
            {
                case Cons.ROLE.SA:
                    btnCompanies.Enabled = true;
                    btnMembers.Enabled = true;
                    projectPage.LoadUpdateData();
                    break;
                case Cons.ROLE.PM:
                    btnCompanies.Enabled = true;
                    btnMembers.Enabled = true;
                    projectPage.LoadUpdateData();
                    break;
                case Cons.ROLE.TL:
                    btnCompanies.Enabled = false;
                    btnMembers.Enabled = true;
                    activePage = 1;
                    projectPage.LoadUpdateData();
                    break;
                case Cons.ROLE.TM:
                    btnCompanies.Enabled = false;
                    btnMembers.Enabled = false;
                    activePage = 1;
                    projectPage.LoadUpdateData();
                    break;
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            changePage();
            companyTabPage.LoadData();
            memberPage.LoadData();
            projectPage.LoadUpdateData();
            taskTabPage.LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
