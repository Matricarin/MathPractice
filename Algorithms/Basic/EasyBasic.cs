using System.Text;

namespace Algorithms.Basic;

public static class EasyBasic
{
    public static string AddBinary(string a, string b)
    {
        var i = a.Length - 1;
        var j = b.Length - 1;
        var carry = 0;
        var result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            var sum = carry;

            if (i >= 0)
            {
                sum += a[i--] - '0';
            }

            if (j >= 0)
            {
                sum += b[j--] - '0';
            }

            result.Insert(0, (sum % 2).ToString());
            carry = sum / 2;
        }

        return result.ToString();
    }

    public static List<int> ZigZagSequence(List<int> input)
    {
        var ordered = input.OrderBy(i => i).ToList();
        var first = ordered.Take(ordered.Count  / 2);
        var second = ordered.GetRange(ordered.Count / 2, ordered.Count - (ordered.Count - 2));
        var union = first.Union(second).ToList();
        return union;
    }
    
    public static int FindJudge(int n, int[][] trust) 
    {
        var relations = new Relation[n];
        foreach (var relation in trust)
        {
            relations[relation[0] - 1].Out++;
            relations[relation[1] - 1].In++;
        }
        for (int i = 0; i < n; i++)
        {
            if (relations[i].Out == 0 && relations[i].In == n - 1)
            {
                return i + 1;
            }
        }

        return -1;
    }

    private struct Relation
    {
        public int In;
        public int Out;
        public Relation()
        {
            In = 0;
            Out = 0;
        }
    }
}