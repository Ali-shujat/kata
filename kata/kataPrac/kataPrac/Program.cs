using System;
using System.Linq;
using System.Text;

namespace KataPrac; // Note: actual namespace depends on the project name.

internal class Program
{
    static void Main(string[] args)
    {
        var t = new object[] { 66, 101 };
        string st = "AbCdefgH";
        var haystack_2 = new object[] { "283497238987234", "a dog", "a cat", "junk", "a piece of hay", "needle", "ago" };
        // //Find array contains 
        // Console.WriteLine(Check(t, 10));
        // // Array to string 
        // Console.WriteLine(Smash(new string[] { "hello", "amazing", "world" }));
        // // transform a string into a number
        // Console.WriteLine(StringToNumber("1405"));
        // //How many true in array
        // Console.WriteLine(CountSheeps(new bool[] { true, false, true, false, true }));
        // //"found the needle at position "
        // Console.WriteLine(FindNeedle(haystack_2));
        Console.WriteLine(Accum(st));
        Console.WriteLine(Accum1(st));
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

   
    public static bool Check(object[] a, object x) => a.Contains(x);
    public static string Smash(string[] words) => string.Join(" ", words);
    public static int StringToNumber(String str) => int.Parse(str);

    public static int CountSheeps(bool[] sheeps)
    {
        bool[] b = Array.FindAll(sheeps, x => x == true);
        return b.Count();
        //return sheeps.Count(s => s);
    }
    public static string FindNeedle(object[] haystack)
    {
        var p = Array.IndexOf(haystack, "needle");
        return ("found the needle at position " + p);
        //  return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
    }
    public static String Accum(string s)
    {
        char[] ch = s.ToCharArray();
        var strA = new List<char>();
        int counter = 0;

        foreach (char c in ch)
        {
            counter++;
            //int count = Array.IndexOf(ch, c);
            for (int i = 0; i < counter; i++)
            {
                if (i == 0)
                {
                    strA.Add(Char.ToUpper(c));
                }
                else
                {

                    strA.Add(Char.ToLower(c));
                }
            }
            strA.Add('-');

        }
        var d = String.Concat(strA);
        return d.Remove(d.Length - 1);

    }
    public static string Accum1(string s)
    {
        if (s.Length < 1) return "";

        StringBuilder sb = new StringBuilder();
        int count = 1;
        foreach (char c in s.ToLower())
            sb.Append(Char.ToUpper(c), 1)
              .Append(c, count++ - 1)
              .Append('-');

        return sb.ToString().TrimEnd('-');
    }



}