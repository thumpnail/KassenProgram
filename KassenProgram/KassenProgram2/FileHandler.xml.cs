using System;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace KassenProgram.Utils {
    public static class XMLReaderWriter {
        private static XmlDocument doc = new XmlDocument();
        //private static XmlReader xmlReader;
        private static StreamReader streamReader;
        private static StreamWriter streamWriter;

        public static void ReadXML(string XMLDBFile) {
            bool isGoodToGo = false, fileLoded = false;
            try {
                do {
                    if (File.Exists(XMLDBFile)) {
                        streamReader = new StreamReader(XMLDBFile);
                        doc.Load(streamReader);
                        streamReader.Close();
                        isGoodToGo = true;
                        fileLoded = true;
                    } else {
                        //File.Create(XMLDBFile);
                        streamWriter = new StreamWriter(XMLDBFile);
                        streamWriter.WriteLine(@"<Products>");
                        streamWriter.WriteLine(@"</Products>");
                        streamWriter.Close();
                    }
                } while (!isGoodToGo);
                if (fileLoded) {
                    XmlNode root = doc.DocumentElement;
                    XmlNodeList nodes = root.SelectNodes("/Products/product");
                    Console.WriteLine("Node count: " + nodes.Count);
                    try {
                        //actually reading the file
                        for (int i = 0; i < nodes.Count; i++) {
                            /*ProductDB.ProductList.Add(new Product(int.Parse(nodes[i].Attributes["id"].Value),
                                                        nodes[i].Attributes["type"].Value,
                                                        nodes[i].Attributes["name"].Value,
                                                        int.Parse(nodes[i].Attributes["sold"].Value),
                                                        int.Parse(nodes[i].Attributes["amountStore"].Value),
                                                        int.Parse(nodes[i].Attributes["amountStock"].Value),
                                                        double.Parse(nodes[i].Attributes["prize"].Value) / 100,
                                                        nodes[i].InnerText));*/
                        }
                    } catch {
                        Console.WriteLine("Read failed");
                    }
                } else {
                    Console.WriteLine("Error while reading");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }

        }
        public static void WriteXML(string XMLDBFile) {
            if (File.Exists(XMLDBFile)) {
                doc.Load(XMLDBFile);

                XmlNode root = doc.DocumentElement;

                /*
                //remove all childs from Products
                XmlNode targetNode = root.SelectSingleNode("/Products");
                targetNode.RemoveChild(targetNode);
                */
                //print all from productList
                XmlWriter writer = XmlWriter.Create(XMLDBFile);

                writer.WriteStartElement("Products");

                for (int i = 0; i < ProductDB.ProductList.Count; i++) {
                    writer.WriteStartElement("product");
                    writer.WriteAttributeString("id", ProductDB.ProductList[i].id.ToString());
                    writer.WriteAttributeString("type", ProductDB.ProductList[i].type);
                    writer.WriteAttributeString("name", ProductDB.ProductList[i].name);
                    writer.WriteAttributeString("sold", ProductDB.ProductList[i].sold.ToString());
                    writer.WriteAttributeString("amountStore", ProductDB.ProductList[i].amountStore.ToString());
                    writer.WriteAttributeString("amountStock", ProductDB.ProductList[i].amountStock.ToString());
                    writer.WriteAttributeString("prize", ProductDB.ProductList[i].prize.ToString());
                    writer.WriteString(ProductDB.ProductList[i].description);
                }
            }
        }
    }
}
