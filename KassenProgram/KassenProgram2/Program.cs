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

            string JSNDBFile = Directory.GetCurrentDirectory() + @"\products.json";
            Console.WriteLine(JSNDBFile);

            Console.ForegroundColor = ConsoleColor.Blue;
            jsonReaderWriter.ReadJSON(JSNDBFile);

            ProductDB.AddProduct("4030254414465","tea","Rooibos",0,6,0,2.90,"Beerentraum;Afrika;", 19, DateTime.Parse("07.2020"));
            ProductDB.AddProduct("4030254413826","tea","Rooibos",0,8,0,2.90,"Vanille;Suedafrika;", 19, DateTime.Parse("07.2020"));
            ProductDB.AddProduct("0","tea","Kraeuter Tee",0,4,0,3.00,"Kraeuter Tee;Bio;", 14, DateTime.Parse("17.09.2022"));

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
