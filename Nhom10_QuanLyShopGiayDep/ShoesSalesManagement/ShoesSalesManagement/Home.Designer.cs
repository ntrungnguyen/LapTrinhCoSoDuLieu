namespace ShoesSalesManagement
{
    partial class Home
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnStatistics = new Guna.UI.WinForms.GunaButton();
            this.btnBills = new Guna.UI.WinForms.GunaButton();
            this.btnSale = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnManagement = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Pink;
            this.gunaPanel1.Controls.Add(this.btnStatistics);
            this.gunaPanel1.Controls.Add(this.btnBills);
            this.gunaPanel1.Controls.Add(this.btnSale);
            this.gunaPanel1.Controls.Add(this.btnLogout);
            this.gunaPanel1.Controls.Add(this.btnManagement);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(248, 798);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.AnimationHoverSpeed = 0.07F;
            this.btnStatistics.AnimationSpeed = 0.03F;
            this.btnStatistics.BaseColor = System.Drawing.Color.Pink;
            this.btnStatistics.BorderColor = System.Drawing.Color.Black;
            this.btnStatistics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStatistics.FocusedColor = System.Drawing.Color.Empty;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::ShoesSalesManagement.Properties.Resources.bill;
            this.btnStatistics.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStatistics.Location = new System.Drawing.Point(3, 442);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnStatistics.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStatistics.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStatistics.OnHoverImage = null;
            this.btnStatistics.OnPressedColor = System.Drawing.Color.Black;
            this.btnStatistics.Size = new System.Drawing.Size(243, 66);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBills
            // 
            this.btnBills.AnimationHoverSpeed = 0.07F;
            this.btnBills.AnimationSpeed = 0.03F;
            this.btnBills.BaseColor = System.Drawing.Color.Pink;
            this.btnBills.BorderColor = System.Drawing.Color.Black;
            this.btnBills.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBills.FocusedColor = System.Drawing.Color.Empty;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = global::ShoesSalesManagement.Properties.Resources.statistics;
            this.btnBills.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBills.Location = new System.Drawing.Point(3, 369);
            this.btnBills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBills.Name = "btnBills";
            this.btnBills.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnBills.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBills.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBills.OnHoverImage = null;
            this.btnBills.OnPressedColor = System.Drawing.Color.Black;
            this.btnBills.Size = new System.Drawing.Size(243, 66);
            this.btnBills.TabIndex = 1;
            this.btnBills.Text = "Hóa đơn";
            this.btnBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnSale
            // 
            this.btnSale.AnimationHoverSpeed = 0.07F;
            this.btnSale.AnimationSpeed = 0.03F;
            this.btnSale.BaseColor = System.Drawing.Color.Pink;
            this.btnSale.BorderColor = System.Drawing.Color.Black;
            this.btnSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSale.FocusedColor = System.Drawing.Color.Empty;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::ShoesSalesManagement.Properties.Resources.sell1;
            this.btnSale.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSale.Location = new System.Drawing.Point(3, 295);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSale.Name = "btnSale";
            this.btnSale.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnSale.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSale.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSale.OnHoverImage = null;
            this.btnSale.OnPressedColor = System.Drawing.Color.Black;
            this.btnSale.Size = new System.Drawing.Size(243, 66);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Bán hàng";
            this.btnSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Pink;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ShoesSalesManagement.Properties.Resources.logout;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(3, 674);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(243, 65);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.AnimationHoverSpeed = 0.07F;
            this.btnManagement.AnimationSpeed = 0.03F;
            this.btnManagement.BaseColor = System.Drawing.Color.Pink;
            this.btnManagement.BorderColor = System.Drawing.Color.Black;
            this.btnManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Image = global::ShoesSalesManagement.Properties.Resources.management;
            this.btnManagement.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManagement.Location = new System.Drawing.Point(3, 229);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnManagement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManagement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManagement.OnHoverImage = null;
            this.btnManagement.OnPressedColor = System.Drawing.Color.Black;
            this.btnManagement.Size = new System.Drawing.Size(243, 62);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Quản lý mặt hàng";
            this.btnManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.LightPink;
            this.gunaPanel2.Controls.Add(this.lbUserName);
            this.gunaPanel2.Controls.Add(this.pictureBox1);
            this.gunaPanel2.Location = new System.Drawing.Point(1, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(247, 134);
            this.gunaPanel2.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(11, 95);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(150, 22);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Tên người dùng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoesSalesManagement.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(80, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(248, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1548, 798);
            this.panelDesktop.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 798);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnManagement;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUserName;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaButton btnBills;
        private Guna.UI.WinForms.GunaButton btnStatistics;
        private Guna.UI.WinForms.GunaButton btnSale;
        private Guna.UI.WinForms.GunaPanel panelDesktop;
    }
}