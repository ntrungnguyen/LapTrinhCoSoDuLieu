using Microsoft.VisualBasic.FileIO;
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

namespace Lab4_Demo
{
	public partial class frmExplorer : Form
	{
		// Tìm tên ứng với ổ đĩa
		private string ImageKeyDriver(DriveInfo drive)
		{
			string type = "";
			switch (drive.DriveType)
			{
				case DriveType.Fixed:
					type = "HDD";
					break;
				case DriveType.CDRom:
					type = "CD";
					break;
				case DriveType.Removable:
					type = "Removable";
					break;
				case DriveType.Network:
					type = "Network";
					break;
				default:
					type = "HDD";
					break;
			}
			return type;
		}

		//Load ổ đĩa
		private void LoadDrive(TreeNode tn)
		{
			TreeNode tnode = new TreeNode();
			foreach (DriveInfo dr in DriveInfo.GetDrives())
			{
				tnode = new TreeNode();
				tnode.Text = dr.Name;
				tnode.Tag = dr.ToString();
				tnode.ImageKey = ImageKeyDriver(dr);
				tnode.ImageKey = ImageKeyDriver(dr);
				tn.Nodes.Add(tnode);
			}
		}

		//Thêm thư mục vào tnParent
		private void InsertFolder(TreeNode tnParent)
		{
			try
			{
				DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
				foreach (DirectoryInfo dircur in dir.GetDirectories())
				{
					TreeNode tnChild = new TreeNode(dircur.Name, 6, 6);
					tnChild.Tag = dircur.FullName;
					tnParent.Nodes.Add(tnChild);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		//Phương thức file vào listviewFile của tnParent
		private void InsertFile(TreeNode tnParent)
		{
			try
			{
				DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
				this.listViewFile.Items.Clear();
				foreach (FileInfo filecur in dir.GetFiles())
				{
					ListViewItem lvitem = new ListViewItem(filecur.Name);
					lvitem.SubItems.Add(filecur.LastWriteTime.ToShortDateString());
					lvitem.SubItems.Add(filecur.Extension);
					lvitem.SubItems.Add((filecur.Length / 1024).ToString());
					this.listViewFile.Items.Add(lvitem);
				}
				this.statusStrip1.Text = "Tổng số Files: " + this.listViewFile.Items.Count;
			}
			catch (Exception)
			{

				throw;
			}
		}

		//Phương thức thêm đĩa hoặc thư mục và file của node tnparent
		private void InsertChildParent(TreeNode tnparent)
		{
			if (tnparent != null)
			{
				if (tnparent.Level == 0)
				{
					TreeNode tnMyDocuments = new TreeNode("My Documents", 2, 2);
					tnMyDocuments.Tag = SpecialDirectories.MyDocuments;
					TreeNode tnMyComputer = new TreeNode("My Computer", 1, 1);
					tnMyComputer.Tag = "My Computer";
					tnparent.Nodes.Insert(0, tnMyDocuments);
					tnparent.Nodes.Insert(1, tnMyComputer);
				}
				else
				{
					if (tnparent.Nodes.Count == 0)
					{
						if (tnparent.Text == "My Computer")
						{
							LoadDrive(tnparent);
							return;
						}
						InsertFolder(tnparent);
					}
					InsertFile(tnparent);
				}
			}
		}
		public frmExplorer()
		{
			InitializeComponent();
		}

		private void frmExplorer_Load(object sender, EventArgs e)
		{
			TreeNode tnode = new TreeNode();
			tnode.Text = "Desktop";
			tnode.Tag = SpecialDirectories.Desktop;
			tnode.ImageKey = "Desktop";
			int root = this.treeViewFolder.Nodes.Add(tnode);
			string name = Application.StartupPath;
			name = name.Substring(0, name.LastIndexOf('\\'));
			name = name.Substring(0, name.LastIndexOf('\\'));
		}


		//Sự kiện AfterSelect của treeView:
		//Load thư mục vào node hiện hành và
		//File vào listViewFile
		private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode tnParent = e.Node;
			tnCurrent = e.Node;
			InsertChildParent(tnParent);
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
