using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductApp
{
    public partial class frmProductManager : Form
    {
        public frmProductManager()
        {
            InitializeComponent();
        }

        ProductDAO productDAO = new ProductDAO();
        DataTable dtProduct;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getAllProducts();
        }

        private void getAllProducts()
        {
            dtProduct = productDAO.getProduct();
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtDate.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", dtProduct, "productID");
            txtProductName.DataBindings.Add("Text", dtProduct, "productName");
            txtCategory.DataBindings.Add("Text", dtProduct, "category");
            txtDescription.DataBindings.Add("Text", dtProduct, "description");
            txtDate.DataBindings.Add("Text", dtProduct, "date");

            dgvListProduct.DataSource = dtProduct;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDate.Value = DateTime.Today;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            string productName = txtProductName.Text;
            string category = txtCategory.Text;
            string description = txtDescription.Text;
            DateTime date = txtDate.Value;
            Products products = new Products(productID, productName, category, description, date);

            bool r = productDAO.addProduct(products);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Add " + s);
            getAllProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            string productName = txtProductName.Text;
            string category = txtCategory.Text;
            string description = txtDescription.Text;
            DateTime date = txtDate.Value;
            Products products = new Products(productID, productName, category, description, date);

            bool r = productDAO.updateProduct(products);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Update " + s);
            getAllProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
