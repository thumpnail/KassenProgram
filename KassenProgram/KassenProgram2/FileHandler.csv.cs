using System;
using CsvHelper;
using KassenProgram.Utils;
using System.IO;
using System.Collections.Generic;
using System.Linq;


public static class csvReaderWriter {
    public static void csvReader(string CSVDBFile) {
        if (!File.Exists(CSVDBFile)) {
            Console.WriteLine("no file found");
            StreamWriter writer = new StreamWriter(CSVDBFile);
            writer.WriteLine("id;type;name;sold;amountStore;amountStock;prize;description");
            writer.Close();
        }
        TextReader reader = new StreamReader(CSVDBFile);
        CsvReader csv = new CsvReader(reader);
        csv.Configuration.MissingFieldFound = null;
        csv.Configuration.HasHeaderRecord = false;
        var record = csv.GetRecords<Product>();
        Console.WriteLine("try to convert to enumerable");
        IEnumerable<Product> records = record;
        Console.WriteLine("try");
        //try {
            ProductDB.ProductList = records.ToList();
            Console.WriteLine("after");
            foreach (var item in records) {
                Console.WriteLine("inside try");
                Console.WriteLine(item.id);
                Console.WriteLine("after id");
                Console.WriteLine(item.type);
                Console.WriteLine("after type");
                Console.WriteLine(item.name);
                Console.WriteLine("after name");
                Console.WriteLine(item.sold);
                Console.WriteLine("after sold");
                Console.WriteLine(item.amountStore);
                Console.WriteLine("after amountStore");
                Console.WriteLine(item.amountStock);
                Console.WriteLine("after amountStock");
                Console.WriteLine(item.description);
                Console.WriteLine("after description");
                Console.WriteLine();
            }
        //} catch (Exception ex) {
            Console.WriteLine("ex");
        //}
        
        for (int i = 0; i < ProductDB.ProductList.Count; i++) {
            ProductDB.ProductList[i].printAll();
        }
    }

    public static void csvWriter(string CSVDBFile) {

    }
}