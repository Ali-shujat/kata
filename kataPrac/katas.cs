using System.Globalization;
using System.Linq;

namespace kataPrac
{
    public static class katas
    {
        // To upper case every word first letter in a string
        public static string ToJadenCase(this string phrase)
        {
            return new CultureInfo("en-US").TextInfo.ToTitleCase(phrase);
        }
        public static string seriesSum(int n)
        {
            double result = 0.00;
            if (n == 0) return result.ToString("0.00");
            int counter = 1;
            for (int i = 1; i <= n; i++)
            {
                result += (double)1 / counter;
                counter += 3;
            }
            return String.Format("{0:0.00}", result);
        }
        public static string PrinterError(String s)
        {
            string lowerCaseString = s.ToLower();
            var aplhabet = "nopqrstuvwxyz".ToList();
            int count = (s.Where(v => aplhabet.Contains(v))).Count();
            return String.Format("{0}/{1}", count, s.Length);
        }
    }
}
