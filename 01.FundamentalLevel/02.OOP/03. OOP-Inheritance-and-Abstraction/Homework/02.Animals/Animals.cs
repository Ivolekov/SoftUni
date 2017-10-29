using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Interface;

namespace _02.Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            Cat pisana = new Cat("Pisana", 10);
            Cat pisanche = new Cat("Pisanche", 5);

            Tomcat tomi = new Tomcat("Tomi", 4, Gender.Male);
            Tomcat tomito = new Tomcat("Tomito", 3, Gender.Male);

            Kitten macurana = new Kitten("Macurana", 2, Gender.Female);
            Kitten macuranka = new Kitten("Macuranka", 6, Gender.Female);

            Dog rex = new Dog("Rex", 3);
            Dog karaman = new Dog("Karaman", 1);

            Frog frogy = new Frog("Frogy", 8);
            Frog frogy1 = new Frog("Frogy1", 2);

            Console.WriteLine(pisana);
            Console.WriteLine(tomi);
            Console.WriteLine(pisanche);
            Console.WriteLine(rex);
            Console.WriteLine(frogy);
            IList<Animal> allAnimal = new List<Animal>();
            allAnimal.Add(pisana);
            allAnimal.Add(pisanche);
            allAnimal.Add(tomi);
            allAnimal.Add(tomito);
            allAnimal.Add(macurana);
            allAnimal.Add(macuranka);
            allAnimal.Add(rex);
            allAnimal.Add(karaman);
            allAnimal.Add(frogy);
            allAnimal.Add(frogy1);

            foreach (var kind in allAnimal.GroupBy(x => x.GetType().Name))
            {
                double averageAge = kind.Select(x => x.Age).Average();
                Console.WriteLine("Animal : {0}, AverageAge: {1}", kind.Key, averageAge);
            }
        }
    }
}
