using System;
using System.IO; // Constains IO operations
using Ganss.Excel;
using System.Collections.Generic;

namespace CiteDemo {
    class IOPerations {
        static void Main() {
            // Excel IO
            string path = "C:\\Users\\user\\Desktop\\ExcelData.xlsx";
            ExcelMapper mapper = new ExcelMapper(path);
            
            IEnumerable<Data> data = mapper.Fetch<Data>(0);
            foreach (Data item in data) {
                Console.WriteLine("Name={0},Age={1},Level={2},Score={3}",
                    item.Name, item.Age, item.Level, item.Score);
            }

            Console.ReadLine();
        }

        static void FileIO() {
            // File IO
            string message = "This is a message I want to write to a file";
            string path = "C:\\Users\\user\\Desktop\\Output.txt";
            //File.WriteAllText(path, message);
            File.AppendAllText(path, "I append this line");

            string path1 = "C:\\Users\\user\\Desktop\\Output1.txt";
            string[] content = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday" };
            File.WriteAllLines(path1, content);
            Console.WriteLine("Done");

            // Read
            string readPath = "C:\\Users\\user\\Desktop\\Input.txt";
            string content1 = File.ReadAllText(readPath);
            Console.WriteLine(content1);

            Console.WriteLine("===============================");

            string[] allLines = File.ReadAllLines(readPath);
            foreach (string line in allLines) {
                Console.WriteLine(line);
            }
        }
    }

    class Data {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public double Score { get; set; }
    }
}
