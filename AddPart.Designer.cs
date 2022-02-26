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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMachineIDTextBox = new System.Windows.Forms.TextBox();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price / Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Machine";
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
            // addPartMachineIDTextBox
            // 
            this.addPartMachineIDTextBox.Location = new System.Drawing.Point(176, 241);
            this.addPartMachineIDTextBox.Name = "addPartMachineIDTextBox";
            this.addPartMachineIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartMachineIDTextBox.TabIndex = 18;
            // 
            // addPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 310);
            this.Controls.Add(this.addPartMachineIDTextBox);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartOutsourced);
            this.Controls.Add(this.addPartInHouse);
            this.Controls.Add(this.addPartLabel);
            this.Name = "addPartForm";
            this.Text = "Add a Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton addPartInHouse;
        private System.Windows.Forms.RadioButton addPartOutsourced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartMachineIDTextBox;
    }
}