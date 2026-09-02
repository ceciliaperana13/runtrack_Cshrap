using System;
//main instanciez une gargouille de 100 PV avec 15 d'armure et affichez ses caractéristiques complètes dans la console.
class Program
{
    static void Main(string[] args)
    {
        CorruptedGargoyle gargoyle = new CorruptedGargoyle("Gargouille", 100, 15);
        Console.WriteLine($"Nom : {gargoyle.Name}");
        Console.WriteLine($"Santé : {gargoyle.Health}");
        Console.WriteLine($"Valeur d'armure : {gargoyle.ArmorValue}");
    }
}