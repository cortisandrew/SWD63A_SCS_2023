using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Example
{
    public class HalfSquareSimulator : ISimulator
    {
        private Random random = new Random();

        public double Simulate()
        {
            // Select a point at random on the unit square
            double x = random.NextDouble();
            double y = random.NextDouble();

            // check whether the point is on the "shaded" area
            // the shaded area is the BOTTOM half of the unit square
            bool isPointOnShadedArea = (y < 0.5);

            if (isPointOnShadedArea)
            {
                // return 1 if on shaded area, 0 otherwise
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
