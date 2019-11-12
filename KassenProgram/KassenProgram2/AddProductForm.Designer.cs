namespace KassenProgram {
    partial class AddProductForm {
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
            this.generateID = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.TextBox();
            this.productType = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productAmountStore = new System.Windows.Forms.TextBox();
            this.productAmountStock = new System.Windows.Forms.TextBox();
            this.productPrize = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.productExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxEdvanced = new System.Windows.Forms.CheckBox();
            this.productMWST = new System.Windows.Forms.TextBox();
            // 
            // generateID
            // 
            this.generateID.Location = new System.Drawing.Point(4, 4);
            this.generateID.Name = "generateID";
            this.generateID.Size = new System.Drawing.Size(94, 29);
            this.generateID.TabIndex = 1;
            this.generateID.Text = "Gen ID";
            this.generateID.UseVisualStyleBackColor = true;
            this.generateID.Click += new System.EventHandler(this.generateID_Click);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(104, 6);
            this.productID.Name = "productID";
            this.productID.PlaceholderText = "ID";
            this.productID.Size = new System.Drawing.Size(48, 23);
            this.productID.TabIndex = 2;
            // 
            // productType
            // 
            this.productType.Location = new System.Drawing.Point(4, 39);
            this.productType.Name = "productType";
            this.productType.PlaceholderText = "Type";
            this.productType.Size = new System.Drawing.Size(148, 23);
            this.productType.TabIndex = 3;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(4, 72);
            this.productName.Name = "productName";
            this.productName.PlaceholderText = "Name";
            this.productName.Size = new System.Drawing.Size(148, 23);
            this.productName.TabIndex = 4;
            // 
            // productAmountStore
            // 
            this.productAmountStore.Location = new System.Drawing.Point(4, 105);
            this.productAmountStore.Name = "productAmountStore";
            this.productAmountStore.PlaceholderText = "Amount Store";
            this.productAmountStore.Size = new System.Drawing.Size(148, 23);
            this.productAmountStore.TabIndex = 5;
            // 
            // productAmountStock
            // 
            this.productAmountStock.Location = new System.Drawing.Point(4, 138);
            this.productAmountStock.Name = "productAmountStock";
            this.productAmountStock.PlaceholderText = "Amount Stock";
            this.productAmountStock.Size = new System.Drawing.Size(148, 23);
            this.productAmountStock.TabIndex = 6;
            // 
            // productPrize
            // 
            this.productPrize.Location = new System.Drawing.Point(4, 171);
            this.productPrize.Name = "productPrize";
            this.productPrize.PlaceholderText = "Prize";
            this.productPrize.Size = new System.Drawing.Size(70, 23);
            this.productPrize.TabIndex = 7;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(158, 39);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.PlaceholderText = "Description";
            this.productDescription.Size = new System.Drawing.Size(249, 159);
            this.productDescription.TabIndex = 8;
            // 
            // productExpiryDate
            // 
            this.productExpiryDate.Location = new System.Drawing.Point(158, 6);
            this.productExpiryDate.Name = "productExpiryDate";
            this.productExpiryDate.Size = new System.Drawing.Size(249, 23);
            this.productExpiryDate.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(313, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(213, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxEdvanced
            // 
            this.checkBoxEdvanced.AutoSize = true;
            this.checkBoxEdvanced.Location = new System.Drawing.Point(4, 204);
            this.checkBoxEdvanced.Name = "checkBoxEdvanced";
            this.checkBoxEdvanced.Size = new System.Drawing.Size(117, 19);
            this.checkBoxEdvanced.TabIndex = 12;
            this.checkBoxEdvanced.Text = "Enable Advanced";
            this.checkBoxEdvanced.UseVisualStyleBackColor = true;
            this.checkBoxEdvanced.CheckedChanged += new System.EventHandler(this.checkBoxEdvanced_CheckedChanged);
            // 
            // productMWST
            // 
            this.productMWST.Location = new System.Drawing.Point(82, 171);
            this.productMWST.Name = "productMWST";
            this.productMWST.PlaceholderText = "Mwst";
            this.productMWST.Size = new System.Drawing.Size(70, 23);
            this.productMWST.TabIndex = 13;
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(415, 236);
            this.Controls.Add(this.productMWST);
            this.Controls.Add(this.checkBoxEdvanced);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.productExpiryDate);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productPrize);
            this.Controls.Add(this.productAmountStock);
            this.Controls.Add(this.productAmountStore);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.generateID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);

        }

        #endregion

        private System.Windows.Forms.Button generateID;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.TextBox productType;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productAmountStore;
        private System.Windows.Forms.TextBox productAmountStock;
        private System.Windows.Forms.TextBox productPrize;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.DateTimePicker productExpiryDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxEdvanced;
        private System.Windows.Forms.TextBox productMWST;
    }
}