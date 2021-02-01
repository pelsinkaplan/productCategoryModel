using System;
using System.Windows.Forms;
using productCategoryModel.Models;
using productCategoryModel.Sevices;

namespace productCategoryModel.Forms
{
    public partial class InsertCategory : Form
    {
        public InsertCategory()
        {
            InitializeComponent();
            getCategories();
        }

        CategoryService categoryService = new CategoryService();

        private void getCategories()
        {
            dataGridViewCategories.DataSource = categoryService.GetCategories();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if (categoryService.isThereSameCategory(textBoxAddCategory.Text))
            {
                MessageBox.Show("Bir kategoriden birden fazla olamaz!");
            }
            else
            {
                Category category = new Category();
                category.Name = textBoxAddCategory.Text;
                categoryService.Add(category);
                getCategories();
                MessageBox.Show(category.Name + " başarıyla eklendi!");
            }

        }
    }
}
