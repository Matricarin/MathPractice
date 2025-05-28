namespace Structures.Graphs;

/// <summary>
///     Матрица смежности
///     Представляет собой матрицу n * n, где n - количество вершин графа,
///     а значение (i,j) представляет собой ребро графа, 1 - если ребро
///     существует, 0 - если нет.
/// </summary>
public sealed class AdjacencyMatrix
{
    private readonly double[][] _matrix;

    public AdjacencyMatrix(double[][] matrix)
    {
        if (!IsSquareMatrix(matrix))
        {
            throw new ArgumentException("The matrix must be square.");
        }
        _matrix = matrix;
    }

    public AdjacencyMatrix(int rows, int columns)
    {
        if (rows == columns)
        {
            throw new ArgumentException("The matrix must be square.");
        }
        
        _matrix = new double[rows][];
        
        for (int i = 0; i < rows; i++)
        {
            _matrix[i] = new double[columns];
        }
    }
    
    /// <summary>
    ///     Выводит список индексов вершин, на которых есть петли. 
    /// </summary>
    /// <returns></returns>
    public List<int> FindLoopsInMatrix()
    {
        var loops = new List<int>();
        var rows = _matrix.Length;
        for (int i = 0; i < rows; i++)
        {
            var columns = _matrix[i].Length;
            for (int j = 0; j < columns; j++)
            {
                if (i == j)
                {
                    if (_matrix[i][j] != 0)
                    {
                        loops.Add(i);
                    }
                }
            }
        }
        return loops;
    }

    /// <summary>
    ///     Проверка явлется ли созданная матрица квадратной, так как
    ///     матрица должна быть n * n, где n - количество вершин
    /// </summary>
    /// <param name="matrix">матрица</param>
    private bool IsSquareMatrix(double[][] matrix)
    {
        var rows = matrix.Length;
        for (int i = 0; i < rows; i++)
        {
            var columns = matrix[i].Length;
            if (rows != columns)
            {
                return false;
            }
        }
        return true;
    }
}