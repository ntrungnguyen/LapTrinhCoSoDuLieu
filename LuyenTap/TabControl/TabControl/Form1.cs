using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.tabControl2.TabPages.Clear();
			TabPage tabSV = new TabPage();
			TabPage tabGV = new TabPage();
			TabPage tabMH = new TabPage();

			tabSV.Text = "Sinh viên";
			tabGV.Text = "Giáo viên";
			tabMH.Text = "Môn học";

			this.tabControl2.TabPages.Add(tabSV);
			this.tabControl2.TabPages.Add(tabGV);
			this.tabControl2.TabPages.Add(tabMH);

		}
	}
}
