using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public void loadBillsDetails(string IDHoaDon)
        {
            ChiTietHoaDonBL chiTietHoaDonBL = new ChiTietHoaDonBL();
            listChiTietHoaDon = chiTietHoaDonBL.GetAll();
            dgvBillsDetails.DataSource = listChiTietHoaDon;
        }

        public void loadBillsDetails()
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
