using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KassenProgram {
    public partial class viewProduct : Form {
        public viewProduct() {
            InitializeComponent();
        }

        private void checkBoxEnableEdit_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxEnableEdit.Checked) {
                buttonCancel.Enabled = true;
                buttonSave.Enabled = true;
                buttonGenerateID.Enabled = true;
                productID.Enabled = true;
                productType.Enabled = true;
                productName.Enabled = true;
                productSold.Enabled = true;
                productStore.Enabled = true;
                productStock.Enabled = true;
                productPrize.Enabled = true;
                productMWST.Enabled = true;
                productDescription.Enabled = true;
                productExpiryDate.Enabled = true;
                addedDate.Enabled = true;
            } else {
                buttonCancel.Enabled = false;
                buttonSave.Enabled = false;
                buttonGenerateID.Enabled = false;
                productID.Enabled = false;
                productType.Enabled = false;
                productName.Enabled = false;
                productSold.Enabled = false;
                productStore.Enabled = false;
                productStock.Enabled = false;
                productPrize.Enabled = false;
                productMWST.Enabled = false;
                productDescription.Enabled = false;
                productExpiryDate.Enabled = false;
                addedDate.Enabled = false;
            }
            
        }

        private void checkBoxEdvanced_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxEnableAdvanced.Checked) {
                productID.Enabled = true;
                buttonGenerateID.Enabled = false;
            } else {
                productID.Enabled = false;
                buttonGenerateID.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void generateID_Click(object sender, EventArgs e) {
            productID.Text = Utils.ProductDB.ProductList.Count.ToString();
        }

        private void viewProduct_Load(object sender, EventArgs e) {
            buttonCancel.Enabled = false;
            buttonSave.Enabled = false;
            buttonGenerateID.Enabled = false;
            
            productID.Enabled = false;
            productType.Enabled = false;
            productName.Enabled = false;
            productSold.Enabled = false;
            productStore.Enabled = false;
            productStock.Enabled = false;
            productPrize.Enabled = false;
            productMWST.Enabled = false;
            productDescription.Enabled = false;
            productExpiryDate.Enabled = false;
            addedDate.Enabled = false;


            try {
                productID.Text = Program.form.listView2.SelectedItems[0].SubItems[0].Text;
                productType.Text = Program.form.listView2.SelectedItems[0].SubItems[1].Text;
                productName.Text = Program.form.listView2.SelectedItems[0].SubItems[2].Text;
                productSold.Text = Program.form.listView2.SelectedItems[0].SubItems[3].Text;
                productStore.Text = Program.form.listView2.SelectedItems[0].SubItems[4].Text;
                productStock.Text = Program.form.listView2.SelectedItems[0].SubItems[5].Text;
                productPrize.Text = Program.form.listView2.SelectedItems[0].SubItems[6].Text;
                productDescription.Text = Program.form.listView2.SelectedItems[0].SubItems[7].Text;
                productExpiryDate.Value = DateTime.Parse(Program.form.listView2.SelectedItems[0].SubItems[8].Text);
                addedDate.Value = DateTime.Parse(Program.form.listView2.SelectedItems[0].SubItems[9].Text);
            } catch (Exception) {
                DialogResult dialogResult = MessageBox.Show("Error while parsing", "ERROR", MessageBoxButtons.OK);
                Console.WriteLine(dialogResult);
                if (dialogResult == DialogResult.OK) {
                    this.Close();
                }
            }
        }
    }
}
