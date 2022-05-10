using Xunit;
using System.Collections.Generic;
using Pearson;
namespace Pearson.Tests; 
public class AllOtherTests
{
    CoinChange coinChange;
    Fibonacci fibonacci;
    Palindrome palindrome;
    public AllOtherTests()
    {
        coinChange = new CoinChange();
        fibonacci = new Fibonacci();
        palindrome = new Palindrome();        
    }

    [Fact]
    public void CoinChangeTests()
    {
       var result = coinChange.GenerateCoinChange(39);
       var expected = new List<string>{
           "1*20p", "1*10p", "1*5p", "2*2p"
       };
       Assert.Equal(expected,result);
    }

  [Fact]
    public void FibonacciTests()
    {
       var result = fibonacci.Fib(5);
       var expected = "0 1 1 2 3 5 ";
       Assert.Equal(expected,result);
    }

      [Fact]
    public void PalindromeTests()
    {
       var result = palindrome.StringIsPalindromeStatus("Pankaj");
       var expected = false;
       Assert.Equal(expected,result);
       result = palindrome.StringIsPalindromeStatus("noon");
       expected = true;
       Assert.Equal(expected,result);
    }

}