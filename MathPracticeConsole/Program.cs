using Matrices;

namespace MathPracticeConsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            
            var matrix = new double[rows][];
            
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()?.Split().Select(double.Parse).ToArray() 
                            ?? throw new InvalidOperationException();
            }
            
            var adjMatrix = new AdjacencyMatrix(matrix);
            
            var loops = adjMatrix.FindLoopsInMatrix();
            
            Console.WriteLine(loops.Count == 0 ? "NO LOOPS" : string.Join('\n', loops));
            Console.ReadKey();
        }
    }
}