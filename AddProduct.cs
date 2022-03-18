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
    public partial class addProductForm : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public addProductForm()
        {
            InitializeComponent();
            productIDTextBox.ReadOnly = true;
            availablePartsDataGrid.DataSource = Inventory.AllParts;
            associatedPartsOfProductGrid.DataSource = addedParts;


            //create new bindinglist for bottom grid
            //set datasource of bottom grid to this binding list
            //in save routine at bottom, save addedPart to new bindingList

            availablePartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            availablePartsDataGrid.ReadOnly = true;
            availablePartsDataGrid.MultiSelect = false;
            availablePartsDataGrid.AllowUserToAddRows = false;
            availablePartsDataGrid.RowHeadersVisible = false;

            associatedPartsOfProductGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsOfProductGrid.ReadOnly = true;
            associatedPartsOfProductGrid.MultiSelect = false;
            associatedPartsOfProductGrid.AllowUserToAddRows = false;
            associatedPartsOfProductGrid.RowHeadersVisible = false;
            autoGenerateID();
        }
        
        public void autoGenerateID()
        {
            string num = "123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getindex;

            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                }
                while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }
            productIDTextBox.Text = (otp);

        }
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            //loop through bottom grid, casting each row as a part
            //In the loop, add each part to my newly addedProduct


            Part partToAdd = (Part)associatedPartsOfProductGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partToAdd);


            if (int.Parse(addProductMinTextBox.Text) > int.Parse(addProductMaxTextBox.Text))
            {
                MessageBox.Show("Min cannot be greater then Max");
                return;
            }
            if (int.Parse(addProductInventoryTextBox.Text) > int.Parse(addProductMaxTextBox.Text) || int.Parse(addProductInventoryTextBox.Text) < int.Parse(addProductMinTextBox.Text))
            {
                MessageBox.Show("Inventory must be between max and min Inventory");
                return;
            }

            try
            {
                var addedProduct = new Product
                {
                    InStock = int.Parse(addProductInventoryTextBox.Text),
                    Min = int.Parse(addProductMinTextBox.Text),
                    Max = int.Parse(addProductMaxTextBox.Text),
                    Price = decimal.Parse(addProductPriceTextBox.Text),
                    Name = addProductNameTextBox.Text,
                    ProductID = int.Parse(productIDTextBox.Text)
                };

                Inventory.addProduct(addedProduct);

                //foreach (DataGridViewRow row in associatedPartsOfProductGrid.Rows)
                ////foreach (Part part in addedParts)
                //{

                //    //Part part = (Part)row.DataBoundItem;

                //    //Product.addAssociatedPart(part);
                //    Inventory.addProduct(addedProduct);

                //}
            }

            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min need to be numeric values");
            }
            Close();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void availablePartsDataGrid_CellClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentIndexUpper = e.RowIndex;
                availablePartsDataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            }
            else
            {

            }
        }

        private void addProductAddPartButton_Click(object sender, EventArgs e)
        {
            // check if nothing has been selected in top grid
            //if nothing is selected, message box prompts to select a part
            // else 
            //cast current row as part 
            // add part to associatedParts binding list

            if (!availablePartsDataGrid.CurrentRow.Selected)
            {
                MessageBox.Show("A part must be selected");
                return;
            }
            else
            {
                var partAddedToProduct = (Part)availablePartsDataGrid.CurrentRow.DataBoundItem;
                addedParts.Add(partAddedToProduct);
                
            }

        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(addProductSearchBox.Text);

            if (searchValue < 1) return;
            Part matchedPart = Inventory.lookupPart(int.Parse(addProductSearchBox.Text));

            foreach (DataGridViewRow row in availablePartsDataGrid.Rows)
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

        private void AddProductDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part? This action cannot be undone once completed.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in associatedPartsOfProductGrid.SelectedRows)
                {
                    associatedPartsOfProductGrid.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }
    }
  }

