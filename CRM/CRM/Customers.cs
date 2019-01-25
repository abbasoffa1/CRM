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
    public partial class Customers : Form
    {
        CRMEntities db = new CRMEntities();
        public Customer customer;
        public Customers()
        {
            InitializeComponent();
            FillDgv();
        }
        //DataGrid View doldurulur
        public void FillDgv()
        {
            dgvCustomers.Rows.Clear();
            foreach (var item in db.Customers.ToList())
            {
                dgvCustomers.Rows.Add(item.Id, item.FullName, item.Phone, item.Email);
            }
        }
        //Customer Yaradilir
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer cstmr = new Customer();
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill all inputs!");
            }
            else
            {
                cstmr.Email = txtEmail.Text;
                cstmr.Phone = txtPhone.Text;
                cstmr.FullName = txtFullName.Text;
                db.Customers.Add(cstmr);
                db.SaveChanges();
                Reset();
            }
        }
        //0-lanir hersey
        public void Reset()
        {
            txtEmail.ResetText();
            txtFullName.ResetText();
            txtPhone.ResetText();

            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            FillDgv();
        }

        //Silme funskiyasi
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Are you sure delete this customer?", "Delete", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();

                Reset();
            }
        }

        //Yenilenir
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill all inputs!");
            }
            else
            {
                customer.FullName = txtFullName.Text;
                customer.Email = txtEmail.Text;
                customer.Phone = txtPhone.Text;

                db.SaveChanges();
                Reset();
            }
        }
        //Secilir row
        private void dgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            customer = db.Customers.Find(id);

            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;

            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtFullName.Text = customer.FullName;
        }
    }
}
