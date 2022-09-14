
namespace BaiTapVD
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbMessage = new System.Windows.Forms.Label();
			this.txtBLoginName = new System.Windows.Forms.TextBox();
			this.txtBpassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cbBChiNhanh = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu";
			// 
			// lbMessage
			// 
			this.lbMessage.AutoSize = true;
			this.lbMessage.ForeColor = System.Drawing.Color.Red;
			this.lbMessage.Location = new System.Drawing.Point(16, 117);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new System.Drawing.Size(12, 17);
			this.lbMessage.TabIndex = 2;
			this.lbMessage.Text = ".";
			// 
			// txtBLoginName
			// 
			this.txtBLoginName.Location = new System.Drawing.Point(136, 44);
			this.txtBLoginName.Name = "txtBLoginName";
			this.txtBLoginName.Size = new System.Drawing.Size(180, 22);
			this.txtBLoginName.TabIndex = 1;
			// 
			// txtBpassword
			// 
			this.txtBpassword.Location = new System.Drawing.Point(136, 83);
			this.txtBpassword.Name = "txtBpassword";
			this.txtBpassword.Size = new System.Drawing.Size(180, 22);
			this.txtBpassword.TabIndex = 2;
			this.txtBpassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(99, 146);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(105, 33);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(226, 146);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(90, 33);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Chinh nhánh";
			// 
			// cbBChiNhanh
			// 
			this.cbBChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBChiNhanh.FormattingEnabled = true;
			this.cbBChiNhanh.Items.AddRange(new object[] {
            "Phù Đổng Thiên Vương",
            "Bùi Thị Xuân",
            "Phan Đình Phùng",
            "Nguyễn Thị Minh Khai"});
			this.cbBChiNhanh.Location = new System.Drawing.Point(136, 9);
			this.cbBChiNhanh.Name = "cbBChiNhanh";
			this.cbBChiNhanh.Size = new System.Drawing.Size(180, 24);
			this.cbBChiNhanh.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 320);
			this.Controls.Add(this.cbBChiNhanh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtBpassword);
			this.Controls.Add(this.txtBLoginName);
			this.Controls.Add(this.lbMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbMessage;
		private System.Windows.Forms.TextBox txtBLoginName;
		private System.Windows.Forms.TextBox txtBpassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbBChiNhanh;
	}
}

