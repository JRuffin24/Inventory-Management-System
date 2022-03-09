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
        //Inhouse inhouse = new Inhouse();
        //Outsourced outSourced = new Outsourced();


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

            if(part is Inhouse) 
            {
                var inhousePart = (Inhouse)part;
                modifyPartsMorCLabel.Text = "Machine ID";
                modifyPartInHouseRadioButton.Checked = true;
                modifyPartMorCTextBox.Text = inhousePart.MachineID.ToString();
            }
            else
            {
                var outsourcedPart = (Outsourced)part;
                modifyPartsMorCLabel.Text = "Company ID";
                modifyPartInHouseRadioButton.Checked = true;
                modifyPartMorCTextBox.Text = outsourcedPart.CompanyID.ToString();

            }
            

        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {

            int PartID = 1;

            if (modifyPartInHouseRadioButton.Checked)
            {
                var inHouseModifyPart = new Inhouse
                {
                    PartID = int.Parse(modifyPartIDTextBox.Text),
                    Name = modifyPartNameTextBox.Text,
                    Price = Decimal.Parse(modifyPartPriceTextBox.Text),
                    InStock = int.Parse(modifyPartInventoryTextBox.Text),
                    Min = int.Parse(modifyPartMinTextBox.Text),
                    Max = int.Parse(modifyPartMaxTextBox.Text),
                    MachineID = int.Parse(modifyPartMorCTextBox.Text)
                    
                };
                Inventory.updatePart(PartID,inHouseModifyPart);
                
            }
            else if (modifyPartOutsourcedRadioButton.Checked)
            {

                var outsourcedModifyPart = new Outsourced
                {
                    PartID = int.Parse(modifyPartIDTextBox.Text),
                    Name = modifyPartNameTextBox.Text,
                    Price = Decimal.Parse(modifyPartPriceTextBox.Text),
                    InStock = int.Parse(modifyPartInventoryTextBox.Text),
                    Min = int.Parse(modifyPartMinTextBox.Text),
                    Max = int.Parse(modifyPartMaxTextBox.Text),
                    CompanyID = int.Parse(modifyPartMorCTextBox.Text)
                }; 
                Inventory.updatePart(PartID,outsourcedModifyPart);
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


