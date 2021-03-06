namespace Inventory_Management_System
{
    partial class addProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProductLabel = new System.Windows.Forms.Label();
            this.addProductIDLabel = new System.Windows.Forms.Label();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductMaxPriceLabel = new System.Windows.Forms.Label();
            this.addProductMinPriceLabel = new System.Windows.Forms.Label();
            this.addProductAddPartButton = new System.Windows.Forms.Button();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            this.addProductSearchBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.allCandidatePartsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.availablePartsDataGrid = new System.Windows.Forms.DataGridView();
            this.associatedPartsOfProductGrid = new System.Windows.Forms.DataGridView();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.AddProductDeletePart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsOfProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Location = new System.Drawing.Point(24, 23);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(66, 13);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // addProductIDLabel
            // 
            this.addProductIDLabel.AutoSize = true;
            this.addProductIDLabel.Location = new System.Drawing.Point(16, 79);
            this.addProductIDLabel.Name = "addProductIDLabel";
            this.addProductIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addProductIDLabel.TabIndex = 3;
            this.addProductIDLabel.Text = "ID";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Location = new System.Drawing.Point(13, 128);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addProductNameLabel.TabIndex = 4;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Location = new System.Drawing.Point(12, 169);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addProductInventoryLabel.TabIndex = 5;
            this.addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Location = new System.Drawing.Point(19, 216);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.addProductPriceLabel.TabIndex = 6;
            this.addProductPriceLabel.Text = "Price";
            // 
            // addProductMaxPriceLabel
            // 
            this.addProductMaxPriceLabel.AutoSize = true;
            this.addProductMaxPriceLabel.Location = new System.Drawing.Point(12, 258);
            this.addProductMaxPriceLabel.Name = "addProductMaxPriceLabel";
            this.addProductMaxPriceLabel.Size = new System.Drawing.Size(27, 13);
            this.addProductMaxPriceLabel.TabIndex = 7;
            this.addProductMaxPriceLabel.Text = "Max";
            // 
            // addProductMinPriceLabel
            // 
            this.addProductMinPriceLabel.AutoSize = true;
            this.addProductMinPriceLabel.Location = new System.Drawing.Point(138, 258);
            this.addProductMinPriceLabel.Name = "addProductMinPriceLabel";
            this.addProductMinPriceLabel.Size = new System.Drawing.Size(24, 13);
            this.addProductMinPriceLabel.TabIndex = 8;
            this.addProductMinPriceLabel.Text = "Min";
            // 
            // addProductAddPartButton
            // 
            this.addProductAddPartButton.Location = new System.Drawing.Point(664, 206);
            this.addProductAddPartButton.Name = "addProductAddPartButton";
            this.addProductAddPartButton.Size = new System.Drawing.Size(75, 23);
            this.addProductAddPartButton.TabIndex = 9;
            this.addProductAddPartButton.Text = "Add";
            this.addProductAddPartButton.UseVisualStyleBackColor = true;
            this.addProductAddPartButton.Click += new System.EventHandler(this.addProductAddPartButton_Click);
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Location = new System.Drawing.Point(346, 21);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSearchButton.TabIndex = 10;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            this.addProductSearchButton.Click += new System.EventHandler(this.addProductSearchButton_Click);
            // 
            // addProductSearchBox
            // 
            this.addProductSearchBox.Location = new System.Drawing.Point(444, 23);
            this.addProductSearchBox.Name = "addProductSearchBox";
            this.addProductSearchBox.Size = new System.Drawing.Size(124, 20);
            this.addProductSearchBox.TabIndex = 11;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(82, 76);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIDTextBox.TabIndex = 12;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(82, 128);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameTextBox.TabIndex = 13;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(82, 166);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInventoryTextBox.TabIndex = 14;
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Location = new System.Drawing.Point(82, 213);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductPriceTextBox.TabIndex = 15;
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Location = new System.Drawing.Point(57, 255);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(56, 20);
            this.addProductMaxTextBox.TabIndex = 16;
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Location = new System.Drawing.Point(188, 255);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(56, 20);
            this.addProductMinTextBox.TabIndex = 17;
            // 
            // allCandidatePartsLabel
            // 
            this.allCandidatePartsLabel.AutoSize = true;
            this.allCandidatePartsLabel.Location = new System.Drawing.Point(262, 53);
            this.allCandidatePartsLabel.Name = "allCandidatePartsLabel";
            this.allCandidatePartsLabel.Size = new System.Drawing.Size(96, 13);
            this.allCandidatePartsLabel.TabIndex = 18;
            this.allCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Parts Associated with this product:";
            // 
            // availablePartsDataGrid
            // 
            this.availablePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availablePartsDataGrid.Location = new System.Drawing.Point(264, 76);
            this.availablePartsDataGrid.Name = "availablePartsDataGrid";
            this.availablePartsDataGrid.RowHeadersWidth = 102;
            this.availablePartsDataGrid.Size = new System.Drawing.Size(475, 124);
            this.availablePartsDataGrid.TabIndex = 20;
            // 
            // associatedPartsOfProductGrid
            // 
            this.associatedPartsOfProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsOfProductGrid.Location = new System.Drawing.Point(265, 235);
            this.associatedPartsOfProductGrid.Name = "associatedPartsOfProductGrid";
            this.associatedPartsOfProductGrid.RowHeadersWidth = 102;
            this.associatedPartsOfProductGrid.Size = new System.Drawing.Size(474, 144);
            this.associatedPartsOfProductGrid.TabIndex = 21;
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(356, 444);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSaveButton.TabIndex = 22;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(463, 444);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addProductCancelButton.TabIndex = 23;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // AddProductDeletePart
            // 
            this.AddProductDeletePart.Location = new System.Drawing.Point(664, 385);
            this.AddProductDeletePart.Name = "AddProductDeletePart";
            this.AddProductDeletePart.Size = new System.Drawing.Size(75, 23);
            this.AddProductDeletePart.TabIndex = 24;
            this.AddProductDeletePart.Text = "Delete";
            this.AddProductDeletePart.UseVisualStyleBackColor = true;
            this.AddProductDeletePart.Click += new System.EventHandler(this.AddProductDeletePart_Click);
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 479);
            this.Controls.Add(this.AddProductDeletePart);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.associatedPartsOfProductGrid);
            this.Controls.Add(this.availablePartsDataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.allCandidatePartsLabel);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.addProductSearchBox);
            this.Controls.Add(this.addProductSearchButton);
            this.Controls.Add(this.addProductAddPartButton);
            this.Controls.Add(this.addProductMinPriceLabel);
            this.Controls.Add(this.addProductMaxPriceLabel);
            this.Controls.Add(this.addProductPriceLabel);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductIDLabel);
            this.Controls.Add(this.addProductLabel);
            this.Name = "addProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsOfProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label addProductIDLabel;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.Label addProductMaxPriceLabel;
        private System.Windows.Forms.Label addProductMinPriceLabel;
        private System.Windows.Forms.Button addProductAddPartButton;
        private System.Windows.Forms.Button addProductSearchButton;
        private System.Windows.Forms.TextBox addProductSearchBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.Label allCandidatePartsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView availablePartsDataGrid;
        private System.Windows.Forms.DataGridView associatedPartsOfProductGrid;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button AddProductDeletePart;
    }
}