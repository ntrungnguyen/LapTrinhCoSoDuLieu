using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RestaurantContext : DbContext
    {
        //tham chiếu tới các nhóm món ăn trong bảng category
        public DbSet<Category> Categories { get; set; }


        //tham chiếu tới các món ăn, đồ uống trong food
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //xóa bỏ quy tắc sử dụng danh từ số nhiều cho tên bảng
            //lúc này thuộc tính categories ánh xạ tới bảng Category trong db
            // và foods tương ứng Food trong csdl
            
            modelBuilder.Entity<Food>()
                .HasRequired(x=>x.Category)
                .WithMany()
                .HasForeignKey(x=>x.FoodCategoryId)
                .WillCascadeOnDelete(true);
        }
    }
}
