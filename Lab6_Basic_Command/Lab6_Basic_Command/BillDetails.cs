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
	public partial class BillDetails : Form
	{
		public BillDetails()
		{
			InitializeComponent();
			LoadBillDetails();
		}
		public void LoadBillDetails()
		{
			string connectionString = "server=. ; database = RestaurantManagement; Integrated Security = true ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT * FROM BillDetails";

			sqlConnection.Open();

			this.Text = "Chi tiết hóa đơn";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Account");
			da.Fill(dt);

			dgvBillDetails.DataSource = dt;

			dgvBillDetails.Columns[0].HeaderText = "ID";
			dgvBillDetails.Columns[1].HeaderText = "ID hóa đơn";
			dgvBillDetails.Columns[2].HeaderText = "ID đồ ăn";
			dgvBillDetails.Columns[3].HeaderText = "Số lượng";

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
