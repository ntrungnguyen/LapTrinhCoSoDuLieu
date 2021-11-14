
namespace Lab7_Advanced_Command
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
            this.components = new System.ComponentModel.Container();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoodList.Location = new System.Drawing.Point(2, 80);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.Size = new System.Drawing.Size(798, 377);
            this.dgvFoodList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalculateQuantity,
            this.tsmiSeperator,
            this.tsmiAddFood,
            this.tsmiUpdateFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 92);
            // 
            // tsmiCalculateQuantity
            // 
            this.tsmiCalculateQuantity.Name = "tsmiCalculateQuantity";
            this.tsmiCalculateQuantity.Size = new System.Drawing.Size(185, 22);
            this.tsmiCalculateQuantity.Text = "Tính số lượng đã bán";
            this.tsmiCalculateQuantity.Click += new System.EventHandler(this.tsmiCalculateQuantity_Click);
            // 
            // tsmiSeperator
            // 
            this.tsmiSeperator.Name = "tsmiSeperator";
            this.tsmiSeperator.Size = new System.Drawing.Size(185, 22);
            this.tsmiSeperator.Text = "Seperator";
            // 
            // tsmiAddFood
            // 
            this.tsmiAddFood.Name = "tsmiAddFood";
            this.tsmiAddFood.Size = new System.Drawing.Size(185, 22);
            this.tsmiAddFood.Text = "Thêm món ăn";
            this.tsmiAddFood.Click += new System.EventHandler(this.tsmiAddFood_Click);
            // 
            // tsmiUpdateFood
            // 
            this.tsmiUpdateFood.Name = "tsmiUpdateFood";
            this.tsmiUpdateFood.Size = new System.Drawing.Size(185, 22);
            this.tsmiUpdateFood.Text = "Cập nhật món ăn";
            this.tsmiUpdateFood.Click += new System.EventHandler(this.tsmiUpdateFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nhóm món ăn:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(147, 51);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(245, 21);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Có tất cả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Món ăn thuộc nhóm:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(98, 481);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "...";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(283, 481);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 13);
            this.lblCatName.TabIndex = 5;
            this.lblCatName.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm theo tên:";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(565, 51);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(160, 20);
            this.txtSearchByName.TabIndex = 7;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrder,
            this.tsmiAccount});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(180, 22);
            this.tsmiOrder.Text = "Hóa đơn";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiAccount
            // 
            this.tsmiAccount.Name = "tsmiAccount";
            this.tsmiAccount.Size = new System.Drawing.Size(180, 22);
            this.tsmiAccount.Text = "Tài khoản";
            this.tsmiAccount.Click += new System.EventHandler(this.tsmiAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFoodList);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmiSeperator;
		private System.Windows.Forms.ToolStripMenuItem tsmiAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmiUpdateFood;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
    }
}

