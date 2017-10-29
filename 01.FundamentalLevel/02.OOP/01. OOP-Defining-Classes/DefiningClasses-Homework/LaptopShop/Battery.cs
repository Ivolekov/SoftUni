using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(double batteryLife)
        {
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("batteryType", "The field \"baterry\" can not be empty");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("batteryLife", "The field \"baterry life\" can not be negative");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();

            batteryInfo.AppendLine("battery: " + this.BatteryType);
            batteryInfo.AppendLine("battery life: " + this.BatteryLife + " hours");

            return batteryInfo.ToString();
        }
    }
}
