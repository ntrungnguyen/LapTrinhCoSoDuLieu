
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
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountManager)).BeginInit();
			this.ctmsAccountManager.SuspendLayout();
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
			// 
			// ctmsAccountManager
			// 
			this.ctmsAccountManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteAccount,
            this.xemDanhSáchVaiTròToolStripMenuItem});
			this.ctmsAccountManager.Name = "ctmsAccountManager";
			this.ctmsAccountManager.Size = new System.Drawing.Size(192, 70);
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
			this.btnAddAccount.Location = new System.Drawing.Point(212, 363);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(121, 23);
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "Thêm tài khoản";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// btnUpdateAccount
			// 
			this.btnUpdateAccount.Location = new System.Drawing.Point(348, 363);
			this.btnUpdateAccount.Name = "btnUpdateAccount";
			this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateAccount.TabIndex = 2;
			this.btnUpdateAccount.Text = "Cập nhật";
			this.btnUpdateAccount.UseVisualStyleBackColor = true;
			// 
			// btnResetAccount
			// 
			this.btnResetAccount.Location = new System.Drawing.Point(439, 363);
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
			// AccountManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbbSapXep);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnResetAccount);
			this.Controls.Add(this.btnUpdateAccount);
			this.Controls.Add(this.btnAddAccount);
			this.Controls.Add(this.dgvAccountManager);
			this.Name = "AccountManager";
			this.Text = "AccountManager";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountManager)).EndInit();
			this.ctmsAccountManager.ResumeLayout(false);
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
	}
}