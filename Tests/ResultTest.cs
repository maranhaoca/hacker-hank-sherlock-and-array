using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int> { 5, 6, 8, 11 };

        var expected = "YES";
        var actual = Result.balancedSums(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var arr = new List<int> { 2, 0, 0, 0 };

        var expected = "YES";
        var actual = Result.balancedSums(arr);

        Assert.Equal(expected, actual);
    }    
}
