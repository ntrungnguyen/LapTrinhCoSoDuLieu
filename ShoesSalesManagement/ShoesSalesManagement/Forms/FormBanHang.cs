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
    public partial class FormBanHang : Form
    {
        List<NguoiDung> dsNguoiDung;
        List<LoaiHang> dsLoaiHang = new List<LoaiHang>();
        List<MatHang> dsMatHang = new List<MatHang>();
        public FormBanHang()
        {
            InitializeComponent();
        }

        
        //-----------------------------//
        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == -1)
                return;
            
        }


        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadNguoiDung();
            LoadType();
            LoadMatHang();
        }

        private void LoadType()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();
            dsLoaiHang = loaiHangBL.GetIDCon();

            cbbType.DataSource = dsLoaiHang;
            cbbType.DisplayMember = "TenLoai";
            cbbType.ValueMember = "ID";

        }

        private void LoadNguoiDung()
        {
            NguoiDungBL nguoiDungBL = new NguoiDungBL();
            dsNguoiDung = nguoiDungBL.GetAll();

            cbbNhanVien.DataSource = dsNguoiDung;
            cbbNhanVien.DisplayMember = "TenNhanVien";
            cbbNhanVien.ValueMember = "ID";
        }

        private void LoadMatHang()
        {
            MatHangBL matHangBL = new MatHangBL();
            dsMatHang = matHangBL.GetAll();

            int count = 1;
            lvMatHang.Items.Clear();

            foreach (var giay in dsMatHang)
            {
                ListViewItem item = lvMatHang.Items.Add(count.ToString());

                item.SubItems.Add(giay.TenMatHang);
                item.SubItems.Add(giay.ID_Loai.ToString());
                item.SubItems.Add(giay.GiaBan.ToString());
                count++;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            List<MatHang> dsMatHang = new List<MatHang>();
            lvMatHang.Items.Clear();
            MatHangBL matHangBL = new MatHangBL();
            dsMatHang = matHangBL.Search(tbSearch.Text);
            foreach (MatHang mathang in dsMatHang)
            {

                ListViewItem item = new ListViewItem(mathang.ID.ToString());
                
                item.SubItems.Add(mathang.TenMatHang);
                item.SubItems.Add(mathang.ID_Loai.ToString());
                item.SubItems.Add(mathang.GiaBan.ToString());
                //item.SubItems.Add(mathang.ThuongHieu);

                lvMatHang.Items.Add(item);
            }
        }

        private void lvMatHang_DoubleClick(object sender, EventArgs e)
        {
            int i = lvMatHang.SelectedItems.Count-1;
            while (i > 0)
            {
                lvDonHang.Items.Add(lvMatHang.SelectedItems[i]);
                
            }
        }
    }
}
