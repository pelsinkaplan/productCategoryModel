using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using productCategoryModel.Sevices;
using productCategoryModel.Models;

namespace productCategoryModel.Forms
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
            getProducts();
            getProductsToSelect();
        }

        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();

        Product selectedProduct = null;
        Category selectedCategory = null;
        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            int selectedProductId = (int)(comboBox1.SelectedValue);
            int selectedCategoryId = (int)(comboBoxCategory.SelectedValue);
            var product = productService.GetProductById(selectedProductId);
            var category = categoryService.GetCategoryById(selectedCategoryId);
            selectedProduct = product;
            selectedCategory = category;
            productService.Edit(selectedProduct, textBoxName.Text, textBoxPrice.Text, textBoxContents.Text,selectedCategory);
            getProducts();
            getProductsToSelect();
            MessageBox.Show(product.Name + " ürünü başarıyla güncellendi!");
        }


        private void getProductsToSelect()
        {
            comboBox1.DataSource = productService.GetProducts();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCategory.DataSource = productService.GetCategories();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            this.comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void getProducts()
        {
            dataGridView1.DataSource = productService.GetProducts();
        }
    }
}
