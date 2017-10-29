using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Catalog
    {
        static void Main(string[] args)
        {
            List<Component> components = new List<Component>();
            components.Add(new Component("CPU", 123.43m));
            components.Add(new Component("HDD", 59.45m));
            components.Add(new Component("RAM", 45.50m));
            Computer pc = new Computer("HP", components);
            List<Computer> catalog = new List<Computer>();
            catalog.Add(pc);
            List<Component> components1 = new List<Component>();
            components1.Add(new Component("CPU", 342));
            components1.Add(new Component("Motheboard", 456));
            components1.Add(new Component("Graphics card", 123));
            Computer pc1 = new Computer("Lenovo", components1);
            catalog.Add(pc1);
            List<Component> components2 = new List<Component>();
            components2.Add(new Component("CPU", 145));
            components2.Add(new Component("RAM 4GB", 123.65m));
            Computer pc2 = new Computer("Sony", components2);
            catalog.Add(pc2);

            var catalogSort = catalog.OrderBy(x => x.Price);


            foreach (var item in catalogSort)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
