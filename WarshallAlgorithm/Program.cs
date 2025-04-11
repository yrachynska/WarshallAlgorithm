
using WarshallAlgorithm;

Console.WriteLine("Enter number of vertices: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter density in percents: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("If you want oriented graph enter '+', if no enter '-' : ");
char or = Convert.ToChar(Console.ReadLine());
int[,] graph= GraphGenerator.GenerateGraph(n, q, or);
GraphGenerator.Print(graph);

Console.WriteLine("Transitive closure of a graph:");
int[,] closure = Warshall.WarshallAlgorithm(graph);
Warshall.PrintMatrix(closure);
