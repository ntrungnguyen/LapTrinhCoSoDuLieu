using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TimKiem : Form
    {
        public List<SinhVien> dssv;
        public SinhVien sv;

        public TimKiem()
        {
        }

        public TimKiem(QuanLySinhVien qlsv)
        {
            dssv = qlsv.list;
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var timkiem = txtNhap.Text;

            if (rdnID.Checked == true)
            {
                SinhVien kq = dssv.Find(x => x.Id == timkiem.Trim());
                if(kq == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã là" + timkiem, "Lỗi");
                }
                else
                {
                    FormNhapSV form = new FormNhapSV();
                }
            }
        }
    }
}
