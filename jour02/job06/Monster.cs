using System;

public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool IsDangerous { get; set; }

    public Monster(string name, int health, bool isDangerous)
    {
        this.Name = name;
        this.Health = health;
        this.IsDangerous = isDangerous;
    }
}   