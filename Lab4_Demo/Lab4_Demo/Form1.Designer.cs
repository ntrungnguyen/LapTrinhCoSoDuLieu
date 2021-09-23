
namespace Lab4_Demo
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
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
			this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnHinh = new System.Windows.Forms.Button();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.cbLop = new System.Windows.Forms.ComboBox();
			this.tbHinh = new System.Windows.Forms.TextBox();
			this.tbDiaChi = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbTen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctmsXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.ctms.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbHinh
			// 
			this.pbHinh.Location = new System.Drawing.Point(12, 21);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(234, 247);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinh.TabIndex = 0;
			this.pbHinh.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mtbSDT);
			this.groupBox1.Controls.Add(this.mtbMSSV);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.btnMacDinh);
			this.groupBox1.Controls.Add(this.btnHinh);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.rdNu);
			this.groupBox1.Controls.Add(this.rdNam);
			this.groupBox1.Controls.Add(this.cbLop);
			this.groupBox1.Controls.Add(this.tbHinh);
			this.groupBox1.Controls.Add(this.tbDiaChi);
			this.groupBox1.Controls.Add(this.tbEmail);
			this.groupBox1.Controls.Add(this.tbTen);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(252, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(688, 245);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên";
			// 
			// mtbSDT
			// 
			this.mtbSDT.Location = new System.Drawing.Point(470, 147);
			this.mtbSDT.Mask = "0000.000.000";
			this.mtbSDT.Name = "mtbSDT";
			this.mtbSDT.Size = new System.Drawing.Size(200, 22);
			this.mtbSDT.TabIndex = 8;
			// 
			// mtbMSSV
			// 
			this.mtbMSSV.Location = new System.Drawing.Point(115, 37);
			this.mtbMSSV.Mask = "0000000";
			this.mtbMSSV.Name = "mtbMSSV";
			this.mtbMSSV.Size = new System.Drawing.Size(222, 22);
			this.mtbMSSV.TabIndex = 0;
			this.mtbMSSV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(576, 208);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(94, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(434, 208);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(94, 23);
			this.btnLuu.TabIndex = 11;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Location = new System.Drawing.Point(290, 208);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(94, 23);
			this.btnMacDinh.TabIndex = 10;
			this.btnMacDinh.Text = "Mặc định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnHinh
			// 
			this.btnHinh.Location = new System.Drawing.Point(576, 179);
			this.btnHinh.Name = "btnHinh";
			this.btnHinh.Size = new System.Drawing.Size(94, 23);
			this.btnHinh.TabIndex = 9;
			this.btnHinh.Text = "Chọn hình";
			this.btnHinh.UseVisualStyleBackColor = true;
			this.btnHinh.Click += new System.EventHandler(this.btnHinh_Click);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(470, 43);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
			this.dtpNgaySinh.TabIndex = 4;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(545, 79);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(47, 21);
			this.rdNu.TabIndex = 6;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Location = new System.Drawing.Point(470, 79);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(58, 21);
			this.rdNam.TabIndex = 5;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// cbLop
			// 
			this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLop.FormattingEnabled = true;
			this.cbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
			this.cbLop.Location = new System.Drawing.Point(470, 106);
			this.cbLop.Name = "cbLop";
			this.cbLop.Size = new System.Drawing.Size(166, 24);
			this.cbLop.TabIndex = 7;
			// 
			// tbHinh
			// 
			this.tbHinh.Location = new System.Drawing.Point(115, 179);
			this.tbHinh.Name = "tbHinh";
			this.tbHinh.ReadOnly = true;
			this.tbHinh.Size = new System.Drawing.Size(446, 22);
			this.tbHinh.TabIndex = 13;
			// 
			// tbDiaChi
			// 
			this.tbDiaChi.Location = new System.Drawing.Point(115, 145);
			this.tbDiaChi.Name = "tbDiaChi";
			this.tbDiaChi.Size = new System.Drawing.Size(222, 22);
			this.tbDiaChi.TabIndex = 3;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(115, 110);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(222, 22);
			this.tbEmail.TabIndex = 2;
			// 
			// tbTen
			// 
			this.tbTen.Location = new System.Drawing.Point(115, 74);
			this.tbTen.Name = "tbTen";
			this.tbTen.Size = new System.Drawing.Size(222, 22);
			this.tbTen.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(362, 148);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Số điện thoại";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(362, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Lớp";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(358, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Phái";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(358, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Hình";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ và tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lvSinhVien);
			this.groupBox2.Location = new System.Drawing.Point(14, 284);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(925, 253);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách sinh viên";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.CheckBoxes = true;
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lvSinhVien.ContextMenuStrip = this.ctms;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(0, 21);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(925, 232);
			this.lvSinhVien.TabIndex = 0;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên";
			this.columnHeader2.Width = 135;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phái";
			this.columnHeader3.Width = 61;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày sinh";
			this.columnHeader4.Width = 113;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			this.columnHeader5.Width = 84;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số điện thoại";
			this.columnHeader6.Width = 114;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Email";
			this.columnHeader7.Width = 111;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Địa chỉ";
			this.columnHeader8.Width = 137;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Hình";
			this.columnHeader9.Width = 441;
			// 
			// ctms
			// 
			this.ctms.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsXoa,
            this.tsmiLoad});
			this.ctms.Name = "ctms";
			this.ctms.Size = new System.Drawing.Size(189, 52);
			// 
			// ctmsXoa
			// 
			this.ctmsXoa.Name = "ctmsXoa";
			this.ctmsXoa.Size = new System.Drawing.Size(210, 24);
			this.ctmsXoa.Text = "Xóa";
			this.ctmsXoa.Click += new System.EventHandler(this.ctmsXoa_Click);
			// 
			// tsmiLoad
			// 
			this.tsmiLoad.Name = "tsmiLoad";
			this.tsmiLoad.Size = new System.Drawing.Size(210, 24);
			this.tsmiLoad.Text = "Tải lại danh sách";
			this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 551);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pbHinh);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ctms.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox mtbSDT;
		private System.Windows.Forms.MaskedTextBox mtbMSSV;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.Button btnHinh;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.ComboBox cbLop;
		private System.Windows.Forms.TextBox tbHinh;
		private System.Windows.Forms.TextBox tbDiaChi;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbTen;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ContextMenuStrip ctms;
		private System.Windows.Forms.ToolStripMenuItem ctmsXoa;
		private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
	}
}

