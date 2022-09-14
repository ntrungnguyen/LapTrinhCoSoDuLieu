
namespace Demo_1_9_2021.Components
{
    partial class NewsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublisherDate = new System.Windows.Forms.Label();
            this.lBlDetails = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblPublisherDate
            // 
            this.lblPublisherDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherDate.AutoEllipsis = true;
            this.lblPublisherDate.AutoSize = true;
            this.lblPublisherDate.Location = new System.Drawing.Point(19, 161);
            this.lblPublisherDate.Name = "lblPublisherDate";
            this.lblPublisherDate.Size = new System.Drawing.Size(50, 20);
            this.lblPublisherDate.TabIndex = 2;
            this.lblPublisherDate.Text = "label3";
            // 
            // lBlDetails
            // 
            this.lBlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lBlDetails.AutoEllipsis = true;
            this.lBlDetails.AutoSize = true;
            this.lBlDetails.Location = new System.Drawing.Point(620, 161);
            this.lBlDetails.Name = "lBlDetails";
            this.lBlDetails.Size = new System.Drawing.Size(88, 20);
            this.lBlDetails.TabIndex = 3;
            this.lBlDetails.TabStop = true;
            this.lBlDetails.Text = "Xem chi tiết";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(19, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(737, 106);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "label2";
            // 
            // NewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lBlDetails);
            this.Controls.Add(this.lblPublisherDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "NewsControl";
            this.Size = new System.Drawing.Size(776, 227);
            this.Load += new System.EventHandler(this.NewsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPublisherDate;
        private System.Windows.Forms.LinkLabel lBlDetails;
        private System.Windows.Forms.Label lblDescription;
    }
}
