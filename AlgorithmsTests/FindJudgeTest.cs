using Algorithms.Basic;

namespace AlgorithmsTests;

[TestFixture]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class FindJudgeTest
{
    [TestCaseSource(typeof(FindJudgeData), nameof(FindJudgeData.Data))]
    public void IsPathExistTest(int n, int[][] trust, int expected)
    {
        var result = EasyBasic.FindJudge(n, trust);
        Assert.That(result, Is.EqualTo(expected));
    }
}

public class FindJudgeData
{
    public static object[] Data = new object[]
    {
        new object[]
        {
            2,
            new int[][]
            {
                [1, 2]
            },
            2
        }
    };
}
