using System;
using Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        RunicSeal seal = new RunicSeal("Œil d'Ambre");
        seal.Decrire();

        Console.WriteLine();
        Console.WriteLine("test sans la clé");
        SealedDoor doorSansCle = new SealedDoor(false);
        doorSansCle.Open();

        Console.WriteLine();
        Console.WriteLine("test avec la clé");
        SealedDoor doorAvecCle = new SealedDoor(true);
        doorAvecCle.Open();
    }
}