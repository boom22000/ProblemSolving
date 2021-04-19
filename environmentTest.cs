using System;

namespace cSharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "test", "hello", "Sung`s", "Git", "Welcome guys" };
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}", s[i]);
            }
        }
    }
}
