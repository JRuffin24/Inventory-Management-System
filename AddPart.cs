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
        Outsourced outSourced = new Outsourced();
        public static string partID { get; set; }
        
        
        
        //Inhouse part = null;
        public addPartForm()
        {
            InitializeComponent();
            addPartInHouse.Checked = true;
            addPartMorCLabel.Text = "Machine";
            autoGenerateID();
            addPartIDTextBox.ReadOnly = true;
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
            addPartIDTextBox.Text = (otp);

        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (addPartInHouse.Checked)
            {
                try
                {
                    var inHouseNewPart = new Inhouse
                    {
                        Name = addPartNameTextBox.Text,

                        PartID = Convert.ToInt32(addPartIDTextBox.Text),
                        Price = Convert.ToDecimal(addPartPriceTextBox.Text),
                        InStock = Convert.ToInt32(addPartInventoryTextBox.Text),
                        Min = Convert.ToInt32(addPartMinTextBox.Text),
                        Max = Convert.ToInt32(addPartMaxTextBox.Text),
                        MachineID = Convert.ToInt32(addPartMorCTextBox.Text)

                    };
                    Inventory.addPart(inHouseNewPart);
                }
                catch
                {
                    MessageBox.Show("Price, Inventory, Min, Max, and MachineID must be numbers");
                }
            }
            else if (addPartOutsourced.Checked)
            {
                try
                {
                    var outsourcedNewPart = new Outsourced
                    {
                        PartID = Convert.ToInt32(addPartIDTextBox.Text),
                        Name = addPartNameTextBox.Text,
                        Price = Convert.ToDecimal(addPartPriceTextBox.Text),
                        InStock = Convert.ToInt32(addPartInventoryTextBox.Text),
                        Min = Convert.ToInt32(addPartMinTextBox.Text),
                        Max = Convert.ToInt32(addPartMaxTextBox.Text),
                        CompanyID = Convert.ToInt32(addPartMorCTextBox.Text)
                    };
                    Inventory.addPart(outsourcedNewPart);
                }
                catch
                {
                    MessageBox.Show("Price, Inventory, Min, Max, and CompanyID must be numbers");
                }
                Close();
            }


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

        private void addPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            addPartMorCLabel.Text = "Company";
            
        }

        private void addPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            addPartMorCLabel.Text = "Machine";

        }
        
    }
}
