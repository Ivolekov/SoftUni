//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is 
//contained in another file text.txt. Matching should be case-insensitive.
//Write the results in file results.txt. Sort the words by frequency in descending order. Use StreamReader in 
//combination with StreamWriter.
//words.txt		
//quick
//is
//fault
//text.txt	
//-I was quick to judge him, but it wasn't his fault.
//-Is this some kind of joke?! Is it?
//-Quick, hide here…It is safer.	
//result.txt
//is - 3
//quick - 2
//fault - 1

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class WordCount
{
    public static void Main()
    {
        StreamReader words = new StreamReader("Words.txt", Encoding.UTF8);
        StreamReader text = new StreamReader("Text.txt", Encoding.UTF8);
        StreamWriter result = new StreamWriter("Result.txt");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        using (words)
        {
            string line = words.ReadLine();

            while (line != null)
            {
                string[] lineWords = line.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lineWords.Length; i++)
                {
                    lineWords[i] = lineWords[i].ToLower();

                    if (!(dictionary.ContainsKey(lineWords[i])))
                    {
                        dictionary.Add(lineWords[i], 0);
                    }
                }

                line = words.ReadLine();
            }

            using (text)
            {
                using (result)
                {
                    string lineText = text.ReadLine();

                    while (lineText != null)
                    {
                        string[] lineTextSplited = lineText.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                            StringSplitOptions.RemoveEmptyEntries);

                        for (int j = 0; j < lineTextSplited.Length; j++)
                        {
                            lineTextSplited[j] = lineTextSplited[j].ToLower();

                            if (dictionary.ContainsKey(lineTextSplited[j]))
                            {
                                dictionary[lineTextSplited[j]] += 1;
                            }
                        }

                        lineText = text.ReadLine();
                    }

                    foreach (var wordCount in dictionary.OrderByDescending(key => key.Value))
                    {
                        result.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
                    }
                }
            }
        }
    }
}