using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace KassenProgram.Utils {
    public static class ProductDB {
        public static List<Product> ProductList = new List<Product>();
        public static void InsertProduct(Product product, int id) {
            int index = id-1;
            List<Product> products = new List<Product>();
            for (int i = 0; i < ProductList.Count; i++) {
                if (ProductList[i].id == id) {

<<<<<<< HEAD
                }
            }
        }
        public static void AddProduct(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST, DateTime expiryDate) {
            ProductDB.ProductList.Add(new Product(id, type, name, sold, amountStore, amountStock, prize, description, MWST, expiryDate));
=======
        public static void AddProduct(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST, DateTime expiryDate) {
            ProductDB.ProductList.Add(new Product(id, type, name, sold, amountStore, amountStock, prize, description, MWST, expiryDate));
            Console.WriteLine("//////////////Print product");
            Console.WriteLine("ID:___________" + id);
            Console.WriteLine("Name:_________" + name);
            Console.WriteLine("Type:_________" + type);
            Console.WriteLine("Sold:_________" + sold);
            Console.WriteLine("Amount Store:_" + amountStore);
            Console.WriteLine("Amount Stock:_" + amountStock);
            Console.WriteLine("Prize:________" + prize);
            Console.WriteLine("Description:__" + description);
            Console.WriteLine("MWST__________" + MWST);
            Console.WriteLine("Expiry Date:__" + expiryDate);
            Console.WriteLine();

            Console.WriteLine("//////////////Print list");
            for (int i = 0; i < ProductList.Count; i++) {
                ProductList[i].printAll();
            }
>>>>>>> origin/master
        }
        public static void RemoveProduct(int id) {
            Console.WriteLine("Removing:");
            ProductDB.ProductList[id].printAll();
            ProductList.Remove(ProductList[id-1]);
        }
        public static void SortList_byID() {
            List<Product> newProductList = new List<Product>();
            for (int i = 0; i < ProductList.Count; i++) {
                try {
                    for (int o = 0; o < ProductList.Count; o++) {
                        if (ProductList[o].id == i + 1) {
                            newProductList.Add(ProductList[o]);
                        }
                    }
                } catch (Exception) {
                    Console.WriteLine("Error");
                }
            }
            ProductList = newProductList;
        }
    }

    public class Product {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int sold { get; set; }
        public int amountStore { get; set; }
        public int amountStock { get; set; }
        public double prize { get; set; }
        public string description { get; set; }
        public double MWST { get; set; }
        public DateTime added { get; set; }
        public DateTime expiryDate { get; set; }
<<<<<<< HEAD
        public Product(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST, DateTime expiryDate) {
=======
        public Product(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST,DateTime expiryDate) {
>>>>>>> origin/master
            this.id = id;
            this.type = type;
            this.name = name;
            this.sold = sold;
            this.amountStore = amountStore;
            this.amountStock = amountStock;
            this.prize = prize;
            this.description = description;
            this.expiryDate = expiryDate;
            this.MWST = MWST;
            added = DateTime.Now;
        }
        public void printAll() {
            Console.WriteLine("ID:___________" + id);
            Console.WriteLine("Name:_________" + name);
            Console.WriteLine("Type:_________" + type);
            Console.WriteLine("Sold:_________" + sold);
            Console.WriteLine("Amount Store:_" + amountStore);
            Console.WriteLine("Amount Stock:_" + amountStock);
            Console.WriteLine("Prize:________" + prize);
            Console.WriteLine("Description:__" + description);
            Console.WriteLine("MWST__________" + MWST);
            Console.WriteLine("Added:________" + added);
            Console.WriteLine("Expiry Date:__" + expiryDate);
            Console.WriteLine();
        }
    }
}
