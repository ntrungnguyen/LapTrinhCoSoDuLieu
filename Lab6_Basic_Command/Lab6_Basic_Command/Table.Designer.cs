
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
			this.xóaBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhMụcHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhậtKýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddtable = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnDeleteTable = new System.Windows.Forms.Button();
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
			this.dgvTable.Location = new System.Drawing.Point(3, 41);
			this.dgvTable.Name = "dgvTable";
			this.dgvTable.Size = new System.Drawing.Size(429, 316);
			this.dgvTable.TabIndex = 0;
			// 
			// ctmsTable
			// 
			this.ctmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaBànToolStripMenuItem,
            this.xemDanhMụcHóaĐơnToolStripMenuItem,
            this.xemNhậtKýHóaĐơnToolStripMenuItem});
			this.ctmsTable.Name = "ctmsTable";
			this.ctmsTable.Size = new System.Drawing.Size(203, 70);
			// 
			// xóaBànToolStripMenuItem
			// 
			this.xóaBànToolStripMenuItem.Name = "xóaBànToolStripMenuItem";
			this.xóaBànToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xóaBànToolStripMenuItem.Text = "Xóa bàn";
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
			this.btnAddtable.Location = new System.Drawing.Point(12, 12);
			this.btnAddtable.Name = "btnAddtable";
			this.btnAddtable.Size = new System.Drawing.Size(75, 23);
			this.btnAddtable.TabIndex = 2;
			this.btnAddtable.Text = "Thêm bàn";
			this.btnAddtable.UseVisualStyleBackColor = true;
			this.btnAddtable.Click += new System.EventHandler(this.btnAddtable_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cập nhật";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnDeleteTable
			// 
			this.btnDeleteTable.Location = new System.Drawing.Point(174, 12);
			this.btnDeleteTable.Name = "btnDeleteTable";
			this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTable.TabIndex = 4;
			this.btnDeleteTable.Text = "Xóa bàn";
			this.btnDeleteTable.UseVisualStyleBackColor = true;
			this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
			// 
			// Table
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 361);
			this.Controls.Add(this.btnDeleteTable);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAddtable);
			this.Controls.Add(this.dgvTable);
			this.Name = "Table";
			this.Text = "Table";
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.ctmsTable.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTable;
		private System.Windows.Forms.ContextMenuStrip ctmsTable;
		private System.Windows.Forms.ToolStripMenuItem xóaBànToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemDanhMụcHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.Button btnAddtable;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnDeleteTable;
	}
}