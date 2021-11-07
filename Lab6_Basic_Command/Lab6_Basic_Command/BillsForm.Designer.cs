
namespace Lab6_Basic_Command
{
	partial class BillsForm
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
			this.dgvBills = new System.Windows.Forms.DataGridView();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnViewBills = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBills
			// 
			this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBills.Location = new System.Drawing.Point(1, 68);
			this.dgvBills.Name = "dgvBills";
			this.dgvBills.Size = new System.Drawing.Size(801, 383);
			this.dgvBills.TabIndex = 0;
			this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "dd/MM/yy";
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(51, 12);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(200, 20);
			this.dtpFrom.TabIndex = 1;
			// 
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "dd/MM/yy";
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(291, 12);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(200, 20);
			this.dtpTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "To:";
			// 
			// btnViewBills
			// 
			this.btnViewBills.Location = new System.Drawing.Point(506, 9);
			this.btnViewBills.Name = "btnViewBills";
			this.btnViewBills.Size = new System.Drawing.Size(75, 23);
			this.btnViewBills.TabIndex = 5;
			this.btnViewBills.Text = "Xem";
			this.btnViewBills.UseVisualStyleBackColor = true;
			// 
			// BillsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 450);
			this.Controls.Add(this.btnViewBills);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.dgvBills);
			this.Name = "BillsForm";
			this.Text = "BillsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBills;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnViewBills;
	}
}