using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KassenProgram {
    public partial class AddProductForm : Form {
        public AddProductForm() {
            InitializeComponent();
        }
        public void Start() {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            try {
                Utils.ProductDB.ProductList.Insert(int.Parse(productID.Text), new Utils.Product(int.Parse(productID.Text), productType.Text, productName.Text, 0, int.Parse(productAmountStore.Text), int.Parse(productAmountStock.Text), double.Parse(productPrize.Text), productDescription.Text, double.Parse(productMWST.Text), productExpiryDate.Value));
            } catch (Exception) {
                Console.WriteLine("error");
                DialogResult dialogResult = MessageBox.Show("Watch you product", "ERROR", MessageBoxButtons.OK);
            }
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            productID.Enabled = false;
            productType.Enabled = false;
            productName.Enabled = false;
            productAmountStore.Enabled = false;
            productAmountStock.Enabled = false;
            productPrize.Enabled = false;
            productExpiryDate.Enabled = false;
            productMWST.Enabled = false;

            Program.form.UpdateListView();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e) {
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
            productID.Enabled = false;
            productType.Enabled = true;
            productName.Enabled = true;
            productAmountStore.Enabled = true;
            productAmountStock.Enabled = true;
            productPrize.Enabled = true;
            productExpiryDate.Enabled = true;
            productMWST.Enabled = true;
        }

        private void generateID_Click(object sender, EventArgs e) {
            productID.Text = ""+(Utils.ProductDB.ProductList.Count+1);
        }

        private void checkBoxEdvanced_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxEdvanced.Checked) {
                productID.Enabled = true;
                generateID.Enabled = false;
            } else {
                productID.Enabled = false;
                generateID.Enabled = true;
            }
        }
    }
}
