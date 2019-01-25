using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CRM.Model;
namespace CRM
{
    public partial class User : Form
    {
        private readonly CRMEntities db = new CRMEntities();
        public User()
        {
            InitializeComponent();
            CreateTabControl();
        }
        public void CreateTabControl()
        {
            //Tab Panel yaradirig
            TabControl tabControl = new TabControl();
            foreach (var user in db.Users.ToList())
            {
                //Tabpage elave olunur Databasedeki User listine esasen
                TabPage tabPage = new TabPage();
                tabPage.Text = user.Name;
                //DataGridView Yaradirig bu secdiyimiz userin butun tasklarini gosterir
                DataGridView dgv = new DataGridView();
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersHeight = 60;
                foreach (var item in typeof(Model.vwTaskList).GetProperties().ToList())
                {
                    //Columnlar Doldurulur View esasen
                    DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                    column1.ReadOnly = true;
                    column1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column1.HeaderText = item.Name;
                    column1.Width = 150;
                    dgv.Columns.Add(column1);
                }
                foreach (var item in db.vwTaskLists.ToList().Where(t=>t.User_Name==user.Name).ToList())
                {
                    //Datalar rowlara doldurulur
                    dgv.Rows.Add(item.Id,item.Task_Name, item.User_Name, item.Customer_Name, item.Start_Work_Time.ToString("HH:mm dd-MM-yyyy"), item.Finish_Work_Time==null?"":Convert.ToDateTime(item.Finish_Work_Time).ToString("HH:mm dd-MM-yyyy"), item.Status);
                }
                dgv.Size = new Size(1100, 580);
                dgv.ForeColor = Color.Black;
                tabPage.Controls.Add(dgv);
                tabControl.Controls.Add(tabPage);
            }
            tabControl.Location = new Point(40, 40);
            tabControl.Size = new Size(1100, 620);
            //TabControl elave olunur 
            this.Controls.Add(tabControl);
        }
    }
}
