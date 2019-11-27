using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KassenProgram {
    public partial class viewProduct : Form {
        private static string oldId;

        public viewProduct() {
            InitializeComponent();
        }

        private void checkBoxEnableEdit_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxEnableEdit.Checked) {
                buttonCancel.Enabled = true;
                buttonSave.Enabled = true;

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

        private void buttonSave_Click(object sender, EventArgs e) {
            Utils.ProductDB.RemoveProduct(oldId);

            try {
                Utils.ProductDB.AddProduct(productID.Text, productType.Text, productName.Text, int.Parse(productSold.Text), int.Parse(productStore.Text), int.Parse(productStock.Text), double.Parse(productPrize.Text), productDescription.Text, double.Parse(productMWST.Text), DateTime.Parse(productExpiryDate.Text));
            } catch (Exception a) {
                Console.WriteLine("error while adding");
                Console.WriteLine(a);
            }
            Program.form.UpdateListView();
            buttonCancel.Enabled = false;
            buttonSave.Enabled = false;

            productID.Enabled = false;
            productDescription.Enabled = false;
            productExpiryDate.Enabled = false;
            productMWST.Enabled = false;
            productName.Enabled = false;
            productPrize.Enabled = false;
            productSold.Enabled = false;
            productStock.Enabled = false;
            productStore.Enabled = false;
            productType.Enabled = false;
            addedDate.Enabled = false;

            checkBoxEnableEdit.Checked = false;

            Program.form.UpdateListView();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void viewProduct_Load(object sender, EventArgs e) { 
            buttonCancel.Enabled = false;
            buttonSave.Enabled = false;
            
            productID.Enabled = false;
            productType.Enabled = false;
            productName.Enabled = false;
            productSold.Enabled = false;
            productStore.Enabled = false;
            productStock.Enabled = false;
            productPrize.Enabled = false;
            productMWST.Enabled = false;
            productDescription.Enabled = false;
            productMWST.Enabled = false;
            productExpiryDate.Enabled = false;
            addedDate.Enabled = false;

            try {//id
                productID.Text = Program.form.listView2.SelectedItems[0].SubItems[0].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//type
                productType.Text = Program.form.listView2.SelectedItems[0].SubItems[1].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//name
                productName.Text = Program.form.listView2.SelectedItems[0].SubItems[2].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//sold
                productSold.Text = Program.form.listView2.SelectedItems[0].SubItems[3].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//amount store
                productStore.Text = Program.form.listView2.SelectedItems[0].SubItems[4].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//amount stock
                productStock.Text = Program.form.listView2.SelectedItems[0].SubItems[5].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//prize
                productPrize.Text = Program.form.listView2.SelectedItems[0].SubItems[6].Text.Substring(0, Program.form.listView2.SelectedItems[0].SubItems[6].Text.IndexOf("€"));
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//description
                productDescription.Text = Program.form.listView2.SelectedItems[0].SubItems[8].Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//mwst
                productMWST.Text = Program.form.listView2.SelectedItems[0].SubItems[7].Text.Substring(0, Program.form.listView2.SelectedItems[0].SubItems[7].Text.IndexOf("%"));
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//expiry date
                productExpiryDate.Value = DateTime.Parse(Program.form.listView2.SelectedItems[0].SubItems[9].Text);
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//added date
                addedDate.Value = DateTime.Parse(Program.form.listView2.SelectedItems[0].SubItems[10].Text);
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {//old id
                oldId = productID.Text;
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            try {
                
            } catch (Exception error) {
                DialogResult dialogResult = MessageBox.Show("Error while parsing", "ERROR", MessageBoxButtons.OK);
                Console.WriteLine(dialogResult);
                Console.WriteLine(error);
                if (dialogResult == DialogResult.OK) {
                    this.Close();
                }
            }
        }

        private void addedDate_ValueChanged(object sender, EventArgs e) {

        }
    }
}
