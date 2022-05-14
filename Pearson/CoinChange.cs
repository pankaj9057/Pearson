 using System.Text;
 namespace Pearson;
 public class CoinChange
 {
    public IList<string> GenerateCoinChange(int amount)
    {
        var list = new List<string>();
        int[] coins = {100,50,20, 10, 5,2, 1 };
        int count, i;
        for (i = 0; i <coins.Length; i++)
        {
            count = amount / coins[i];
            if (count != 0)
            {              
                list.Add($"{count}*{coins[i]}p");
            }
            amount %= coins[i];
        }
        return list;
    }
}