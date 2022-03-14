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
        public addProductForm()
        {
            InitializeComponent();
            productIDTextBox.ReadOnly = true;
            availablePartsDataGrid.DataSource = Inventory.AllParts;
            associatedPartsOfProductGrid.DataSource = Product.AssociatedParts;
            availablePartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            availablePartsDataGrid.ReadOnly = true;
            availablePartsDataGrid.MultiSelect = false;
            availablePartsDataGrid.AllowUserToAddRows = false;
            availablePartsDataGrid.RowHeadersVisible = false;
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

        private void addProductAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
