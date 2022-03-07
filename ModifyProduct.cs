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

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
