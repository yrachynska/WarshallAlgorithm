
using WarshallAlgorithm;

Console.WriteLine("Enter number of vertices: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter density in percents: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("If you want oriented graph enter '+', if no enter '-' : ");
char or = Convert.ToChar(Console.ReadLine());
GraphGenerator.Print(GraphGenerator.GenerateGraph(n, q, or));
