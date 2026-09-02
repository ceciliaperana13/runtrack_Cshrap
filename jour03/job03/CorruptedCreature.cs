using System;

//CorruptedCreature avec les propriétés name, health et un constructeur initialisant ces valeurs.
class CorruptedCreature
{
    public string Name { get; set; }
    public int Health { get; set; }

    public CorruptedCreature(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
}