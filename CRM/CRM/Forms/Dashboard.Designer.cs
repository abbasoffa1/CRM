namespace CRM
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnCustomers = new System.Windows.Forms.PictureBox();
            this.btnSignOut = new System.Windows.Forms.PictureBox();
            this.btnComments = new System.Windows.Forms.PictureBox();
            this.btnTasks = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.PictureBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.InitialImage")));
            this.btnCustomers.Location = new System.Drawing.Point(22, 159);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(134, 122);
            this.btnCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.InitialImage")));
            this.btnSignOut.Location = new System.Drawing.Point(22, 576);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(134, 122);
            this.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnComments
            // 
            this.btnComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnComments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComments.Image = ((System.Drawing.Image)(resources.GetObject("btnComments.Image")));
            this.btnComments.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnComments.InitialImage")));
            this.btnComments.Location = new System.Drawing.Point(22, 437);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(134, 122);
            this.btnComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnComments.TabIndex = 8;
            this.btnComments.TabStop = false;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnTasks.InitialImage")));
            this.btnTasks.Location = new System.Drawing.Point(22, 298);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(134, 122);
            this.btnTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTasks.TabIndex = 9;
            this.btnTasks.TabStop = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.White;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.InitialImage")));
            this.btnUsers.Location = new System.Drawing.Point(22, 21);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(134, 122);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUsers.TabIndex = 10;
            this.btnUsers.TabStop = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.CUSTOMER,
            this.USER,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.dgvTasks.Location = new System.Drawing.Point(180, 21);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(977, 677);
            this.dgvTasks.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TASK NAME";
            this.Column1.Name = "Column1";
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.HeaderText = "CUSTOMER";
            this.CUSTOMER.Name = "CUSTOMER";
            // 
            // USER
            // 
            this.USER.HeaderText = "USER";
            this.USER.Name = "USER";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "START DATE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "END DATE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "STATUS";
            this.Column4.Name = "Column4";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 741);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnCustomers);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCustomers;
        private System.Windows.Forms.PictureBox btnSignOut;
        private System.Windows.Forms.PictureBox btnComments;
        private System.Windows.Forms.PictureBox btnTasks;
        private System.Windows.Forms.PictureBox btnUsers;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}