namespace KassenProgram {
    partial class MainForm {
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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.buttonViewSelected = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(1226, 12);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(202, 34);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 12);
            this.listView2.Name = "mainListView";
            this.listView2.Size = new System.Drawing.Size(1203, 747);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // buttonViewSelected
            // 
            this.buttonViewSelected.Location = new System.Drawing.Point(1226, 52);
            this.buttonViewSelected.Name = "buttonViewSelected";
            this.buttonViewSelected.Size = new System.Drawing.Size(202, 34);
            this.buttonViewSelected.TabIndex = 4;
            this.buttonViewSelected.Text = "View Selected  Item";
            this.buttonViewSelected.UseVisualStyleBackColor = true;
            this.buttonViewSelected.Click += new System.EventHandler(this.buttonViewSelected_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(1226, 92);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(202, 34);
            this.buttonDeleteSelected.TabIndex = 5;
            this.buttonDeleteSelected.Text = "Delete Selected Item";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1226, 730);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(94, 29);
            this.Update.TabIndex = 6;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 775);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonViewSelected);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.buttonAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonViewSelected;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button Update;
        public System.Windows.Forms.ListView listView2;
    }
}