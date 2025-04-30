namespace Matrices;

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