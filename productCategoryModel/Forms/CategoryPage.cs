using System.Windows.Forms;
using productCategoryModel.Sevices;


namespace productCategoryModel.Forms
{
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
            getCategories();
        }

        CategoryService categoryService = new CategoryService();

        private void getCategories()
        {
            dataGridView2.DataSource = categoryService.GetCategories();
        }
    }
}
