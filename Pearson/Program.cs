Console.WriteLine("Enter input string to get palindrome status ");
var input = Console.ReadLine();
Console.WriteLine($"Palindrome status for {input} : {Pearson.Palindrome.StringIsPalindromeStatus(inputString: input?.ToString().ToLower()!)}");

var roman = new Pearson.Roman();
Console.WriteLine("Enter input number to convert into Roman");
var numberInputForRoman = Console.ReadLine();
Console.WriteLine($"Roman for {numberInputForRoman} is : {roman.ConvertToRoman(Convert.ToInt32(numberInputForRoman))}");

Console.WriteLine("Enter input number to generate fibonacci series");
var numberInputForFibSeries = Console.ReadLine();
Console.WriteLine($"Fibonacci series for {numberInputForFibSeries} is : {Pearson.Fibonacci.Fib(Convert.ToInt32(numberInputForFibSeries))}");

Console.WriteLine("Enter the amount (in pence) you want to change : ");
var amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Change for {amount}p is :");
 
foreach(var item in Pearson.CoinChange.GenerateCoinChange(amount))
 {
    Console.WriteLine(item);
 }


Console.WriteLine("Enter the number range to generate prime number : ");
var primeNumberRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Prime numbers for {primeNumberRange} are :");

foreach (var item in Pearson.PrimeNumbers.GeneratePrimeNumbers(primeNumberRange))
{
    Console.WriteLine(item);
}