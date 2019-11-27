using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace KassenProgram.Utils {
    public static class ProductDB {
        public static List<Product> ProductList = new List<Product>();

        public static void AddProduct(string id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST, DateTime expiryDate) {
            if (IsIDUniqe(id)) {
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
            } else {
                Console.WriteLine("Is not uniqe");
            }
            
        }
        private static bool IsIDUniqe(string id) {
            int coliders = 0;
            for (int i = 0; i < ProductList.Count; i++) {
                if (ProductList[i].id.Equals(id)) {
                    coliders += 1;
                }
            }
            Console.WriteLine("Coliders: " + coliders);
            if (coliders == 0) {
                return true;
            } else {
                return false;
            }
        }
        public static void RemoveProduct(string id) {
            Console.WriteLine("/////////Removing:");
            ProductDB.FindByID(id).printAll();
            if (FindByID(id) != null) {
                ProductList.Remove(FindByID(id));
            }
        }
        private static Product FindByID(string id) {
            for (int i = 0; i < ProductList.Count; i++) {
                if (ProductList[i].id.Equals(id)) {
                    return ProductList[i];
                }
            }
            return null;
        }
    }

    public class Product {
        public string id { get; set; }
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
    
        public Product(string id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST,DateTime expiryDate) {
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
