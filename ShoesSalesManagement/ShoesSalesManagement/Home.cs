using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesSalesManagement
{
    public partial class Home : Form
    {
        private Home activeForm;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
      

        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBanHang(), sender);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormThongKe(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyMatHang(), sender);
        }

    }

    
}
