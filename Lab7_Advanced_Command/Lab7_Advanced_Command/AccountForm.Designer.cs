
namespace Lab7_Advanced_Command
{
	partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewActivities = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpAccount = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(21, 12);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(85, 36);
            this.btnViewAccount.TabIndex = 0;
            this.btnViewAccount.Text = "Hiển thị danh sách tài khoản";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(496, 52);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(99, 38);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Thêm một tài khoản mới";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(496, 90);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(99, 36);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.Text = "Cập nhật tài khoản";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccount.Location = new System.Drawing.Point(4, 238);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(657, 319);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.Click += new System.EventHandler(this.dgvAccount_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewRole,
            this.tsmiViewActivities});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 70);
            // 
            // tsmiViewRole
            // 
            this.tsmiViewRole.Name = "tsmiViewRole";
            this.tsmiViewRole.Size = new System.Drawing.Size(212, 22);
            this.tsmiViewRole.Text = "Xem danh sách các vai trò";
            this.tsmiViewRole.Click += new System.EventHandler(this.tsmiViewRole_Click);
            // 
            // tsmiViewActivities
            // 
            this.tsmiViewActivities.Name = "tsmiViewActivities";
            this.tsmiViewActivities.Size = new System.Drawing.Size(212, 22);
            this.tsmiViewActivities.Text = "Xem nhật ký hoạt động";
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(103, 26);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(136, 20);
            this.tbAccountName.TabIndex = 4;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(103, 75);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(136, 20);
            this.tbFullName.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(103, 51);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(335, 26);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(130, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // tbTell
            // 
            this.tbTell.Location = new System.Drawing.Point(335, 52);
            this.tbTell.Name = "tbTell";
            this.tbTell.Size = new System.Drawing.Size(130, 20);
            this.tbTell.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên đầy đủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày tạo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.dtpAccount);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAccountName);
            this.groupBox1.Controls.Add(this.btnUpdateAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTell);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa trắng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpAccount
            // 
            this.dtpAccount.CustomFormat = "dd/MM/yyyy";
            this.dtpAccount.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAccount.Location = new System.Drawing.Point(335, 75);
            this.dtpAccount.Name = "dtpAccount";
            this.dtpAccount.Size = new System.Drawing.Size(130, 20);
            this.dtpAccount.TabIndex = 16;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnViewAccount);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnViewAccount;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Button btnUpdateAccount;
		private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewRole;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewActivities;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpAccount;
        private System.Windows.Forms.Button btnDelete;
    }
}