
namespace Lab4_Demo
{
	partial class frmPicture
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
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.vScrollBar = new System.Windows.Forms.VScrollBar();
			this.hScrollBar = new System.Windows.Forms.HScrollBar();
			this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiZoomPlus = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiZoomMinus = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.meniStrip1 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbHinh
			// 
			this.pbHinh.Location = new System.Drawing.Point(0, 31);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(770, 362);
			this.pbHinh.TabIndex = 0;
			this.pbHinh.TabStop = false;
			// 
			// vScrollBar
			// 
			this.vScrollBar.Location = new System.Drawing.Point(773, 0);
			this.vScrollBar.Maximum = 1000;
			this.vScrollBar.Name = "vScrollBar";
			this.vScrollBar.Size = new System.Drawing.Size(26, 450);
			this.vScrollBar.TabIndex = 1;
			this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
			// 
			// hScrollBar
			// 
			this.hScrollBar.Location = new System.Drawing.Point(0, 408);
			this.hScrollBar.Maximum = 1000;
			this.hScrollBar.Name = "hScrollBar";
			this.hScrollBar.Size = new System.Drawing.Size(770, 20);
			this.hScrollBar.TabIndex = 2;
			this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
			// 
			// openFileDlg
			// 
			this.openFileDlg.FileName = "openFileDlg";
			// 
			// imageToolStripMenuItem
			// 
			this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReload,
            this.tsmiZoomPlus,
            this.tsmiZoomMinus,
            this.tsmiEdit});
			this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
			this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.imageToolStripMenuItem.Text = "Image";
			// 
			// tsmiReload
			// 
			this.tsmiReload.Name = "tsmiReload";
			this.tsmiReload.Size = new System.Drawing.Size(295, 26);
			this.tsmiReload.Text = "Reload";
			this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
			// 
			// tsmiZoomPlus
			// 
			this.tsmiZoomPlus.Name = "tsmiZoomPlus";
			this.tsmiZoomPlus.Size = new System.Drawing.Size(295, 26);
			this.tsmiZoomPlus.Text = "Zoom +           Ctrl + Alt + Up";
			this.tsmiZoomPlus.Click += new System.EventHandler(this.tsmiZoomPlus_Click);
			// 
			// tsmiZoomMinus
			// 
			this.tsmiZoomMinus.Name = "tsmiZoomMinus";
			this.tsmiZoomMinus.Size = new System.Drawing.Size(295, 26);
			this.tsmiZoomMinus.Text = "Zoom -         Ctrl + Alt + Down";
			this.tsmiZoomMinus.Click += new System.EventHandler(this.tsmiZoomMinus_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(295, 26);
			this.tsmiEdit.Text = "Edit";
			this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "MenuStrip";
			// 
			// meniStrip1
			// 
			this.meniStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.meniStrip1.Location = new System.Drawing.Point(0, 428);
			this.meniStrip1.Name = "meniStrip1";
			this.meniStrip1.Size = new System.Drawing.Size(800, 22);
			this.meniStrip1.TabIndex = 0;
			this.meniStrip1.Text = "statusStrip1";
			// 
			// frmPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.hScrollBar);
			this.Controls.Add(this.vScrollBar);
			this.Controls.Add(this.pbHinh);
			this.Controls.Add(this.meniStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "frmPicture";
			this.Text = "Picture 0";
			this.Load += new System.EventHandler(this.frmPicture_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.VScrollBar vScrollBar;
		private System.Windows.Forms.HScrollBar hScrollBar;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiReload;
		private System.Windows.Forms.ToolStripMenuItem tsmiZoomPlus;
		private System.Windows.Forms.ToolStripMenuItem tsmiZoomMinus;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip meniStrip1;
	}
}

