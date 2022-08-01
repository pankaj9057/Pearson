namespace Pearson;
public class PrimeNumbers
{
    public static IList<string> GeneratePrimeNumbers(int inputRange)
    {
        
        var result = new List<string>();
        for (int i = 2; i <= inputRange; i++)
        {
            var isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if(i%j==0)
                {
                    isPrime = false; 
                    break;
                }
            }
            if(isPrime)
                    result.Add(i.ToString());
        }

        return result;
    }
}
