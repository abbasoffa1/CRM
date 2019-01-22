using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CRM.Model;
namespace CRM
{
    public partial class Tasks : Form
    {
        CRMEntities db = new CRMEntities();
        private Model.Task task;
        public Tasks()
        {
            InitializeComponent();
            FillDgv();
            FillAllComboBoxs();
        }
        //DataGridView Doldurulur StartTime esasinda en yeni taskdan en kohne taska qeder
        public void FillDgv()
        {
            dgvTasks.Rows.Clear();
            foreach (var item in db.vwTaskLists.OrderByDescending(m => m.Start_Work_Time))
            {
                dgvTasks.Rows.Add(item.Id, item.Task_Name, item.Customer_Name, item.User_Name, item.Start_Work_Time, item.Finish_Work_Time, item.Status);
            }
            Reset();
        }
        //ComboBoxlar doldurulur
        public void FillAllComboBoxs()
        {
            foreach (var item in db.Users.ToList())
            {
                cmbUser.Items.Add(item.Id + "-" + item.Name);
            }
            foreach (var item in db.Customers.ToList())
            {
                cmbCustomer.Items.Add(item.Id + "-" + item.FullName);
            }
            cmbStatus.Items.Add("Finished");
            cmbStatus.Items.Add("Continue");
        }
        //Task Create
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Task newTask = new Model.Task();
            if(string.IsNullOrEmpty(txtTaskName.Text)||string.IsNullOrEmpty(cmbCustomer.Text)|| string.IsNullOrEmpty(cmbUser.Text))
            {
                MessageBox.Show("Please fill all inputs!");
            }
            else
            {
                newTask.Name = txtTaskName.Text;
                if (cmbStatus.SelectedText == "Continue")
                {
                    newTask.IsStatus = Convert.ToBoolean("True");
                }
                newTask.UserId =Convert.ToInt16( cmbUser.Text.Split('-')[0]);
                newTask.CustomerId = Convert.ToInt16(cmbCustomer.Text.Split('-')[0]);
                newTask.Date = dtpStartDate.Value;
                db.Tasks.Add(newTask);
                db.SaveChanges();
                FillDgv();
            }
        }
        //Butun datalari sifirlayirig
        public void Reset()
        {
            txtTaskName.ResetText();
            cmbCustomer.Text = "";
            cmbUser.Text = "";
            dtpStartDate.Value = DateTime.Now;
            cmbStatus.Text = "Continue";
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            cmbStatus.Enabled = false;
        }
        private void dgvTasks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
            cmbStatus.Enabled = true;
            int id = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells[0].Value.ToString());
            task = db.Tasks.Find(id);
            txtTaskName.Text = task.Name;
            cmbUser.Text =task.UserId+"-"+task.User.Name;
            cmbCustomer.Text =task.CustomerId+"-"+ task.Customer.FullName;
            dtpStartDate.Value = task.Date;
        }
        //DataGridViewda datalar update olunur
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(cmbCustomer.Text) || string.IsNullOrEmpty(cmbUser.Text))
            {
                MessageBox.Show("Please fill all inputs!");
            }
            else
            {
                task.Name = txtTaskName.Text;
                task.UserId =Convert.ToInt16( cmbUser.Text.Split('-')[0]);
                task.CustomerId = Convert.ToInt16(cmbCustomer.Text.Split('-')[0]);
                task.Date = dtpStartDate.Value;
                if (cmbStatus.SelectedText == "Continue")
                {
                    task.IsStatus = Convert.ToBoolean("True");
                    task.EndTime = null;
                }
                else
                {
                    task.IsStatus = Convert.ToBoolean("True");
                    DateTime now = DateTime.Now;
                    task.EndTime = now;
                }
                db.SaveChanges();
                FillDgv();
            }
        }
        //DataGridViewda data silme
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure delete this task?", "Delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
                FillDgv();
            }
        }
    }
}