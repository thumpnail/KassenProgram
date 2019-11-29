namespace KassenProgram {
    partial class viewProduct {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.productExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.productPrize = new System.Windows.Forms.TextBox();
            this.productStock = new System.Windows.Forms.TextBox();
            this.productStore = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productType = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.checkBoxEnableEdit = new System.Windows.Forms.CheckBox();
            this.productSold = new System.Windows.Forms.TextBox();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelDateAdded = new System.Windows.Forms.Label();
            this.addedDate = new System.Windows.Forms.DateTimePicker();
            this.productMWST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(346, 237);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(446, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // productExpiryDate
            // 
            this.productExpiryDate.Location = new System.Drawing.Point(288, 6);
            this.productExpiryDate.Name = "productExpiryDate";
            this.productExpiryDate.Size = new System.Drawing.Size(250, 27);
            this.productExpiryDate.TabIndex = 9;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(157, 70);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.PlaceholderText = "Description";
            this.productDescription.Size = new System.Drawing.Size(381, 159);
            this.productDescription.TabIndex = 8;
            // 
            // productPrize
            // 
            this.productPrize.Location = new System.Drawing.Point(83, 171);
            this.productPrize.Name = "productPrize";
            this.productPrize.PlaceholderText = "Prize";
            this.productPrize.Size = new System.Drawing.Size(70, 27);
            this.productPrize.TabIndex = 7;
            // 
            // productStock
            // 
            this.productStock.Location = new System.Drawing.Point(83, 138);
            this.productStock.Name = "productStock";
            this.productStock.PlaceholderText = "in Stock";
            this.productStock.Size = new System.Drawing.Size(70, 27);
            this.productStock.TabIndex = 6;
            // 
            // productStore
            // 
            this.productStore.Location = new System.Drawing.Point(83, 105);
            this.productStore.Name = "productStore";
            this.productStore.PlaceholderText = "in Store";
            this.productStore.Size = new System.Drawing.Size(70, 27);
            this.productStore.TabIndex = 5;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(83, 72);
            this.productName.Name = "productName";
            this.productName.PlaceholderText = "Name";
            this.productName.Size = new System.Drawing.Size(70, 27);
            this.productName.TabIndex = 4;
            // 
            // productType
            // 
            this.productType.Location = new System.Drawing.Point(83, 39);
            this.productType.Name = "productType";
            this.productType.PlaceholderText = "Type";
            this.productType.Size = new System.Drawing.Size(70, 27);
            this.productType.TabIndex = 3;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(83, 6);
            this.productID.Name = "productID";
            this.productID.PlaceholderText = "ID";
            this.productID.Size = new System.Drawing.Size(70, 27);
            this.productID.TabIndex = 2;
            // 
            // checkBoxEnableEdit
            // 
            this.checkBoxEnableEdit.AutoSize = true;
            this.checkBoxEnableEdit.Location = new System.Drawing.Point(159, 237);
            this.checkBoxEnableEdit.Name = "checkBoxEnableEdit";
            this.checkBoxEnableEdit.Size = new System.Drawing.Size(106, 24);
            this.checkBoxEnableEdit.TabIndex = 13;
            this.checkBoxEnableEdit.Text = "Enable Edit";
            this.checkBoxEnableEdit.UseVisualStyleBackColor = true;
            this.checkBoxEnableEdit.CheckedChanged += new System.EventHandler(this.checkBoxEnableEdit_CheckedChanged);
            // 
            // productSold
            // 
            this.productSold.Location = new System.Drawing.Point(83, 235);
            this.productSold.Name = "productSold";
            this.productSold.PlaceholderText = "Sold";
            this.productSold.Size = new System.Drawing.Size(70, 27);
            this.productSold.TabIndex = 14;
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Location = new System.Drawing.Point(159, 8);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(85, 20);
            this.labelExpDate.TabIndex = 15;
            this.labelExpDate.Text = "Expiry Date";
            // 
            // labelDateAdded
            // 
            this.labelDateAdded.AutoSize = true;
            this.labelDateAdded.Location = new System.Drawing.Point(159, 42);
            this.labelDateAdded.Name = "labelDateAdded";
            this.labelDateAdded.Size = new System.Drawing.Size(90, 20);
            this.labelDateAdded.TabIndex = 16;
            this.labelDateAdded.Text = "Added Date";
            // 
            // addedDate
            // 
            this.addedDate.Location = new System.Drawing.Point(288, 39);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(250, 27);
            this.addedDate.TabIndex = 17;
            this.addedDate.ValueChanged += new System.EventHandler(this.addedDate_ValueChanged);
            // 
            // productMWST
            // 
            this.productMWST.Location = new System.Drawing.Point(83, 204);
            this.productMWST.Name = "productMWST";
            this.productMWST.PlaceholderText = "Mwst";
            this.productMWST.Size = new System.Drawing.Size(70, 27);
            this.productMWST.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "In Store:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "In Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prize";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "MWST:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sold:";
            // 
            // viewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 274);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productMWST);
            this.Controls.Add(this.addedDate);
            this.Controls.Add(this.labelDateAdded);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.productSold);
            this.Controls.Add(this.checkBoxEnableEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.productExpiryDate);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productPrize);
            this.Controls.Add(this.productStock);
            this.Controls.Add(this.productStore);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewProduct";
            this.Text = "viewProduct";
            this.Load += new System.EventHandler(this.viewProduct_Load);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker productExpiryDate;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.TextBox productPrize;
        private System.Windows.Forms.TextBox productStock;
        private System.Windows.Forms.TextBox productStore;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productType;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.CheckBox checkBoxEnableEdit;
        private System.Windows.Forms.TextBox productSold;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelDateAdded;
        private System.Windows.Forms.DateTimePicker addedDate;
        private System.Windows.Forms.TextBox productMWST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}