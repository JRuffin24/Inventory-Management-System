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
    
    public partial class addPartForm : Form

    {
        Inhouse inhouse = new Inhouse();
        public static string partID { get; set; }

        
        
        //Inhouse part = null;
        public addPartForm()
        {
            InitializeComponent();
      /*      addPartIDTextBox.ReadOnly = true;
            inhouse.PartID = Convert.ToInt32(addPartIDTextBox.Text);
            inhouse.Name = addPartNameTextBox.Text;
            inhouse.Price = Convert.ToDecimal(addPartPriceTextBox.Text);
            inhouse.InStock = Convert.ToInt32(addPartInventoryTextBox.Text);
            inhouse.Min = Convert.ToInt32(addPartMinTextBox.Text);
            inhouse.Max = Convert.ToInt32(addPartMaxTextBox.Text);
      */
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (addPartInHouse.Checked)
            {
                var inHouseNewPart = new Inhouse
                {
                    PartID = 2, 
                    Name = addPartNameTextBox.Text,
                    Price = Convert.ToDecimal(addPartPriceTextBox.Text),
                    InStock = Convert.ToInt32(addPartInventoryTextBox.Text),
                    Min = Convert.ToInt32(addPartMinTextBox.Text),
                    Max = Convert.ToInt32(addPartMaxTextBox.Text),
                    MachineID = Convert.ToInt32(addPartMachineIDTextBox.Text)
                };
                Inventory.addPart(inHouseNewPart);
            }
            else if (addPartOutsourced.Checked)
            {
                var outsourcedNewPart = new Outsourced
                {
                    PartID = Convert.ToInt32(addPartIDTextBox.Text),
                    Name = addPartNameTextBox.Text,
                    Price = Convert.ToDecimal(addPartPriceTextBox.Text),
                    InStock = Convert.ToInt32(addPartInventoryTextBox.Text),
                    Min = Convert.ToInt32(addPartMinTextBox.Text),
                    Max = Convert.ToInt32(addPartMaxTextBox.Text),
                    CompanyName = addPartMachineIDTextBox.Text
                };
            }
            
            Close();
        }

        private void addPartInventoryTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
