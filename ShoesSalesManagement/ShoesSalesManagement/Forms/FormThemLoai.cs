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
        List<LoaiHang> listLoaiHang = new List<LoaiHang>();
        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadtype()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            listLoaiHang = loaiHangBL.GetAll();
            cbbIDCha.DataSource = listLoaiHang;
            cbbIDCha.ValueMember = "ID";
            cbbIDCha.DisplayMember = "ID_Cha";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Insert = InsertType();
            int Update = UpdateType();
            
            if (Insert > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadTypeToLV();
            }
            else if (Update > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
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

        public void LoadTypeToLV()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            listLoaiHang = loaiHangBL.GetAll();
            int count = 1;

            lvType.Items.Clear();
            foreach (var loai in listLoaiHang)
            {
                ListViewItem item = lvType.Items.Add(count.ToString());

                item.SubItems.Add(loai.TenLoai);
                item.SubItems.Add(loai.ID_Cha.ToString());                
                item.SubItems.Add(loai.MoTa);

                count++;
            }
            
        }

        private void FormThemLoai_Load(object sender, EventArgs e)
        {
            loadtype();
            LoadTypeToLV();
        }
    }
}
