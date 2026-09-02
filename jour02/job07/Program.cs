using System;
using System.Collections.Generic;

class Weapon
{
    public string Name;
    public Weapon(string name) { Name = name; }
}

class Potion
{
    public string Name;
    public Potion(string name) { Name = name; }
}

class Pouch<T>
{
    private List<T> items = new List<T>();

    public void Store(T item)
    {
        items.Add(item);
    }

    public T Retrieve(int index)
    {
        T item = items[index];
        items.RemoveAt(index);
        return item;
    }

    public int GetCount()
    {
        return items.Count;
    }
}

class Michel
{
    static void Main(string[] args)
    {
        Pouch<Weapon> weaponPouch = new Pouch<Weapon>();
        weaponPouch.Store(new Weapon("Épée courte"));
        weaponPouch.Store(new Weapon("Arc long"));

        Pouch<Potion> potionPouch = new Pouch<Potion>();
        potionPouch.Store(new Potion("Potion de soin"));

        Console.WriteLine($"Armes dans la sacoche : {weaponPouch.GetCount()}");
        Weapon w = weaponPouch.Retrieve(0);
        Console.WriteLine($"Récupéré : {w.Name}");
        Console.WriteLine($"Armes restantes : {weaponPouch.GetCount()}");

        Console.WriteLine($"Potions dans la sacoche : {potionPouch.GetCount()}");
    }
}