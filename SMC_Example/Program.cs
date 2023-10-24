using SMC_Example;

// int simulation = 100;
SMC_Driver driver = new SMC_Driver(new QuarterCircleSimulator());

int[] simulations = new int[] { 100, 10000, 1000000 };

foreach (int simulation in simulations)
{
    double area = driver.RunSimulations(simulation);
    Console.WriteLine($"{simulation} simulations");
    Console.WriteLine($"The estimated area of the quarter circle, using {simulation} simulations, is {area}");
    // the exact area is Pi/4
    Console.WriteLine($"The estmated value of Pi is {area * 4}");
    Console.WriteLine();
}


