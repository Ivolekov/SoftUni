//Define a class Laptop that holds the following information about a laptop device: 
//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    internal class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private Battery battery;
        private string screen;
        private decimal price;

        public Laptop(string model, string manufacturer, string processor, int ram,
            string graphicsCard, string hdd, string screen, string batteryType, double batteryLife, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Price = price;
            this.BatteryType = new Battery(batteryType, batteryLife);
            this.Screen = screen;
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;         
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("model","The field \"model\" can not be empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("manufacturer", "The field \"manufacturer\" can not be empty");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("processor", "The field \"processor\" can not be empty");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ram", "The field \"ram\" can not be negative");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("graphicsCars", "The field \"graphics card\" can not be empty");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("hdd", "The field \"hdd\" can not be empty");
                }
                this.hdd = value;
            }
        }

        

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "The field \"price\" can not be negative");
                }
                this.price = value;
            }
        }

        public Battery BatteryType { get; set; }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("screen", "The field \"screen\" can not be empty");
                }
                this.screen = value;
            }
        }

        public override string ToString()
        {
            StringBuilder laptopInfo = new StringBuilder();
            laptopInfo.AppendLine("model: " +  this.Model);
            laptopInfo.AppendLine("manifacturrer: " + this.Manufacturer);
            laptopInfo.AppendLine("processor: " + this.Processor);
            laptopInfo.AppendLine("RAM: " + this.Ram);
            laptopInfo.AppendLine("graphics card: " + this.GraphicsCard);
            laptopInfo.AppendLine("HDD: " + this.Hdd);
            laptopInfo.AppendLine("screen: " + this.Screen);
            laptopInfo.AppendLine("battery: " + this.BatteryType);
            laptopInfo.AppendLine("battery life: " + battery + " hours");
            laptopInfo.AppendFormat("price: {0:F2}lv.", this.Price);

            return laptopInfo.ToString();
        }
    }

   
    
}