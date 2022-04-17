using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace LexicalAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = File.ReadAllText(@"D:\LexicalAnalyzer\TestFiles\Csharp.txt");
            string[] words = code.Split(' ');
            string[] keywords = LanguageKeywords.GetLangaugeKeywords("C#");
            foreach(var word in words)
            {
               if(keywords.Contains(word))
                {
                    Console.WriteLine($"{word} is Keyword");
                }
            }
        }
    }
}
