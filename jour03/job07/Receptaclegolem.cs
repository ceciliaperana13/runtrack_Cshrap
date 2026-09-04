using System;

namespace CombatGolem
{
    public sealed class ReceptacleGolem : BossEntity
    {
        public ReceptacleGolem() : base("Golem Réceptacle", 200) { }

        public override void ExecutePhasePattern()
        {
            double pourcentageVie = (double)Health / MaxHealth * 100;

            if (pourcentageVie > 50)
            {
                // attaque physique brute
                Console.WriteLine($"  {Name} lève son poing de pierre et frappe : \"Coup de poing de pierre\" !");
            }
            else
            {
                Console.WriteLine("  !! Une fissure du sceau irradie d'une lueur malsaine !!");
                Console.WriteLine($"  {Name} laisse déborder la présence maléfique emprisonnée et déclenche une attaque de zone mentale !");
            }
        }
    }
}