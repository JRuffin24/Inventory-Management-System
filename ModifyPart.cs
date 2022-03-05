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
            
            
            
        }
        private void modifyPart_Load(object sender, EventArgs e)
        {


            //if (mainScreenPartsDataGrid.SelectedRows.Count < 0) // make sure user select at least 1 row 
            //{
            //    modifyPartForm modifyForm = new modifyPartForm();
            //    for (int i = 0; i < mainScreenPartsDataGrid.SelectedRows.Count; i++)
            //    {
            //        modifyForm.modifyPartSaveButton.Enabled = false;
            //        if (modifyPartInHouseRadioButton.Checked)
            //        {
            //            var inHouseModifyPart = new Inhouse
            //            {
            //                modifyPartIDTextBox.Text = Convert.ToInt32(inHouseModifyPart.PartID),
            //                modifyPartNameTextBox.Text = inHouseModifyPart.Name,
            //                modifyPartInventoryTextBox.Text = Convert.ToInt32(inHouseModifyPart.InStock),
            //                modifyPartPriceTextBox.Text = Convert.ToDecimal(inHouseModifyPart.Price),
            //                modifyPartMaxTextBox.Text = Convert.ToInt32(inHouseModifyPart.Max),
            //                modifyPartMinTextBox.Text = Convert.ToInt32(inHouseModifyPart.Min),
            //                modifyPartMorCTextBox.Text = Convert.ToInt32(inHouseModifyPart.MachineID);
            //        }
            //    }
            }
        }


    }


