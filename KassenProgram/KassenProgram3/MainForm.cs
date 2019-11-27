using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KassenProgram3.Utils;
using KassenProgram3;

namespace KassenProgram3 {
    public partial class MainForm : Form {
        public MainForm() { InitializeComponent(); }

        public void UpdateListView() {
            ProductDB.SortList_byID();
            mainListView.Clear();

            mainListView.Columns.Add("Id", 40);
            mainListView.Columns.Add("Type");
            mainListView.Columns.Add("Name");
            mainListView.Columns.Add("Sold");
            mainListView.Columns.Add("Store", 60);
            mainListView.Columns.Add("Stock", 60);
            mainListView.Columns.Add("Prize", 60);
            mainListView.Columns.Add("Mwst", 60);
            mainListView.Columns.Add("Description", 300);
            mainListView.Columns.Add("MWST", 60);
            mainListView.Columns.Add("Added", 200);
            mainListView.Columns.Add("ExpiryDate", 200);

            for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                ListViewItem item = new ListViewItem(ProductDB.ProductList[i].id.ToString(), i);
                item.SubItems.Add(ProductDB.ProductList[i].type);
                item.SubItems.Add(ProductDB.ProductList[i].name);
                item.SubItems.Add(ProductDB.ProductList[i].sold.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].amountStore.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].amountStock.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].prize.ToString() + "€");
                item.SubItems.Add(ProductDB.ProductList[i].MWST.ToString() + "%");
                item.SubItems.Add(ProductDB.ProductList[i].description);
                item.SubItems.Add(ProductDB.ProductList[i].MWST.ToString() + "%");
                item.SubItems.Add(ProductDB.ProductList[i].added.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].expiryDate.ToString());
                mainListView.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //listView2 = new ListView();
            mainListView.View = View.Details;
            mainListView.FullRowSelect = true;

            UpdateListView();

            mainListView.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Do you wanna delete this entry", "Wait", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    for (int i = 0; i < mainListView.SelectedItems[0].SubItems.Count; i++) {
                        Console.WriteLine(mainListView.SelectedItems[0].SubItems[i].Text);
                    }
                    Console.WriteLine("////////// " + int.Parse(mainListView.SelectedItems[0].Text));
                    Utils.ProductDB.RemoveProduct(int.Parse(mainListView.SelectedItems[0].Text));
                } catch (Exception) {
                    Console.WriteLine("Nothing selected");
                }
            }
            UpdateListView();
        }

        private void buttonViewSelected_Click(object sender, EventArgs e) {
            viewProductForm vp = new viewProductForm();
            vp.Show();
        }

        private void Update_Click(object sender, EventArgs e) {
            for (int i = 0; i < Utils.ProductDB.ProductList.Count; i++) {
                ProductDB.ProductList[i].printAll();
            }
            UpdateListView();
        }
    }
}
