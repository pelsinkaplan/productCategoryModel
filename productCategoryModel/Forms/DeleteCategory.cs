using System;
using System.Windows.Forms;
using productCategoryModel.Sevices;
using productCategoryModel.Models;


namespace productCategoryModel.Forms
{
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
            getCategoriesToSelect();
            getCategories();
        }

        CategoryService categoryService = new CategoryService();

        Category selectedCategory = null;
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)(comboBox1.SelectedValue);
            var category = categoryService.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
            if (!categoryService.Remove(selectedCategory))
                MessageBox.Show("Silmek istediğiniz kategorinin içerisinde ürünler var!");
            else
            {
                getCategories();
                getCategoriesToSelect();
                MessageBox.Show(selectedCategory.Name + " başarıyla silindi!");
            }

        }

        private void getCategoriesToSelect()
        {
            comboBox1.DataSource = categoryService.GetCategories();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void getCategories()
        {
            dataGridView1.DataSource = categoryService.GetCategories();
        }
    }
}
