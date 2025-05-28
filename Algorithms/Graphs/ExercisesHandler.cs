namespace Algorithms.Graphs;

public class ExercisesHandler
{
    private HashSet<int> cache;

    public ExercisesHandler()
    {
        cache = new HashSet<int>();
    }

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
