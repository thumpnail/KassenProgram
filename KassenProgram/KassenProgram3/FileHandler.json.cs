using System;
using System.IO;
using Newtonsoft.Json;
using KassenProgram;
using KassenProgram3.Utils;

namespace KassenProgram3.Utils {
    public static class jsonReaderWriter {
        public static string[] stack;
        public static void ReadJSON(string JSNDBFile) {
            if (File.Exists(JSNDBFile)) {
                string[] b = new string[10000];
                StreamReader sr = new StreamReader(JSNDBFile);
                
                //read the file
                Console.WriteLine(">> Printing All Lines wich are readed");
                int a = 0;
                while (sr.Peek() >= 0) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    b[a] = line;
                    a += 1;
                }
                
                //port lines to stack
                Console.WriteLine(">> port lines to stack");
                stack = new string[a+1];
                for (int i = 0; i < stack.Length; i++) {
                    stack[i] = b[i];
                }

                //deserilize stack
                Console.WriteLine(">> deserilize stack");
                for (int i = 0; i < stack.Length; i++) {
                    if (stack[i] != null) {
                        ProductDB.ProductList.Add(JsonConvert.DeserializeObject<Product>(stack[i]));
                    }
                }

                //print product list
                Console.WriteLine(">> print all products(Read)");
                for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                    ProductDB.ProductList[i].printAll();
                }

                sr.Close();
            }
        }
        public static void WriteJSON(string JSNDBFile) {
            Console.WriteLine(">> print all products(write)");
            for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                ProductDB.ProductList[i].printAll();
            }
            
            if (File.Exists(JSNDBFile)) {
                File.Delete(JSNDBFile);
            }

            StreamWriter sw = new StreamWriter(JSNDBFile);

            //parse productList in json to a string array
            Console.WriteLine(">> parse productList in json to a string array");
            stack = new string[ProductDB.ProductList.Count];
            for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                stack[i] = JsonConvert.SerializeObject(ProductDB.ProductList[i]);
            }

           //print the string array 
           Console.WriteLine(">> print the string array");
            for (int i = 0; i < stack.Length; i++) {
                Console.WriteLine(stack[i]);
            }

            //writing to file
            Console.WriteLine(">> writing to file");
            foreach (var item in stack) {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
