using System;
namespace Pol1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите слово или число");
            string word = Console.ReadLine();
            int l = word.Length;
            if (l % 2 == 0)
            {
                string wo = word.Substring(0, l/2);
                string rd = Secw(word);
                Comp(wo, rd);
                
            }
            else
            {
                string wo = word.Substring(0,l/2+1);
                string rd = Secw(word);
                Comp(wo, rd);
            }

            Console.ReadLine();
        }
        static void Comp(string v, string v2)
        {
            if (v == v2)
                Console.WriteLine("полиндром");
            else Console.WriteLine("не полиндром");

        }
        static string Secw(string s) 
        {
            string v = "";
            for (int i = s.Length; i > s.Length/2; i--)
            {
                v = v + s[i - 1];
            }
            return v;
        }
    }
    
}