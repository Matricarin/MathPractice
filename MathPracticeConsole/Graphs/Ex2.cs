using Structures;

namespace MathPracticeConsole.Graphs
{
    public class Ex2 : IMathEx
    {
        public void Run()
        {
            var rows = int.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            var matrix = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray() ?? throw new NullReferenceException();
            }

            var adList = new AdjacencyList();

            for(int i = 0; i < rows; i++)
            {
                var list = new List<int>();
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if(matrix[i][j] != 0)
                    {
                        list.Add(j);
                    }
                }
                adList.AddVertex(list.ToArray());
            }

            var content = adList.Vertexes;

            foreach(var item in content)
            {
                if(item == null)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(string.Join(' ', item));
                }
            }
        }
    }
}