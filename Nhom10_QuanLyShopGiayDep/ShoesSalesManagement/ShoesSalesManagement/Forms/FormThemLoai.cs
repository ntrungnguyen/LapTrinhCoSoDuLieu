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
    public partial class FormThemLoai : Form
    {
        LoaiHang typeCurrent = new LoaiHang();
        List<LoaiHang> dsLoaiHang = new List<LoaiHang>();
        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Insert = InsertType();

            if (Insert > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");

                LoadTypeToLV();              
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        public int InsertType()
        {
            LoaiHang loai = new LoaiHang();
            loai.ID = 0;

            if (tbNameType.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                LoadTypeToLV();
            }
            else
            {
                loai.TenLoai = tbNameType.Text;
                loai.ID_Cha = int.Parse(cbbIDCha.SelectedValue.ToString());
                loai.MoTa = tbNotes.Text;

                LoaiHangBL loaiHangBL = new LoaiHangBL();
                return loaiHangBL.Insert(loai);
            }

            return -1;
        }

        

        public void LoadTypeToLV()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            dsLoaiHang = loaiHangBL.GetAll();
            int count = 1;

            lvType.Items.Clear();
            foreach (var loai in dsLoaiHang)
            {
                ListViewItem item = lvType.Items.Add(count.ToString());

                item.SubItems.Add(loai.TenLoai);
                item.SubItems.Add(loai.ID_Cha.ToString());
                item.SubItems.Add(loai.MoTa);

                count++;
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadType()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            dsLoaiHang = loaiHangBL.GetAll();
            cbbIDCha.DataSource = dsLoaiHang;
            cbbIDCha.ValueMember = "ID";
            cbbIDCha.DisplayMember = "ID_Cha";
        }

        private void FormThemLoai_Load(object sender, EventArgs e)
        {
            LoadType();
            LoadTypeToLV();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa đồ chơi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoaiHangBL loaiHangBL = new LoaiHangBL();
                if (loaiHangBL.Delete(typeCurrent) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadTypeToLV();
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại", "Lỗi");
                }
            }
        }



        private void lvType_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            for (int i = 0; i < lvType.Items.Count; i++)
            {
                if (lvType.Items[i].Selected)
                {
                    typeCurrent = dsLoaiHang[i];
                    tbID.Text = typeCurrent.ID.ToString();
                    tbNameType.Text = typeCurrent.TenLoai;
                    cbbIDCha.Text = typeCurrent.ID_Cha.ToString();
                    tbNotes.Text = typeCurrent.MoTa;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            int Update = UpdateType();

            if (Update > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadTypeToLV();
                Reset();

                FormQuanLyMatHang formQuanLyMatHang = new FormQuanLyMatHang();
                formQuanLyMatHang.LoadType();
                formQuanLyMatHang.loadtypePL();
            }
           
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void Reset()
        {
            tbID.Text = "";
            tbNameType.Text = "";
            tbNotes.Text = "";
            cbbIDCha.Text = "";
        }
        public int UpdateType()
        {
            LoaiHang loai = typeCurrent;
            if (tbNameType.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                LoadTypeToLV();
            }
            else
            {
                loai.TenLoai = tbNameType.Text;
                loai.ID_Cha = int.Parse(cbbIDCha.SelectedValue.ToString());
                loai.MoTa = tbNotes.Text;

                LoaiHangBL loaiHangBL = new LoaiHangBL();
                return loaiHangBL.Update(loai);
            }

            return -1;
        }
    }
}
