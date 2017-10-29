//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file. Use StreamReader in combination with StreamWriter.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../LineNumbers.cs");
            StreamWriter writer = new StreamWriter("LineNumbers.txt");
            using (reader)
            {
                using (writer)
                {
                    int lineCount = 0;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        lineCount++;
                        writer.WriteLine("{0} {1}", lineCount, line);
                    }
                }
            }
        }
    }
}
