using System;
using System.Linq;

namespace KataPrac; // Note: actual namespace depends on the project name.

internal class Program
{
    static void Main(string[] args)
    {
        //"TODO: Kata.Solution(string) => string"
        Console.WriteLine(Solution("Shujat"));
        // Console.WriteLine(GetIntegersFromList(new List<object>() { 1, "a", "b", 0, 15 }));
        // Sum of all the integers between and including them and return it
        Console.WriteLine(GetSum(-1, 5));


    }
    public static string Solution(string str)
    {
        // return new string(str.ToArray().Reverse().ToArray());
        char[] charArray = str.ToCharArray();
        string reversedString = String.Empty;
        for (int i = charArray.Length - 1; i > -1; i--)
        {
            reversedString += charArray[i];
        }
        return reversedString;
    }

    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        //return listOfItems.Where(w => w.GetType().Equals(typeof(int))).Select(s => s).Cast<int>().ToList();
        return listOfItems.OfType<int>();
    }
    public static int GetSum(int a, int b)
    {
        // int max = Math.Max(a, b);
        //     int min = Math.Min(a, b);
        //     int result = 0;
        //     for (int i = min; i <= max; i++)
        //     {
        //         result += i;
        //     }
        //     return result;
        int j = 0;
        if (a == b) return a;
        if (a > b)
        {
            for (int i = b; i <= a; i++)
            {
                j = j + i;
            }
            return j;
        }
        else
        {
            for (int i = a; i <= b; i++)
            {
                j = j + i;
            }
            return j;
        }
    }
}