﻿using System;
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
        public modifyProductForm()
        {
            InitializeComponent();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
