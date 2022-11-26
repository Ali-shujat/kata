using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kataPrac
{
    internal class Onsite
    {
        //static void Main(string[] args)
        //{
        //    // var strings = new string[] { "1", "02", "003", "0004", "00005" };

        //    // string longest = strings.OrderByDescending(s => s.Length).First();
        //    // Console.WriteLine("Hello World!");
        //    // Console.WriteLine(largestPair(49999));
        //    //Console.WriteLine(ClosestEnemy(new int[] { 1, 0, 0, 0, 2, 2, 2, 0, 1 }));
        //    //Console.WriteLine(EquivalentKeypresses(new string[] { "a,b,c,d", "g,-B,a,b,c,d,-B,d" }));
        //    //Console.WriteLine(MinWindowSubstring(new string[] { "aaabaaddae", "aed" }));
        //    //Console.WriteLine(LongestString());
        //    //Console.WriteLine(FirstFactorial(4));
        //    //Console.WriteLine(LongestWord("dkjs lk fajdfs dlf jalköj öajk djfdls askla"));
        //    Console.WriteLine(NonrepeatingCharacter("hello world hi hey"));
        //}

        private static string EquivalentKeypresses(string[] strings)
        {
            List<string> str1 = strings[0].Split(',').ToList();
            List<string> str2 = strings[1].Split(',').ToList();
            List<int> itemIndex = new();
            for (int i = 0; i < str2.Count(); i++)
            {
                if (str2[i] == "-B")
                {
                    str2.RemoveAt(i - 1);
                    itemIndex.Add(i - 1);
                    Console.WriteLine("first string value: " + str2[i]);
                    Console.WriteLine("first string index: " + i);
                }
            }
            str2 = str2.Where(w => w != "-B").ToList();

            bool isEqual = Enumerable.SequenceEqual(str1, str2);
            return String.Format("{0}", isEqual);
        }

        private static int ClosestEnemy(int[] arr)
        {
            int maxArr = arr.Max();
            int minArr = arr.Min() + 1;

            List<int> maxIndex = new List<int>();
            List<int> minIndex = new();
            List<int> closestEnemy = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    maxIndex.Add(i);
                }
                if (arr[i] == 1)
                {
                    minIndex.Add(i);
                }
            }
            foreach (int maxI in maxIndex)
            {
                foreach (int minI in minIndex)
                {
                    Console.WriteLine("{0} -- {1}", maxI, minI);
                    closestEnemy.Add(Math.Abs(maxI - minI));
                }
            }

            return closestEnemy.Min();
            //Math.Abs(maxIndex - minIndex);

        }

        private static int largestPair(int v)
        {
            List<string> stringList = new();
            int m = 0;
            v = Math.Abs(v);
            if (v < 10) return v;
            while (v >= 10) // if you want to accept single digits change this to v > 0
            {
                m = Math.Max(m, v % 100);
                v /= 10;
            }
            return m;
        }

        public static string MinWindowSubstring(string[] strArr)
        {
            var n = strArr[0];
            var k = strArr[1];
            var dic = new Dictionary<char, int>();

            foreach (var s in k)
            {
                if (dic.ContainsKey(s))
                    dic[s] = dic[s] + 1;
                else
                    dic[s] = 1;
            }

            for (int i = k.Length; i <= n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (j + i <= n.Length)
                    {
                        var sub = n.Substring(j, i).ToCharArray();
                        if (dic.Keys.All(key => sub.Count(s => s == key) >= dic[key]))
                        {
                            return new string(sub);
                        }
                    }
                }
            }

            // code goes here  
            return "";


        }

        public static string LongestString()
        {
            string[] arr = { "c++", "python", "c#", "java", "shujat", "halloween" };
            string longest = arr.OrderByDescending(s => s.Length).First();
            string longest_string = arr[0];
            foreach (string s in arr)
            {
                if (s.Length > longest_string.Length)
                {
                    longest_string = s;
                }
            }
            Console.Write(longest_string + "\n");
            Console.Write(longest);
            return "";
        }
        public static int FirstFactorial(int num)
        {

            for (int i = num - 1; i > 0; i--)
            {
                num = num * i;
            }

            return num;
        }

        public static string LongestWord(string sen)
        {

            Regex rgx = new Regex(@"[^\w\s]");
            sen = rgx.Replace(sen, "");
            string[] words = sen.Split(' ');

            return words.OrderByDescending(x => x.Length).First();

        }

        static int LargestFour(int[] arr)
        {
            int value = 0;
            Array.Sort(arr);
            if (arr.Length < 4)
            {
                return arr.Sum();
            }
            for (int i = arr.Length - 1; i >= arr.Length - 4; i--)
            {
                value += arr[i];
            }
            return value;

        }

        public static string NonrepeatingCharacter(string str)
        {
            char y = str.GroupBy(x => x).First(g => g.Count() == 1).Key;
            return y.ToString();

        }
    }
}
