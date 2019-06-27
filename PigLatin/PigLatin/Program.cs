using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your word!");
                string word = Console.ReadLine();
                if(word == "stop")
                {
                    break;
                }
                else
                {
                    PigLatin(word);
                }
            }
           
            Console.ReadLine();
        }
        static void PigLatin(string word)
        {
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            char[] vows = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string first = word.Substring(0, 1);
            string last = word.Substring(word.Length - 1);
            if (vowels.Contains(first) && vowels.Contains(last))
            {
                Console.WriteLine(word + "yay");
            }
            else if (vowels.Contains(first) && !vowels.Contains(last))
            {
                Console.WriteLine(word + "ay");
            }
            else if (word.IndexOfAny(vows) == -1)
            {
                Console.WriteLine(word + "ay");
            }
            else if (word.IndexOfAny(vows) >= 0 && !vowels.Contains(first))
            {
                string beforevowel = word.Substring(0, word.IndexOfAny(vows));
                string afterwithvowel = word.Substring(word.IndexOfAny(vows));
                Console.WriteLine(afterwithvowel + beforevowel + "ay");
                
            }

        }
    }
}
