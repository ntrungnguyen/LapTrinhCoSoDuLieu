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

namespace ShoesSalesManagement
{
    public partial class Form1 : Form
    {
        private const string PlaceHolderText = "Tên tài khoản";
        
        public Form1()
        {
            InitializeComponent();
            SetUpSearchInputText();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-QPREIOKV;Initial Catalog=ShoesSalesManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();

            try
            {
                cmd.CommandText = $"select * from NguoiDung Where TaiKhoan=@account and MatKhau =@pass";

                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 1000);

                cmd.Parameters["@account"].Value = tbUser.Text;
                cmd.Parameters["@pass"].Value = tbPass.Text;

                conn.Open();

               SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    //Home home = new Home();
                    //home.ShowDialog();
                    if (tbUser.Text.ToLower() == "trungnguyen")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền admin");
                        Home home = new Home();
                        home.PhanQuyenAdmin();
                        home.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền nhân viên");
                        Home home = new Home();
                        home.PhanQuyenNhanVien();
                        home.ShowDialog();
                    }
                }
                else
                {
                    lblNotication.Text = "Sai tên đăng nhập hoặc mật khẩu";
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                Application.Exit();
        }

        private void SetUpSearchInputText()
        {
            tbUser.Text = PlaceHolderText;
            tbUser.GotFocus += RemovePlaceHolderText;
            tbUser.LostFocus += ShowPlaceHolderText;
        }

        private void ShowPlaceHolderText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUser.Text))
                tbUser.Text = PlaceHolderText;
        }

        private void RemovePlaceHolderText(object sender, EventArgs e)
        {
            if (tbUser.Text == PlaceHolderText)
                tbUser.Text = "";
        }
    }
}
