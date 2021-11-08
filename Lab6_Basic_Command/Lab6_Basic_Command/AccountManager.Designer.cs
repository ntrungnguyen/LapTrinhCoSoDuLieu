
namespace Lab6_Basic_Command
{
	partial class AccountManager
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
			this.dgvAccountManager = new System.Windows.Forms.DataGridView();
			this.ctmsAccountManager = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhSáchVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.btnUpdateAccount = new System.Windows.Forms.Button();
			this.btnResetAccount = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbSapXep = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbAccountName = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbTell = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnXoaTrang = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountManager)).BeginInit();
			this.ctmsAccountManager.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAccountManager
			// 
			this.dgvAccountManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccountManager.ContextMenuStrip = this.ctmsAccountManager;
			this.dgvAccountManager.Location = new System.Drawing.Point(-1, -1);
			this.dgvAccountManager.Name = "dgvAccountManager";
			this.dgvAccountManager.Size = new System.Drawing.Size(800, 352);
			this.dgvAccountManager.TabIndex = 0;
			this.dgvAccountManager.Click += new System.EventHandler(this.dgvAccountManager_Click);
			// 
			// ctmsAccountManager
			// 
			this.ctmsAccountManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteAccount,
            this.xemDanhSáchVaiTròToolStripMenuItem});
			this.ctmsAccountManager.Name = "ctmsAccountManager";
			this.ctmsAccountManager.Size = new System.Drawing.Size(192, 48);
			// 
			// tsmiDeleteAccount
			// 
			this.tsmiDeleteAccount.Name = "tsmiDeleteAccount";
			this.tsmiDeleteAccount.Size = new System.Drawing.Size(191, 22);
			this.tsmiDeleteAccount.Text = "Xóa tài khoản";
			this.tsmiDeleteAccount.Click += new System.EventHandler(this.tsmiDeleteAccount_Click);
			// 
			// xemDanhSáchVaiTròToolStripMenuItem
			// 
			this.xemDanhSáchVaiTròToolStripMenuItem.Name = "xemDanhSáchVaiTròToolStripMenuItem";
			this.xemDanhSáchVaiTròToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.xemDanhSáchVaiTròToolStripMenuItem.Text = "Xem danh sách vai trò";
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(585, 16);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(102, 31);
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "Thêm tài khoản";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// btnUpdateAccount
			// 
			this.btnUpdateAccount.Location = new System.Drawing.Point(221, 363);
			this.btnUpdateAccount.Name = "btnUpdateAccount";
			this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateAccount.TabIndex = 2;
			this.btnUpdateAccount.Text = "Cập nhật";
			this.btnUpdateAccount.UseVisualStyleBackColor = true;
			this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
			// 
			// btnResetAccount
			// 
			this.btnResetAccount.Location = new System.Drawing.Point(312, 363);
			this.btnResetAccount.Name = "btnResetAccount";
			this.btnResetAccount.Size = new System.Drawing.Size(75, 23);
			this.btnResetAccount.TabIndex = 3;
			this.btnResetAccount.Text = "Reset";
			this.btnResetAccount.UseVisualStyleBackColor = true;
			this.btnResetAccount.Click += new System.EventHandler(this.btnResetAccount_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sắp xếp:";
			// 
			// cbbSapXep
			// 
			this.cbbSapXep.FormattingEnabled = true;
			this.cbbSapXep.Items.AddRange(new object[] {
            "Nhóm",
            "Trạng thái"});
			this.cbbSapXep.Location = new System.Drawing.Point(67, 363);
			this.cbbSapXep.Name = "cbbSapXep";
			this.cbbSapXep.Size = new System.Drawing.Size(121, 21);
			this.cbbSapXep.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tên tài khoản";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Họ và tên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Mật khẩu";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(252, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(252, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Số điện thoại";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(92, 16);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(134, 20);
			this.tbName.TabIndex = 9;
			// 
			// tbAccountName
			// 
			this.tbAccountName.Location = new System.Drawing.Point(92, 42);
			this.tbAccountName.Name = "tbAccountName";
			this.tbAccountName.Size = new System.Drawing.Size(134, 20);
			this.tbAccountName.TabIndex = 10;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(92, 68);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(134, 20);
			this.tbPassword.TabIndex = 11;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(355, 16);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(121, 20);
			this.tbEmail.TabIndex = 12;
			// 
			// tbTell
			// 
			this.tbTell.Location = new System.Drawing.Point(355, 42);
			this.tbTell.Name = "tbTell";
			this.tbTell.Size = new System.Drawing.Size(121, 20);
			this.tbTell.TabIndex = 13;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(355, 69);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Ngày tạo tài khoản";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnXoaTrang);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbTell);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbEmail);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnAddAccount);
			this.groupBox1.Controls.Add(this.tbPassword);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbAccountName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 403);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(701, 102);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thêm tài khoản";
			// 
			// btnXoaTrang
			// 
			this.btnXoaTrang.Location = new System.Drawing.Point(585, 65);
			this.btnXoaTrang.Name = "btnXoaTrang";
			this.btnXoaTrang.Size = new System.Drawing.Size(102, 23);
			this.btnXoaTrang.TabIndex = 15;
			this.btnXoaTrang.Text = "Xóa trắng";
			this.btnXoaTrang.UseVisualStyleBackColor = true;
			this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
			// 
			// AccountManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 521);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbbSapXep);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnResetAccount);
			this.Controls.Add(this.btnUpdateAccount);
			this.Controls.Add(this.dgvAccountManager);
			this.Name = "AccountManager";
			this.Text = "AccountManager";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountManager)).EndInit();
			this.ctmsAccountManager.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAccountManager;
		private System.Windows.Forms.ContextMenuStrip ctmsAccountManager;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAccount;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchVaiTròToolStripMenuItem;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Button btnUpdateAccount;
		private System.Windows.Forms.Button btnResetAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbSapXep;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbAccountName;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbTell;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnXoaTrang;
	}
}