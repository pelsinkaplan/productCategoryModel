using System;
using System.Collections.Generic;
using System.Linq;
using productCategoryModel.Data;
using productCategoryModel.Models;

namespace productCategoryModel.Sevices
{
    class ProductService
    {
        dbContext dbContext = new dbContext();
        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }
        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
        public Product GetProductById(int id)
        {
            return dbContext.Products.Find(id);
        }
        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Remove(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }
        public void Edit(Product product, string name, string price, string contents, Category category)
        {
            if (name != "") product.Name = name;
            if (price != "") product.Price = price;
            if (contents != "") product.Contents = contents;
            product.CategoryId = category.Id;
            dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

        }
    }
}
