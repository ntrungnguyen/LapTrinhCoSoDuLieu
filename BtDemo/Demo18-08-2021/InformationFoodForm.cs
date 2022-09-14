using Demo18_08_2021.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo18_08_2021
{
	public partial class InformationFoodForm : Form
	{
		private int _foodId;
		public Food ReturnedFood;
		public InformationFoodForm(int foodId = 0)
		{
			InitializeComponent();
			_foodId = foodId;

			
		}


		private void InformationFoodForm_Load(object sender, EventArgs e)
		{
			cbbGroupFood.DataSource = WorkingContext.CategoryList;
			cbbGroupFood.DisplayMember = "Name";
			cbbGroupFood.ValueMember = "Id";

			if (_foodId > 0)
			{
				txtCodeFoodDrink.Text = ReturnedFood.Id.ToString();
				txtNameFoodDrink.Text = ReturnedFood.Name;
				txtUnitCalc.Text = ReturnedFood.Unit;
				nudUnitPrice.Value = ReturnedFood.UnitPrice;
				cbbGroupFood.SelectedIndex = ReturnedFood.CategoryId;
				txtPicture.Text = ReturnedFood.ImageLink;
				txtDescription.Text = ReturnedFood.Description;
				try
				{
					ptbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
					ptbPicture.Load(txtPicture.Text);
				}
				catch (Exception)
				{
					
				}
			}
		}

		private void btnChoosePicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Open Dialog";// "Add Photos";
			dlg.Multiselect = true;
			dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
			+ "*.jpg;*.jpeg;*.gif;*.bmp;"
			+ "*.tif;*.tiff;*.png|"
			+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
			+ "GIF files (*.gif)|*.gif|"
			+ "BMP files (*.bmp)|*.bmp|"
			+ "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
			+ "PNG files (*.png)|*.png|"
			+ "All files (*.*)|*.*";

			dlg.InitialDirectory = Environment.CurrentDirectory;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var filename = dlg.FileName;
				txtPicture.Text = filename;
				ptbPicture.Load(filename);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var name = txtNameFoodDrink.Text;
			var unit = txtUnitCalc.Text;
			var description = txtDescription.Text;
			var link = txtPicture.Text;
			var price = Convert.ToInt32(nudUnitPrice.Value);
			var categoryId = Convert.ToInt32(cbbGroupFood.SelectedValue);

			if (_foodId ==0)
			{
				int id = WorkingContext.FoodList.Any() ? WorkingContext.FoodList.Max(f => f.Id) + 1 : 1;
				ReturnedFood = new Food(id, name, unit, price, description, link, categoryId);
				WorkingContext.FoodList.Add(ReturnedFood);
			}
			else
			{

			}
			DialogResult = DialogResult.OK;
		}
	}
}
