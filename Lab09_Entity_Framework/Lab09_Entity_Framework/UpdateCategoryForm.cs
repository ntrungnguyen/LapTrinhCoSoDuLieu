using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class UpdateCategoryForm : Form
    {
        private RestaurantContext _dbContext;
        private int _categoryId;
        public UpdateCategoryForm(int? categoryId = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _categoryId = categoryId ?? 0;
        }


        private Category GetCategoryById(int categoryId)
        {
            //nếu Id được truyền vào là hợp lệ, ta tìm thông tin theo ID
            // Ngược lại, chỉ đơn giản trả về null, cho biết không thấy
            return categoryId > 0 ? _dbContext.Categories.Find(categoryId) : null;
        }

        private void ShowCategory()
        {
            var category = GetCategoryById(_categoryId);

            if (category == null) return;

            txtCategoryId.Text = category.Id.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }


        private Category GetUpdatedCategory()
        {
            //tạo đối tượng category với thông tin đã nhập
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };

            //gán giá trị của ID ban đầu (nếu đang cập nhật)
            if (_categoryId > 0)
            {
                category.Id = _categoryId;
            }
            return category;
        }

        private bool ValidateUserInput()
        {
            //kiểm tra tên nhóm thức ăn đã được nhập hay chưa
            if(string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhóm thức ăn không được để trống", "Thông báo");
                return false;
            }

            //kiểm tra loại thức ăn đã được chọn hay chưa
            if(cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm thức ăn", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //kiểm tra nếu dữ liệu nhập vào là hợp lệ
            if (ValidateUserInput())
            {
                //thì lấy thông tin người dùng nhập vào
                var newCategory = GetUpdatedCategory();

                //và tìm xem đã có nhóm thức ăn trong CSDL chưa
                var oldCategory = GetCategoryById(_categoryId);

                if (oldCategory == null)
                {
                    //thì thêm nhóm thức ăn mới
                    _dbContext.Categories.Add(newCategory);
                }
                else
                {
                    //ta chỉ cần cập nhật thông tin cần thiết
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
                }

                _dbContext.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
