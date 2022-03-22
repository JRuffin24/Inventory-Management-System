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
        BindingList<Part> addedParts = new BindingList<Part>();
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

            
           
            modProductAvailableParts.DataSource = Inventory.AllParts;
            
            modProductAvailableParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          
            
            modProductAvailableParts.ReadOnly = true;            
            
            modProductAvailableParts.MultiSelect = false;           
            
            modProductAvailableParts.AllowUserToAddRows = false;
            
            modProductAvailableParts.RowHeadersVisible = false;            
 
        //Load associated Parts for each product into the bottom data grid   
            
            foreach (Part part in product.AssociatedParts)
            {
                addedParts.Add(part);
            }
            modProductsAssociatedParts.DataSource = addedParts;
            
            modProductsAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            modProductsAssociatedParts.ReadOnly = true;
            
            modProductsAssociatedParts.MultiSelect = false;
            
            modProductsAssociatedParts.AllowUserToAddRows = false;
            
            modProductsAssociatedParts.RowHeadersVisible = false;

            modifyProductIDTextBox.ReadOnly = true;

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(modifyProductMinTextBox.Text) > int.Parse(modifyProductMaxTextBox.Text))
            {
                MessageBox.Show("Min cannot be greater then Max");
                
                return;
            }
            if (int.Parse(modifyProductStockTextBox.Text) > int.Parse(modifyProductMaxTextBox.Text) || int.Parse(modifyProductStockTextBox.Text) < int.Parse(modifyProductMinTextBox.Text))
            {
                MessageBox.Show("Inventory must be between max and min Inventory");
                
                return;
            }
            try
            {
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
                    
                    InStock = modProductInStock,
                    
                    Min = modProductMin,
                    
                    Max = modProductMax
                };
                
                foreach(Part part in addedParts)
                {
                    modifiedProduct.addAssociatedPart(part);
                }
                
                Inventory.updateProduct(modProductID, modifiedProduct);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min need to be numeric values");
            }

            Close();

        }

        private void modifyProductAddButton_Click(object sender, EventArgs e)
        {

            if (!modProductAvailableParts.CurrentRow.Selected)
            {
                MessageBox.Show("A part must be selected");
                
                return;
            }
            else
            {
                var partAddedToProduct = (Part)modProductAvailableParts.CurrentRow.DataBoundItem;
                
                addedParts.Add(partAddedToProduct);

            }     
        }

        private void modifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part? This action cannot be undone once completed.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in modProductsAssociatedParts.SelectedRows)
                {
                    modProductsAssociatedParts.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void modifyProductSearchButton_Click(object sender, EventArgs e)
        {

            int searchValue = int.Parse(modProductSearchBox.Text);

            if (searchValue < 1) return;
            
            Part matchedPart = Inventory.lookupPart(int.Parse(modProductSearchBox.Text));

            foreach (DataGridViewRow row in modProductAvailableParts.Rows)
            {

                Part part = (Part)row.DataBoundItem;
               
                if (part.PartID == matchedPart.PartID)
                {
                    row.Selected = true;
                    
                    break;
                }
                else
                {
                    row.Selected = false;
                }

            }
        }
    }
}
