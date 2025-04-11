namespace WarshallAlgorithm;

public class Warshall
{
    public static int[,] WarshallAlgorithm(int[,] graph)
    {
        int n = graph.GetLength(0);
        int[,] reach = (int[,])graph.Clone();
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    reach[i, j] = reach[i, j] | (reach[i, k] & reach[k, j]);
                }
            }
        }
        return reach;
    }
    
    public static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}