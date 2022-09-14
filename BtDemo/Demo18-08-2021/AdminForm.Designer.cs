namespace Demo18_08_2021
{
	partial class AdminForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbbFloor = new System.Windows.Forms.ComboBox();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTableId = new System.Windows.Forms.TextBox();
			this.lvTableList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblNameFood = new System.Windows.Forms.Label();
			this.gbViewPictureFood = new System.Windows.Forms.GroupBox();
			this.ptbViewPictureFood = new System.Windows.Forms.PictureBox();
			this.lvFood = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtSearchFood = new System.Windows.Forms.TextBox();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.lbFind = new System.Windows.Forms.Label();
			this.lbFood = new System.Windows.Forms.Label();
			this.gbFood = new System.Windows.Forms.GroupBox();
			this.pnGroupFood = new System.Windows.Forms.Panel();
			this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.ctmsListView.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gbViewPictureFood.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbViewPictureFood)).BeginInit();
			this.gbFood.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(768, 81);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Mã bàn:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 4);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1348, 892);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.btnUpdate);
			this.tabPage1.Controls.Add(this.btnAdd);
			this.tabPage1.Controls.Add(this.cbbFloor);
			this.tabPage1.Controls.Add(this.txtTableName);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtTableId);
			this.tabPage1.Controls.Add(this.lvTableList);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(1340, 863);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Danh sách bàn ăn";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(1087, 231);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 32);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(935, 231);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(109, 32);
			this.btnUpdate.TabIndex = 27;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(772, 231);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(109, 32);
			this.btnAdd.TabIndex = 28;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbbFloor
			// 
			this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFloor.FormattingEnabled = true;
			this.cbbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbbFloor.Location = new System.Drawing.Point(884, 164);
			this.cbbFloor.Margin = new System.Windows.Forms.Padding(4);
			this.cbbFloor.Name = "cbbFloor";
			this.cbbFloor.Size = new System.Drawing.Size(309, 24);
			this.cbbFloor.TabIndex = 25;
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(884, 117);
			this.txtTableName.Margin = new System.Windows.Forms.Padding(4);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(311, 22);
			this.txtTableName.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(768, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 21;
			this.label3.Text = "Tầng:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(768, 122);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "Tên bàn:";
			// 
			// txtTableId
			// 
			this.txtTableId.Location = new System.Drawing.Point(884, 73);
			this.txtTableId.Margin = new System.Windows.Forms.Padding(4);
			this.txtTableId.Name = "txtTableId";
			this.txtTableId.ReadOnly = true;
			this.txtTableId.Size = new System.Drawing.Size(311, 22);
			this.txtTableId.TabIndex = 24;
			// 
			// lvTableList
			// 
			this.lvTableList.CheckBoxes = true;
			this.lvTableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvTableList.ContextMenuStrip = this.ctmsListView;
			this.lvTableList.FullRowSelect = true;
			this.lvTableList.GridLines = true;
			this.lvTableList.HideSelection = false;
			this.lvTableList.Location = new System.Drawing.Point(11, 12);
			this.lvTableList.Margin = new System.Windows.Forms.Padding(4);
			this.lvTableList.MultiSelect = false;
			this.lvTableList.Name = "lvTableList";
			this.lvTableList.Size = new System.Drawing.Size(663, 745);
			this.lvTableList.TabIndex = 20;
			this.lvTableList.UseCompatibleStateImageBehavior = false;
			this.lvTableList.View = System.Windows.Forms.View.Details;
			this.lvTableList.SelectedIndexChanged += new System.EventHandler(this.lvTableList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã bàn";
			this.columnHeader1.Width = 107;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên bàn";
			this.columnHeader2.Width = 210;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Trạng thái";
			this.columnHeader3.Width = 73;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tầng";
			this.columnHeader4.Width = 82;
			// 
			// ctmsListView
			// 
			this.ctmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xemDanhSáchHóaĐơnToolStripMenuItem});
			this.ctmsListView.Name = "ctmsListView";
			this.ctmsListView.Size = new System.Drawing.Size(238, 52);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(237, 24);
			this.tsmiDelete.Text = "Xóa tất cả";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// xemDanhSáchHóaĐơnToolStripMenuItem
			// 
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Name = "xemDanhSáchHóaĐơnToolStripMenuItem";
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Text = "Xem danh sách hóa đơn";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.lblNameFood);
			this.tabPage2.Controls.Add(this.gbViewPictureFood);
			this.tabPage2.Controls.Add(this.lvFood);
			this.tabPage2.Controls.Add(this.txtSearchFood);
			this.tabPage2.Controls.Add(this.btnAddFood);
			this.tabPage2.Controls.Add(this.lbFind);
			this.tabPage2.Controls.Add(this.lbFood);
			this.tabPage2.Controls.Add(this.gbFood);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(1340, 863);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Món ăn/uống";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lblNameFood
			// 
			this.lblNameFood.AutoSize = true;
			this.lblNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNameFood.Location = new System.Drawing.Point(349, 694);
			this.lblNameFood.Name = "lblNameFood";
			this.lblNameFood.Size = new System.Drawing.Size(17, 25);
			this.lblNameFood.TabIndex = 6;
			this.lblNameFood.Text = ".";
			// 
			// gbViewPictureFood
			// 
			this.gbViewPictureFood.Controls.Add(this.ptbViewPictureFood);
			this.gbViewPictureFood.Location = new System.Drawing.Point(349, 497);
			this.gbViewPictureFood.Name = "gbViewPictureFood";
			this.gbViewPictureFood.Size = new System.Drawing.Size(203, 194);
			this.gbViewPictureFood.TabIndex = 5;
			this.gbViewPictureFood.TabStop = false;
			this.gbViewPictureFood.Text = "Ảnh món ăn";
			// 
			// ptbViewPictureFood
			// 
			this.ptbViewPictureFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ptbViewPictureFood.Location = new System.Drawing.Point(5, 20);
			this.ptbViewPictureFood.Name = "ptbViewPictureFood";
			this.ptbViewPictureFood.Size = new System.Drawing.Size(192, 167);
			this.ptbViewPictureFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbViewPictureFood.TabIndex = 0;
			this.ptbViewPictureFood.TabStop = false;
			// 
			// lvFood
			// 
			this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
			this.lvFood.FullRowSelect = true;
			this.lvFood.GridLines = true;
			this.lvFood.HideSelection = false;
			this.lvFood.Location = new System.Drawing.Point(349, 55);
			this.lvFood.Name = "lvFood";
			this.lvFood.Size = new System.Drawing.Size(818, 423);
			this.lvFood.TabIndex = 4;
			this.lvFood.UseCompatibleStateImageBehavior = false;
			this.lvFood.View = System.Windows.Forms.View.Details;
			this.lvFood.Click += new System.EventHandler(this.lvFood_Click);
			this.lvFood.DoubleClick += new System.EventHandler(this.lvFood_DoubleClick);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Mã";
			this.columnHeader5.Width = 48;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Tên món ăn";
			this.columnHeader6.Width = 161;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Đơn vị tính";
			this.columnHeader7.Width = 102;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Đơn giá";
			this.columnHeader8.Width = 90;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Nhóm món ăn uống";
			this.columnHeader9.Width = 166;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Mô tả";
			this.columnHeader10.Width = 164;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Hình ảnh";
			this.columnHeader11.Width = 71;
			// 
			// txtSearchFood
			// 
			this.txtSearchFood.Location = new System.Drawing.Point(930, 18);
			this.txtSearchFood.Name = "txtSearchFood";
			this.txtSearchFood.Size = new System.Drawing.Size(205, 22);
			this.txtSearchFood.TabIndex = 3;
			this.txtSearchFood.Text = "Nhập từ khóa ...";
			this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(1141, 18);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(26, 23);
			this.btnAddFood.TabIndex = 2;
			this.btnAddFood.Text = "+";
			this.ttAdd.SetToolTip(this.btnAddFood, "Thêm món ăn");
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// lbFind
			// 
			this.lbFind.AutoSize = true;
			this.lbFind.Location = new System.Drawing.Point(672, 23);
			this.lbFind.Name = "lbFind";
			this.lbFind.Size = new System.Drawing.Size(124, 17);
			this.lbFind.TabIndex = 1;
			this.lbFind.Text = "Tìm kiếm theo tên:";
			// 
			// lbFood
			// 
			this.lbFood.AutoSize = true;
			this.lbFood.Location = new System.Drawing.Point(346, 20);
			this.lbFood.Name = "lbFood";
			this.lbFood.Size = new System.Drawing.Size(127, 17);
			this.lbFood.TabIndex = 1;
			this.lbFood.Text = "Danh sách món ăn";
			// 
			// gbFood
			// 
			this.gbFood.Controls.Add(this.pnGroupFood);
			this.gbFood.Location = new System.Drawing.Point(8, 20);
			this.gbFood.Name = "gbFood";
			this.gbFood.Size = new System.Drawing.Size(332, 458);
			this.gbFood.TabIndex = 0;
			this.gbFood.TabStop = false;
			this.gbFood.Text = "Nhóm món ăn";
			// 
			// pnGroupFood
			// 
			this.pnGroupFood.Location = new System.Drawing.Point(0, 22);
			this.pnGroupFood.Name = "pnGroupFood";
			this.pnGroupFood.Size = new System.Drawing.Size(332, 433);
			this.pnGroupFood.TabIndex = 0;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(0, 14);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(302, 180);
			this.txtDescription.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Location = new System.Drawing.Point(578, 497);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 194);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mô tả";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1344, 772);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ctmsListView.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.gbViewPictureFood.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbViewPictureFood)).EndInit();
			this.gbFood.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbbFloor;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTableId;
		private System.Windows.Forms.ListView lvTableList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ContextMenuStrip ctmsListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ListView lvFood;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.TextBox txtSearchFood;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Label lbFind;
		private System.Windows.Forms.Label lbFood;
		private System.Windows.Forms.GroupBox gbFood;
		private System.Windows.Forms.Panel pnGroupFood;
		private System.Windows.Forms.ToolTip ttAdd;
		private System.Windows.Forms.GroupBox gbViewPictureFood;
		private System.Windows.Forms.PictureBox ptbViewPictureFood;
		private System.Windows.Forms.Label lblNameFood;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDescription;
	}
}