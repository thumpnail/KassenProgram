﻿using System;
using System.IO;
using KassenProgram;
using KassenProgram.Utils;
using System.Threading;
using System.Windows.Forms;

namespace KassenProgram {
    public class Program {
        public static MainForm form = new MainForm();
        public static void Main(string[] args) {
            Console.Clear();
            //string XMLDBFile = @"products.xml";
            //string CSVDBFile = @"products.csv";
            string JSNDBFile = @"products.json";

            Console.ForegroundColor = ConsoleColor.Blue;
            jsonReaderWriter.ReadJSON(JSNDBFile);

            //ProductDB.AddProduct(1,"choclate","Schokolade",5,6,7,10.05,"alle lieben fleisch", DateTime.Today);
            //ProductDB.AddProduct(2,"coffe","Kaffe",2,3,4,12.99,"Kaffe ist immer gut", DateTime.Today);
            //ProductDB.AddProduct(3,"tea","Schwarz Tee",5,6,7,11.20,"Schwarzer tee ist besser als Kaffe", DateTime.UtcNow);

            StartGUI();

            Console.ForegroundColor = ConsoleColor.Red;
            jsonReaderWriter.WriteJSON(JSNDBFile);
        }
        [STAThread]
        public static void StartGUI() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form);
        }
    }
}