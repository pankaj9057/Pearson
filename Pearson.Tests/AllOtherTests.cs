using Xunit;
using System.Collections.Generic;
using Pearson;
namespace Pearson.Tests; 
public class AllOtherTests
{

    [Fact]
    public void CoinChangeTests()
    {
       var result = CoinChange.GenerateCoinChange(39);
       var expected = new List<string>{
           "1*20p", "1*10p", "1*5p", "2*2p"
       };
       Assert.Equal(expected,result);
    }

    [Fact]
    public void FibonacciTests()
    {
       var result = Fibonacci.Fib(5);
       var expected = "0 1 1 2 3 5 ";
       Assert.Equal(expected,result);
    }

    [Fact]
    public void PalindromeTests()
    {
       var result = Palindrome.StringIsPalindromeStatus("Pankaj");
       var expected = false;
       Assert.Equal(expected,result);
       result = Palindrome.StringIsPalindromeStatus("noon");
       expected = true;
       Assert.Equal(expected,result);
    }


    [Fact]
    public void PrimeNumberTests()
    {
        var result = PrimeNumbers.GeneratePrimeNumbers(11);
        var expected = new List<string>{
           "2", "3", "5", "7","11"
       };
        Assert.Equal(expected, result);
    }
}