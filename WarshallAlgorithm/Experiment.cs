using System.Diagnostics;

namespace WarshallAlgorithm;

public static class Experiment
{
    public static void Runs()
    {
        int[] sizes = { 5, 10, 50, 100 };
        int[] percent = { 25, 50, 75 };
        int runs = 3;

        foreach (int n in sizes)
        {
            foreach (int q in percent)
            {
                long totalTicks = 0;

                for (int i = 0; i < runs; i++)
                {
                    int[,] graph = GraphGenerator.GenerateGraph(n, q, '+');

                    Stopwatch sw = Stopwatch.StartNew();
                    int[,] result = Warshall.WarshallAlgorithm(graph);
                    sw.Stop();

                    totalTicks += sw.ElapsedTicks;
                }

                double avgMs = (totalTicks / (double)runs) * 1000 / Stopwatch.Frequency;
                Console.WriteLine($"n = {n}, q = {q}% -> Avg time: {avgMs:F4} ms");
            }
        }
    }
}
