using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Paths
{
    public static class Storage
    {
        public static void Save(double[] points, string pathFile)
        {
            Paths3D paths = new Paths3D(points);
            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                writer.WriteLine(String.Format("{0} {1} {2}", paths.Points[0], paths.Points[1], paths.Points[2]));
            }
        }

        public static List<double[]> Load(string pathFile)
        {
            List<double[]> doblesList = new List<double[]>();
            using (StreamReader reader = new StreamReader(pathFile))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;

                    double[] numbers = line.Split().Select(x => double.Parse(x)).ToArray();
                    doblesList.Add(numbers);
                }
            }
            return doblesList;
        }
    }
}
