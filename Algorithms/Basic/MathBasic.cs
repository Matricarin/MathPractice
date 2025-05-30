namespace Algorithms.Basic;

public static class MathBasic
{
    public static List<int> FindPoint(int px, int py,int qx, int qy)
    {
        if (px == qx && py == qy)
        {
            return [px, py];
        }

        var dir = (qx - px, qy - py);
        var length = Math.Sqrt((qx - px) * (qx - px) + (qy - py) * (qy - py));
        var targetLength = length * 2;
        var normal = (dir.Item1 / length, dir.Item2 / length);
        var target = (px + normal.Item1 * targetLength, py + normal.Item2 * targetLength);
        
        return [(int)target.Item1, (int)target.Item2];
    }
}