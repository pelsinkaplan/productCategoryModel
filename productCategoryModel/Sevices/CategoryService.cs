using System;
using System.Collections.Generic;
using System.Linq;
using productCategoryModel.Data;
using productCategoryModel.Models;

namespace productCategoryModel.Sevices
{
    class CategoryService
    {

        dbContext dbContext = new dbContext();
        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public void Add(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void Edit(Category category, string name)
        {
            category.Name = name;
            dbContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

        }
        public bool isThereSameCategory(string categoryName)
        {
            foreach (Category category in dbContext.Categories)
                if (category.Name == categoryName) return true;
            return false;
        }

        public IList<Product> GetProducts(int id)
        {
            Category category = dbContext.Categories.Find(id);
            IList<Product> products = category.Products;
            return products;
        }

        public bool isThereProduct(int id)
        {
            if (GetProducts(id) == null)
                return false;
            return true;
        }
        public bool Remove(Category category)
        {
            if (CategoryStatus(category))
            {
                dbContext.Remove<Category>(category);
                dbContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        private bool CategoryStatus(Category category)
        {
            foreach (var product in dbContext.Products)
            {
                if (product.CategoryId == category.Id)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
