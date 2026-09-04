using System;

class List
{
    static void ListTargets(string[] targets)
    {
        for (int i = 0; i < targets.Length; i++)//possible de mettre for each  pour simplifier 
        {
            Console.WriteLine($"Mannequin : {targets[i]}");
        }
    }

    static void Main(string[] args)
    {
        string[] targets = { "Premier", "Deuxième", "Troisième", "Quatrième", "Cinquième","...","Centième" };
        ListTargets(targets);
    }
}
