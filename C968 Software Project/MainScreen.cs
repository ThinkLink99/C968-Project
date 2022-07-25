namespace C968_Software_Project
{
    public partial class MainScreen : Form
    {
        private Forms.AddPart _frmAddPart;
        private Forms.ModifyPart _frmModifyPart;

        private Forms.AddProduct _frmAddProduct;
        private Forms.ModifyProduct _frmModifyProduct;

        private Models.Inventory _inventory;

        public MainScreen()
        {
            InitializeComponent();

            _frmAddPart = new Forms.AddPart();
            _frmModifyPart = new Forms.ModifyPart();

            _frmAddProduct = new Forms.AddProduct();
            _frmModifyProduct = new Forms.ModifyProduct();

            _inventory = new Models.Inventory();
        }

        private void ShowInventory()
        {
            dgvParts.DataSource = _inventory.AllParts;
            dgvProducts.DataSource = _inventory.Products;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            _frmAddPart.ShowDialog();
        }
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            _frmModifyPart.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _frmAddProduct.ShowDialog();
        }
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            _frmModifyProduct.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ShowInventory();
        }
    }
}