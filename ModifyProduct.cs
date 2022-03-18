using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class modifyProductForm : Form
    {
        public modifyProductForm()
        {
            InitializeComponent();
        }

        public modifyProductForm(Product product)
        {
            InitializeComponent();
            modifyProductIDTextBox.Text = product.ProductID.ToString();
            modifyProductNameTextBox.Text = product.Name.ToString();
            modifyProductStockTextBox.Text = product.InStock.ToString();
            modifyProductPriceTextBox.Text = product.Price.ToString();
            modifyProductMaxTextBox.Text = product.Max.ToString();
            modifyProductMinTextBox.Text = product.Min.ToString();
            
            
        }

   

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            // int ProductID = 1;

            var modProductID = int.Parse(modifyProductIDTextBox.Text);
            var modProductName = modifyProductNameTextBox.Text;
            var modProductInStock = int.Parse(modifyProductStockTextBox.Text);
            var modProductMin = int.Parse(modifyProductMinTextBox.Text);
            var modProductMax = int.Parse(modifyProductMaxTextBox.Text);
            var modProductPrice = decimal.Parse(modifyProductPriceTextBox.Text);

            var modifiedProduct = new Product
            {
                ProductID = modProductID,
                Name = modProductName,
                Price = modProductPrice,
                InStock = modProductInStock ,
                Min = modProductMin,
                Max = modProductMax
            };
            Inventory.updateProduct(modProductID, modifiedProduct);
            Close();
        }
    }
}
