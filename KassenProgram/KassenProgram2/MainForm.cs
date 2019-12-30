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
            listView2.Clear();

            listView2.Columns.Add("Id", 100);
            listView2.Columns.Add("Type", 100);
            listView2.Columns.Add("Name", 150);
            listView2.Columns.Add("Sold", 40);
            listView2.Columns.Add("Store", 50);
            listView2.Columns.Add("Stock", 50);
            listView2.Columns.Add("Prize", 50);
            listView2.Columns.Add("Mwst", 40);
            listView2.Columns.Add("Description", 300);
            listView2.Columns.Add("Added", 150);
            listView2.Columns.Add("ExpiryDate", 150);

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

            comboBoxSelectColum.Items.Add("id");
            comboBoxSelectColum.Items.Add("type");
            comboBoxSelectColum.Items.Add("name");
            comboBoxSelectColum.Items.Add("sold");
            comboBoxSelectColum.Items.Add("amountStore");
            comboBoxSelectColum.Items.Add("amountStock");
            comboBoxSelectColum.Items.Add("prize");
            comboBoxSelectColum.Items.Add("MWST");
            comboBoxSelectColum.Items.Add("Tags");

            comboBoxSelectDateType.Items.Add("Added Date");
            comboBoxSelectDateType.Items.Add("Expiry Date");

            listView2.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Do you wanna delete this entry", "Wait", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    for (int i = 0; i < listView2.SelectedItems[0].SubItems.Count; i++) {
                        Console.WriteLine(listView2.SelectedItems[0].SubItems[i].Text);
                    }
                    Console.WriteLine("////////// " + listView2.SelectedItems[0].Text);
                    Utils.ProductDB.RemoveProduct(listView2.SelectedItems[0].Text);
                } catch (Exception) {
                    Console.WriteLine("Nothing selected");
                }
            }
            UpdateListView();
        }

        private void buttonViewSelected_Click(object sender, EventArgs e) {
            viewProduct vp = new viewProduct();
            vp.Show();
        }

        private void Update_Click(object sender, EventArgs e) {
            for (int i = 0; i < Utils.ProductDB.ProductList.Count; i++) {
                ProductDB.ProductList[i].printAll();
            }
            UpdateListView();
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            try {
                //head
                List<Product> searchResult = new List<Product>();
                Console.WriteLine("Searching for " + comboBoxSelectColum.SelectedItem.ToString() + " in data by refference(" + textSearchField.Text + ")");

                //selecting all entries
                for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                    switch (comboBoxSelectColum.SelectedItem.ToString()) {
                        case "id":
                            if (ProductDB.ProductList[i].id.Contains(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "type":
                            if (ProductDB.ProductList[i].type.Contains(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "name":
                            if (ProductDB.ProductList[i].name.Contains(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "sold":
                            if (ProductDB.ProductList[i].sold == int.Parse(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "amountStore":
                            if (ProductDB.ProductList[i].amountStore == int.Parse(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "amountStock":
                            if (ProductDB.ProductList[i].amountStock == int.Parse(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "prize":
                            if (ProductDB.ProductList[i].prize == double.Parse(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "MWST":
                            if (ProductDB.ProductList[i].MWST == int.Parse(textSearchField.Text)) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        case "Tags":
                            if (ProductDB.ProductList[i].description.Contains(textSearchField.Text + ";")) {
                                searchResult.Add(ProductDB.ProductList[i]);
                            }
                            break;
                        default:
                            Console.WriteLine("Error while searching");
                            Update();
                            break;
                    }
                }

                searchUpdate(searchResult);
            } catch(Exception ex) {
                Console.WriteLine("Could not read properly");
                Console.WriteLine("Error: " + ex);
                Update();
            }
        }
        private void searchUpdate(List<Product> result) {
            try {
                listView2.Clear();

                listView2.Columns.Add("Id", 100);
                listView2.Columns.Add("Type", 100);
                listView2.Columns.Add("Name", 150);
                listView2.Columns.Add("Sold", 40);
                listView2.Columns.Add("Store", 50);
                listView2.Columns.Add("Stock", 50);
                listView2.Columns.Add("Prize", 50);
                listView2.Columns.Add("Mwst", 40);
                listView2.Columns.Add("Description", 300);
                listView2.Columns.Add("Added", 150);
                listView2.Columns.Add("ExpiryDate", 150);

                for (int i = 0; i < result.Count; i++) {
                    ListViewItem item = new ListViewItem(result[i].id.ToString(), i);
                    item.SubItems.Add(result[i].type);
                    item.SubItems.Add(result[i].name);
                    item.SubItems.Add(result[i].sold.ToString());
                    item.SubItems.Add(result[i].amountStore.ToString());
                    item.SubItems.Add(result[i].amountStock.ToString());
                    item.SubItems.Add(result[i].prize.ToString() + "€");
                    item.SubItems.Add(result[i].MWST.ToString() + "%");
                    item.SubItems.Add(result[i].description);
                    item.SubItems.Add(result[i].added.ToString());
                    item.SubItems.Add(result[i].expiryDate.ToString());
                    listView2.Items.Add(item);
                }
            } catch (Exception ex2) {
                Console.WriteLine("An error accoured while printing the result");
                Console.WriteLine(ex2);
                Console.WriteLine("Printing normal view");
                Update();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            UpdateListView();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e) {
            Console.WriteLine("DateTime from: " + dateTimePickerFrom.Value.ToString());
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e) {
            Console.WriteLine("DateTime to: " + dateTimePickerTo.Value.ToString());
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            Console.WriteLine("DateTime from: " + dateTimePickerFrom.Value.Date.ToString());
            Console.WriteLine("DateTime to: " + dateTimePickerTo.Value.Date.ToString());
            try {
                List<Product> searchResult = new List<Product>();
                for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                    if (dateTimePickerFrom.Value.Date <= dateTimePickerTo.Value.Date) {
                        if (comboBoxSelectDateType.Text.Equals("Added Date")) {
                            if (ProductDB.ProductList[i].added.Date >= dateTimePickerFrom.Value.Date && ProductDB.ProductList[i].added.Date <= dateTimePickerTo.Value.Date) {
                                searchResult.Add(ProductDB.ProductList[i]);
                                Console.WriteLine(ProductDB.ProductList[i].id + " added");
                            } else {
                                Console.WriteLine(ProductDB.ProductList[i].id + " not added");
                            }
                        } else if (comboBoxSelectDateType.Text.Equals("Expiry Date")) {
                            if (ProductDB.ProductList[i].expiryDate.Date >= dateTimePickerFrom.Value.Date && ProductDB.ProductList[i].expiryDate.Date <= dateTimePickerTo.Value.Date) {
                                searchResult.Add(ProductDB.ProductList[i]);
                                Console.WriteLine(ProductDB.ProductList[i].id + " added");
                            } else {
                                Console.WriteLine(ProductDB.ProductList[i].id + " not added");
                            }
                        } else {
                            Console.WriteLine("And another error accured");
                            break;
                        }
                    } else {
                        Console.WriteLine("from is allways smaller then to :*");
                        break;
                    }
                }
                searchUpdate(searchResult);
            } catch (Exception ex_DateFrom) {
                Console.WriteLine("A big fckin error appeared");
                Console.WriteLine(ex_DateFrom);
                throw;
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e) {
            CalculateForm calculateForm = new CalculateForm();
            calculateForm.Show();
        }
    }
}
