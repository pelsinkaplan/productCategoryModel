using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using productCategoryModel.Forms;

namespace productCategoryModel
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        bool isCategorySelected = true;

        private void showOperationButtons()
        {
            labelSelectOperation.Visible = true;
            buttonSelectDelete.Visible = true;
            buttonSelectDelete.Enabled = true;
            buttonSelectInsert.Visible = true;
            buttonSelectInsert.Enabled = true;
            buttonSelectShow.Visible = true;
            buttonSelectShow.Enabled = true;
            buttonSelectUpdate.Visible = true;
            buttonSelectUpdate.Enabled = true;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            isCategorySelected = false;
            showOperationButtons();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            isCategorySelected = true;
            showOperationButtons();
        }

        private void buttonSelectInsert_Click(object sender, EventArgs e)
        {
            if (isCategorySelected)
            {
                InsertCategory insertCategory = new InsertCategory();
                insertCategory.Show();
            }
            else
            {
                InsertProduct insertProduct = new InsertProduct();
                insertProduct.Show();
            }
        }

        private void buttonSelectShow_Click(object sender, EventArgs e)
        {
            if (isCategorySelected)
            {
                CategoryPage categoryPage = new CategoryPage();
                categoryPage.Show();
            }
            else
            {
                ProductPage productPage = new ProductPage();
                productPage.Show();
            }
        }

        private void buttonSelectDelete_Click(object sender, EventArgs e)
        {
            if (isCategorySelected)
            {
                DeleteCategory deleteCategory = new DeleteCategory();
                deleteCategory.Show();
            }
            else
            {
                DeleteProduct deleteProduct = new DeleteProduct();
                deleteProduct.Show();
            }
        }

        private void buttonSelectUpdate_Click(object sender, EventArgs e)
        {
            if (isCategorySelected)
            {
                UpdateCategory updateCategory = new UpdateCategory();
                updateCategory.Show();
            }
            else
            {
                UpdateProduct updateProduct = new UpdateProduct();
                updateProduct.Show();
            }
        }
    }
}
