using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
	public partial class Form1 : Form
	{
		String extention = ".png";

		public Form1()
		{
			InitializeComponent();

			cbbImage.SelectedValueChanged += CbbImage_SelectedValueChanged;

			LoadImageName();
		}

		private void CbbImage_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue!=null)
			{
				Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
				ptbImage.Image = bm;
			}
		}

		void LoadImageName()
		{
			List<String> ListImage = new List<string>() { "1", "2", "3" };
			cbbImage.DataSource = ListImage;
		}
	}
}
