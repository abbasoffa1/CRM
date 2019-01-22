using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Model;
namespace CRM
{
    public partial class CreateUser : Form
    {
        CRMEntities db = new CRMEntities();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.User user = new Model.User();

            if(string.IsNullOrEmpty(txtFullName.Text)|| string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill all inputs!");
            }
            else
            {
                user.Name = txtFullName.Text;
                user.Password = txtPass.Text;
                user.Username = txtUser.Text;
                user.Email = txtEmail.Text;
                db.Users.Add(user);
                db.SaveChanges();
                txtEmail.ResetText();
                txtFullName.ResetText();
                txtPass.ResetText();
                txtUser.ResetText();
            }
        }
    }
}
