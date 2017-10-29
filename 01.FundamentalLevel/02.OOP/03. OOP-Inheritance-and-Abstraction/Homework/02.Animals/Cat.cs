using _02.Animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Cat:Animal
    {
        public Cat(string name,int age):base(name,age)
        {
        }
        public override string ToString()
        {
            {
                return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            }
        }

        public override void ProducedSound()
        {
            Console.WriteLine("Pisi Pisi Pisi");
        }
    }
}
