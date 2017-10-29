using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public abstract class Animal : _02.Animals.Interface.ISoundProducable
    {
        private string name;
        private int age;

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public abstract override string ToString();
        public abstract void ProducedSound();
    }
}
