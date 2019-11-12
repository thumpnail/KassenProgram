using System;
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
<<<<<<< HEAD
            string JSNDBFile = Directory.GetCurrentDirectory()+@"\products.json";
            Console.WriteLine(JSNDBFile);
=======
            string JSNDBFile = @"products.json";
>>>>>>> origin/master

            Console.ForegroundColor = ConsoleColor.Blue;
            jsonReaderWriter.ReadJSON(JSNDBFile);

<<<<<<< HEAD
            //ProductDB.AddProduct(1,"choclate","Schokolade",5,6,7,10.05,"alle lieben fleisch", 19, DateTime.Now);
            //ProductDB.AddProduct(2,"coffe","Kaffe",2,3,4,12.99,"Kaffe ist immer gut", 14, DateTime.Now);
            //ProductDB.AddProduct(3,"tea","Schwarz Tee",5,6,7,11.20,"Schwarzer tee ist besser als Kaffe", 14, DateTime.Now);
=======
            ProductDB.AddProduct(1,"choclate","Schokolade",5,6,7,10.05,"alle lieben fleisch", 19, DateTime.Now);
            //ProductDB.AddProduct(2,"coffe","Kaffe",2,3,4,12.99,"Kaffe ist immer gut", 14, DateTime.Now);
            //ProductDB.AddProduct(3,"tea","Schwarz Tee",5,6,7,11.20,"Schwarzer tee ist besser als Kaffe", 14, DateTime.UtcNow);
>>>>>>> origin/master

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
