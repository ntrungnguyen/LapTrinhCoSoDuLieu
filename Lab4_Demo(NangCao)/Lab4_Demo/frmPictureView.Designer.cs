
namespace Lab4_Demo
{
	partial class frmPictureView
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiArrangecons = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMaximize = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMinimiza = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tstZoomIn = new System.Windows.Forms.ToolStripLabel();
			this.tstZoomout = new System.Windows.Forms.ToolStripLabel();
			this.tstEdit = new System.Windows.Forms.ToolStripLabel();
			this.sttsStatus = new System.Windows.Forms.StatusStrip();
			this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
			this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.layoutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSaveAs,
            this.tsmiExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(141, 26);
			this.tsmiNew.Text = "New";
			this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
			// 
			// tsmiSaveAs
			// 
			this.tsmiSaveAs.Name = "tsmiSaveAs";
			this.tsmiSaveAs.Size = new System.Drawing.Size(141, 26);
			this.tsmiSaveAs.Text = "Save as";
			this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(141, 26);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusStrip,
            this.tsmiToolStrip});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// tsmiStatusStrip
			// 
			this.tsmiStatusStrip.Name = "tsmiStatusStrip";
			this.tsmiStatusStrip.Size = new System.Drawing.Size(224, 26);
			this.tsmiStatusStrip.Text = "StatusStrip";
			this.tsmiStatusStrip.Click += new System.EventHandler(this.tsmiStatusStrip_Click);
			// 
			// tsmiToolStrip
			// 
			this.tsmiToolStrip.Name = "tsmiToolStrip";
			this.tsmiToolStrip.Size = new System.Drawing.Size(224, 26);
			this.tsmiToolStrip.Text = "ToolStrip";
			this.tsmiToolStrip.Click += new System.EventHandler(this.tsmiToolStrip_Click);
			// 
			// layoutToolStripMenuItem
			// 
			this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArrangecons,
            this.tsmiCascade,
            this.tsmiHorizontal,
            this.tsmiVertical,
            this.tsmiMaximize,
            this.tsmiMinimiza});
			this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
			this.layoutToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.layoutToolStripMenuItem.Text = "Layout";
			// 
			// tsmiArrangecons
			// 
			this.tsmiArrangecons.Name = "tsmiArrangecons";
			this.tsmiArrangecons.Size = new System.Drawing.Size(224, 26);
			this.tsmiArrangecons.Text = "Arrangecons";
			this.tsmiArrangecons.Click += new System.EventHandler(this.tsmiArrangecons_Click);
			// 
			// tsmiCascade
			// 
			this.tsmiCascade.Name = "tsmiCascade";
			this.tsmiCascade.Size = new System.Drawing.Size(224, 26);
			this.tsmiCascade.Text = "Cascade";
			this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
			// 
			// tsmiHorizontal
			// 
			this.tsmiHorizontal.Name = "tsmiHorizontal";
			this.tsmiHorizontal.Size = new System.Drawing.Size(224, 26);
			this.tsmiHorizontal.Text = "Arrange Horizontal";
			this.tsmiHorizontal.Click += new System.EventHandler(this.tsmiHorizontal_Click);
			// 
			// tsmiVertical
			// 
			this.tsmiVertical.Name = "tsmiVertical";
			this.tsmiVertical.Size = new System.Drawing.Size(224, 26);
			this.tsmiVertical.Text = "Arrange Vertical";
			this.tsmiVertical.Click += new System.EventHandler(this.tsmiVertical_Click);
			// 
			// tsmiMaximize
			// 
			this.tsmiMaximize.Name = "tsmiMaximize";
			this.tsmiMaximize.Size = new System.Drawing.Size(224, 26);
			this.tsmiMaximize.Text = "Maximize All";
			this.tsmiMaximize.Click += new System.EventHandler(this.tsmiMaximize_Click);
			// 
			// tsmiMinimiza
			// 
			this.tsmiMinimiza.Name = "tsmiMinimiza";
			this.tsmiMinimiza.Size = new System.Drawing.Size(224, 26);
			this.tsmiMinimiza.Text = "Minimiza All";
			this.tsmiMinimiza.Click += new System.EventHandler(this.tsmiMinimiza_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstZoomIn,
            this.tstZoomout,
            this.tstEdit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tstZoomIn
			// 
			this.tstZoomIn.Image = global::Lab4_Demo.Properties.Resources.ZoomIn;
			this.tstZoomIn.Name = "tstZoomIn";
			this.tstZoomIn.Size = new System.Drawing.Size(20, 22);
			this.tstZoomIn.Click += new System.EventHandler(this.tstZoomIn_Click);
			// 
			// tstZoomout
			// 
			this.tstZoomout.Image = global::Lab4_Demo.Properties.Resources.ZoomOut;
			this.tstZoomout.Name = "tstZoomout";
			this.tstZoomout.Size = new System.Drawing.Size(20, 22);
			this.tstZoomout.Click += new System.EventHandler(this.tstZoomout_Click);
			// 
			// tstEdit
			// 
			this.tstEdit.Image = global::Lab4_Demo.Properties.Resources.edit;
			this.tstEdit.Name = "tstEdit";
			this.tstEdit.Size = new System.Drawing.Size(20, 22);
			this.tstEdit.Click += new System.EventHandler(this.tstEdit_Click);
			// 
			// sttsStatus
			// 
			this.sttsStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sttsStatus.Location = new System.Drawing.Point(0, 428);
			this.sttsStatus.Name = "sttsStatus";
			this.sttsStatus.Size = new System.Drawing.Size(800, 22);
			this.sttsStatus.TabIndex = 3;
			this.sttsStatus.Text = "statusStrip1";
			// 
			// openFileDlg
			// 
			this.openFileDlg.FileName = "openFileDialog1";
			// 
			// frmPictureView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.sttsStatus);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmPictureView";
			this.Text = "Picture View";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPictureView_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiToolStrip;
		private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiArrangecons;
		private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
		private System.Windows.Forms.ToolStripMenuItem tsmiHorizontal;
		private System.Windows.Forms.ToolStripMenuItem tsmiVertical;
		private System.Windows.Forms.ToolStripMenuItem tsmiMaximize;
		private System.Windows.Forms.ToolStripMenuItem tsmiMinimiza;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tstZoomIn;
		private System.Windows.Forms.ToolStripLabel tstZoomout;
		private System.Windows.Forms.ToolStripLabel tstEdit;
		private System.Windows.Forms.StatusStrip sttsStatus;
		private System.Windows.Forms.SaveFileDialog saveFileDlg;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
	}
}