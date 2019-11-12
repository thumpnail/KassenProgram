using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using KassenProgram.Utils;

namespace KassenProgram {
    public partial class MainForm : Form {
        public MainForm() { InitializeComponent(); }

        public void UpdateListView() {
            ProductDB.SortList_byID();
            listView2.Clear();

            listView2.Columns.Add("Id", 40);
            listView2.Columns.Add("Type");
            listView2.Columns.Add("Name");
            listView2.Columns.Add("Sold");
            listView2.Columns.Add("Store", 60);
            listView2.Columns.Add("Stock", 60);
            listView2.Columns.Add("Prize");
            listView2.Columns.Add("Description", 300);
            listView2.Columns.Add("MWST", 60);
            listView2.Columns.Add("Added", 200);
            listView2.Columns.Add("ExpiryDate", 200);

            for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                ListViewItem item = new ListViewItem(ProductDB.ProductList[i].id.ToString(), i);
                item.SubItems.Add(ProductDB.ProductList[i].type);
                item.SubItems.Add(ProductDB.ProductList[i].name);
                item.SubItems.Add(ProductDB.ProductList[i].sold.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].amountStore.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].amountStock.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].prize.ToString() + "€");
                item.SubItems.Add(ProductDB.ProductList[i].description);
                item.SubItems.Add(ProductDB.ProductList[i].MWST.ToString() + "%");
                item.SubItems.Add(ProductDB.ProductList[i].added.ToString());
                item.SubItems.Add(ProductDB.ProductList[i].expiryDate.ToString());
                listView2.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //listView2 = new ListView();
            listView2.View = View.Details;
            listView2.FullRowSelect = true;

            UpdateListView();
            listView2.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e) {
            try {
                ListView lv = new ListView();
                for (int i = 0; i < listView2.SelectedItems[0].SubItems.Count; i++) {
                    Console.WriteLine(listView2.SelectedItems[0].SubItems[i].Text);
                }
                Console.WriteLine("////////// " + int.Parse(listView2.SelectedItems[0].Text));
                Utils.ProductDB.RemoveProduct(int.Parse(listView2.SelectedItems[0].Text));
            } catch (Exception) {
                Console.WriteLine("Nothing selected");
            }
            UpdateListView();
        }

        private void buttonViewSelected_Click(object sender, EventArgs e) {
            viewProduct vp = new viewProduct();
            vp.Show();
        }

        private void Update_Click(object sender, EventArgs e) {
            UpdateListView();
        }
    }
}
