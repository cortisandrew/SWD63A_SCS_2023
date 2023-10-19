using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRandomVariableExperiment
{
    internal class Simulation
    {
        // make sure to initialise this only once!!
        private Random r;
        private int dailyCost = -200;
        private int profitPerSale = 400;

        internal Simulation(Random r)
        {
            this.r = r;
        }

        internal (string, float) Simulate()
        {
            double probabilityResult = r.NextDouble();

            int sales = 0;

            if (probabilityResult < 0.52200625)
            {
                // probability of 0.52200625 of getting
                // 0 sales for the day
                sales = 0;    
            }
            else if (probabilityResult < 0.89048125)
            {
                // probability of 0.89048125 - 0.52200625 = 0.368475
                // of getting 1 sale for the day
                sales = 1;

            } else if (probabilityResult < 0.98801875)
            {
                // probability of 0.98801875 - 0.89048125 = 0.0975375
                // of getting 2 sales for the day
                sales = 2;
            } else if (probabilityResult < 0.99949375)
            {
                // probability of 0.99949375 - 0.98801875 = 0.011475
                // of getting 3 sales for the day
                sales = 3;
            } else
            {
                // probability of 1 - 0.99949375 = 0.00050625
                // of getting 4 sales for the day
                sales = 4;
            }

            return (sales.ToString(), dailyCost + (sales * profitPerSale));
        }
    }
}
