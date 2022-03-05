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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            //set the data source
            mainScreenPartsDataGrid.DataSource = Inventory.AllParts;
           // mainScreenDataGridProducts.DataSource = Program.products;


            //sets the selection mode to full row instead of individual cell
            mainScreenPartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Make grid read only
            mainScreenPartsDataGrid.ReadOnly = true;

            //Turn off multiselect
            mainScreenPartsDataGrid.MultiSelect = false;

            //remove bottom empty row
            mainScreenPartsDataGrid.AllowUserToAddRows = false;
        }
       
        //clear selection upon data load
         private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mainScreenPartsDataGrid.ClearSelection();
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

        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            addProductForm addProduct = new addProductForm();
            addProduct.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            modifyProductForm modifyProduct = new modifyProductForm();
            modifyProduct.ShowDialog();
        }
    }
}
