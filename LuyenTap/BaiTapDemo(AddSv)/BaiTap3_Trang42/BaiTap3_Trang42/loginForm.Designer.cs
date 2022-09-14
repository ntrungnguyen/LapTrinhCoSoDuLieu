
namespace BaiTap3_Trang42
{
    partial class loginForm
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
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.bdnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMessenger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(146, 56);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(187, 27);
            this.txtLoginName.TabIndex = 1;
            this.txtLoginName.TextChanged += new System.EventHandler(this.txtLoginName_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(146, 121);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(187, 27);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // bdnLogin
            // 
            this.bdnLogin.Location = new System.Drawing.Point(96, 188);
            this.bdnLogin.Name = "bdnLogin";
            this.bdnLogin.Size = new System.Drawing.Size(94, 29);
            this.bdnLogin.TabIndex = 3;
            this.bdnLogin.Text = "Đăng Nhập";
            this.bdnLogin.UseVisualStyleBackColor = true;
            this.bdnLogin.Click += new System.EventHandler(this.bdnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMessenger
            // 
            this.lblMessenger.AutoSize = true;
            this.lblMessenger.ForeColor = System.Drawing.Color.Red;
            this.lblMessenger.Location = new System.Drawing.Point(29, 152);
            this.lblMessenger.Name = "lblMessenger";
            this.lblMessenger.Size = new System.Drawing.Size(12, 20);
            this.lblMessenger.TabIndex = 6;
            this.lblMessenger.Text = ".";
            this.lblMessenger.Click += new System.EventHandler(this.lblMessenger_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi nhánh";
            // 
            // cbbChinhanh
            // 
            this.cbbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChinhanh.FormattingEnabled = true;
            this.cbbChinhanh.Items.AddRange(new object[] {
            "Phan Đình Phùng",
            "Bùi Thị Xuân ",
            "Nguyễn Thị MInh Khai"});
            this.cbbChinhanh.Location = new System.Drawing.Point(146, 19);
            this.cbbChinhanh.Name = "cbbChinhanh";
            this.cbbChinhanh.Size = new System.Drawing.Size(187, 28);
            this.cbbChinhanh.TabIndex = 0;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMessenger);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bdnLogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChinhanh);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button bdnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessenger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbChinhanh;
    }
}