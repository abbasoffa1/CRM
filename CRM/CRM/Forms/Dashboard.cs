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
    public partial class Dashboard : Form
    {
        private readonly CRMEntities db = new CRMEntities();
        public Dashboard()
        {
            InitializeComponent();
            FillDgv();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {

        }

        private void btnComments_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public void FillDgv()
        {
            foreach (var item in db.vwTaskLists.OrderByDescending(m=>m.Start_Work_Time).Take(20))
            {
                 dgvTasks.Rows.Add(item.Id, item.Task_Name, item.Customer_Name, item.User_Name, item.Start_Work_Time, item.Finish_Work_Time, item.Status);
            }
        }
    }
}
