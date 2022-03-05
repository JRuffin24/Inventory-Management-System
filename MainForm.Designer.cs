namespace Inventory_Management_System
{
    partial class mainForm
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
            this.partsSearch = new System.Windows.Forms.Button();
            this.productSearch = new System.Windows.Forms.Button();
            this.addParts = new System.Windows.Forms.Button();
            this.modifyParts = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProducts = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainScreenPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.mainScreenDataGridProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenDataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(174, 63);
            this.partsSearch.Margin = new System.Windows.Forms.Padding(2);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(55, 28);
            this.partsSearch.TabIndex = 0;
            this.partsSearch.Text = "Search";
            this.partsSearch.UseVisualStyleBackColor = true;
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(603, 63);
            this.productSearch.Margin = new System.Windows.Forms.Padding(2);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(54, 33);
            this.productSearch.TabIndex = 1;
            this.productSearch.Text = "Search";
            this.productSearch.UseVisualStyleBackColor = true;
            // 
            // addParts
            // 
            this.addParts.Location = new System.Drawing.Point(206, 326);
            this.addParts.Margin = new System.Windows.Forms.Padding(2);
            this.addParts.Name = "addParts";
            this.addParts.Size = new System.Drawing.Size(48, 32);
            this.addParts.TabIndex = 2;
            this.addParts.Text = "Add";
            this.addParts.UseVisualStyleBackColor = true;
            this.addParts.Click += new System.EventHandler(this.addParts_Click);
            // 
            // modifyParts
            // 
            this.modifyParts.Location = new System.Drawing.Point(274, 326);
            this.modifyParts.Margin = new System.Windows.Forms.Padding(2);
            this.modifyParts.Name = "modifyParts";
            this.modifyParts.Size = new System.Drawing.Size(46, 33);
            this.modifyParts.TabIndex = 3;
            this.modifyParts.Text = "Modify";
            this.modifyParts.UseVisualStyleBackColor = true;
            this.modifyParts.Click += new System.EventHandler(this.modifyParts_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(339, 327);
            this.deletePart.Margin = new System.Windows.Forms.Padding(2);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(46, 32);
            this.deletePart.TabIndex = 4;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addProducts
            // 
            this.addProducts.Location = new System.Drawing.Point(630, 326);
            this.addProducts.Margin = new System.Windows.Forms.Padding(2);
            this.addProducts.Name = "addProducts";
            this.addProducts.Size = new System.Drawing.Size(53, 33);
            this.addProducts.TabIndex = 5;
            this.addProducts.Text = "Add";
            this.addProducts.UseVisualStyleBackColor = true;
            this.addProducts.Click += new System.EventHandler(this.addProducts_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(695, 326);
            this.modifyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(48, 33);
            this.modifyProduct.TabIndex = 6;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(755, 326);
            this.deleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(48, 33);
            this.deleteProduct.TabIndex = 7;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inventory Management System";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(670, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Products";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(756, 413);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(48, 32);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainScreenPartsDataGrid
            // 
            this.mainScreenPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainScreenPartsDataGrid.Location = new System.Drawing.Point(26, 114);
            this.mainScreenPartsDataGrid.Name = "mainScreenPartsDataGrid";
            this.mainScreenPartsDataGrid.Size = new System.Drawing.Size(375, 183);
            this.mainScreenPartsDataGrid.TabIndex = 16;
            this.mainScreenPartsDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // mainScreenDataGridProducts
            // 
            this.mainScreenDataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainScreenDataGridProducts.Location = new System.Drawing.Point(443, 114);
            this.mainScreenDataGridProducts.Name = "mainScreenDataGridProducts";
            this.mainScreenDataGridProducts.Size = new System.Drawing.Size(363, 183);
            this.mainScreenDataGridProducts.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 914);
            this.Controls.Add(this.mainScreenDataGridProducts);
            this.Controls.Add(this.mainScreenPartsDataGrid);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProducts);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyParts);
            this.Controls.Add(this.addParts);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partsSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenDataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button partsSearch;
        private System.Windows.Forms.Button productSearch;
        private System.Windows.Forms.Button addParts;
        private System.Windows.Forms.Button modifyParts;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProducts;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView mainScreenPartsDataGrid;
        private System.Windows.Forms.DataGridView mainScreenDataGridProducts;
    }
}

