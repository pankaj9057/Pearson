namespace Pearson;

public class Palindrome
{
    public static bool StringIsPalindromeStatus(string inputString)
    {
        string first = inputString.Substring(0, inputString.Length / 2);
        char[] arr   = inputString.ToCharArray();

        Array.Reverse(arr);

        string temp   = new(arr);
        string second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
}
