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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private List<Category> GetCategories()
        {
            //khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            //lấy danh sách tất cả nhóm thức ăn, sắp xếp theo tên
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void ShowCategories()
        {
            //xoa tat ca cac nút trên cây
            tvwCategory.Nodes.Clear();

            //tao ds loại nhóm thức ăn, đồ uống
            //tên của các loại này được hiển thị trên các nút bậc 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            //tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            //laays danh sách nhóm đồ ăn, thức uống
            var categories = GetCategories();

            //duyệt qua các loại nhóm thức ăn
            foreach (var cateType in cateMap)
            {
                //tạo các nút tương ứng với loại nhóm thức ăn
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType;

                //duyệt qua các nhóm thức ăn
                foreach (var category in categories)
                {
                    //nếu nhóm đang xét kh cùng loại thì bỏ qua
                    if (category.Type != cateType.Key) continue;

                    //ngược lại tạo các nút tương ứng trên cây
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }

            //mở rộng các nhánh của cây để thấy hết tất cả các nhóm thức ăn
            tvwCategory.ExpandAll();

            //đánh dấu nút gốc đang được chọn
            tvwCategory.SelectedNode = rootNode;
        }


        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();

            //tạo truy vấn lấy ds món ăn
            var foods = dbContext.Foods.AsQueryable();

            //nếu mã nhóm món ăn khác null và hợp lê
            if (categoryId != null && categoryId > 0)
            {
                //thì tìm theo mã số thức ăn
                foods = foods.Where(x=>x.FoodCategoryId == categoryId);
            }

            //sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chưa đầy đủ thông tin về món ăn
            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }


        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            //tìm các món ăn theo loại nhóm thức ăn (CategoryType)
            //sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chưa đầy đủ thông tin về món ăn
            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();

            if (node == null) return;

            //tạo danh sách để chứa danh sách các món ăn tìm được
            List<FoodModel> foods = null;

            if (node.Level == 1)
            {
                //thì lấy danh sách món ăn theo loại nhóm
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                //ngược kauh kấy ds món ăn theo thể loại
                //nếu nút được chọn là 'Tất cả' thì lấy hết
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }

            ShowFoodsOnListView(foods);
        }


        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0)
            {
                return;
            }
            var dbContext = new RestaurantContext();
            var selectedFoodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var selectedFood = dbContext.Foods.Find(selectedFoodId);

            if (selectedFood != null)
            {
                dbContext.Foods.Remove(selectedFood);
                dbContext.SaveChanges();
                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }
    }
}
