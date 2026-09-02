using System;

class Hero
{
    public string Name;
    public Hero(string name) { Name = name; }
    public override string ToString() => $"Héros {Name}, prêt au combat.";
}

class Marchand
{
    public string Name;
    public Marchand(string name) { Name = name; }
    public override string ToString() => $"Marchand {Name}, vend des objets rares.";
}

class Monster
{
    public string Name;
    public Monster(string name) { Name = name; }
    public override string ToString() => $"Monstre {Name}, hostile et dangereux.";
}

class Inspector
{
    public static void InspectEntity<T>(T entity)
    {
        Console.WriteLine($"Type : {typeof(T).Name}");
        Console.WriteLine($"Description : {entity.ToString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero("cecilia");
        Marchand marchand = new Marchand("bob");
        Monster monster = new Monster("Gobelin");

        Inspector.InspectEntity(hero);
        Inspector.InspectEntity(marchand);
        Inspector.InspectEntity(monster);
    }
}