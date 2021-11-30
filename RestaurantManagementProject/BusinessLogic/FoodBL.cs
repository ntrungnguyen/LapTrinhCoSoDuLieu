using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.CategoryDA;

namespace BusinessLogic
{
    //lớp foodBL có các phương thức xử lý bảng Food
    public class FoodBL
    {
        //đối tượng categoryDA từ dataAccess
        FoodDA foodDA = new FoodDA();

        //lấy hết dữ liệu
        public List<Food> GetAll()
        {
            return foodDA.GetAll();
        }

        //phương thức lấy về đối tượng Food theo khóa chính
        public Food GetByID(int ID)
        {
            //lấy hết
            List<Food> list = GetAll();

            //duyệt để tìm kiếm
            foreach (var item in list)
            {
                if (item.ID == ID) // nếu gặp khóa chính
                    return item; //trả về kết quả
            }
            return null;
        }

        //tìm theo khóa
        public List<Food> Find(string key)
        {
            List<Food> list = GetAll();
            List<Food> result = new List<Food>();

            //duyệt theo danh sách
            foreach (var item in list)
            {
                if (item.ID.ToString().Contains(key)
                    || item.Name.Contains(key)
                    || item.Unit.Contains(key)
                    || item.Price.ToString().Contains(key)
                    || item.Notes.Contains(key))
                    result.Add(item); //thêm vào danh sách kết quả
            }
            return result;
        }

        //Phương thức thêm dữ liệu
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }

        //Phương thức cập nhật dữ liệu
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }

        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }

    }
}
