using CA_TheaterDB_CodeFirst.Entities;

namespace CA_TheaterDB_CodeFirst.Data
{
    internal class CategoryData
    {
        public static List<Category> GetCategoryData()
        {
            List<Category> category = new List<Category>
            {
                new Category { ID = 1, CategoryName = "Action" },
                new Category { ID = 2, CategoryName = "Comedy" },
                new Category { ID = 3, CategoryName = "Drama" },
                new Category { ID = 4, CategoryName = "Fantasy" },
                new Category { ID = 5, CategoryName = "Horror" },
                new Category { ID = 6, CategoryName = "Mystery" },
            };
            return category;
        }
    }
}
