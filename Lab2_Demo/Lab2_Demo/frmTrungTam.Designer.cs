
namespace Lab2_Demo
{
	partial class frmTrungTam
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbbMaHV = new System.Windows.Forms.ComboBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
			this.chkTinHocA = new System.Windows.Forms.CheckBox();
			this.chkTinHocB = new System.Windows.Forms.CheckBox();
			this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
			this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
			this.lblTienTHA = new System.Windows.Forms.Label();
			this.lblTienTHB = new System.Windows.Forms.Label();
			this.lblTienTAA = new System.Windows.Forms.Label();
			this.lblTienTAB = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(342, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tính tiền học trung tâm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mã học viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Họ tên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ngày đăng kí";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(266, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Giới tính";
			// 
			// cbbMaHV
			// 
			this.cbbMaHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaHV.FormattingEnabled = true;
			this.cbbMaHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
			this.cbbMaHV.Location = new System.Drawing.Point(132, 75);
			this.cbbMaHV.Name = "cbbMaHV";
			this.cbbMaHV.Size = new System.Drawing.Size(121, 24);
			this.cbbMaHV.TabIndex = 0;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(343, 73);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(58, 21);
			this.rdNam.TabIndex = 1;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(407, 73);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(47, 21);
			this.rdNu.TabIndex = 2;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(132, 108);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(322, 22);
			this.txtHoTen.TabIndex = 3;
			// 
			// dtpNgayDangKy
			// 
			this.dtpNgayDangKy.Location = new System.Drawing.Point(132, 136);
			this.dtpNgayDangKy.Name = "dtpNgayDangKy";
			this.dtpNgayDangKy.Size = new System.Drawing.Size(261, 22);
			this.dtpNgayDangKy.TabIndex = 4;
			// 
			// chkTinHocA
			// 
			this.chkTinHocA.AutoSize = true;
			this.chkTinHocA.Location = new System.Drawing.Point(71, 176);
			this.chkTinHocA.Name = "chkTinHocA";
			this.chkTinHocA.Size = new System.Drawing.Size(90, 21);
			this.chkTinHocA.TabIndex = 5;
			this.chkTinHocA.Text = "Tin học A";
			this.chkTinHocA.UseVisualStyleBackColor = true;
			// 
			// chkTinHocB
			// 
			this.chkTinHocB.AutoSize = true;
			this.chkTinHocB.Location = new System.Drawing.Point(71, 214);
			this.chkTinHocB.Name = "chkTinHocB";
			this.chkTinHocB.Size = new System.Drawing.Size(90, 21);
			this.chkTinHocB.TabIndex = 6;
			this.chkTinHocB.Text = "Tin học B";
			this.chkTinHocB.UseVisualStyleBackColor = true;
			// 
			// chkTiengAnhA
			// 
			this.chkTiengAnhA.AutoSize = true;
			this.chkTiengAnhA.Location = new System.Drawing.Point(71, 251);
			this.chkTiengAnhA.Name = "chkTiengAnhA";
			this.chkTiengAnhA.Size = new System.Drawing.Size(108, 21);
			this.chkTiengAnhA.TabIndex = 7;
			this.chkTiengAnhA.Text = "Tiếng Anh A";
			this.chkTiengAnhA.UseVisualStyleBackColor = true;
			// 
			// chkTiengAnhB
			// 
			this.chkTiengAnhB.AutoSize = true;
			this.chkTiengAnhB.Location = new System.Drawing.Point(71, 292);
			this.chkTiengAnhB.Name = "chkTiengAnhB";
			this.chkTiengAnhB.Size = new System.Drawing.Size(108, 21);
			this.chkTiengAnhB.TabIndex = 8;
			this.chkTiengAnhB.Text = "Tiếng Anh B";
			this.chkTiengAnhB.UseVisualStyleBackColor = true;
			// 
			// lblTienTHA
			// 
			this.lblTienTHA.AutoSize = true;
			this.lblTienTHA.Location = new System.Drawing.Point(289, 176);
			this.lblTienTHA.Name = "lblTienTHA";
			this.lblTienTHA.Size = new System.Drawing.Size(96, 17);
			this.lblTienTHA.TabIndex = 7;
			this.lblTienTHA.Text = "300.000 đồng";
			// 
			// lblTienTHB
			// 
			this.lblTienTHB.AutoSize = true;
			this.lblTienTHB.Location = new System.Drawing.Point(289, 215);
			this.lblTienTHB.Name = "lblTienTHB";
			this.lblTienTHB.Size = new System.Drawing.Size(96, 17);
			this.lblTienTHB.TabIndex = 7;
			this.lblTienTHB.Text = "500.000 đồng";
			// 
			// lblTienTAA
			// 
			this.lblTienTAA.AutoSize = true;
			this.lblTienTAA.Location = new System.Drawing.Point(289, 255);
			this.lblTienTAA.Name = "lblTienTAA";
			this.lblTienTAA.Size = new System.Drawing.Size(96, 17);
			this.lblTienTAA.TabIndex = 7;
			this.lblTienTAA.Text = "400.000 đồng";
			// 
			// lblTienTAB
			// 
			this.lblTienTAB.AutoSize = true;
			this.lblTienTAB.Location = new System.Drawing.Point(289, 296);
			this.lblTienTAB.Name = "lblTienTAB";
			this.lblTienTAB.Size = new System.Drawing.Size(96, 17);
			this.lblTienTAB.TabIndex = 7;
			this.lblTienTAB.Text = "600.000 đồng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(121, 332);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tổng tiền";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(227, 329);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(158, 22);
			this.txtTongTien.TabIndex = 9;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTinhTien.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnTinhTien.Location = new System.Drawing.Point(71, 367);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(105, 31);
			this.btnTinhTien.TabIndex = 11;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnExit.Location = new System.Drawing.Point(327, 367);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(58, 31);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
			this.btnCancel.Image = global::Lab2_Demo.Properties.Resources.btnCancel11;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(196, 367);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 31);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmTrungTam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 417);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblTienTAB);
			this.Controls.Add(this.lblTienTAA);
			this.Controls.Add(this.lblTienTHB);
			this.Controls.Add(this.lblTienTHA);
			this.Controls.Add(this.chkTiengAnhB);
			this.Controls.Add(this.chkTiengAnhA);
			this.Controls.Add(this.chkTinHocB);
			this.Controls.Add(this.chkTinHocA);
			this.Controls.Add(this.dtpNgayDangKy);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.cbbMaHV);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmTrungTam";
			this.Text = "Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbbMaHV;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
		private System.Windows.Forms.CheckBox chkTinHocA;
		private System.Windows.Forms.CheckBox chkTinHocB;
		private System.Windows.Forms.CheckBox chkTiengAnhA;
		private System.Windows.Forms.CheckBox chkTiengAnhB;
		private System.Windows.Forms.Label lblTienTHA;
		private System.Windows.Forms.Label lblTienTHB;
		private System.Windows.Forms.Label lblTienTAA;
		private System.Windows.Forms.Label lblTienTAB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnExit;
	}
}

