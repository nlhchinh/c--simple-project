namespace MaintainProducts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        ProductData data = new ProductData();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                string ProName = txtProductName.Text;
                float Price = float.Parse(txtUnitPrice.Text);
                int Quantity = int.Parse(txtQuantity.Text);

                Product p = new Product
                {
                    ProductID = ProID,
                    ProductName = ProName,
                    UnitPrice = Price,
                    Quantity = Quantity
                };
                data.AddNew(p);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = data.GetProductList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                data.Remove(ProID);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource= data.GetProductList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int ProID = int.Parse(txtProductID.Text);
            Product p = data.Find(ProID);
            if (PreProcessMessage == null)
                MessageBox.Show("Product not found");
            else
            {
                txtProductName.Text = p.ProductName;
                txtQuantity.Text = p.Quantity.ToString();
                txtUnitPrice.Text = p.UnitPrice.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
        }
    }
}