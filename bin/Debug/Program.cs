using System;
using System.Collections.Generic;
using System.IO; //step 1: include necessary namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFile("Test.txt");
            ReadFile("Test.txt");
            
        }
        static void WriteFile(string fileName) {
            TextWriter writer = new StreamWriter(fileName); //step 2: initialize object
            writer.Write("Hello"); //Step 3: write something
            writer.WriteLine("World");
            for(int i = 1; i <= 12; i++)
            {
                writer.WriteLine($"{i}X3={i*3}");
            }
            writer.Close(); //step 4: close the object
        }
        static void ReadFile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            string input;
            while ((input=reader.ReadLine())!=null) {
                Console.WriteLine(input);
            }
            
            
            reader.Close();
        }
    }
}
