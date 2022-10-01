using System;
using System.IO;

namespace StreamWriterTest {
    internal class Program {
        static void Main (string[] args) {

            string sourcePath = @"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\file1.txt";
            string targetPath = @"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\file2.txt";

            try {
                string[] lines = File.ReadAllLines (sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
