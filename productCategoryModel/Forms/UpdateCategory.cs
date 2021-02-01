using productCategoryModel.Models;
using productCategoryModel.Sevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace productCategoryModel.Forms
{
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
            getCategoriesToSelect();
            getCategories();
        }

        CategoryService categoryService = new CategoryService();

        Category selectedCategory = null;
        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)(comboBox1.SelectedValue);
            var category = categoryService.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
            categoryService.Edit(selectedCategory, textBoxNewName.Text);
            getCategories();
            getCategoriesToSelect();
            MessageBox.Show(selectedCategory.Name + " kategorisi başarıyla güncellendi!");
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
