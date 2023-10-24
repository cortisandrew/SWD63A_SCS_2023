using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Example
{
    public class QuarterCircleSimulator : ISimulator
    {
        private Random random = new Random();

        public double Simulate()
        {
            // Select a point at random on the unit square
            double x = random.NextDouble();
            double y = random.NextDouble();

            // check whether the point is on the "shaded" area
            bool isPointOnShadedArea = false;

            // find (Euclidean) distance between the point and the centre of the circle
            // if the distance is greater (or equal to) than the radius, no collision
            // else the point is on the circle (i.e. shaded area)

            /*
            double centreX = 0; // coordinates of the centre of the circle
            double centreY = 0;
            */
            double radius = 1; // radius of the circle

            /*
            double distanceFromCentre =
                Math.Sqrt(
                    ((x-centreX) * (x-centreX)) + ((y-centreY) * (y-centreY)
                    );
            */
            double distanceFromCentre =
                Math.Sqrt(
                    (x * x) + (y * y)
                    );

            if ( distanceFromCentre < radius )
            {
                isPointOnShadedArea = true;
            }
            else
            {
                isPointOnShadedArea = false;
            }

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
