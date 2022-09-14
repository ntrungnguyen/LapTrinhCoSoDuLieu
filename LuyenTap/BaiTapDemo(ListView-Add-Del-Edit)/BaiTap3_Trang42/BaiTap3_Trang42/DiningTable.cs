using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDemo
{
	public class DiningTable
	{
		public int TableID { get; set; }

		public string TableName { get; set; }

		public int Status { get; set; }

		public int Floor { get; set; }

		public DiningTable()
		{

		}

		public DiningTable(int tableId, string tableName, int floor)
		{
			TableID = tableId;
			TableName = tableName;
			Status = 0;
			Floor = floor;
		} 
	}
}
