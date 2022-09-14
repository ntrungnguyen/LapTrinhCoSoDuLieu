using BaiTapDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3_Trang42
{
    public partial class FormChuongTrinh : Form
    {
        private List<DiningTable> tableList;
        

        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            tableList = new List<DiningTable>();
            Random r = new Random();

            for (int i = 1; i < 23; i++)
            {
                DiningTable table = new DiningTable();
                table.TableName = $"Bàn {i}";
                table.TableID = i;
                table.Status = r.Next(0, 2);
                table.Floor = r.Next(1, 4);

                tableList.Add(table);
            }

            LoadTableListFLP();
            //LoadTableListLV();
            LoadTableListDetail();
        }

        //Hiện bảng dạng FLP
        private void LoadTableListFLP()
        {
            var floors = new[] { flpFloorOne, flpFloorTwo, flpFloorThree };
            foreach (var table in tableList)
            {
                Button btn = new Button();
                btn.Text = table.TableName + "\r" + (table.Status == 1 ? "Có người" : "Trống");
                btn.BackColor = table.Status == 1 ? Color.Orange : Color.Aquamarine;
                btn.Height = 50;
                btn.Width = 120;

                ttFloor.SetToolTip(btn, $"Tầng {table.Floor}");


                floors[table.Floor - 1].Controls.Add(btn);
            }
        }

        //Hiện bảng dạng lv
        private void LoadTableListLV()
		{
            ListViewGroup floorOne = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
            ListViewGroup floorTwo = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
            ListViewGroup floorThree = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);

            lvTableList.Groups.Add(floorOne);
            lvTableList.Groups.Add(floorTwo);
            lvTableList.Groups.Add(floorThree);

            var floorGroup = new[] { floorOne, floorTwo, floorThree };

            foreach (var table in tableList)
			{
                ListViewItem item = new ListViewItem(table.TableName, table.Status);
                item.Group = floorGroup[table.Floor - 1];
                lvTableList.Items.Add(item);
			}
		}

        //Hiện bảng dạng chi tiết (Column)
        private void LoadTableListDetail()
		{
            lvTableList.Items.Clear();
			foreach (var table in tableList)
			{
                ListViewItem item = new ListViewItem(table.TableID.ToString());
                item.SubItems.Add(table.TableName);
                item.SubItems.Add(table.Status == 1 ? "Có người" : "Trống");
                item.SubItems.Add(table.Floor.ToString());

                lvTableList.Items.Add(item);
			}
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
            var tableName = txtTableName.Text;
            var floor = int.Parse(cbbFloor.Text);
            var tableId = tableList.Max(p => p.TableID) + 1;

            DiningTable table = new DiningTable(tableId, tableName, floor);
            tableList.Add(table);
            LoadTableListDetail();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            var tableName = txtTableName.Text;
            var floor = int.Parse(cbbFloor.Text);
            var tableId = int.Parse(txtTableId.Text);

            var table = tableList.FirstOrDefault(p => p.TableID == tableId);
            table.TableName = tableName;
            table.Floor = floor;

            LoadTableListDetail();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            var tableId = int.Parse(txtTableId.Text);

            tableList.RemoveAll(p => p.TableID == tableId);
            LoadTableListDetail();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
            var listCheckedItem = lvTableList.CheckedItems;
			foreach (ListViewItem item in listCheckedItem)
			{
                var id = int.Parse(item.SubItems[0].Text);
                tableList.RemoveAll(p => p.TableID == id);
			}

            LoadTableListDetail();
		}

		private void lvTableList_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
            var count = lvTableList.CheckedItems.Count;
            tsslNumOfCheckedItem.Text = $"Số lượng item được chọn là {count}";
		}

		private void tsmiAdmin_Click(object sender, EventArgs e)
		{
            AdminForm form = new AdminForm();
            form.ShowDialog();
		}
	}
}
