using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public partial class mainForm : Form
    {
        Inhouse inhouse = new Inhouse();
        Outsourced outsourced = new Outsourced();
        public mainForm()
        {
            InitializeComponent();

            //set the data source
            mainScreenPartsDataGrid.DataSource = Inventory.AllParts;
            mainScreenDataGridProducts.DataSource = Program.products;


            //sets the selection mode to full row instead of individual cell
            mainScreenPartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainScreenDataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Make grid read only
            mainScreenPartsDataGrid.ReadOnly = true;
            mainScreenDataGridProducts.ReadOnly = true;

            //Turn off multiselect
            mainScreenPartsDataGrid.MultiSelect = false;
            mainScreenDataGridProducts.MultiSelect = false;

            //remove bottom empty row
            mainScreenPartsDataGrid.AllowUserToAddRows = false;
            mainScreenDataGridProducts.AllowUserToAddRows = false;

            //removing first column
            mainScreenPartsDataGrid.RowHeadersVisible = false;
            mainScreenDataGridProducts.RowHeadersVisible = false;
        }
        public mainForm(Part part)
        {
            partSearchTextBox.Text = part.PartID.ToString();
            InitializeComponent();
        }

        //clear selection upon data load
        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mainScreenPartsDataGrid.ClearSelection();
            mainScreenDataGridProducts.ClearSelection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addParts_Click(object sender, EventArgs e)
        {
            addPartForm addForm = new addPartForm();
            addForm.ShowDialog();

        }

        private void modifyParts_Click(object sender, EventArgs e)
        {
            if (mainScreenPartsDataGrid.SelectedRows.Count > 0)
            {
                var selectedPart = (Part)mainScreenPartsDataGrid.CurrentRow.DataBoundItem;

                modifyPartForm modifyForm = new modifyPartForm(selectedPart);

                modifyForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a part.");
            }


        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part? This action cannot be undone once completed.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in mainScreenPartsDataGrid.SelectedRows)
                {
                    mainScreenPartsDataGrid.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            addProductForm addProduct = new addProductForm();
            addProduct.ShowDialog();


        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if (mainScreenDataGridProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)mainScreenDataGridProducts.CurrentRow.DataBoundItem;

                modifyProductForm modifyProduct = new modifyProductForm(selectedProduct);

                modifyProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }
       
        //trying to search for a part
        private void partsSearch_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(partSearchTextBox.Text);

            if (searchValue < 1) return;
            Part matchedPart = Inventory.lookupPart(int.Parse(partSearchTextBox.Text));

            foreach (DataGridViewRow row in mainScreenPartsDataGrid.Rows)
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

        private void productSearch_Click(object sender, EventArgs e)
        {

            int searchValue = int.Parse(productsSearchTextBox.Text);
            if (searchValue < 1) return;

            Product matchedProduct = Inventory.lookupProduct(int.Parse(productsSearchTextBox.Text));

            foreach (DataGridViewRow row in mainScreenDataGridProducts.Rows)
            {

                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == matchedProduct.ProductID)
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



        

