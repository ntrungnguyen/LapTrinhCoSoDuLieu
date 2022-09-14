using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo18_08_2021.DTO;

namespace Demo18_08_2021
{
	public partial class AdminForm : Form
	{
		private int _currentCategoryId = 0;
		private const string _placeHolder = "Nhập tên món ăn";
		
		public AdminForm()
		{
			InitializeComponent();
		}


		private void AdminForm_Load(object sender, EventArgs e)
		{
			LoadTableToLvDetail();
			LoadCategoryToPanel();
			LoadFoodToLvDetail(WorkingContext.FoodList);

			SetUpSearchInputText();
			
		}
		private void LoadTableToLvDetail()
		{
			lvTableList.Items.Clear();
			foreach (var table in WorkingContext.TableList)
			{
				ListViewItem item = new ListViewItem(table.TableId.ToString());
				item.SubItems.Add(table.TableName);
				item.SubItems.Add(table.Status == 1 ? "Có người" : "Trống");
				item.SubItems.Add(table.Floor.ToString());

				lvTableList.Items.Add(item);
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var tableName = txtTableName.Text;
			var floor = int.Parse(cbbFloor.Text);
			var tableId = WorkingContext.TableList.Max(p => p.TableId) + 1;

			DiningTable table = new DiningTable(tableId, tableName, floor);
			WorkingContext.TableList.Add(table);

			LoadTableToLvDetail();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var tableName = txtTableName.Text;
			var floor = int.Parse(cbbFloor.Text);
			var tableId = int.Parse(txtTableId.Text);

			var table = WorkingContext.TableList.FirstOrDefault(p => p.TableId == tableId);
			table.TableName = tableName;
			table.Floor = floor;

			LoadTableToLvDetail();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var tableId = int.Parse(txtTableId.Text);

			WorkingContext.TableList.RemoveAll(p => p.TableId == tableId);
			LoadTableToLvDetail();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			var listCheckedItem = lvTableList.CheckedItems;

			foreach (ListViewItem item in listCheckedItem)
			{
				var id = int.Parse(item.SubItems[0].Text);
				WorkingContext.TableList.RemoveAll(p => p.TableId == id);
			}

			LoadTableToLvDetail();
		}

		private void lvTableList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var count = lvTableList.SelectedItems.Count;

			if (count > 0)
			{
				var item = lvTableList.SelectedItems[0];

				txtTableId.Text = item.SubItems[0].Text;
				txtTableName.Text = item.SubItems[1].Text;
				cbbFloor.SelectedIndex = int.Parse(item.SubItems[3].Text) - 1;

				btnDelete.Enabled = true;
				btnUpdate.Enabled = true;
			}
		}

		private void CreateButton(int id, string name, int yPos)
		{
			
			var btn = new Button();
			btn.Text = name;
			btn.BackColor = Color.Aquamarine;
			btn.Height = 33;
			btn.Width = 245;
			btn.Location = new Point(0, yPos);
			btn.Tag = id;
			btn.Click += CategoryButton_Click;

			pnGroupFood.Controls.Add(btn);
		}

		private void CategoryButton_Click(object sender, EventArgs e)
		{
			_currentCategoryId = Convert.ToInt32((sender as Button).Tag);
			var foods = WorkingContext.FoodList;
			if (_currentCategoryId > 0) 
			{
				foods = foods.Where(f => f.CategoryId == _currentCategoryId).ToList();
			}
			LoadFoodToLvDetail(foods);

		}

		private void LoadFoodToLvDetail(List<Food> list)
		{
			lvFood.Items.Clear();
			foreach (var food in list)
			{
				AddFoodToLV(food);
			}
		}

		private void AddFoodToLV(Food food)
		{
			ListViewItem item = new ListViewItem(food.Id.ToString());
			item.SubItems.Add(food.Name);
			item.SubItems.Add(food.Unit);
			item.SubItems.Add(food.UnitPrice.ToString());
			item.SubItems.Add(food.CategoryId.ToString());
			item.SubItems.Add(food.Description);
			item.SubItems.Add(food.ImageLink);

			lvFood.Items.Add(item);
		}

		private void LoadCategoryToPanel()
		{
			var yPos = 0;

			CreateButton(0, "Tất cả", yPos);

			foreach (var cat in WorkingContext.CategoryList)
			{
				yPos += 35;
				CreateButton(cat.Id, cat.Name, yPos);
			}
		}

		private void SetUpSearchInputText()
		{
			txtSearchFood.Text = _placeHolder;
			txtSearchFood.GotFocus += RemovePlaceHolderText;
			txtSearchFood.LostFocus += ShowPlaceHolderText;
		}

		private void ShowPlaceHolderText(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearchFood.Text))
				txtSearchFood.Text = _placeHolder;
		}

		private void RemovePlaceHolderText(object sender, EventArgs e)
		{
			if (txtSearchFood.Text == _placeHolder)
				txtSearchFood.Text = "";
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			var dialog = new InformationFoodForm();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var food = dialog.ReturnedFood;
				AddFoodToLV(food);
			}
		}


		//Xử lý sự kiện tìm theo tên món ăn 
		private void txtSearchFood_TextChanged(object sender, EventArgs e)
		{
			var foods = WorkingContext.FoodList;
			lvFood.Items.Clear();
			foreach (var item in foods)
			{
				if (item.Name.ToLower().StartsWith(txtSearchFood.Text.ToLower()))
				{
					AddFoodToLV(item);
				}
			}
			
		}

		//Hiển thị hình ảnh và tên món ăn 
		private void lvFood_Click(object sender, EventArgs e)
		{
			lblNameFood.Text = lvFood.SelectedItems[0].SubItems[1].Text;
			txtDescription.Text = lvFood.SelectedItems[0].SubItems[5].Text;
			try
			{
				ptbViewPictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
				ptbViewPictureFood.Load(lvFood.SelectedItems[0].SubItems[6].Text);
			}
			catch (Exception)
			{

			}
			
		}

		private void lvFood_DoubleClick(object sender, EventArgs e)
		{
			InformationFoodForm DoubleClick = new InformationFoodForm(1);
			int categoryID = 0;
			int count = lvFood.SelectedItems.Count;

			if (count > 0)
			{
				int id = int.Parse(lvFood.SelectedItems[0].SubItems[0].Text);
				string name = lvFood.SelectedItems[0].SubItems[1].Text;
				string unit = lvFood.SelectedItems[0].SubItems[2].Text;
				var price = Convert.ToInt32(lvFood.SelectedItems[0].SubItems[3].Text);
				categoryID = int.Parse(lvFood.SelectedItems[0].SubItems[4].Text);
				string decription = lvFood.SelectedItems[0].SubItems[5].Text;
				string path = lvFood.SelectedItems[0].SubItems[6].Text;
				DoubleClick.ReturnedFood = new Food(id, name, unit, price, decription, path, categoryID - 1);
			}
			if (DoubleClick.ShowDialog() == DialogResult.OK)
			{
				var foods = WorkingContext.FoodList;
				if (DoubleClick.ReturnedFood.CategoryId > 0)
				{
					foods = foods.Where(f => f.CategoryId == DoubleClick.ReturnedFood.CategoryId).ToList();
				}
				LoadFoodToLvDetail(foods);
			}
			
		}

	}
}

