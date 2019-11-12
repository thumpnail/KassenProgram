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
            this.checkBoxEnableAdvanced = new System.Windows.Forms.CheckBox();
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
            this.buttonGenerateID = new System.Windows.Forms.Button();
            this.checkBoxEnableEdit = new System.Windows.Forms.CheckBox();
            this.productSold = new System.Windows.Forms.TextBox();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelDateAdded = new System.Windows.Forms.Label();
            this.addedDate = new System.Windows.Forms.DateTimePicker();
            this.productMWST = new System.Windows.Forms.TextBox();
            // 
            // checkBoxEnableAdvanced
            // 
            this.checkBoxEnableAdvanced.AutoSize = true;
            this.checkBoxEnableAdvanced.Location = new System.Drawing.Point(5, 237);
            this.checkBoxEnableAdvanced.Name = "checkBoxEnableAdvanced";
            this.checkBoxEnableAdvanced.Size = new System.Drawing.Size(117, 19);
            this.checkBoxEnableAdvanced.TabIndex = 12;
            this.checkBoxEnableAdvanced.Text = "Enable Advanced";
            this.checkBoxEnableAdvanced.UseVisualStyleBackColor = true;
            this.checkBoxEnableAdvanced.CheckedChanged += new System.EventHandler(this.checkBoxEdvanced_CheckedChanged);
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
            this.productExpiryDate.Size = new System.Drawing.Size(250, 23);
            this.productExpiryDate.TabIndex = 9;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(159, 72);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.PlaceholderText = "Description";
            this.productDescription.Size = new System.Drawing.Size(381, 159);
            this.productDescription.TabIndex = 8;
            // 
            // productPrize
            // 
            this.productPrize.Location = new System.Drawing.Point(5, 171);
            this.productPrize.Name = "productPrize";
            this.productPrize.PlaceholderText = "Prize";
            this.productPrize.Size = new System.Drawing.Size(148, 23);
            this.productPrize.TabIndex = 7;
            // 
            // productStock
            // 
            this.productStock.Location = new System.Drawing.Point(5, 138);
            this.productStock.Name = "productStock";
            this.productStock.PlaceholderText = "Amount Stock";
            this.productStock.Size = new System.Drawing.Size(148, 23);
            this.productStock.TabIndex = 6;
            // 
            // productStore
            // 
            this.productStore.Location = new System.Drawing.Point(5, 105);
            this.productStore.Name = "productStore";
            this.productStore.PlaceholderText = "Amount Store";
            this.productStore.Size = new System.Drawing.Size(148, 23);
            this.productStore.TabIndex = 5;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(5, 72);
            this.productName.Name = "productName";
            this.productName.PlaceholderText = "Name";
            this.productName.Size = new System.Drawing.Size(148, 23);
            this.productName.TabIndex = 4;
            // 
            // productType
            // 
            this.productType.Location = new System.Drawing.Point(5, 39);
            this.productType.Name = "productType";
            this.productType.PlaceholderText = "Type";
            this.productType.Size = new System.Drawing.Size(148, 23);
            this.productType.TabIndex = 3;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(105, 6);
            this.productID.Name = "productID";
            this.productID.PlaceholderText = "ID";
            this.productID.Size = new System.Drawing.Size(48, 23);
            this.productID.TabIndex = 2;
            // 
            // buttonGenerateID
            // 
            this.buttonGenerateID.Location = new System.Drawing.Point(5, 4);
            this.buttonGenerateID.Name = "buttonGenerateID";
            this.buttonGenerateID.Size = new System.Drawing.Size(94, 29);
            this.buttonGenerateID.TabIndex = 1;
            this.buttonGenerateID.Text = "Gen ID";
            this.buttonGenerateID.UseVisualStyleBackColor = true;
            this.buttonGenerateID.Click += new System.EventHandler(this.generateID_Click);
            // 
            // checkBoxEnableEdit
            // 
            this.checkBoxEnableEdit.AutoSize = true;
            this.checkBoxEnableEdit.Location = new System.Drawing.Point(157, 237);
            this.checkBoxEnableEdit.Name = "checkBoxEnableEdit";
            this.checkBoxEnableEdit.Size = new System.Drawing.Size(84, 19);
            this.checkBoxEnableEdit.TabIndex = 13;
            this.checkBoxEnableEdit.Text = "Enable Edit";
            this.checkBoxEnableEdit.UseVisualStyleBackColor = true;
            this.checkBoxEnableEdit.CheckedChanged += new System.EventHandler(this.checkBoxEnableEdit_CheckedChanged);
            // 
            // productSold
            // 
            this.productSold.Location = new System.Drawing.Point(5, 204);
            this.productSold.Name = "productSold";
            this.productSold.PlaceholderText = "Sold";
            this.productSold.Size = new System.Drawing.Size(70, 23);
            this.productSold.TabIndex = 14;
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Location = new System.Drawing.Point(159, 8);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(66, 15);
            this.labelExpDate.TabIndex = 15;
            this.labelExpDate.Text = "Expiry Date";
            // 
            // labelDateAdded
            // 
            this.labelDateAdded.AutoSize = true;
            this.labelDateAdded.Location = new System.Drawing.Point(159, 42);
            this.labelDateAdded.Name = "labelDateAdded";
            this.labelDateAdded.Size = new System.Drawing.Size(69, 15);
            this.labelDateAdded.TabIndex = 16;
            this.labelDateAdded.Text = "Added Date";
            // 
            // addedDate
            // 
            this.addedDate.Location = new System.Drawing.Point(288, 39);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(250, 23);
            this.addedDate.TabIndex = 17;
            // 
            // productMWST
            // 
            this.productMWST.Location = new System.Drawing.Point(83, 204);
            this.productMWST.Name = "productMWST";
            this.productMWST.PlaceholderText = "Mwst";
            this.productMWST.Size = new System.Drawing.Size(70, 23);
            this.productMWST.TabIndex = 18;
            // 
            // viewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 274);
            this.Controls.Add(this.productMWST);
            this.Controls.Add(this.addedDate);
            this.Controls.Add(this.labelDateAdded);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.productSold);
            this.Controls.Add(this.checkBoxEnableEdit);
            this.Controls.Add(this.checkBoxEnableAdvanced);
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
            this.Controls.Add(this.buttonGenerateID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewProduct";
            this.Text = "viewProduct";
            this.Load += new System.EventHandler(this.viewProduct_Load);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEnableAdvanced;
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
        private System.Windows.Forms.Button buttonGenerateID;
        private System.Windows.Forms.CheckBox checkBoxEnableEdit;
        private System.Windows.Forms.TextBox productSold;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelDateAdded;
        private System.Windows.Forms.DateTimePicker addedDate;
        private System.Windows.Forms.TextBox productMWST;
    }
}