namespace ShoesSalesManagement.Forms
{
    partial class FormBanHang
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
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lvMatHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.lvMuaHang = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.cbbNhanVien = new Guna.UI.WinForms.GunaComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox5.SuspendLayout();
            this.gunaGroupBox4.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lvMatHang);
            this.gunaGroupBox1.Controls.Add(this.tbSearch);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.LightPink;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 2);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(847, 794);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Mặt hàng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(240, 2);
            // 
            // lvMatHang
            // 
            this.lvMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMatHang.FullRowSelect = true;
            this.lvMatHang.GridLines = true;
            this.lvMatHang.HideSelection = false;
            this.lvMatHang.Location = new System.Drawing.Point(3, 107);
            this.lvMatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMatHang.Name = "lvMatHang";
            this.lvMatHang.Size = new System.Drawing.Size(840, 678);
            this.lvMatHang.TabIndex = 1;
            this.lvMatHang.UseCompatibleStateImageBehavior = false;
            this.lvMatHang.View = System.Windows.Forms.View.Details;
            this.lvMatHang.DoubleClick += new System.EventHandler(this.lvMatHang_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên mặt hàng";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 164;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BaseColor = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.LightPink;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(57, 57);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Radius = 10;
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(499, 37);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Controls.Add(this.gunaGroupBox5);
            this.gunaGroupBox2.Controls.Add(this.gunaGroupBox4);
            this.gunaGroupBox2.Controls.Add(this.gunaButton1);
            this.gunaGroupBox2.Controls.Add(this.gunaGroupBox3);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.LightPink;
            this.gunaGroupBox2.Location = new System.Drawing.Point(852, 2);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(458, 794);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Thông tin hóa đơn";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(125, 2);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.Location = new System.Drawing.Point(197, 628);
            this.gunaTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.SelectedText = "";
            this.gunaTextBox4.Size = new System.Drawing.Size(251, 37);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(24, 628);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(100, 28);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Tổng tiền";
            // 
            // gunaGroupBox5
            // 
            this.gunaGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox5.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox5.Controls.Add(this.lvMuaHang);
            this.gunaGroupBox5.LineColor = System.Drawing.Color.Lavender;
            this.gunaGroupBox5.Location = new System.Drawing.Point(3, 354);
            this.gunaGroupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox5.Name = "gunaGroupBox5";
            this.gunaGroupBox5.Size = new System.Drawing.Size(453, 254);
            this.gunaGroupBox5.TabIndex = 2;
            this.gunaGroupBox5.Text = "Mặt hàng đã chọn";
            this.gunaGroupBox5.TextLocation = new System.Drawing.Point(110, 2);
            // 
            // lvMuaHang
            // 
            this.lvMuaHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader7});
            this.lvMuaHang.FullRowSelect = true;
            this.lvMuaHang.GridLines = true;
            this.lvMuaHang.HideSelection = false;
            this.lvMuaHang.Location = new System.Drawing.Point(3, 37);
            this.lvMuaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMuaHang.Name = "lvMuaHang";
            this.lvMuaHang.Size = new System.Drawing.Size(447, 214);
            this.lvMuaHang.TabIndex = 0;
            this.lvMuaHang.UseCompatibleStateImageBehavior = false;
            this.lvMuaHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã hàng";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên mặt hàng";
            this.columnHeader8.Width = 158;
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Controls.Add(this.gunaDateTimePicker1);
            this.gunaGroupBox4.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox4.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox4.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Lavender;
            this.gunaGroupBox4.Location = new System.Drawing.Point(0, 142);
            this.gunaGroupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Size = new System.Drawing.Size(456, 207);
            this.gunaGroupBox4.TabIndex = 1;
            this.gunaGroupBox4.Text = "Thông tin khách hàng";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(115, 2);
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(197, 129);
            this.gunaDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 10;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(251, 30);
            this.gunaDateTimePicker1.TabIndex = 7;
            this.gunaDateTimePicker1.Text = "13/12/2021";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 12, 13, 11, 1, 0, 514);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(197, 166);
            this.gunaTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(251, 37);
            this.gunaTextBox3.TabIndex = 6;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(197, 91);
            this.gunaTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(251, 37);
            this.gunaTextBox2.TabIndex = 5;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(197, 48);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(251, 37);
            this.gunaTextBox1.TabIndex = 4;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(24, 170);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(120, 28);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Khuyến mãi";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(24, 130);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(151, 28);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Ngày bán hàng";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 91);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 28);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Số điện thoại";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(24, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(156, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tên khách hàng";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.LightPink;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 752);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(458, 42);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Thanh toán";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Controls.Add(this.cbbNhanVien);
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Lavender;
            this.gunaGroupBox3.Location = new System.Drawing.Point(0, 46);
            this.gunaGroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(456, 90);
            this.gunaGroupBox3.TabIndex = 0;
            this.gunaGroupBox3.Text = "Nhân viên";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(155, 2);
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbNhanVien.BaseColor = System.Drawing.Color.White;
            this.cbbNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.cbbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cbbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(77, 43);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbNhanVien.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbNhanVien.Radius = 10;
            this.cbbNhanVien.Size = new System.Drawing.Size(300, 31);
            this.cbbNhanVien.TabIndex = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.Width = 105;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 802);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox5.ResumeLayout(false);
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            this.gunaGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.ListView lvMatHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaTextBox tbSearch;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaComboBox cbbNhanVien;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.ListView lvMuaHang;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}