using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenProgramInFramework {
    public static class ProductDB {
        public static List<Product> productList = new List<Product>();

        public static void SortList_byID() {
            List<Product> newProductList = new List<Product>();
            for (int i = 0; i < productList.Count; i++) {
                try {
                    for (int o = 0; o < productList.Count; o++) {
                        if (productList[o].id == i+1) {
                            newProductList.Add(productList[o]);
                        }
                    }
                } catch (Exception) {
                    Console.WriteLine("Error");
                }
            }
            productList = newProductList;
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
        public double MWST { get; set; }
        public DateTime added { get; set; }
        public DateTime expiryDate { get; set; }
        public Product(int id, string type, string name, int sold, int amountStore, int amountStock, double prize, string description, double MWST, DateTime expiryDate) {
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
}
