using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Example
{
    public class SMC_Driver
    {
        ISimulator simulator;


        public SMC_Driver(ISimulator simulator)
        {
            this.simulator = simulator;
        }

        /// <summary>
        /// Run the simulation n times
        /// </summary>
        /// <param name="n">n is the number of times that the simulation will be executed. It is the "time" used by the SMC</param>
        public double RunSimulations(int n)
        {
            double y_i = 0;
            List<double> y_list = new List<double>(n);

            for (int i = 0; i < n; i++)
            {
                y_i = simulator.Simulate();
                y_list.Add(y_i);
            }

            return y_list.Average();
        }

    }
}
