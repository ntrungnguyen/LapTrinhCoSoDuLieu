namespace ShoesSalesManagement.Forms
{
    partial class FormQuanLyMatHang
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
            this.lvMatHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddType = new Guna.UI.WinForms.GunaButton();
            this.tbThuongHieu = new Guna.UI.WinForms.GunaTextBox();
            this.tbNotes = new Guna.UI.WinForms.GunaTextBox();
            this.tbName = new Guna.UI.WinForms.GunaTextBox();
            this.tbID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.tbSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.tbQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.tbGiaBan = new Guna.UI.WinForms.GunaTextBox();
            this.tbGiaNhap = new Guna.UI.WinForms.GunaTextBox();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnPicture = new Guna.UI.WinForms.GunaButton();
            this.cbbType = new Guna.UI.WinForms.GunaComboBox();
            this.pbPicture = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.cbbPhanLoai = new Guna.UI.WinForms.GunaComboBox();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMatHang
            // 
            this.lvMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMatHang.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.lvMatHang.FullRowSelect = true;
            this.lvMatHang.GridLines = true;
            this.lvMatHang.HideSelection = false;
            this.lvMatHang.Location = new System.Drawing.Point(3, 34);
            this.lvMatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMatHang.Name = "lvMatHang";
            this.lvMatHang.Size = new System.Drawing.Size(1567, 345);
            this.lvMatHang.TabIndex = 0;
            this.lvMatHang.UseCompatibleStateImageBehavior = false;
            this.lvMatHang.View = System.Windows.Forms.View.Details;
            this.lvMatHang.Click += new System.EventHandler(this.lvMatHang_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giày";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên mặt hàng";
            this.columnHeader2.Width = 213;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng tồn";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá nhập";
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá bán";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thương hiệu";
            this.columnHeader7.Width = 183;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mô tả";
            this.columnHeader8.Width = 316;
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(172, 28);
            // 
            // tsmiDeleteItem
            // 
            this.tsmiDeleteItem.Name = "tsmiDeleteItem";
            this.tsmiDeleteItem.Size = new System.Drawing.Size(171, 24);
            this.tsmiDeleteItem.Text = "Xóa mặt hàng";
            this.tsmiDeleteItem.Click += new System.EventHandler(this.tsmiDeleteItem_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.AnimationHoverSpeed = 0.07F;
            this.btnAddType.AnimationSpeed = 0.03F;
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.BaseColor = System.Drawing.Color.LightPink;
            this.btnAddType.BorderColor = System.Drawing.Color.Black;
            this.btnAddType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddType.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.White;
            this.btnAddType.Image = null;
            this.btnAddType.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddType.Location = new System.Drawing.Point(1121, 57);
            this.btnAddType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddType.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddType.OnHoverImage = null;
            this.btnAddType.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddType.Radius = 10;
            this.btnAddType.Size = new System.Drawing.Size(107, 32);
            this.btnAddType.TabIndex = 15;
            this.btnAddType.Text = "Thêm loại";
            this.btnAddType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // tbThuongHieu
            // 
            this.tbThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.tbThuongHieu.BaseColor = System.Drawing.Color.White;
            this.tbThuongHieu.BorderColor = System.Drawing.Color.LightPink;
            this.tbThuongHieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbThuongHieu.FocusedBaseColor = System.Drawing.Color.White;
            this.tbThuongHieu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbThuongHieu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbThuongHieu.Location = new System.Drawing.Point(459, 130);
            this.tbThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbThuongHieu.Name = "tbThuongHieu";
            this.tbThuongHieu.PasswordChar = '\0';
            this.tbThuongHieu.Radius = 10;
            this.tbThuongHieu.SelectedText = "";
            this.tbThuongHieu.Size = new System.Drawing.Size(247, 37);
            this.tbThuongHieu.TabIndex = 11;
            // 
            // tbNotes
            // 
            this.tbNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbNotes.BaseColor = System.Drawing.Color.White;
            this.tbNotes.BorderColor = System.Drawing.Color.LightPink;
            this.tbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNotes.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbNotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNotes.Location = new System.Drawing.Point(913, 133);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PasswordChar = '\0';
            this.tbNotes.Radius = 10;
            this.tbNotes.SelectedText = "";
            this.tbNotes.Size = new System.Drawing.Size(315, 102);
            this.tbNotes.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BaseColor = System.Drawing.Color.White;
            this.tbName.BorderColor = System.Drawing.Color.LightPink;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.FocusedBaseColor = System.Drawing.Color.White;
            this.tbName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbName.Location = new System.Drawing.Point(459, 94);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.Radius = 10;
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(247, 37);
            this.tbName.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.Transparent;
            this.tbID.BaseColor = System.Drawing.Color.White;
            this.tbID.BorderColor = System.Drawing.Color.LightPink;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.FocusedBaseColor = System.Drawing.Color.White;
            this.tbID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbID.Location = new System.Drawing.Point(459, 57);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.Radius = 10;
            this.tbID.ReadOnly = true;
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(247, 37);
            this.tbID.TabIndex = 3;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(347, 174);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel8.TabIndex = 8;
            this.gunaLabel8.Text = "Giá nhập";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(347, 134);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel7.TabIndex = 7;
            this.gunaLabel7.Text = "Thương hiệu";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BaseColor = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(166, 367);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Radius = 10;
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(363, 37);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(835, 138);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel6.TabIndex = 6;
            this.gunaLabel6.Text = "Mô tả";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(835, 100);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = "Số lượng";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(835, 62);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(37, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Loại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(347, 100);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Tên giày";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(347, 212);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Giá bán";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(347, 62);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Mã giày";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.lvMatHang);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.LightPink;
            this.gunaGroupBox2.Location = new System.Drawing.Point(3, 414);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(1572, 405);
            this.gunaGroupBox2.TabIndex = 4;
            this.gunaGroupBox2.Text = "Thông tin mặt hàng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(400, 2);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.tbQuantity);
            this.gunaGroupBox1.Controls.Add(this.tbGiaBan);
            this.gunaGroupBox1.Controls.Add(this.tbGiaNhap);
            this.gunaGroupBox1.Controls.Add(this.btnUpdate);
            this.gunaGroupBox1.Controls.Add(this.btnSave);
            this.gunaGroupBox1.Controls.Add(this.btnReset);
            this.gunaGroupBox1.Controls.Add(this.btnPicture);
            this.gunaGroupBox1.Controls.Add(this.btnAddType);
            this.gunaGroupBox1.Controls.Add(this.cbbType);
            this.gunaGroupBox1.Controls.Add(this.tbThuongHieu);
            this.gunaGroupBox1.Controls.Add(this.tbNotes);
            this.gunaGroupBox1.Controls.Add(this.tbName);
            this.gunaGroupBox1.Controls.Add(this.tbID);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.pbPicture);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.LightPink;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 2);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1572, 354);
            this.gunaGroupBox1.TabIndex = 3;
            this.gunaGroupBox1.Text = "Quản lý mặt hàng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(385, 2);
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.tbQuantity.BaseColor = System.Drawing.Color.White;
            this.tbQuantity.BorderColor = System.Drawing.Color.LightPink;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.tbQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbQuantity.Location = new System.Drawing.Point(913, 96);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.Radius = 10;
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(313, 37);
            this.tbQuantity.TabIndex = 25;
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.tbGiaBan.BaseColor = System.Drawing.Color.White;
            this.tbGiaBan.BorderColor = System.Drawing.Color.LightPink;
            this.tbGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGiaBan.FocusedBaseColor = System.Drawing.Color.White;
            this.tbGiaBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbGiaBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGiaBan.Location = new System.Drawing.Point(459, 203);
            this.tbGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.PasswordChar = '\0';
            this.tbGiaBan.Radius = 10;
            this.tbGiaBan.SelectedText = "";
            this.tbGiaBan.Size = new System.Drawing.Size(247, 37);
            this.tbGiaBan.TabIndex = 24;
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.tbGiaNhap.BaseColor = System.Drawing.Color.White;
            this.tbGiaNhap.BorderColor = System.Drawing.Color.LightPink;
            this.tbGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGiaNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.tbGiaNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbGiaNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGiaNhap.Location = new System.Drawing.Point(459, 167);
            this.tbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.PasswordChar = '\0';
            this.tbGiaNhap.Radius = 10;
            this.tbGiaNhap.SelectedText = "";
            this.tbGiaNhap.Size = new System.Drawing.Size(247, 37);
            this.tbGiaNhap.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::ShoesSalesManagement.Properties.Resources.update;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(1079, 306);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(148, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::ShoesSalesManagement.Properties.Resources.Add;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(913, 306);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(128, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.Gray;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::ShoesSalesManagement.Properties.Resources.arrows;
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(351, 306);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 10;
            this.btnReset.Size = new System.Drawing.Size(160, 42);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Mặc định";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.AnimationHoverSpeed = 0.07F;
            this.btnPicture.AnimationSpeed = 0.03F;
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPicture.BorderColor = System.Drawing.Color.Black;
            this.btnPicture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPicture.FocusedColor = System.Drawing.Color.Empty;
            this.btnPicture.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.ForeColor = System.Drawing.Color.White;
            this.btnPicture.Image = global::ShoesSalesManagement.Properties.Resources.image;
            this.btnPicture.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPicture.Location = new System.Drawing.Point(93, 306);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPicture.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPicture.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPicture.OnHoverImage = null;
            this.btnPicture.OnPressedColor = System.Drawing.Color.Black;
            this.btnPicture.Radius = 10;
            this.btnPicture.Size = new System.Drawing.Size(160, 42);
            this.btnPicture.TabIndex = 3;
            this.btnPicture.Text = "Chọn hình";
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.Color.Transparent;
            this.cbbType.BaseColor = System.Drawing.Color.White;
            this.cbbType.BorderColor = System.Drawing.Color.LightPink;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FocusedColor = System.Drawing.Color.Empty;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbType.ForeColor = System.Drawing.Color.Black;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(913, 57);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbType.Name = "cbbType";
            this.cbbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbType.Radius = 10;
            this.cbbType.Size = new System.Drawing.Size(201, 31);
            this.cbbType.TabIndex = 14;
            // 
            // pbPicture
            // 
            this.pbPicture.BaseColor = System.Drawing.Color.White;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicture.Location = new System.Drawing.Point(49, 57);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(244, 244);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(48, 373);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel9.TabIndex = 6;
            this.gunaLabel9.Text = "Tìm kiếm:";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(626, 373);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel10.TabIndex = 7;
            this.gunaLabel10.Text = "Phân loại:";
            // 
            // cbbPhanLoai
            // 
            this.cbbPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbbPhanLoai.BaseColor = System.Drawing.Color.White;
            this.cbbPhanLoai.BorderColor = System.Drawing.Color.Silver;
            this.cbbPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhanLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPhanLoai.ForeColor = System.Drawing.Color.Black;
            this.cbbPhanLoai.FormattingEnabled = true;
            this.cbbPhanLoai.Location = new System.Drawing.Point(746, 373);
            this.cbbPhanLoai.Name = "cbbPhanLoai";
            this.cbbPhanLoai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbPhanLoai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbPhanLoai.Radius = 10;
            this.cbbPhanLoai.Size = new System.Drawing.Size(214, 31);
            this.cbbPhanLoai.TabIndex = 8;
            this.cbbPhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbbPhanLoai_SelectedIndexChanged);
            // 
            // FormQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 866);
            this.Controls.Add(this.cbbPhanLoai);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLyMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mặt hàng";
            this.Load += new System.EventHandler(this.FormQuanLyMatHang_Load);
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvMatHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnPicture;
        private Guna.UI.WinForms.GunaButton btnAddType;
        private Guna.UI.WinForms.GunaTextBox tbThuongHieu;
        private Guna.UI.WinForms.GunaTextBox tbNotes;
        private Guna.UI.WinForms.GunaTextBox tbName;
        private Guna.UI.WinForms.GunaTextBox tbID;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox tbSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox pbPicture;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox tbQuantity;
        private Guna.UI.WinForms.GunaTextBox tbGiaBan;
        private Guna.UI.WinForms.GunaTextBox tbGiaNhap;
        private Guna.UI.WinForms.GunaComboBox cbbType;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaComboBox cbbPhanLoai;
    }
}