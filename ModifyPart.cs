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
    public partial class modifyPartForm : Form
    {
        Inhouse inhouse = new Inhouse();
        Outsourced outSourced = new Outsourced();


        public modifyPartForm()
        {
            InitializeComponent();
        }

        public modifyPartForm(Part part)
        {
            InitializeComponent();
            modifyPartIDTextBox.Text = part.PartID.ToString();
            modifyPartNameTextBox.Text = part.Name;
            modifyPartInventoryTextBox.Text = part.InStock.ToString();
            modifyPartPriceTextBox.Text = part.Price.ToString();
            modifyPartMaxTextBox.Text = part.Max.ToString();
            modifyPartMinTextBox.Text = part.Min.ToString();
            //                modifyPartMorCTextBox.Text = Convert.ToInt32(part.MachineID);

        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {

            if (modifyPartInHouseRadioButton.Checked)
            {
                var inHouseNewPart = new Inhouse
                {
                    PartID = Convert.ToInt32(modifyPartIDTextBox.Text),
                    Name = modifyPartNameTextBox.Text,
                    Price = Convert.ToDecimal(modifyPartPriceTextBox.Text),
                    InStock = Convert.ToInt32(modifyPartInventoryTextBox.Text),
                    Min = Convert.ToInt32(modifyPartMinTextBox.Text),
                    Max = Convert.ToInt32(modifyPartMaxTextBox.Text),
                    MachineID = Convert.ToInt32(modifyPartMorCTextBox.Text)
                };
                //Inventory.addPart(inHouseNewPart);
            }
            else if (modifyPartOutsourcedRadioButton.Checked)
            {

                var outsourcedNewPart = new Outsourced
                {
                    PartID = Convert.ToInt32(modifyPartIDTextBox.Text),
                    Name = modifyPartNameTextBox.Text,
                    Price = Convert.ToDecimal(modifyPartPriceTextBox.Text),
                    InStock = Convert.ToInt32(modifyPartInventoryTextBox.Text),
                    Min = Convert.ToInt32(modifyPartMinTextBox.Text),
                    Max = Convert.ToInt32(modifyPartMaxTextBox.Text),
                    CompanyID = Convert.ToInt32(modifyPartMorCTextBox.Text)
                };
                //Inventory.addPart(outsourcedNewPart);
            }

            Close();

        }
        private void modifyPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartsMorCLabel.Text = "Company";

        }

        private void modifyPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartsMorCLabel.Text = "Machine";

        }
    }

}


