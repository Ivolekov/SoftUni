using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Computer
    {
        private string name;
        private List<Component> component;

        public Computer(string name, List<Component> component)
        {
            this.Name = name;
            this.Component = component;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "You must enter name of the computer");
                }
                this.name = value;
            }
        }

        public List<Component> Component
        {
            get { return this.component; }
            set
            {
                if (value.Count==0)
                {
                    throw new ArgumentOutOfRangeException("components", "You must choose component for the computer");
                }
                this.component = value;
            }
        }

        public static decimal CalculatePrice(Computer comp)
        {
            var components = comp.component;
            decimal price = 0m;
            foreach (var component in components)
            {
                price += component.Price;
            }
            return price;
        }

        public decimal Price
        {
            get {return CalculatePrice(this); }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var component in this.Component)
            {
                result.AppendLine(string.Format("{0}{2} {1:c2}", component.Name, component.Price, 
                    string.IsNullOrWhiteSpace(component.Details) ? ":" : ":" + " " + component.Details + ":"));
            }
            result.AppendLine(string.Format("Total price: {0:c2}", this.Price));
            return result.ToString();
        }
    }
}
