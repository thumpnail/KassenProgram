using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace KassenProgram.Utils {
    public static class ProductDB {
        public static List<Product> ProductList = new List<Product>();

        public static void AddProduct(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, DateTime expiryDate) {
            ProductDB.ProductList.Add(new Product(id, type, name, sold, amountStore, amountStock, prize, description, expiryDate));
        }
        public static void RemoveProduct(int id) {
            ProductList.Remove(ProductList[id-1]);
            ProductList.Sort();
        }
    }

    public class Product {
        public int id { get; }
        public string type { get; }
        public string name { get; }
        public int sold { get; set; }
        public int amountStore { get; set; }
        public int amountStock { get; set; }
        public double prize { get; set; }
        public string description { get; set; }
        public DateTime added { get; set; }
        public DateTime expiryDate { get; set; }
        public Product(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, DateTime expiryDate) {
            this.id = id;
            this.type = type;
            this.name = name;
            this.sold = sold;
            this.amountStore = amountStore;
            this.amountStock = amountStock;
            this.prize = prize;
            this.description = description;
            this.expiryDate = expiryDate;
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
            Console.WriteLine("Added:________" + added);
            Console.WriteLine("Expiry Date:__" + expiryDate);
            Console.WriteLine();
        }
    }
}
