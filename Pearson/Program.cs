var palindrome = new Pearson.Palindrome();
Console.WriteLine("Enter input string to get palindrome status ");
var input = Console.ReadLine();
Console.WriteLine($"Palindrome status for {input} : {palindrome.StringIsPalindromeStatus(inputString: input?.ToString().ToLower()!)}");

var roman = new Pearson.Roman();
Console.WriteLine("Enter input number to convert into Roman");
var numberInputForRoman = Console.ReadLine();
Console.WriteLine($"Roman for {numberInputForRoman} is : {roman.ConvertToRoman(Convert.ToInt32(numberInputForRoman))}");

var fibonacci = new Pearson.Fibonacci();
Console.WriteLine("Enter input number to generate fibonacci series");
var numberInputForFibSeries = Console.ReadLine();
Console.WriteLine($"Fibonacci series for {numberInputForFibSeries} is : {fibonacci.Fib(Convert.ToInt32(numberInputForFibSeries))}");

var coinChange =  new Pearson.CoinChange();
Console.WriteLine("Enter the amount (in pence) you want to change : ");
var amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Change for {amount}p is :");
 
foreach(var item in coinChange.GenerateCoinChange(amount))
 {
    Console.WriteLine(item);
 }