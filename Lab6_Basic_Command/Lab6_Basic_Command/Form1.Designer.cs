﻿
namespace Lab6_Basic_Command
{
	partial class Form1
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryID = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDeleteCat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.btnViewAccount = new System.Windows.Forms.Button();
			this.btnViewBills = new System.Windows.Forms.Button();
			this.btnListTable = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 104);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(101, 28);
			this.btnLoad.TabIndex = 3;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.HideSelection = false;
			this.lvCategory.Location = new System.Drawing.Point(1, 138);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(607, 327);
			this.lvCategory.TabIndex = 1;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// chID
			// 
			this.chID.Text = "Mã Loại";
			this.chID.Width = 102;
			// 
			// chName
			// 
			this.chName.Text = "Tên loại món ăn";
			this.chName.Width = 235;
			// 
			// chType
			// 
			this.chType.Text = "Loại";
			this.chType.Width = 127;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã nhóm:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên nhóm thức ăn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Loại:";
			// 
			// txtCategoryID
			// 
			this.txtCategoryID.Location = new System.Drawing.Point(112, 15);
			this.txtCategoryID.Name = "txtCategoryID";
			this.txtCategoryID.Size = new System.Drawing.Size(223, 20);
			this.txtCategoryID.TabIndex = 0;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(112, 41);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(223, 20);
			this.txtCategoryName.TabIndex = 1;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(112, 67);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(223, 20);
			this.txtType.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(173, 104);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 28);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(267, 104);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 28);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(365, 104);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(92, 28);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteCat,
            this.tsmiViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
			// 
			// tsmiDeleteCat
			// 
			this.tsmiDeleteCat.Name = "tsmiDeleteCat";
			this.tsmiDeleteCat.Size = new System.Drawing.Size(199, 22);
			this.tsmiDeleteCat.Text = "Xóa nhóm sản phẩm";
			this.tsmiDeleteCat.Click += new System.EventHandler(this.tsmiDeleteCat_Click);
			// 
			// tsmiViewFood
			// 
			this.tsmiViewFood.Name = "tsmiViewFood";
			this.tsmiViewFood.Size = new System.Drawing.Size(199, 22);
			this.tsmiViewFood.Text = "Xem danh sách món ăn";
			this.tsmiViewFood.Click += new System.EventHandler(this.tsmiViewFood_Click);
			// 
			// btnViewAccount
			// 
			this.btnViewAccount.Location = new System.Drawing.Point(502, 12);
			this.btnViewAccount.Name = "btnViewAccount";
			this.btnViewAccount.Size = new System.Drawing.Size(94, 41);
			this.btnViewAccount.TabIndex = 7;
			this.btnViewAccount.Text = "Xem danh sách tài khoản";
			this.btnViewAccount.UseVisualStyleBackColor = true;
			this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
			// 
			// btnViewBills
			// 
			this.btnViewBills.Location = new System.Drawing.Point(408, 12);
			this.btnViewBills.Name = "btnViewBills";
			this.btnViewBills.Size = new System.Drawing.Size(88, 41);
			this.btnViewBills.TabIndex = 8;
			this.btnViewBills.Text = "Xem hóa đơn";
			this.btnViewBills.UseVisualStyleBackColor = true;
			this.btnViewBills.Click += new System.EventHandler(this.btnViewBills_Click);
			// 
			// btnListTable
			// 
			this.btnListTable.Location = new System.Drawing.Point(502, 59);
			this.btnListTable.Name = "btnListTable";
			this.btnListTable.Size = new System.Drawing.Size(94, 43);
			this.btnListTable.TabIndex = 9;
			this.btnListTable.Text = "Danh sách các bàn";
			this.btnListTable.UseVisualStyleBackColor = true;
			this.btnListTable.Click += new System.EventHandler(this.btnListTable_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 467);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.btnListTable);
			this.Controls.Add(this.btnViewBills);
			this.Controls.Add(this.btnViewAccount);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.txtCategoryID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListView lvCategory;
		private System.Windows.Forms.ColumnHeader chID;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryID;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCat;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewFood;
		private System.Windows.Forms.Button btnViewAccount;
		private System.Windows.Forms.Button btnViewBills;
		private System.Windows.Forms.Button btnListTable;
	}
}

