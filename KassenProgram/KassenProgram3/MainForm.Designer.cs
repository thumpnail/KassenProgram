namespace KassenProgram3 {
    public partial class MainForm {
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
            this.mainListView = new System.Windows.Forms.ListView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonViewProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Location = new System.Drawing.Point(13, 13);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(1035, 734);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(1054, 13);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(156, 39);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonViewProduct
            // 
            this.buttonViewProduct.Location = new System.Drawing.Point(1054, 58);
            this.buttonViewProduct.Name = "buttonViewProduct";
            this.buttonViewProduct.Size = new System.Drawing.Size(156, 39);
            this.buttonViewProduct.TabIndex = 2;
            this.buttonViewProduct.Text = "View Selected Item";
            this.buttonViewProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(1054, 103);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(156, 40);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Delete Selected Item";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1054, 707);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(156, 40);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 759);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonViewProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.mainListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView mainListView;
        public System.Windows.Forms.Button buttonAddProduct;
        public System.Windows.Forms.Button buttonViewProduct;
        public System.Windows.Forms.Button buttonDeleteProduct;
        public System.Windows.Forms.Button buttonUpdate;
    }
}