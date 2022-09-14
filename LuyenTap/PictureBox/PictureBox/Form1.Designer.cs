
namespace PictureBox
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
			this.ptbImage = new System.Windows.Forms.PictureBox();
			this.cbbImage = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// ptbImage
			// 
			this.ptbImage.Location = new System.Drawing.Point(177, 39);
			this.ptbImage.Name = "ptbImage";
			this.ptbImage.Size = new System.Drawing.Size(277, 210);
			this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbImage.TabIndex = 0;
			this.ptbImage.TabStop = false;
			// 
			// cbbImage
			// 
			this.cbbImage.FormattingEnabled = true;
			this.cbbImage.Location = new System.Drawing.Point(12, 39);
			this.cbbImage.Name = "cbbImage";
			this.cbbImage.Size = new System.Drawing.Size(121, 24);
			this.cbbImage.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 309);
			this.Controls.Add(this.cbbImage);
			this.Controls.Add(this.ptbImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ptbImage;
		private System.Windows.Forms.ComboBox cbbImage;
	}
}

