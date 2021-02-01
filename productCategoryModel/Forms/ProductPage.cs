using System.Windows.Forms;
using productCategoryModel.Sevices;


namespace productCategoryModel
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
            getProducts();
        }

        ProductService productService = new ProductService();

        private void getProducts()
        {
            dataGridView1.DataSource = productService.GetProducts();
        }
    }
}
