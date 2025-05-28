namespace Structures.Graphs
{
    /// <summary>
    ///     Список смежности
    ///     Представляет собой список вершин, представленные в виде массивов
    ///     вершин с которыми она соединена. То есть это список списков.
    /// </summary>
    public sealed class AdjacencyList
    {
        private List<int[]?> _list;

        public List<int[]?> Vertexes => _list;
        
        /// <summary>
        ///     Добавления списка связных вершин
        /// </summary>
        /// <param name="vertexes">null - если вершина ни с кем не соединена</param>
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