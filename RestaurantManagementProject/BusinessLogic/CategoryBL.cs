using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    //lớp categoryBL có các phương thức xử lý bảng Category
    public class CategoryBL
    {
        //đối tượng categoryDA từ dataAccess
        CategoryDA categoryDA = new CategoryDA();

        //phương thức lấy hết dữ liệu
        public List<Category> GetAll()
        {
            return categoryDA.GetAll();
        }

        //phương thức thêm dữ liệu
        public int Insert(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 0);
        }

        //cập nhật
        public int Update(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 1);
        }

        //xóa
        public int Delete(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 2);
        }
    }
}
