
using System;

class Identification
{
    static void Identify(int niveau)
    {
        if (niveau == 0)
            Console.WriteLine("Cette créature est inoffensive.");
        else if (niveau == 1)
            Console.WriteLine("Cette créature est faible.");
        else if (niveau >= 2 && niveau <= 4)
            Console.WriteLine("Cette créature est dangereuse.");
        else
            Console.WriteLine("Cette créature représente un danger énorme !");
    }

    static void Main(string[] args)
    {
        Identify(0);
        Identify(1);
        Identify(3);
        Identify(7);
    }
}