namespace Structures
{
    public sealed class AdjacencyList
    {
        private List<int[]?> _list;

        public List<int[]?> Vertexes => _list;

        public void AddVertex(int[]? vertexes)
        {
            _list.Add(vertexes);
        }

        public AdjacencyList()
        {
            _list = new List<int[]?>();
        }
    }
}