namespace Algorithms.Graphs;

public class ExercisesHandler
{
    private HashSet<int> cache;

    public ExercisesHandler()
    {
        cache = new HashSet<int>();
    }
    
    /// <summary>
    ///     Проверить есть ли путь между двумя вершинами направленного графа.
    ///     Решение через поиск в глубину DFS.
    /// </summary>
    /// <param name="adjList">Список смежности</param>
    /// <param name="node1">Первая вершина</param>
    /// <param name="node2">Вторая вершина</param>
    public bool IsPathExist(List<List<int>> adjList, int node1, int node2)
    {
        if (adjList.Count == 0)
        {
            return false;
        }

        if (adjList[node1].Contains(node2))
        {
            return true;
        }

        if (!cache.Add(node1))
        {
            return false;
        }

        foreach (var node in adjList[node1])
        {
            if (IsPathExist(adjList, node, node2))
            {
                return true;
            }
        }

        return false;
    }
}
