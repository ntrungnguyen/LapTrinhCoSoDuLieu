using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";

            //thiết lập index = 0 cho cbb
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }


        // Danh sách toàn cục bảng Category
        List<Category> listCategory = new List<Category>();

        // Danh sách toàn cục bảng Food
        List<Food> listFood = new List<Food>();

        // Đối tượng Food đang chọn hiện hành
        Food foodCurrent = new Food();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void LoadCategory()
        {
            //gọi đối tượng categoryBL từ tầng businessLogic
            CategoryBL categoryBL = new CategoryBL();

            //lấy dữ liệu gán cho biến toàn cục listcategory
            listCategory = categoryBL.GetAll();

            cbbCategory.DataSource = listCategory;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }

        public void LoadFoodDataToListView()
        {
            //gọi đối tượng foodbl từ tầng businessLogic
            FoodBL foodBL = new FoodBL();

            //lấy dữ liệu
            listFood = foodBL.GetAll();
            int count = 1; //biến số thứ tự

            //xóa dữ liệu trong LV
            lsvFood.Items.Clear();

            //duyệt mảng dữ liệu đưa vào LV
            foreach (var food in listFood)
            {
                //số thứ tự
                ListViewItem item = lsvFood.Items.Add(count.ToString());

                //đưa dữ liệu vào Name, Unit, Price vào cột tiếp theo
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());

                //theo dữ liệu của bảng categoryID, lấy Name để hiển thị
                string foodName = listCategory.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);

                //đưa dữ liệu notes vào cột cuối
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void lsvFood_Click(object sender, EventArgs e)
        {
            //duyệt toàn bộ dữ liệu trong LV
            for  (int i = 0; i < lsvFood.Items.Count; i++)
            {
                //nếu có dòng được chọn thì lấy dòng đó
                if (lsvFood.Items[i].Selected)
                {
                    //Lấy các tham số và gán dữ liệu vào các ô
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;

                    //lấy index của cbb theo categoryID
                    cbbCategory.SelectedIndex = listCategory.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        //thêm dữ liệu cho food
        public int InsertFood()
        {
            //khai báo đtuong food từ tầng dataAccess
            Food food = new Food();
            food.ID = 0;

            //kiểm tra
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                //giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    //cố gắng lấy giá trị
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    //nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;

                //giá trị foodcategoryID được lấy từ cbb
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());

                //khai báo đối tượng foodBL từ tầng business
                FoodBL foodBL = new FoodBL();

                //chèn dữ liệu vào bảng
                return foodBL.Insert(food);
            }
            return -1;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //gọi phương thức thêm dữ liệu
            int result = InsertFood();
            if (result > 0) //nếu thêm thành công
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiếm tra lại dữ liệu nhập");
            }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mẫu tin này?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //khai báo đối tượng foodbl từ businesslogic
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xóa thực phẩm thành công");
                    LoadFoodDataToListView();
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }

        //cập nhật
        public int UpdateFood()
        {
            Food food = foodCurrent;

            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;

                int price = 0;
                try
                {
                    //chuyển giá trị từ kiểu văn bản qua kiểu int
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    //nếu sai gán giá trị = 0
                    price = 0;
                }
                food.Price = price;

                //giá trị foodcategoryID được lấy từ cbb
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());

                //khai báo đối tượng foobbl từ tầng business
                FoodBL foodBL = new FoodBL();

                //cập nhật dữ liệu trong bảng
                return foodBL.Update(food);
            }
            return -1;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
    }
}
