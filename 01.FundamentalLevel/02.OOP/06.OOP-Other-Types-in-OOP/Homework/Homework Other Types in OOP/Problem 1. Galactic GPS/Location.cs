namespace Problem_1.Galactic_GPS
{
    using System;

    public struct Location
    {
        private double latitude;
        private double longtitude;

        public Location(double latidude, double longtitude, Planet planet)
            : this()
        {
            this.Latitude = latidude;
            this.Longtitude = longtitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be between -90 and 90.");
                }
                this.latitude = value;
            }
        }

        public double Longtitude
        {
            get
            {
                return this.longtitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be between -180 and 180.");
                }
                this.longtitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
        }
    }
}