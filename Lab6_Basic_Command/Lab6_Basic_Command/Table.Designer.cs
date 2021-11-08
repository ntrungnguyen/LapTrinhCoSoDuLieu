
namespace Lab6_Basic_Command
{
	partial class Table
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
			this.components = new System.ComponentModel.Container();
			this.dgvTable = new System.Windows.Forms.DataGridView();
			this.ctmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhMụcHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhậtKýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddtable = new System.Windows.Forms.Button();
			this.btnUpdateTable = new System.Windows.Forms.Button();
			this.btnDeleteTable = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbTableName = new System.Windows.Forms.TextBox();
			this.tbCapacity = new System.Windows.Forms.TextBox();
			this.cbbStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
			this.ctmsTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTable
			// 
			this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTable.ContextMenuStrip = this.ctmsTable;
			this.dgvTable.Location = new System.Drawing.Point(3, 89);
			this.dgvTable.Name = "dgvTable";
			this.dgvTable.Size = new System.Drawing.Size(429, 342);
			this.dgvTable.TabIndex = 0;
			this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
			this.dgvTable.Click += new System.EventHandler(this.dgvTable_Click);
			// 
			// ctmsTable
			// 
			this.ctmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteTable,
            this.xemDanhMụcHóaĐơnToolStripMenuItem,
            this.xemNhậtKýHóaĐơnToolStripMenuItem});
			this.ctmsTable.Name = "ctmsTable";
			this.ctmsTable.Size = new System.Drawing.Size(203, 92);
			// 
			// tsmiDeleteTable
			// 
			this.tsmiDeleteTable.Name = "tsmiDeleteTable";
			this.tsmiDeleteTable.Size = new System.Drawing.Size(202, 22);
			this.tsmiDeleteTable.Text = "Xóa bàn";
			this.tsmiDeleteTable.Click += new System.EventHandler(this.tsmiDeleteTable_Click);
			// 
			// xemDanhMụcHóaĐơnToolStripMenuItem
			// 
			this.xemDanhMụcHóaĐơnToolStripMenuItem.Name = "xemDanhMụcHóaĐơnToolStripMenuItem";
			this.xemDanhMụcHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xemDanhMụcHóaĐơnToolStripMenuItem.Text = "Xem danh mục hóa đơn";
			// 
			// xemNhậtKýHóaĐơnToolStripMenuItem
			// 
			this.xemNhậtKýHóaĐơnToolStripMenuItem.Name = "xemNhậtKýHóaĐơnToolStripMenuItem";
			this.xemNhậtKýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xemNhậtKýHóaĐơnToolStripMenuItem.Text = "Xem nhật ký hóa đơn";
			// 
			// btnAddtable
			// 
			this.btnAddtable.Location = new System.Drawing.Point(241, 4);
			this.btnAddtable.Name = "btnAddtable";
			this.btnAddtable.Size = new System.Drawing.Size(75, 23);
			this.btnAddtable.TabIndex = 2;
			this.btnAddtable.Text = "Thêm bàn";
			this.btnAddtable.UseVisualStyleBackColor = true;
			this.btnAddtable.Click += new System.EventHandler(this.btnAddtable_Click);
			// 
			// btnUpdateTable
			// 
			this.btnUpdateTable.Location = new System.Drawing.Point(241, 33);
			this.btnUpdateTable.Name = "btnUpdateTable";
			this.btnUpdateTable.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateTable.TabIndex = 3;
			this.btnUpdateTable.Text = "Cập nhật";
			this.btnUpdateTable.UseVisualStyleBackColor = true;
			this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
			// 
			// btnDeleteTable
			// 
			this.btnDeleteTable.Location = new System.Drawing.Point(241, 60);
			this.btnDeleteTable.Name = "btnDeleteTable";
			this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTable.TabIndex = 4;
			this.btnDeleteTable.Text = "Xóa bàn";
			this.btnDeleteTable.UseVisualStyleBackColor = true;
			this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tên bàn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Trạng thái";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Sức chứa";
			// 
			// tbTableName
			// 
			this.tbTableName.Location = new System.Drawing.Point(91, 6);
			this.tbTableName.Name = "tbTableName";
			this.tbTableName.Size = new System.Drawing.Size(121, 20);
			this.tbTableName.TabIndex = 6;
			// 
			// tbCapacity
			// 
			this.tbCapacity.Location = new System.Drawing.Point(91, 62);
			this.tbCapacity.Name = "tbCapacity";
			this.tbCapacity.Size = new System.Drawing.Size(121, 20);
			this.tbCapacity.TabIndex = 7;
			// 
			// cbbStatus
			// 
			this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbStatus.FormattingEnabled = true;
			this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
			this.cbbStatus.Location = new System.Drawing.Point(91, 35);
			this.cbbStatus.Name = "cbbStatus";
			this.cbbStatus.Size = new System.Drawing.Size(121, 21);
			this.cbbStatus.TabIndex = 8;
			// 
			// Table
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 435);
			this.Controls.Add(this.cbbStatus);
			this.Controls.Add(this.tbCapacity);
			this.Controls.Add(this.tbTableName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteTable);
			this.Controls.Add(this.btnUpdateTable);
			this.Controls.Add(this.btnAddtable);
			this.Controls.Add(this.dgvTable);
			this.Name = "Table";
			this.Text = "Table";
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.ctmsTable.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTable;
		private System.Windows.Forms.ContextMenuStrip ctmsTable;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeleteTable;
		private System.Windows.Forms.ToolStripMenuItem xemDanhMụcHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.Button btnAddtable;
		private System.Windows.Forms.Button btnUpdateTable;
		private System.Windows.Forms.Button btnDeleteTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbTableName;
		private System.Windows.Forms.TextBox tbCapacity;
		private System.Windows.Forms.ComboBox cbbStatus;
	}
}