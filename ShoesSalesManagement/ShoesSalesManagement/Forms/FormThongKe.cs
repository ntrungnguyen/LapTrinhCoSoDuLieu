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
    public partial class FormThongKe : Form
    {
        List<HoaDon> dsHoaDon  = new List<HoaDon>();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void loadKhachHang()
        {
            HoaDonBL hoaDonBL = new HoaDonBL();
            dsHoaDon = hoaDonBL.GetAll();

            int count = 1;
            lvThongTin.Items.Clear();

            foreach (var item in dsHoaDon)
            {
                ListViewItem list = lvThongTin.Items.Add(count.ToString());
                list.SubItems.Add(item.TenKhachHang);
                list.SubItems.Add(item.SoDienThoai);
                count++;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            List<HoaDon> dsHoaDon = new List<HoaDon>();
            lvThongTin.Items.Clear();

            HoaDonBL hoaDonBL = new HoaDonBL();
            dsHoaDon = hoaDonBL.Search(tbSearch.Text);

            foreach (HoaDon hoaDon in dsHoaDon)
            {
                ListViewItem item = new ListViewItem(hoaDon.ID.ToString());
                item.SubItems.Add(hoaDon.TenKhachHang);
                item.SubItems.Add(hoaDon.SoDienThoai);

                lvThongTin.Items.Add(item);
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadKhachHang();
        }

        

        private void lvThongTin_DoubleClick(object sender, EventArgs e)
        {
            FormChiTietHoaDon formChiTietHoa = new FormChiTietHoaDon();
            formChiTietHoa.ShowDialog();

            string IDHoaDon = lvThongTin.SelectedItems[0].ToString();
            formChiTietHoa.loadBillsDetails(IDHoaDon);
        }
    }
}
