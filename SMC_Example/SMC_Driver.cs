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

        List<double> y_list = new List<double>();

        public SMC_Driver(ISimulator simulator)
        {
            this.simulator = simulator;
        }

        /// <summary>
        /// Run the simulation n times
        /// </summary>
        /// <param name="n">n is the number of times that the simulation will be executed. It is the "time" used by the SMC</param>
        public void RunSimulations(int n)
        {
            double y_i = 0;
            y_list.Clear();
            //List<double> y_list = new List<double>(n);

            for (int i = 0; i < n; i++)
            {
                y_i = simulator.Simulate();
                y_list.Add(y_i);
            }
        }

        public double EstimateMu()
        {
            // this is the value mu hat _n and it is an estimate (hat) of mu using exactly n simulations
            return y_list.Average();
        }

        // If you are estimating sigma, then this is the estimated RMSE
        public double RMSE()
        {
            //double sigma = 0.4105; // "magic value" - given in slides. Usually in the home assignment you would want to calculate this....

            // estimated sigma if you are unable to obtain the value
            //double sigma_squared = y_list.Sum(x => (x - y_list.Average()) * (x - y_list.Average())) / y_list.Count;

            double sigma = Math.Sqrt(y_list.Sum(x => (x - y_list.Average()) * (x - y_list.Average()))/y_list.Count);

            return sigma / Math.Sqrt(y_list.Count);
        }

    }
}
