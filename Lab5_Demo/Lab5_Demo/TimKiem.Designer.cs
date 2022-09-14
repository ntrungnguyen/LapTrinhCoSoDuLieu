
namespace Lab5_Demo
{
	partial class TimKiem
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
			this.rdMSSV = new System.Windows.Forms.RadioButton();
			this.rdTen = new System.Windows.Forms.RadioButton();
			this.rdLop = new System.Windows.Forms.RadioButton();
			this.tbTim = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdMSSV
			// 
			this.rdMSSV.AutoSize = true;
			this.rdMSSV.Location = new System.Drawing.Point(16, 34);
			this.rdMSSV.Margin = new System.Windows.Forms.Padding(4);
			this.rdMSSV.Name = "rdMSSV";
			this.rdMSSV.Size = new System.Drawing.Size(67, 21);
			this.rdMSSV.TabIndex = 0;
			this.rdMSSV.TabStop = true;
			this.rdMSSV.Text = "MSSV";
			this.rdMSSV.UseVisualStyleBackColor = true;
			// 
			// rdTen
			// 
			this.rdTen.AutoSize = true;
			this.rdTen.Location = new System.Drawing.Point(99, 34);
			this.rdTen.Margin = new System.Windows.Forms.Padding(4);
			this.rdTen.Name = "rdTen";
			this.rdTen.Size = new System.Drawing.Size(54, 21);
			this.rdTen.TabIndex = 1;
			this.rdTen.TabStop = true;
			this.rdTen.Text = "Tên";
			this.rdTen.UseVisualStyleBackColor = true;
			// 
			// rdLop
			// 
			this.rdLop.AutoSize = true;
			this.rdLop.Location = new System.Drawing.Point(165, 34);
			this.rdLop.Margin = new System.Windows.Forms.Padding(4);
			this.rdLop.Name = "rdLop";
			this.rdLop.Size = new System.Drawing.Size(53, 21);
			this.rdLop.TabIndex = 2;
			this.rdLop.TabStop = true;
			this.rdLop.Text = "Lớp";
			this.rdLop.UseVisualStyleBackColor = true;
			// 
			// tbTim
			// 
			this.tbTim.Location = new System.Drawing.Point(16, 63);
			this.tbTim.Margin = new System.Windows.Forms.Padding(4);
			this.tbTim.Name = "tbTim";
			this.tbTim.Size = new System.Drawing.Size(232, 22);
			this.tbTim.TabIndex = 3;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(16, 95);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(105, 37);
			this.btnTimKiem.TabIndex = 4;
			this.btnTimKiem.Text = "Tìm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// TimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 166);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.tbTim);
			this.Controls.Add(this.rdLop);
			this.Controls.Add(this.rdTen);
			this.Controls.Add(this.rdMSSV);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TimKiem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TimKiem";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rdMSSV;
		private System.Windows.Forms.RadioButton rdTen;
		private System.Windows.Forms.RadioButton rdLop;
		private System.Windows.Forms.TextBox tbTim;
		private System.Windows.Forms.Button btnTimKiem;
	}
}