
namespace Button_CheckBox_RadioButton
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
			this.btnButton = new System.Windows.Forms.Button();
			this.btnFlat = new System.Windows.Forms.Button();
			this.chkMauChu = new System.Windows.Forms.CheckBox();
			this.chkMauNen = new System.Windows.Forms.CheckBox();
			this.rdFlat = new System.Windows.Forms.RadioButton();
			this.rdPopup = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnButton
			// 
			this.btnButton.Location = new System.Drawing.Point(12, 28);
			this.btnButton.Name = "btnButton";
			this.btnButton.Size = new System.Drawing.Size(75, 23);
			this.btnButton.TabIndex = 0;
			this.btnButton.Text = "Button";
			this.btnButton.UseVisualStyleBackColor = true;
			// 
			// btnFlat
			// 
			this.btnFlat.Location = new System.Drawing.Point(12, 90);
			this.btnFlat.Name = "btnFlat";
			this.btnFlat.Size = new System.Drawing.Size(93, 34);
			this.btnFlat.TabIndex = 1;
			this.btnFlat.Text = "Button Flat";
			this.btnFlat.UseVisualStyleBackColor = true;
			// 
			// chkMauChu
			// 
			this.chkMauChu.AutoSize = true;
			this.chkMauChu.Location = new System.Drawing.Point(126, 28);
			this.chkMauChu.Name = "chkMauChu";
			this.chkMauChu.Size = new System.Drawing.Size(84, 21);
			this.chkMauChu.TabIndex = 2;
			this.chkMauChu.Text = "Màu chữ";
			this.chkMauChu.UseVisualStyleBackColor = true;
			this.chkMauChu.CheckedChanged += new System.EventHandler(this.chkMauChu_CheckedChanged);
			// 
			// chkMauNen
			// 
			this.chkMauNen.AutoSize = true;
			this.chkMauNen.Location = new System.Drawing.Point(126, 55);
			this.chkMauNen.Name = "chkMauNen";
			this.chkMauNen.Size = new System.Drawing.Size(85, 21);
			this.chkMauNen.TabIndex = 3;
			this.chkMauNen.Text = "Màu nền";
			this.chkMauNen.UseVisualStyleBackColor = true;
			this.chkMauNen.CheckedChanged += new System.EventHandler(this.chkMauNen_CheckedChanged);
			// 
			// rdFlat
			// 
			this.rdFlat.AutoSize = true;
			this.rdFlat.Location = new System.Drawing.Point(126, 90);
			this.rdFlat.Name = "rdFlat";
			this.rdFlat.Size = new System.Drawing.Size(84, 21);
			this.rdFlat.TabIndex = 4;
			this.rdFlat.TabStop = true;
			this.rdFlat.Text = "Kiểu Flat";
			this.rdFlat.UseVisualStyleBackColor = true;
			this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
			// 
			// rdPopup
			// 
			this.rdPopup.AutoSize = true;
			this.rdPopup.Location = new System.Drawing.Point(126, 117);
			this.rdPopup.Name = "rdPopup";
			this.rdPopup.Size = new System.Drawing.Size(102, 21);
			this.rdPopup.TabIndex = 5;
			this.rdPopup.TabStop = true;
			this.rdPopup.Text = "Kiểu Popup";
			this.rdPopup.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 152);
			this.Controls.Add(this.rdPopup);
			this.Controls.Add(this.rdFlat);
			this.Controls.Add(this.chkMauNen);
			this.Controls.Add(this.chkMauChu);
			this.Controls.Add(this.btnFlat);
			this.Controls.Add(this.btnButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnButton;
		private System.Windows.Forms.Button btnFlat;
		private System.Windows.Forms.CheckBox chkMauChu;
		private System.Windows.Forms.CheckBox chkMauNen;
		private System.Windows.Forms.RadioButton rdFlat;
		private System.Windows.Forms.RadioButton rdPopup;
	}
}

