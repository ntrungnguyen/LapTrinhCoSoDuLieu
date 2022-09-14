
namespace BooleanAlgebra
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblOperation = new System.Windows.Forms.Label();
			this.chkOperand1 = new System.Windows.Forms.CheckBox();
			this.chkOperand2 = new System.Windows.Forms.CheckBox();
			this.chkResult = new System.Windows.Forms.CheckBox();
			this.btnNewOperation = new System.Windows.Forms.Button();
			this.btnCheckOperation = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(200, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 46);
			this.label2.TabIndex = 1;
			this.label2.Text = "B";
			// 
			// lblOperation
			// 
			this.lblOperation.AutoSize = true;
			this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperation.Location = new System.Drawing.Point(324, 32);
			this.lblOperation.Name = "lblOperation";
			this.lblOperation.Size = new System.Drawing.Size(109, 46);
			this.lblOperation.TabIndex = 2;
			this.lblOperation.Text = "A ^ B";
			// 
			// chkOperand1
			// 
			this.chkOperand1.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkOperand1.AutoSize = true;
			this.chkOperand1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkOperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkOperand1.Location = new System.Drawing.Point(12, 90);
			this.chkOperand1.Name = "chkOperand1";
			this.chkOperand1.Size = new System.Drawing.Size(121, 46);
			this.chkOperand1.TabIndex = 3;
			this.chkOperand1.Text = "FALSE";
			this.chkOperand1.UseVisualStyleBackColor = true;
			this.chkOperand1.CheckedChanged += new System.EventHandler(this.chkOperand1_CheckedChanged);
			// 
			// chkOperand2
			// 
			this.chkOperand2.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkOperand2.AutoSize = true;
			this.chkOperand2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkOperand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkOperand2.Location = new System.Drawing.Point(163, 90);
			this.chkOperand2.Name = "chkOperand2";
			this.chkOperand2.Size = new System.Drawing.Size(121, 46);
			this.chkOperand2.TabIndex = 4;
			this.chkOperand2.Text = "FALSE";
			this.chkOperand2.UseVisualStyleBackColor = true;
			this.chkOperand2.CheckedChanged += new System.EventHandler(this.chkOperand2_CheckedChanged);
			// 
			// chkResult
			// 
			this.chkResult.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkResult.AutoSize = true;
			this.chkResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkResult.Location = new System.Drawing.Point(312, 90);
			this.chkResult.Name = "chkResult";
			this.chkResult.Size = new System.Drawing.Size(121, 46);
			this.chkResult.TabIndex = 5;
			this.chkResult.Text = "FALSE";
			this.chkResult.UseVisualStyleBackColor = true;
			this.chkResult.CheckedChanged += new System.EventHandler(this.chkResult_CheckedChanged);
			// 
			// btnNewOperation
			// 
			this.btnNewOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewOperation.Location = new System.Drawing.Point(12, 159);
			this.btnNewOperation.Name = "btnNewOperation";
			this.btnNewOperation.Size = new System.Drawing.Size(241, 43);
			this.btnNewOperation.TabIndex = 6;
			this.btnNewOperation.Text = "New Operation";
			this.btnNewOperation.UseVisualStyleBackColor = true;
			this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
			// 
			// btnCheckOperation
			// 
			this.btnCheckOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckOperation.Location = new System.Drawing.Point(301, 159);
			this.btnCheckOperation.Name = "btnCheckOperation";
			this.btnCheckOperation.Size = new System.Drawing.Size(132, 43);
			this.btnCheckOperation.TabIndex = 7;
			this.btnCheckOperation.Text = "Check";
			this.btnCheckOperation.UseVisualStyleBackColor = true;
			this.btnCheckOperation.Click += new System.EventHandler(this.btnCheckOperation_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(12, 226);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(421, 43);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 297);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCheckOperation);
			this.Controls.Add(this.btnNewOperation);
			this.Controls.Add(this.chkResult);
			this.Controls.Add(this.chkOperand2);
			this.Controls.Add(this.chkOperand1);
			this.Controls.Add(this.lblOperation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "BooleanAlgebra";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblOperation;
		private System.Windows.Forms.CheckBox chkOperand1;
		private System.Windows.Forms.CheckBox chkOperand2;
		private System.Windows.Forms.CheckBox chkResult;
		private System.Windows.Forms.Button btnNewOperation;
		private System.Windows.Forms.Button btnCheckOperation;
		private System.Windows.Forms.Button btnClose;
	}
}

