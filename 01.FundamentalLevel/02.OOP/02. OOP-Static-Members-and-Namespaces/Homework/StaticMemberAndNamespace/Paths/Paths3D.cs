using System;
using System.Collections.Generic;

namespace Paths
{
    class Paths3D
    {
        private double[] points;

        public double[] Points
        {
            get { return points; }
            set
            {
                double x = Convert.ToDouble(value[0]);
                double y = Convert.ToDouble(value[1]);
                double z = Convert.ToDouble(value[1]);

                if (x < 0 || y < 0 || z < 0)
                    throw new ArgumentOutOfRangeException();

                this.points = value;
            }
        }

        public Paths3D(double[] points )
        {
            this.Points = points;
        }

    }
}
