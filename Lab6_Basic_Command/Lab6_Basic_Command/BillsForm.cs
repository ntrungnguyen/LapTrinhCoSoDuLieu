using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
	public partial class BillsForm : Form
	{
		public BillsForm()
		{
			InitializeComponent();
		}
		public void LoadBills(string fromTime, string toTime)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = string.Format($"SELECT * FROM Bills WHERE CheckoutDate BETWEEN '{fromTime}' and '{toTime}'");

			sqlConnection.Open();

			this.Text = "Hóa đơn";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);

			dgvBills.DataSource = dt;
			dgvBills.Columns[0].ReadOnly = true;

			dgvBills.Columns[0].HeaderText = "ID";
			dgvBills.Columns[1].HeaderText = "Tên";
			dgvBills.Columns[2].HeaderText = "ID bàn";
			dgvBills.Columns[3].HeaderText = "Giá";
			dgvBills.Columns[4].HeaderText = "Giảm giá";
			dgvBills.Columns[5].HeaderText = "Thuế";
			dgvBills.Columns[6].HeaderText = "Trạng thái";
			dgvBills.Columns[7].HeaderText = "Ngày thanh toán";
			dgvBills.Columns[8].HeaderText = "Tài khoản";			

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void dgvBills_DoubleClick(object sender, EventArgs e)
		{
			BillDetails billDetails = new BillDetails();
			string billID = dgvBills.CurrentRow.Cells[0].Value.ToString();
			billDetails.LoadBillDetails(int.Parse(billID));
			billDetails.Show();
		}

		private void btnViewBills_Click(object sender, EventArgs e)
		{
			if(dtpFrom.Value.ToShortDateString() != null || dtpTo.Value.ToShortDateString() != null)
			{
				LoadBills(dtpFrom.Value.ToShortDateString(), dtpTo.Value.ToShortDateString());
			}
		}
	}
}
