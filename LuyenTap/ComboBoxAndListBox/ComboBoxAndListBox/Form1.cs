using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxAndListBox
{
	public partial class LstBoxNN : Form
	{
		public LstBoxNN()
		{
			string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
			this.listBox1.DataSource = datas;
		}


		
	}
}
