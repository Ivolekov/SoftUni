//Write a program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use StreamReader.

using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader("../../OddLines.cs");
            using (stream)
            {
                int lineCount = 0;
                string line = stream.ReadLine();
                while (line != null)
                {
                    lineCount++;
                    Console.WriteLine("{0} {1}", lineCount, line);
                    lineCount++;
                    line = stream.ReadLine();
                }
                stream.Close();
            }
        }
    }
}
