using Structures;

namespace MathPracticeConsole.Matrices
{
    public class Ex1 : IMathEx
    {
        public void Run()
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