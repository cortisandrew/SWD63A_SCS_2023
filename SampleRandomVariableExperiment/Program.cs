using SimpleRandomVariableExperiment;

// The Random is a Lagged Fibonacci Generator
// usually not a good PRNG
// If you need simulations for your dissertation do not use this!
Random r = new Random();

// Initialise the random generator only once!!

int numberOfSimlations = 3650000;

var simulator = new Simulation(r);

//Dictionary<string, int> countsOfEachEvent = new Dictionary<string, int>();
List<float> allProfits = new List<float>(numberOfSimlations);

for (int i = 0; i < numberOfSimlations; i++)
{
    (string, float) dailyResult = simulator.Simulate();
    //Console.WriteLine($"After simulating a day, we have sold {dailyResult.Item1} products for a profit/loss of {dailyResult.Item2}");
    allProfits.Add(dailyResult.Item2);
}

Console.WriteLine($"The mean of the profit was {allProfits.Average()}");