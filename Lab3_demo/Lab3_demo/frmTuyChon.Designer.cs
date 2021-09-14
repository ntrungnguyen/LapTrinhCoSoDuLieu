
namespace Lab3_demo
{
	partial class frmTuyChon
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
			this.rdMaSV = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdNgaySinh = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// rdMaSV
			// 
			this.rdMaSV.AutoSize = true;
			this.rdMaSV.Checked = true;
			this.rdMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdMaSV.ForeColor = System.Drawing.Color.Blue;
			this.rdMaSV.Location = new System.Drawing.Point(7, 23);
			this.rdMaSV.Name = "rdMaSV";
			this.rdMaSV.Size = new System.Drawing.Size(85, 24);
			this.rdMaSV.TabIndex = 0;
			this.rdMaSV.TabStop = true;
			this.rdMaSV.Text = "Mã SV";
			this.rdMaSV.UseVisualStyleBackColor = true;
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdHoTen.ForeColor = System.Drawing.Color.Blue;
			this.rdHoTen.Location = new System.Drawing.Point(150, 23);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(91, 24);
			this.rdHoTen.TabIndex = 0;
			this.rdHoTen.Text = "Họ Tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			// 
			// rdNgaySinh
			// 
			this.rdNgaySinh.AutoSize = true;
			this.rdNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNgaySinh.ForeColor = System.Drawing.Color.Blue;
			this.rdNgaySinh.Location = new System.Drawing.Point(294, 23);
			this.rdNgaySinh.Name = "rdNgaySinh";
			this.rdNgaySinh.Size = new System.Drawing.Size(115, 24);
			this.rdNgaySinh.TabIndex = 0;
			this.rdNgaySinh.Text = "Ngày Sinh";
			this.rdNgaySinh.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập thông tin";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(165, 21);
			this.tbSearch.Multiline = true;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(150, 31);
			this.tbSearch.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.BlueViolet;
			this.btnSearch.Location = new System.Drawing.Point(334, 18);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 34);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnSapXep
			// 
			this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSapXep.ForeColor = System.Drawing.Color.BlueViolet;
			this.btnSapXep.Location = new System.Drawing.Point(69, 170);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(91, 34);
			this.btnSapXep.TabIndex = 3;
			this.btnSapXep.Text = "Sắp Xếp";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.BlueViolet;
			this.btnExit.Location = new System.Drawing.Point(199, 170);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 34);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdNgaySinh);
			this.groupBox1.Controls.Add(this.rdHoTen);
			this.groupBox1.Controls.Add(this.rdMaSV);
			this.groupBox1.Location = new System.Drawing.Point(33, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(431, 59);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.btnSearch);
			this.gbSearch.Controls.Add(this.tbSearch);
			this.gbSearch.Controls.Add(this.label1);
			this.gbSearch.Location = new System.Drawing.Point(33, 77);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(431, 62);
			this.gbSearch.TabIndex = 5;
			this.gbSearch.TabStop = false;
			// 
			// frmTuyChon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 241);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSapXep);
			this.Name = "frmTuyChon";
			this.Text = "Tùy chọn";
			this.Load += new System.EventHandler(this.frmTuyChon_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton rdMaSV;
		private System.Windows.Forms.RadioButton rdHoTen;
		private System.Windows.Forms.RadioButton rdNgaySinh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnSapXep;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbSearch;
	}
}