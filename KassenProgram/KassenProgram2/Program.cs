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

            TagFileReader.readTags();

            //ProductDB.AddProduct("4030254414465","tea","Rooibos",0,6,0,2.90,"Beerentraum;Afrika;", 19, DateTime.Parse("07.2020"));
            //ProductDB.AddProduct("4030254413826","tea","Rooibos",0,8,0,2.90,"Vanille;Suedafrika;", 19, DateTime.Parse("07.2020"));
            //ProductDB.AddProduct("0","tea","Kraeuter Tee",0,4,0,3.00,"Kraeuter Tee;Bio;", 14, DateTime.Parse("17.09.2022"));

            //GenProducts(250);

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
        private static void GenProducts(int amount) {
            for (int o = 0; o < amount; o++) {
                try {
                    string[] _typeList = { "tea", "coffe", "cookies", "stuff" };
                    string[] _nameList = { "Schwarzer Tee", "Ingwer Tee", "Rooibos", "Kreauter tee" };
                    string[] _tagList = TagFileReader.tagList.ToArray();
                    double[] _MWSTList = { 14, 19 };

                    string genID = "";
                    Random rnd = new Random();
                    for (int i = 0; i < 13; i++) {
                        genID += rnd.Next(0, 9);
                    }
                    string genTags = "";
                    for (int i = 0; i < rnd.Next(1, 3); i++) {
                        genTags += _tagList[rnd.Next(0, _tagList.Length)];
                    }
                    ProductDB.AddProduct(genID, _typeList[rnd.Next(0, _typeList.Length)], _nameList[rnd.Next(0, _nameList.Length)], rnd.Next(0, 20), rnd.Next(0, rnd.Next(1, 50)), rnd.Next(0, rnd.Next(1, 50)), double.Parse("" + rnd.Next(0, 20) + "," + rnd.Next(0, 99)), "sampleTag;"+genTags, _MWSTList[rnd.Next(0, _MWSTList.Length)], DateTime.Parse(rnd.Next(1, 31) + "." + rnd.Next(1, 12) + "." + rnd.Next(2000, 2022))) ;
                } catch (Exception ex_gen) {
                    Console.WriteLine("Error while Generating");
                    Console.WriteLine(ex_gen);
                }
            }
        }
    }
}
