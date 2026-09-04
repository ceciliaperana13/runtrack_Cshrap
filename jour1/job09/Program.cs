using System;
using System.Collections.Generic;

namespace EnigmeTri
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var mots = new List<string>(args);

            if (mots.Count == 0)
            {
                Console.WriteLine("Aucun mot fourni. exemple: -- mot1 mot2 mot3 ...");
                return;
            }

            var motsTries = TrieMots.Sort(mots);

            Console.WriteLine("Liste d'origine  : " + string.Join(" ", mots));
            Console.WriteLine("Liste triée      : " + string.Join(" ", motsTries));
        }
    }
}