using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_demo
{
    public partial class frmTuyChon : Form
    {
        public List<SinhVien> dsSV;
        int i;
        public frmTuyChon(QuanLySinhVien qlsv, int num)
        {
            dsSV = qlsv.DanhSach;
            i = num;
            InitializeComponent();
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            if (i == 0)
            {
                gbSearch.Enabled = false;
            }
            else
            {
                btnSapXep.Enabled = false;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rdMaSV.Checked == true)
            {
                dsSV = dsSV.OrderBy(x => x.MaSo).ToList();
                Close();
            }
            if (rdHoTen.Checked == true)
            {
                dsSV = dsSV.OrderBy(x => x.HoTen).ToList();
                Close();
            }
            if (rdNgaySinh.Checked == true)
            {
                dsSV = dsSV.OrderBy(x => x.NgaySinh).ToList();
                Close();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;

           if (string.IsNullOrEmpty(search))
			{
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
           else
			{
                if (rdMaSV.Checked == true)
                {
                    SinhVien kq = dsSV.Find(x => x.MaSo.Trim() == search.Trim());
                    if (kq == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin!" + kq, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Số sinh viên tìm thấy: " + kq);                        
                    }
                }

                if (rdHoTen.Checked == true)
                {
                    SinhVien kq = dsSV.Find(x => x.HoTen.ToLower().Trim() == search.ToLower().Trim());
                    if (kq == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin!" + kq, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Số sinh viên tìm thấy: " + kq);
                    }
                }
            }
        }

		
	}
}