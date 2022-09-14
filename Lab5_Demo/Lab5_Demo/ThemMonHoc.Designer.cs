
namespace Lab5_Demo
{
	partial class ThemMonHoc
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
			this.tbMonHoc = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên môn học: ";
			// 
			// tbMonHoc
			// 
			this.tbMonHoc.Location = new System.Drawing.Point(125, 21);
			this.tbMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbMonHoc.Name = "tbMonHoc";
			this.tbMonHoc.Size = new System.Drawing.Size(273, 22);
			this.tbMonHoc.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(203, 53);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(97, 27);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(308, 53);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(92, 27);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// ThemMonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 116);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.tbMonHoc);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ThemMonHoc";
			this.Text = "Thêm môn học";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMonHoc;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnThoat;
	}
}