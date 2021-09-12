
namespace Lab2_Demo
{
	partial class frmTimThongTin
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
			this.gbTim = new System.Windows.Forms.GroupBox();
			this.rdbtnSDT = new System.Windows.Forms.RadioButton();
			this.rdbtnHoTen = new System.Windows.Forms.RadioButton();
			this.rdbtnMaGV = new System.Windows.Forms.RadioButton();
			this.lbTim = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gbTim.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTim
			// 
			this.gbTim.Controls.Add(this.rdbtnSDT);
			this.gbTim.Controls.Add(this.rdbtnHoTen);
			this.gbTim.Controls.Add(this.rdbtnMaGV);
			this.gbTim.Location = new System.Drawing.Point(27, 25);
			this.gbTim.Name = "gbTim";
			this.gbTim.Size = new System.Drawing.Size(376, 72);
			this.gbTim.TabIndex = 0;
			this.gbTim.TabStop = false;
			this.gbTim.Text = "Tìm theo";
			// 
			// rdbtnSDT
			// 
			this.rdbtnSDT.AutoSize = true;
			this.rdbtnSDT.Location = new System.Drawing.Point(243, 40);
			this.rdbtnSDT.Name = "rdbtnSDT";
			this.rdbtnSDT.Size = new System.Drawing.Size(119, 21);
			this.rdbtnSDT.TabIndex = 2;
			this.rdbtnSDT.TabStop = true;
			this.rdbtnSDT.Text = "Số Điện Thoại";
			this.rdbtnSDT.UseVisualStyleBackColor = true;
			this.rdbtnSDT.CheckedChanged += new System.EventHandler(this.rdbtnSDT_CheckedChanged);
			// 
			// rdbtnHoTen
			// 
			this.rdbtnHoTen.AutoSize = true;
			this.rdbtnHoTen.Location = new System.Drawing.Point(132, 40);
			this.rdbtnHoTen.Name = "rdbtnHoTen";
			this.rdbtnHoTen.Size = new System.Drawing.Size(76, 21);
			this.rdbtnHoTen.TabIndex = 1;
			this.rdbtnHoTen.TabStop = true;
			this.rdbtnHoTen.Text = "Họ Tên";
			this.rdbtnHoTen.UseVisualStyleBackColor = true;
			this.rdbtnHoTen.CheckedChanged += new System.EventHandler(this.rdbtnHoTen_CheckedChanged);
			// 
			// rdbtnMaGV
			// 
			this.rdbtnMaGV.AutoSize = true;
			this.rdbtnMaGV.Location = new System.Drawing.Point(22, 40);
			this.rdbtnMaGV.Name = "rdbtnMaGV";
			this.rdbtnMaGV.Size = new System.Drawing.Size(72, 21);
			this.rdbtnMaGV.TabIndex = 0;
			this.rdbtnMaGV.TabStop = true;
			this.rdbtnMaGV.Text = "Mã GV";
			this.rdbtnMaGV.UseVisualStyleBackColor = true;
			this.rdbtnMaGV.CheckedChanged += new System.EventHandler(this.rdbtnMaGV_CheckedChanged);
			// 
			// lbTim
			// 
			this.lbTim.AutoSize = true;
			this.lbTim.Location = new System.Drawing.Point(24, 119);
			this.lbTim.Name = "lbTim";
			this.lbTim.Size = new System.Drawing.Size(12, 17);
			this.lbTim.TabIndex = 1;
			this.lbTim.Text = ".";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(132, 113);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(190, 22);
			this.txtTimKiem.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(328, 112);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 23);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = ".";
			// 
			// frmTimThongTin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 156);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.lbTim);
			this.Controls.Add(this.gbTim);
			this.Name = "frmTimThongTin";
			this.Text = "Tìm thông tin Giáo Viên";
			this.gbTim.ResumeLayout(false);
			this.gbTim.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbTim;
		private System.Windows.Forms.RadioButton rdbtnSDT;
		private System.Windows.Forms.RadioButton rdbtnHoTen;
		private System.Windows.Forms.RadioButton rdbtnMaGV;
		private System.Windows.Forms.Label lbTim;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label label1;
	}
}