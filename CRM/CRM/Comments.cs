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
    public partial class Comments : Form
    {
        CRMEntities db = new CRMEntities();
        public Comment cmnt;
        public Comments()
        {
            InitializeComponent();
            FillDgv();
            fillComboBoxs();
        }
        public void fillComboBoxs()
        {
            foreach (var item in db.Users.ToList())
            {
                cmbUser.Items.Add(item.Id+"-"+item.Name);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmnt.Date = dtpComment.Value;
            cmnt.UserId = Convert.ToInt32(cmbUser.Text.Split('-')[0]);
            cmnt.Description = rtbComment.Text;
            cmnt.Issue = rtbIssue.Text;
            cmnt.IssueDate = DateTime.Now;
            db.SaveChanges();
            Reset();
        }

        public void FillDgv()
        {
            dgvComments.Rows.Clear();
            foreach (var item in db.Comments.ToList())
            {
                dgvComments.Rows.Add(item.Id,item.User.Name,item.Description,item.Date,item.Issue,item.IssueDate);
            }
        }
        public void Reset()
        {
            rtbIssue.ResetText();
            dtpIssue.Value = DateTime.Now;
            FillDgv();
            rtbComment.Visible = false;
            dtpComment.Visible = false;
            cmbUser.Visible = false;
            lblComment.Visible = false;
            lblDate.Visible = false;
            lblUser.Visible = false;
            btnAdd.Location = new Point(18, 303);
        }
        private void dgvComments_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[0].Value.ToString());

            cmnt = db.Comments.Find(id);

            rtbComment.Visible = true;
            dtpComment.Visible = true;
            cmbUser.Visible = true;
            lblComment.Visible = true;
            lblDate.Visible = true;
            lblUser.Visible = true;
            btnAdd.Location = new Point(18, 600);
            rtbComment.Text = cmnt.Description;
            cmbUser.Text = cmnt.Id + "-" + cmnt.User.Name;
            dtpComment.Value = cmnt.Date;
            rtbIssue.Text = cmnt.Issue;
            dtpIssue.Value = cmnt.IssueDate.Value;
        }
    }
}
