using System.Text;
namespace Pearson;

public class Fibonacci
{ 
public string Fib(int max)
{
    if(max<=0)
    {
        return "0";
    }
    int i = 0;
    StringBuilder result = new StringBuilder();

    for (int j = 1; j <= max; j += i)
    {
        result.Append(string.Format("{0} {1} ", i, j));
        i += j;
    }

    if (i <= max)
        result.Append(i);

    return result.ToString();
}
}
  