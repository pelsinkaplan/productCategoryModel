using System;
using System.Windows.Forms;
using productCategoryModel.Models;
using productCategoryModel.Sevices;

namespace productCategoryModel.Forms
{
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
            getCategoriesToSelect();
            getProducts();
        }

        ProductService productServices = new ProductService();

        Category selectedCategory = null;
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            int selectedCategoryId = (int)(comboBox1.SelectedValue);
            var category = categoryService.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
            Product product = new Product();
            product.Name = textBoxName.Text;
            product.Price = textBoxPrice.Text;
            product.Contents = textBoxContents.Text;
            product.CategoryId = selectedCategory.Id;
            productServices.Add(product);
            getProducts();
            MessageBox.Show(product.Name + " başarıyla eklendi!");
        }

        private void getCategoriesToSelect()
        {
            comboBox1.DataSource = productServices.GetCategories();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void getProducts()
        {
            dataGridViewProducts.DataSource = productServices.GetProducts();
        }
    }
}
