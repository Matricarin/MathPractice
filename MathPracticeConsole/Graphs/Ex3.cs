using Structures;
using Structures.Graphs;

namespace MathPracticeConsole.Graphs
{
    public class Ex3 : IMathEx
    {
        public void Run()
        {
            var amountOfVertices = int.Parse(Console.ReadLine() ?? throw new NullReferenceException("Can't parse input value"));
            var adList = new AdjacencyList();
            
            for(int i = 0; i < amountOfVertices; i++)
            {
                adList.AddVertex(ReadIntArray());    
            }
            
            var vertices = adList.Vertexes;
            var matrix = new double[vertices.Count][];

            for(int j = 0; j < matrix.Length; j++)
            {
                if(vertices[j] == null)
                {
                    var v = new double[amountOfVertices];
                    matrix[j] = v;
                }
                else
                {
                    var arr = new double[amountOfVertices];
                    
                    for(int index = 0; index < arr.Length; index++)
                    {
                        if(vertices[j].Any(v => v == index))
                        {
                            arr[index] = 1;
                        }
                        else
                        {
                            arr[index] = 0;
                        }
                    }
                    matrix[j] = arr;
                }
            }
            
            var k = 0;
            
            foreach(var item in matrix)
            {
                Console.WriteLine($"vert{k++}: " + string.Join(' ', item));
            }
        }

        private int[]? ReadIntArray()
        {
            var s = Console.ReadLine();
            
            if(!string.IsNullOrEmpty(s))
            {
                return s.Split(' ').Select(int.Parse).ToArray();
            }

            return null;
        }
    } 
}