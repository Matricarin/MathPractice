using Algorithms.Graphs;

namespace AlgorithmsTests;

[TestFixture]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class ExerciseFixture
{
    [TestCaseSource(typeof(ExerciseFixtureData), nameof(ExerciseFixtureData.Data))]
    public void IsPathExistTest(List<List<int>> adjList, int node1, int node2, bool expected)
    {
        var handler = new ExercisesHandler();
        var result = handler.IsPathExist(adjList, node1, node2);
        Assert.That(result, Is.EqualTo(expected));
    }
}

public class ExerciseFixtureData
{
    public static object[] Data = new object[]
    {
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new() { 2 },
                new() { 3 },
                new() { 4 },
                new() { 5, 6 },
                new() { 3 },
                new()
            },
            2,
            6,
            true
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new() { 2 },
                new()
            },
            0,
            0,
            false
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new() { 2 },
                new() { 0 },
                new()
            },
            0,
            3,
            false
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new() { 2 },
                new(),
                new() { 4 },
                new()
            },
            0,
            4,
            false
        },
        new object[]
        {
            new List<List<int>>
            {
                new(),
                new(),
                new(),
                new()
            },
            0,
            3,
            false
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new() { 2 },
                new() { 3 },
                new()
            },
            0,
            3,
            true
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 0, 1 },
                new() { 2 },
                new()
            },
            0,
            2,
            true
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1 },
                new(),
                new() { 0 }
            },
            0,
            2,
            false
        },
        new object[]
        {
            new List<List<int>>(),
            0,
            0,
            false
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1, 2 }, 
                new() { 3 },      
                new() { 3 },      
                new() { 4 },      
                new()              
            },
            0,
            4,
            true
        },
        new object[]
        {
            new List<List<int>>
            {
                new() { 1, 2 },    
                new() { 3 },        
                new() { 1, 4 },      
                new() { 5 },         
                new() { 5 },         
                new() { 6 },        
                new() { 2 }         
            },
            0,
            6,
            true
        },
    };
}