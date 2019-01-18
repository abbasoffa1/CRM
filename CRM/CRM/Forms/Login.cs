﻿using System;
using System.Linq;
using System.Windows.Forms;
using CRM.Model;
namespace CRM
{
    public partial class Login : Form
    {
        private readonly CRMEntities db = new CRMEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Tetxboxlarin null olub olmadigi yoxlanilir
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please not use empty space!");
            }else
            {
                foreach (var user in db.Users.ToList())
                {
                    //Username ve Passwordun duz olub olmadigi yoxlanilir
                    if ((user.Username == txtUser.Text) && (user.Password == txtPass.Text))
                    {
                        Dashboard dsh = new Dashboard();
                        dsh.ShowDialog();
                    }
                }
            }
        }
    }
}