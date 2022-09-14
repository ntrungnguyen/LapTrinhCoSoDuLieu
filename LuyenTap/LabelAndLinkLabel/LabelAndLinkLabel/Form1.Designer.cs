
namespace LabelAndLinkLabel
{
	partial class lnk1
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
			this.lnklb1 = new System.Windows.Forms.LinkLabel();
			this.lnklb2 = new System.Windows.Forms.LinkLabel();
			this.lb1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lnklb1
			// 
			this.lnklb1.AutoSize = true;
			this.lnklb1.Location = new System.Drawing.Point(169, 47);
			this.lnklb1.Name = "lnklb1";
			this.lnklb1.Size = new System.Drawing.Size(119, 17);
			this.lnklb1.TabIndex = 0;
			this.lnklb1.TabStop = true;
			this.lnklb1.Text = "ctk43@gmail.com";
			this.lnklb1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklb1_LinkClicked);
			// 
			// lnklb2
			// 
			this.lnklb2.AutoSize = true;
			this.lnklb2.Location = new System.Drawing.Point(169, 102);
			this.lnklb2.Name = "lnklb2";
			this.lnklb2.Size = new System.Drawing.Size(109, 17);
			this.lnklb2.TabIndex = 1;
			this.lnklb2.TabStop = true;
			this.lnklb2.Text = "www.cnttk43.net";
			this.lnklb2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklb2_LinkClicked);
			// 
			// lb1
			// 
			this.lb1.AutoSize = true;
			this.lb1.ForeColor = System.Drawing.Color.Red;
			this.lb1.Location = new System.Drawing.Point(35, 47);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(97, 17);
			this.lb1.TabIndex = 2;
			this.lb1.Text = "Địa chỉ liên hệ";
			// 
			// lb2
			// 
			this.lb2.AutoSize = true;
			this.lb2.ForeColor = System.Drawing.Color.Red;
			this.lb2.Location = new System.Drawing.Point(35, 102);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(75, 17);
			this.lb2.TabIndex = 3;
			this.lb2.Text = "Trang web";
			// 
			// lnk1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 134);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb1);
			this.Controls.Add(this.lnklb2);
			this.Controls.Add(this.lnklb1);
			this.Name = "lnk1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel lnklb1;
		private System.Windows.Forms.LinkLabel lnklb2;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Label lb2;
	}
}

