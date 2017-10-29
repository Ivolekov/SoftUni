using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Paths
{
    class Program
    {
        static void Main()
        {
            try
            {
                double[] line = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
                double[] points = { line[0], line[1], line[2] };
                Storage.Save(points, @"../../path3d.txt");
                Console.WriteLine("Saved points!");

                Thread.Sleep(3000);

                List<double[]> list = Storage.Load(@"../../path3d.txt");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("Line {0}: {1} {2} {3}", i, list[i][0], list[i][1], list[i][2]);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Negative number");
            }
            catch (ArgumentNullException)
            {
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            
        }
    }
}
