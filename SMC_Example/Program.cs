using SMC_Example;

// int simulation = 100;
SMC_Driver driver = new SMC_Driver(new HalfSquareSimulator());
    //new QuarterCircleSimulator());

int[] simulations = new int[] { 10000 };

foreach (int simulation in simulations)
{
    driver.RunSimulations(simulation);
    double area = driver.EstimateMu();
    double RMSE = driver.RMSE();

    Console.WriteLine($"{simulation} simulations");
    // the exact area is Pi/4
    Console.WriteLine($"The estimated area of the quarter circle, using {simulation} simulations, is {area}");
    Console.WriteLine($"The RMSE of the simulation is: {RMSE}");
    
    Console.WriteLine($"The estmated value of Pi is {area * 4}");
    Console.WriteLine();
}


