
namespace OnTapKiemTra_Phan1
{
	partial class FormQuanLy
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.tvKhoa = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbTim = new System.Windows.Forms.TextBox();
			this.rdSDT = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMSSV = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.ctmsListView.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.inToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(794, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// nhậpToolStripMenuItem
			// 
			this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
			this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.nhậpToolStripMenuItem.Text = "Nhập";
			// 
			// lưuToolStripMenuItem
			// 
			this.lưuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.jsonToolStripMenuItem});
			this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
			this.lưuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.lưuToolStripMenuItem.Text = "Lưu";
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.excelToolStripMenuItem.Text = "Excel";
			this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
			// 
			// jsonToolStripMenuItem
			// 
			this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
			this.jsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.jsonToolStripMenuItem.Text = "Json";
			this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
			// 
			// inToolStripMenuItem
			// 
			this.inToolStripMenuItem.Name = "inToolStripMenuItem";
			this.inToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
			this.inToolStripMenuItem.Text = "In";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chọn lớp để hiển thị danh sách sinh viên";
			// 
			// tvKhoa
			// 
			this.tvKhoa.Location = new System.Drawing.Point(8, 84);
			this.tvKhoa.Margin = new System.Windows.Forms.Padding(2);
			this.tvKhoa.Name = "tvKhoa";
			this.tvKhoa.Size = new System.Drawing.Size(217, 551);
			this.tvKhoa.TabIndex = 2;
			this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbTim);
			this.groupBox1.Controls.Add(this.rdSDT);
			this.groupBox1.Controls.Add(this.rdHoTen);
			this.groupBox1.Controls.Add(this.rdMSSV);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(229, 10);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(524, 69);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// tbTim
			// 
			this.tbTim.Location = new System.Drawing.Point(94, 39);
			this.tbTim.Margin = new System.Windows.Forms.Padding(2);
			this.tbTim.Multiline = true;
			this.tbTim.Name = "tbTim";
			this.tbTim.Size = new System.Drawing.Size(228, 24);
			this.tbTim.TabIndex = 3;
			this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
			// 
			// rdSDT
			// 
			this.rdSDT.AutoSize = true;
			this.rdSDT.Location = new System.Drawing.Point(236, 17);
			this.rdSDT.Margin = new System.Windows.Forms.Padding(2);
			this.rdSDT.Name = "rdSDT";
			this.rdSDT.Size = new System.Drawing.Size(88, 17);
			this.rdSDT.TabIndex = 2;
			this.rdSDT.TabStop = true;
			this.rdSDT.Text = "Số điện thoại";
			this.rdSDT.UseVisualStyleBackColor = true;
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Location = new System.Drawing.Point(162, 17);
			this.rdHoTen.Margin = new System.Windows.Forms.Padding(2);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(57, 17);
			this.rdHoTen.TabIndex = 2;
			this.rdHoTen.TabStop = true;
			this.rdHoTen.Text = "Họ tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			// 
			// rdMSSV
			// 
			this.rdMSSV.AutoSize = true;
			this.rdMSSV.Location = new System.Drawing.Point(94, 17);
			this.rdMSSV.Margin = new System.Windows.Forms.Padding(2);
			this.rdMSSV.Name = "rdMSSV";
			this.rdMSSV.Size = new System.Drawing.Size(55, 17);
			this.rdMSSV.TabIndex = 2;
			this.rdMSSV.TabStop = true;
			this.rdMSSV.Text = "MSSV";
			this.rdMSSV.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 19);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tìm theo:";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lvSinhVien.ContextMenuStrip = this.ctmsListView;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(229, 84);
			this.lvSinhVien.Margin = new System.Windows.Forms.Padding(2);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(525, 551);
			this.lvSinhVien.TabIndex = 4;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.DoubleClick += new System.EventHandler(this.lvSinhVien_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 85;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên lót";
			this.columnHeader2.Width = 161;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên";
			this.columnHeader3.Width = 87;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giới tính";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày sinh";
			this.columnHeader5.Width = 88;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số điện thoại";
			this.columnHeader6.Width = 106;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Lớp";
			this.columnHeader7.Width = 104;
			// 
			// ctmsListView
			// 
			this.ctmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa});
			this.ctmsListView.Name = "ctmsListView";
			this.ctmsListView.Size = new System.Drawing.Size(105, 48);
			// 
			// tsmiThem
			// 
			this.tsmiThem.Name = "tsmiThem";
			this.tsmiThem.Size = new System.Drawing.Size(104, 22);
			this.tsmiThem.Text = "Thêm";
			this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
			// 
			// tsmiXoa
			// 
			this.tsmiXoa.Name = "tsmiXoa";
			this.tsmiXoa.Size = new System.Drawing.Size(104, 22);
			this.tsmiXoa.Text = "Xóa";
			this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
			// 
			// FormQuanLy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 644);
			this.Controls.Add(this.lvSinhVien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tvKhoa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormQuanLy";
			this.Text = "Quản lý sinh viên";
			this.Load += new System.EventHandler(this.FormQuanLy_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ctmsListView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView tvKhoa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbTim;
		private System.Windows.Forms.RadioButton rdSDT;
		private System.Windows.Forms.RadioButton rdHoTen;
		private System.Windows.Forms.RadioButton rdMSSV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ContextMenuStrip ctmsListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiThem;
		private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
	}
}

