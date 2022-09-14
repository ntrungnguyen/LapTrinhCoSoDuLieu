
namespace Demo18_08_2021
{
	partial class InformationFoodForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
			this.cbbGroupFood = new System.Windows.Forms.ComboBox();
			this.txtCodeFoodDrink = new System.Windows.Forms.TextBox();
			this.txtNameFoodDrink = new System.Windows.Forms.TextBox();
			this.txtUnitCalc = new System.Windows.Forms.TextBox();
			this.txtPicture = new System.Windows.Forms.TextBox();
			this.gbFood = new System.Windows.Forms.GroupBox();
			this.ptbPicture = new System.Windows.Forms.PictureBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnChoosePicture = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
			this.gbFood.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(293, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã món Ăn/Uống";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(293, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên món Ăn/Uống";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(293, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đơn vị tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(293, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(293, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Hình ảnh";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(293, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Nhóm món ăn";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(293, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Mô tả";
			// 
			// nudUnitPrice
			// 
			this.nudUnitPrice.Location = new System.Drawing.Point(428, 125);
			this.nudUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudUnitPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudUnitPrice.Name = "nudUnitPrice";
			this.nudUnitPrice.Size = new System.Drawing.Size(311, 22);
			this.nudUnitPrice.TabIndex = 1;
			this.nudUnitPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// cbbGroupFood
			// 
			this.cbbGroupFood.FormattingEnabled = true;
			this.cbbGroupFood.Location = new System.Drawing.Point(428, 178);
			this.cbbGroupFood.Name = "cbbGroupFood";
			this.cbbGroupFood.Size = new System.Drawing.Size(310, 24);
			this.cbbGroupFood.TabIndex = 2;
			// 
			// txtCodeFoodDrink
			// 
			this.txtCodeFoodDrink.Location = new System.Drawing.Point(428, 44);
			this.txtCodeFoodDrink.Name = "txtCodeFoodDrink";
			this.txtCodeFoodDrink.Size = new System.Drawing.Size(311, 22);
			this.txtCodeFoodDrink.TabIndex = 3;
			// 
			// txtNameFoodDrink
			// 
			this.txtNameFoodDrink.Location = new System.Drawing.Point(428, 72);
			this.txtNameFoodDrink.Name = "txtNameFoodDrink";
			this.txtNameFoodDrink.Size = new System.Drawing.Size(311, 22);
			this.txtNameFoodDrink.TabIndex = 3;
			// 
			// txtUnitCalc
			// 
			this.txtUnitCalc.Location = new System.Drawing.Point(428, 99);
			this.txtUnitCalc.Name = "txtUnitCalc";
			this.txtUnitCalc.Size = new System.Drawing.Size(311, 22);
			this.txtUnitCalc.TabIndex = 3;
			// 
			// txtPicture
			// 
			this.txtPicture.Location = new System.Drawing.Point(428, 153);
			this.txtPicture.Name = "txtPicture";
			this.txtPicture.ReadOnly = true;
			this.txtPicture.Size = new System.Drawing.Size(311, 22);
			this.txtPicture.TabIndex = 3;
			// 
			// gbFood
			// 
			this.gbFood.Controls.Add(this.ptbPicture);
			this.gbFood.Location = new System.Drawing.Point(12, 33);
			this.gbFood.Name = "gbFood";
			this.gbFood.Size = new System.Drawing.Size(262, 265);
			this.gbFood.TabIndex = 4;
			this.gbFood.TabStop = false;
			this.gbFood.Text = "Nhóm món ăn";
			// 
			// ptbPicture
			// 
			this.ptbPicture.Location = new System.Drawing.Point(0, 23);
			this.ptbPicture.Name = "ptbPicture";
			this.ptbPicture.Size = new System.Drawing.Size(262, 242);
			this.ptbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbPicture.TabIndex = 0;
			this.ptbPicture.TabStop = false;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(489, 327);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 29);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnChoosePicture
			// 
			this.btnChoosePicture.Location = new System.Drawing.Point(762, 152);
			this.btnChoosePicture.Name = "btnChoosePicture";
			this.btnChoosePicture.Size = new System.Drawing.Size(98, 23);
			this.btnChoosePicture.TabIndex = 6;
			this.btnChoosePicture.Text = "Chọn hình";
			this.btnChoosePicture.UseVisualStyleBackColor = true;
			this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(428, 211);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(311, 110);
			this.txtDescription.TabIndex = 7;
			// 
			// InformationFoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 598);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.btnChoosePicture);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.gbFood);
			this.Controls.Add(this.txtPicture);
			this.Controls.Add(this.txtUnitCalc);
			this.Controls.Add(this.txtNameFoodDrink);
			this.Controls.Add(this.txtCodeFoodDrink);
			this.Controls.Add(this.cbbGroupFood);
			this.Controls.Add(this.nudUnitPrice);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "InformationFoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin món ăn";
			this.Load += new System.EventHandler(this.InformationFoodForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
			this.gbFood.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudUnitPrice;
		private System.Windows.Forms.ComboBox cbbGroupFood;
		private System.Windows.Forms.TextBox txtCodeFoodDrink;
		private System.Windows.Forms.TextBox txtNameFoodDrink;
		private System.Windows.Forms.TextBox txtUnitCalc;
		private System.Windows.Forms.TextBox txtPicture;
		private System.Windows.Forms.GroupBox gbFood;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnChoosePicture;
		private System.Windows.Forms.PictureBox ptbPicture;
		private System.Windows.Forms.TextBox txtDescription;
	}
}