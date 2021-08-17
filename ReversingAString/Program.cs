using System;

namespace ReversingAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("abcde"));
        }

        public static string ReverseString(string s)
        {
            if (s.Length <= 100)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            throw new Exception("The input string is too long!");
        }
    }
}
