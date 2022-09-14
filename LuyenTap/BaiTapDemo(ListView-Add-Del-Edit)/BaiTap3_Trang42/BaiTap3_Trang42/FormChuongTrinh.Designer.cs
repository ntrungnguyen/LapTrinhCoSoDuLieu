
namespace BaiTap3_Trang42
{
    partial class FormChuongTrinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuongTrinh));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.flpFloorOne = new System.Windows.Forms.FlowLayoutPanel();
			this.ttFloor = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flpFloorTwo = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.flpFloorThree = new System.Windows.Forms.FlowLayoutPanel();
			this.lvTableList = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imlTable = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.txtTableId = new System.Windows.Forms.TextBox();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbFloor = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslNumOfCheckedItem = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAcount = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.ctmsListView.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpFloorOne
			// 
			this.flpFloorOne.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorOne.Location = new System.Drawing.Point(3, 23);
			this.flpFloorOne.Name = "flpFloorOne";
			this.flpFloorOne.Size = new System.Drawing.Size(378, 165);
			this.flpFloorOne.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flpFloorOne);
			this.groupBox1.Location = new System.Drawing.Point(16, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 191);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tầng 1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flpFloorTwo);
			this.groupBox2.Location = new System.Drawing.Point(16, 234);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(381, 191);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tầng 2";
			// 
			// flpFloorTwo
			// 
			this.flpFloorTwo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorTwo.Location = new System.Drawing.Point(3, 23);
			this.flpFloorTwo.Name = "flpFloorTwo";
			this.flpFloorTwo.Size = new System.Drawing.Size(375, 165);
			this.flpFloorTwo.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flpFloorThree);
			this.groupBox3.Location = new System.Drawing.Point(16, 447);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(384, 191);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tầng 3";
			// 
			// flpFloorThree
			// 
			this.flpFloorThree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorThree.Location = new System.Drawing.Point(3, 23);
			this.flpFloorThree.Name = "flpFloorThree";
			this.flpFloorThree.Size = new System.Drawing.Size(378, 165);
			this.flpFloorThree.TabIndex = 0;
			// 
			// lvTableList
			// 
			this.lvTableList.BackColor = System.Drawing.Color.LightGray;
			this.lvTableList.CheckBoxes = true;
			this.lvTableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvTableList.ContextMenuStrip = this.ctmsListView;
			this.lvTableList.FullRowSelect = true;
			this.lvTableList.GridLines = true;
			this.lvTableList.HideSelection = false;
			this.lvTableList.LargeImageList = this.imlTable;
			this.lvTableList.Location = new System.Drawing.Point(454, 42);
			this.lvTableList.MultiSelect = false;
			this.lvTableList.Name = "lvTableList";
			this.lvTableList.Size = new System.Drawing.Size(301, 587);
			this.lvTableList.TabIndex = 4;
			this.lvTableList.UseCompatibleStateImageBehavior = false;
			this.lvTableList.View = System.Windows.Forms.View.Details;
			this.lvTableList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTableList_ItemChecked);
			this.lvTableList.SelectedIndexChanged += new System.EventHandler(this.lvTableList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã bàn";
			this.columnHeader1.Width = 65;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên bàn";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Trạng thái";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tầng";
			// 
			// ctmsListView
			// 
			this.ctmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xemDanhSáchHóaĐơnToolStripMenuItem});
			this.ctmsListView.Name = "ctmsListView";
			this.ctmsListView.Size = new System.Drawing.Size(238, 52);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(237, 24);
			this.tsmiDelete.Text = "Xóa tất cả";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// xemDanhSáchHóaĐơnToolStripMenuItem
			// 
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Name = "xemDanhSáchHóaĐơnToolStripMenuItem";
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Text = "Xem danh sách hóa đơn";
			// 
			// imlTable
			// 
			this.imlTable.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTable.ImageStream")));
			this.imlTable.TransparentColor = System.Drawing.Color.Transparent;
			this.imlTable.Images.SetKeyName(0, "BanTrong.png");
			this.imlTable.Images.SetKeyName(1, "BanCoKhach.png");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(801, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã bàn";
			// 
			// txtTableId
			// 
			this.txtTableId.Location = new System.Drawing.Point(877, 45);
			this.txtTableId.Name = "txtTableId";
			this.txtTableId.Size = new System.Drawing.Size(171, 27);
			this.txtTableId.TabIndex = 6;
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(877, 95);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(171, 27);
			this.txtTableName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(801, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên bàn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(801, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Tầng";
			// 
			// cbbFloor
			// 
			this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFloor.FormattingEnabled = true;
			this.cbbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbbFloor.Location = new System.Drawing.Point(877, 148);
			this.cbbFloor.Name = "cbbFloor";
			this.cbbFloor.Size = new System.Drawing.Size(171, 28);
			this.cbbFloor.TabIndex = 10;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(801, 212);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 29);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(1001, 212);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 29);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(901, 212);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(94, 29);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNumOfCheckedItem});
			this.statusStrip1.Location = new System.Drawing.Point(0, 642);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1115, 26);
			this.statusStrip1.TabIndex = 12;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslNumOfCheckedItem
			// 
			this.tsslNumOfCheckedItem.Name = "tsslNumOfCheckedItem";
			this.tsslNumOfCheckedItem.Size = new System.Drawing.Size(151, 20);
			this.tsslNumOfCheckedItem.Text = "toolStripStatusLabel1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiAcount});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1115, 28);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiAdmin
			// 
			this.tsmiAdmin.Name = "tsmiAdmin";
			this.tsmiAdmin.Size = new System.Drawing.Size(73, 24);
			this.tsmiAdmin.Text = "Quản lý";
			this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
			// 
			// tsmiAcount
			// 
			this.tsmiAcount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
			this.tsmiAcount.Name = "tsmiAcount";
			this.tsmiAcount.Size = new System.Drawing.Size(85, 24);
			this.tsmiAcount.Text = "Tài khoản";
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// đổiMậtKhẩuToolStripMenuItem
			// 
			this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
			this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
			// 
			// FormChuongTrinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 668);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbbFloor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTableName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTableId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvTableList);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormChuongTrinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormChuongTrinh";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ctmsListView.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.FlowLayoutPanel flpFloorOne;
		private System.Windows.Forms.ToolTip ttFloor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.FlowLayoutPanel flpFloorTwo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FlowLayoutPanel flpFloorThree;
		private System.Windows.Forms.ListView lvTableList;
		private System.Windows.Forms.ImageList imlTable;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTableId;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbFloor;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ContextMenuStrip ctmsListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslNumOfCheckedItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmiAcount;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
	}
}

