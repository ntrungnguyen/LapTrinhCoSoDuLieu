using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesSalesManagement.Forms
{
    public partial class FormChiTietHoaDon : Form
    {
        List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadBillsDetails(string IDHoaDon)
        {
            ChiTietHoaDonBL chiTietHoaDonBL = new ChiTietHoaDonBL();
            listChiTietHoaDon = chiTietHoaDonBL.GetAll();
            dgvBillsDetails.DataSource = listChiTietHoaDon;
        }
    }
}
