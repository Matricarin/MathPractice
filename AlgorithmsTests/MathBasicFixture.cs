using Algorithms.Basic;

namespace AlgorithmsTests;

[TestFixture]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class MathBasicFixture
{
    [Test]
    [TestCase(8,4,3,2,-2,0)]
    public void FindPointTest(int px, int py, int qx, int qy, int x, int y)
    {
        var result = MathBasic.FindPoint(px, py, qx, qy);
        Assert.Multiple(() =>
        {
            var resultX = result.First();
            var resultY = result.Last();
            Assert.That(resultX, Is.EqualTo(x));
            Assert.That(resultY, Is.EqualTo(y));
        });
    }
}