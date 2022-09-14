
namespace MaskedTextBox
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
			this.lb1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.tB1 = new System.Windows.Forms.TextBox();
			this.tB2 = new System.Windows.Forms.TextBox();
			this.bt1 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.lb3 = new System.Windows.Forms.Label();
			this.tB3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lb1
			// 
			this.lb1.AutoSize = true;
			this.lb1.Location = new System.Drawing.Point(25, 43);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(38, 17);
			this.lb1.TabIndex = 0;
			this.lb1.Text = "User";
			// 
			// lb2
			// 
			this.lb2.AutoSize = true;
			this.lb2.Location = new System.Drawing.Point(25, 89);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(69, 17);
			this.lb2.TabIndex = 1;
			this.lb2.Text = "Password";
			// 
			// tB1
			// 
			this.tB1.Location = new System.Drawing.Point(109, 38);
			this.tB1.Name = "tB1";
			this.tB1.Size = new System.Drawing.Size(127, 22);
			this.tB1.TabIndex = 2;
			// 
			// tB2
			// 
			this.tB2.Location = new System.Drawing.Point(109, 86);
			this.tB2.Name = "tB2";
			this.tB2.Size = new System.Drawing.Size(127, 22);
			this.tB2.TabIndex = 3;
			this.tB2.UseSystemPasswordChar = true;
			// 
			// bt1
			// 
			this.bt1.Location = new System.Drawing.Point(63, 231);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(75, 23);
			this.bt1.TabIndex = 4;
			this.bt1.Text = "OK";
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.bt1_Click);
			// 
			// bt2
			// 
			this.bt2.Location = new System.Drawing.Point(165, 231);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(75, 23);
			this.bt2.TabIndex = 5;
			this.bt2.Text = "Cancel";
			this.bt2.UseVisualStyleBackColor = true;
			this.bt2.Click += new System.EventHandler(this.bt2_Click);
			// 
			// lb3
			// 
			this.lb3.AutoSize = true;
			this.lb3.Location = new System.Drawing.Point(25, 136);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(79, 17);
			this.lb3.TabIndex = 6;
			this.lb3.Text = "Description";
			// 
			// tB3
			// 
			this.tB3.Location = new System.Drawing.Point(28, 169);
			this.tB3.Name = "tB3";
			this.tB3.Size = new System.Drawing.Size(235, 22);
			this.tB3.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 269);
			this.Controls.Add(this.tB3);
			this.Controls.Add(this.lb3);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.tB2);
			this.Controls.Add(this.tB1);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.TextBox tB1;
		private System.Windows.Forms.TextBox tB2;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.TextBox tB3;
	}
}

