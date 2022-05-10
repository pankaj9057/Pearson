using Xunit;
using System.Collections.Generic;
using Pearson;
namespace Pearson.Tests; 
public class NumberToRomanTests
{
    Roman roman;
    public NumberToRomanTests()
    {
        roman = new Roman();
    }
     [Theory]
     [MemberData("TestData")]
    public void Roman_Tests(string expected,int actual)
    {
        Assert.Equal(expected, roman.ConvertToRoman(actual));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]{"XXXIX",39};
        yield return new object[]{"CCXLVI",246};
        yield return new object[]{"DCCLXXXIX",789};
        yield return new object[]{"MMCDXXI",2421};
    }
}