using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Component
    {
        private string name;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;    
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "The name can not be empty");
                }
                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "The price can not be negative");
                }
                this.price = value;
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
