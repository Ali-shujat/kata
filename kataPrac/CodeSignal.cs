namespace kataPrac;

internal static class CodeSignal
{
    public static int centuryFromYear(int year)
    {
        double d = 100;
        int f = (int)year / 100;
        if (year % d > 0)
        {
            f++;
        }
        return f;

    }
    public static bool Palindrome(string inputString)
    {
        char[] nameArray = inputString.ToCharArray();
        Array.Reverse(nameArray);
        string reverse = new string(nameArray);

        if (inputString.Equals(reverse, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        return false;
    }

    public static int ArrayLargest(int[] arr)
    {
        if (arr.Length == 2) { return arr[0] * arr[1]; }
        var newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            newArr[i] = arr[i] * arr[i + 1];
        }
        int maxValue = newArr.Max();
        int p = Array.IndexOf(newArr, maxValue);
        if (p == arr.Length - 1) { return arr[p]; }
        int q = arr[p] * arr[p + 1];
        return q;
        //    return inputArray.Select((i, j) => j > 0 ? i * inputArray[j-1] : int.MinValue).Max();

    }

    public static int polygons(int n)
    {
        int a = n - 1;
        int b = a + n;

        int k = 0;
        for (int i = b - 2; i >= 1; i -= 2)
        {
            k += (i + i);
        }
        return k + b;
        //return n * n + (n - 1) * (n - 1);
    }

}
