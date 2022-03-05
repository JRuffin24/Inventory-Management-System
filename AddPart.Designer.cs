namespace Inventory_Management_System
{
    partial class addPartForm
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartInHouse = new System.Windows.Forms.RadioButton();
            this.addPartOutsourced = new System.Windows.Forms.RadioButton();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMorCLabel = new System.Windows.Forms.Label();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMorCTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Location = new System.Drawing.Point(13, 13);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(48, 13);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartInHouse
            // 
            this.addPartInHouse.AutoSize = true;
            this.addPartInHouse.Location = new System.Drawing.Point(154, 13);
            this.addPartInHouse.Name = "addPartInHouse";
            this.addPartInHouse.Size = new System.Drawing.Size(68, 17);
            this.addPartInHouse.TabIndex = 1;
            this.addPartInHouse.TabStop = true;
            this.addPartInHouse.Text = "In-House";
            this.addPartInHouse.UseVisualStyleBackColor = true;
            this.addPartInHouse.CheckedChanged += new System.EventHandler(this.addPartInHouse_CheckedChanged);
            // 
            // addPartOutsourced
            // 
            this.addPartOutsourced.AutoSize = true;
            this.addPartOutsourced.Location = new System.Drawing.Point(288, 13);
            this.addPartOutsourced.Name = "addPartOutsourced";
            this.addPartOutsourced.Size = new System.Drawing.Size(80, 17);
            this.addPartOutsourced.TabIndex = 2;
            this.addPartOutsourced.TabStop = true;
            this.addPartOutsourced.Text = "Outsourced";
            this.addPartOutsourced.UseVisualStyleBackColor = true;
            this.addPartOutsourced.CheckedChanged += new System.EventHandler(this.addPartOutsourced_CheckedChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(121, 61);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addPartIDLabel.TabIndex = 3;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(107, 93);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addPartNameLabel.TabIndex = 4;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(104, 136);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addPartInventoryLabel.TabIndex = 5;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Location = new System.Drawing.Point(107, 171);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.addPartPriceLabel.TabIndex = 6;
            this.addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(104, 199);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addPartMaxLabel.TabIndex = 7;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(270, 206);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addPartMinLabel.TabIndex = 8;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMorCLabel
            // 
            this.addPartMorCLabel.AutoSize = true;
            this.addPartMorCLabel.Location = new System.Drawing.Point(104, 241);
            this.addPartMorCLabel.Name = "addPartMorCLabel";
            this.addPartMorCLabel.Size = new System.Drawing.Size(48, 13);
            this.addPartMorCLabel.TabIndex = 9;
            this.addPartMorCLabel.Text = "Machine";
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(255, 275);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addPartSaveButton.TabIndex = 10;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(354, 275);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addPartCancelButton.TabIndex = 11;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Location = new System.Drawing.Point(176, 54);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartIDTextBox.TabIndex = 12;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(176, 90);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartNameTextBox.TabIndex = 13;
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(176, 133);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartInventoryTextBox.TabIndex = 14;
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.Location = new System.Drawing.Point(176, 168);
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartPriceTextBox.TabIndex = 15;
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(176, 199);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(61, 20);
            this.addPartMaxTextBox.TabIndex = 16;
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Location = new System.Drawing.Point(320, 199);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(71, 20);
            this.addPartMinTextBox.TabIndex = 17;
            // 
            // addPartMorCTextBox
            // 
            this.addPartMorCTextBox.Location = new System.Drawing.Point(176, 241);
            this.addPartMorCTextBox.Name = "addPartMorCTextBox";
            this.addPartMorCTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartMorCTextBox.TabIndex = 18;
            // 
            // addPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 310);
            this.Controls.Add(this.addPartMorCTextBox);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.addPartMorCLabel);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartOutsourced);
            this.Controls.Add(this.addPartInHouse);
            this.Controls.Add(this.addPartLabel);
            this.Name = "addPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton addPartInHouse;
        private System.Windows.Forms.RadioButton addPartOutsourced;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.Label addPartMorCLabel;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartMorCTextBox;
    }
}