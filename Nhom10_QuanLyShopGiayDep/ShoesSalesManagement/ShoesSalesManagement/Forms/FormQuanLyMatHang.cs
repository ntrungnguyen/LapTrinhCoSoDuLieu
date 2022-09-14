using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesSalesManagement.Forms
{
    public partial class FormQuanLyMatHang : Form
    {
        string imgLocation = "";
        List<MatHang> dsMatHang = new List<MatHang>();
        MatHang mhCurrent = new MatHang();
        byte[] img = null;
        List<LoaiHang> dsLoai = new List<LoaiHang>();
        public FormQuanLyMatHang()
        {
            InitializeComponent();
        }

        public void LoadType()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            dsLoai = loaiHangBL.GetAll();

            cbbType.DataSource = dsLoai;
            cbbType.ValueMember = "ID";
            cbbType.DisplayMember = "TenLoai";
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
                item.SubItems.Add(giay.SoLuong.ToString());
                item.SubItems.Add(giay.GiaNhap.ToString());
                item.SubItems.Add(giay.GiaBan.ToString());
                item.SubItems.Add(giay.ThuongHieu);
                item.SubItems.Add(giay.MoTa);
                count++;
            }
        }

        private void FormQuanLyMatHang_Load(object sender, EventArgs e)
        {
            LoadType();
            LoadMatHang();
            loadtypePL();
            cbbPhanLoai.SelectedIndex = -1;
        }

        private void tsmiAddItem_Click(object sender, EventArgs e)
        {
            FormThemLoai formThemLoai = new FormThemLoai();
            formThemLoai.ShowDialog();
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
                item.SubItems.Add(mathang.SoLuong.ToString());
                item.SubItems.Add(mathang.GiaNhap.ToString());
                item.SubItems.Add(mathang.GiaBan.ToString());
                item.SubItems.Add(mathang.ThuongHieu);

                lvMatHang.Items.Add(item);
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa đồ chơi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MatHangBL matHangBL = new MatHangBL();
                if (matHangBL.Delete(mhCurrent) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadMatHang();
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại", "Lỗi");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            tbID.Text = "";
            tbName.Text = "";
            tbQuantity.Text = "";
            tbThuongHieu.Text = "";
            tbGiaNhap.Text = "";
            tbGiaBan.Text = "";
            tbNotes.Text = "";
            cbbType.SelectedIndex = -1;
            pbPicture.Image = null;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormThemLoai formThemLoai = new FormThemLoai();
            formThemLoai.ShowDialog();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File Image";
            dlg.FileName = "Hãy chọn File";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                            + ".jpg;.jpeg;*.gif;*.bmp;"
                            + ".tif;.tiff;*.png|"
                            + "JPEG files (.jpg;.jpeg)|*.jpg;*.jpeg|"
                            + "GIF files (.gif)|.gif|"
                            + "BMP files (.bmp)|.bmp|"
                            + "TIFF files (.tif;.tiff)|*.tif;*.tiff|"
                            + "PNG files (.png)|.png|"
                            + "All files (.)|*.*";

            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                pbPicture.ImageLocation = imgLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int insert = InsertMatHang();

            if (insert > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadMatHang();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng kiểm tra lại");
            }
        }

        public int InsertMatHang()
        {
            MatHang matHang = new MatHang();
            matHang.ID = 0;

            if (tbName.Text == "" || tbQuantity.Text == "" || tbThuongHieu.Text == "" || tbGiaNhap.Text == "" ||
                tbGiaBan.Text == "" || cbbType.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
            }
            else
            {
                int giaban = 0;
                try
                {
                    giaban = int.Parse(tbGiaBan.Text);
                }
                catch
                {
                    giaban = 0;
                }

                int gianhap = 0;
                try
                {
                    gianhap = int.Parse(tbGiaNhap.Text);
                }
                catch
                {
                    gianhap = 0;
                }

                int soluong = 0;
                try
                {
                    soluong = int.Parse(tbQuantity.Text);
                }
                catch
                {
                    soluong = 0;
                }

                matHang.TenMatHang = tbName.Text;
                matHang.ID_Loai = int.Parse(cbbType.SelectedValue.ToString());
                matHang.SoLuong = soluong;
                matHang.GiaNhap = gianhap;
                matHang.GiaBan = giaban;
                matHang.ThuongHieu = tbThuongHieu.Text;
                matHang.MoTa = tbNotes.Text;

                if (matHang.HinhAnh == null)
                {
                    FileStream file = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binary = new BinaryReader(file);

                    img = binary.ReadBytes((int)file.Length);
                    matHang.HinhAnh = img;
                }

                MatHangBL matHangBL = new MatHangBL();
                return matHangBL.Insert(matHang);
            }

            return -1;
        }

        private void lvMatHang_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            for (int i = 0; i < lvMatHang.Items.Count; i++)
            {
                if (lvMatHang.Items[i].Selected)
                {
                    mhCurrent = dsMatHang[i];
                    tbID.Text = mhCurrent.ID.ToString();
                    tbName.Text = mhCurrent.TenMatHang;
                    tbQuantity.Text = mhCurrent.SoLuong.ToString();
                    tbThuongHieu.Text = mhCurrent.ThuongHieu;
                    tbGiaNhap.Text = mhCurrent.GiaNhap.ToString();
                    tbGiaBan.Text = mhCurrent.GiaBan.ToString();
                    cbbType.SelectedValue = mhCurrent.ID_Loai;
                    tbNotes.Text = mhCurrent.MoTa;

                    if (mhCurrent.HinhAnh == null)
                    {
                        pbPicture.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(mhCurrent.HinhAnh);
                        pbPicture.Image = Image.FromStream(ms);
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int update = UpdateMatHang();

            if (update > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadMatHang();
            }
            else
            {
                MessageBox.Show("Không có gì để cập nhật");
            }
        }
        public int UpdateMatHang()
        {
            MatHang matHang = mhCurrent;
            if (tbName.Text == "" || tbQuantity.Text == "" || tbThuongHieu.Text == "" || tbGiaNhap.Text == "" ||
                tbGiaBan.Text == "" || cbbType.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đẩy đủ thông tin");
            }
            else
            {
                int giaban = 0;
                try
                {
                    giaban = int.Parse(tbGiaBan.Text);
                }
                catch
                {
                    giaban = 0;
                }

                int gianhap = 0;
                try
                {
                    gianhap = int.Parse(tbGiaNhap.Text);
                }
                catch
                {
                    gianhap = 0;
                }

                int soluong = 0;
                try
                {
                    soluong = int.Parse(tbQuantity.Text);
                }
                catch
                {
                    soluong = 0;
                }

                matHang.TenMatHang = tbName.Text;
                matHang.ID_Loai = int.Parse(cbbType.SelectedValue.ToString());
                matHang.SoLuong = soluong;
                matHang.GiaNhap = gianhap;
                matHang.GiaBan = giaban;
                matHang.ThuongHieu = tbThuongHieu.Text;
                matHang.MoTa = tbNotes.Text;

                if (matHang.HinhAnh != null)
                {
                    matHang.HinhAnh = mhCurrent.HinhAnh;
                }
                else
                {
                    FileStream file = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binary = new BinaryReader(file);

                    img = binary.ReadBytes((int)file.Length);
                    matHang.HinhAnh = img;
                }

                MatHangBL matHangBL = new MatHangBL();
                return matHangBL.Update(matHang);
            }
            return -1;
        }

        private void cbbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhanLoai.SelectedIndex == -1)
                LoadMatHang();
            else
            {
                int ID = 0;
                Int32.TryParse(cbbPhanLoai.SelectedValue.ToString(), out ID);
                if (ID == 0)
                {
                    return;
                }
                else
                {
                    var matHangs = dsMatHang.FindAll(x => x.ID_Loai == ID).ToList();
                    LoadMatHang(matHangs);
                }
            }
        }

        private void LoadMatHang(List<MatHang> matHangs)
        {
            if (dsMatHang == null)
            {
                matHangs = dsMatHang;
            }

            int count = 1;
            lvMatHang.Items.Clear();

            foreach (var giay in matHangs)
            {
                ListViewItem item = lvMatHang.Items.Add(count.ToString());

                item.SubItems.Add(giay.TenMatHang);
                item.SubItems.Add(giay.ID_Loai.ToString());
                item.SubItems.Add(giay.SoLuong.ToString());
                item.SubItems.Add(giay.GiaNhap.ToString());
                item.SubItems.Add(giay.GiaBan.ToString());
                item.SubItems.Add(giay.ThuongHieu);
                item.SubItems.Add(giay.MoTa);
                count++;
            }
        }

        public void loadtypePL()
        {
            LoaiHangBL loaiHangBL = new LoaiHangBL();

            dsLoai = loaiHangBL.GetAll();

            cbbPhanLoai.DataSource = dsLoai;
            cbbPhanLoai.ValueMember = "ID";
            cbbPhanLoai.DisplayMember = "TenLoai";
        }
    }
}
