namespace ShoesSalesManagement.Forms
{
    partial class FormThemLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLoai));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tbID = new Guna.UI.WinForms.GunaTextBox();
            this.tbNameType = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tbNotes = new Guna.UI.WinForms.GunaTextBox();
            this.cbbIDCha = new Guna.UI.WinForms.GunaComboBox();
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(29, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(27, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "ID:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(29, 77);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 20);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Tên loại:";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.Transparent;
            this.tbID.BaseColor = System.Drawing.Color.White;
            this.tbID.BorderColor = System.Drawing.Color.Silver;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.FocusedBaseColor = System.Drawing.Color.White;
            this.tbID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbID.Location = new System.Drawing.Point(126, 24);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.Radius = 10;
            this.tbID.ReadOnly = true;
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(141, 32);
            this.tbID.TabIndex = 2;
            // 
            // tbNameType
            // 
            this.tbNameType.BackColor = System.Drawing.Color.Transparent;
            this.tbNameType.BaseColor = System.Drawing.Color.White;
            this.tbNameType.BorderColor = System.Drawing.Color.Silver;
            this.tbNameType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameType.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNameType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbNameType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNameType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNameType.Location = new System.Drawing.Point(126, 65);
            this.tbNameType.Name = "tbNameType";
            this.tbNameType.PasswordChar = '\0';
            this.tbNameType.Radius = 10;
            this.tbNameType.SelectedText = "";
            this.tbNameType.Size = new System.Drawing.Size(225, 32);
            this.tbNameType.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(29, 114);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(56, 20);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "ID Cha:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(29, 152);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(51, 20);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Mô tả:";
            // 
            // tbNotes
            // 
            this.tbNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbNotes.BaseColor = System.Drawing.Color.White;
            this.tbNotes.BorderColor = System.Drawing.Color.Silver;
            this.tbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNotes.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbNotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNotes.Location = new System.Drawing.Point(126, 141);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PasswordChar = '\0';
            this.tbNotes.Radius = 10;
            this.tbNotes.SelectedText = "";
            this.tbNotes.Size = new System.Drawing.Size(225, 89);
            this.tbNotes.TabIndex = 2;
            // 
            // cbbIDCha
            // 
            this.cbbIDCha.BackColor = System.Drawing.Color.Transparent;
            this.cbbIDCha.BaseColor = System.Drawing.Color.White;
            this.cbbIDCha.BorderColor = System.Drawing.Color.Silver;
            this.cbbIDCha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIDCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDCha.FocusedColor = System.Drawing.Color.Empty;
            this.cbbIDCha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbIDCha.ForeColor = System.Drawing.Color.Black;
            this.cbbIDCha.FormattingEnabled = true;
            this.cbbIDCha.Location = new System.Drawing.Point(126, 103);
            this.cbbIDCha.Name = "cbbIDCha";
            this.cbbIDCha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbIDCha.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbIDCha.Radius = 10;
            this.cbbIDCha.Size = new System.Drawing.Size(225, 31);
            this.cbbIDCha.TabIndex = 3;
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvType.FullRowSelect = true;
            this.lvType.GridLines = true;
            this.lvType.HideSelection = false;
            this.lvType.Location = new System.Drawing.Point(407, 24);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(458, 259);
            this.lvType.TabIndex = 4;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên loại";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID cha";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô tả";
            this.columnHeader4.Width = 157;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Red;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(191, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 10;
            this.btnExit.Size = new System.Drawing.Size(160, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(25, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormThemLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(895, 302);
            this.Controls.Add(this.lvType);
            this.Controls.Add(this.cbbIDCha);
            this.Controls.Add(this.tbNameType);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại";
            this.Load += new System.EventHandler(this.FormThemLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaTextBox tbID;
        private Guna.UI.WinForms.GunaTextBox tbNameType;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tbNotes;
        private Guna.UI.WinForms.GunaComboBox cbbIDCha;
        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}