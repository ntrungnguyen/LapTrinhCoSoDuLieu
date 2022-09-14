
namespace CheckListBox
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
			this.chkLBMonHoc = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// chkLBMonHoc
			// 
			this.chkLBMonHoc.FormattingEnabled = true;
			this.chkLBMonHoc.Items.AddRange(new object[] {
            "CC và MT LT1",
            "Cơ sở dữ liệu",
            "Tiếng Anh 2",
            "Quản trị mạng",
            "Photoshop",
            "Đồ án",
            "Tin học cơ sở"});
			this.chkLBMonHoc.Location = new System.Drawing.Point(12, 12);
			this.chkLBMonHoc.MultiColumn = true;
			this.chkLBMonHoc.Name = "chkLBMonHoc";
			this.chkLBMonHoc.Size = new System.Drawing.Size(341, 89);
			this.chkLBMonHoc.TabIndex = 0;
			this.chkLBMonHoc.SelectedIndexChanged += new System.EventHandler(this.chkLBMonHoc_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 178);
			this.Controls.Add(this.chkLBMonHoc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox chkLBMonHoc;
	}
}

