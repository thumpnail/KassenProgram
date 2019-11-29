using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KassenProgram.Utils {
    public static class TagFileReader {
        private static StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\data.tag");
        public static List<string> tagList = new List<string>();
        public static void readTags() {
            while(!sr.EndOfStream) {
                tagList.Add(sr.ReadLine());
            }
        }
    }
}
