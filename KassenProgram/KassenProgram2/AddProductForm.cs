using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KassenProgram.Utils;

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
                Utils.ProductDB.AddProduct(productID.Text, productType.Text, productName.Text, 0, int.Parse(productAmountStore.Text), int.Parse(productAmountStock.Text), double.Parse(productPrize.Text), productDescription.Text, double.Parse(productMWST.Text), productExpiryDate.Value);
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
            productID.Enabled = true;
            productType.Enabled = true;
            productName.Enabled = true;
            productAmountStore.Enabled = true;
            productAmountStock.Enabled = true;
            productPrize.Enabled = true;
            productExpiryDate.Enabled = true;
            productMWST.Enabled = true;

            for (int i = 0; i < TagFileReader.tagList.Count; i++) {
                comboBoxTags.Items.Add(TagFileReader.tagList[i]);
            }
        }

        private void productID_TextChanged(object sender, EventArgs e) {

        }

        private void buttonAddTag_Click(object sender, EventArgs e) {
            try {
                if (!productDescription.Text.Contains(comboBoxTags.SelectedItem.ToString())) {
                    productDescription.Text += comboBoxTags.SelectedItem.ToString();
                } else {
                    Console.WriteLine("Error while adding Tag(" + comboBoxTags.SelectedItem.ToString() + ")");
                }
            } catch (Exception E_AddingTag1) {
                Console.WriteLine(E_AddingTag1);
                DialogResult dialogResult = MessageBox.Show("You didn't add a Tag", "Tag Adding Error", MessageBoxButtons.OK);
            }
        }
    }
}
