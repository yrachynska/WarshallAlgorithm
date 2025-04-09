namespace WarshallAlgorithm;

public class GraphGenerator
{
    public static char[,] GenerateGraph(int n, int q)
    {
        char[,] matrix = new char[n,n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = '0';
            }
        }
        
        int maxEdges = n * (n - 1) / 2;
        int edges = maxEdges * q / 200;

        HashSet <(int,int)> listDistances = new HashSet<(int, int)>();
        Random rnd = new Random();

        while (edges > 0)
        { 
            int i = rnd.Next(1, n);
            int j = rnd.Next(0, i);

            if (!listDistances.Contains((i,j)))
            {
                listDistances.Add((i,j));
                listDistances.Add((j,i));
                edges--;
            }
        }

        foreach (var point in listDistances)
        {
            matrix[point.Item1, point.Item2] = '1';
        }
        
        return matrix;
    }

    public static void Print(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}