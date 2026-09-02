using System;
using System.Security.Cryptography.X509Certificates;

class MadAdventurer : CorruptedCreature
{
    public MadAdventurer(string Name, int Health) : base(Name, Health)
    {
    }
    public override void TakeMiasmaDamage(int damage)
    {
        this.Health -= damage;
        Console.WriteLine("L'aventurier crie sous l'effet des hallucinations!");
    }
}