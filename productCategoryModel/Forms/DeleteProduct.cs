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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
            getProductsToSelect();
            getProducts();
        }

        ProductService productService = new ProductService();

        Product selectedProduct = null;
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int selectedProductId = (int)(comboBox1.SelectedValue);
            var category = productService.GetProductById(selectedProductId);
            selectedProduct = category;
            productService.Remove(selectedProduct);
            getProducts();
            getProductsToSelect();
            MessageBox.Show(selectedProduct.Name + " başarıyla silindi!");
        }

        private void getProductsToSelect()
        {
            comboBox1.DataSource = productService.GetProducts();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void getProducts()
        {
            dataGridView1.DataSource = productService.GetProducts();
        }
    }
}
