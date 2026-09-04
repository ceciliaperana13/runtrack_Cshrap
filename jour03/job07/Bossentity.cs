using System;

namespace CombatGolem
{
    /// Classe abstraite commune à tous les boss du donjon.
    public abstract class BossEntity : IDamageable
    {
        public string Name { get; }
        public int Health { get; protected set; }
        public int MaxHealth { get; }

        protected BossEntity(string name, int health)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
        }

        public bool EstVaincu => Health <= 0;

        public virtual void TakeDamage(int amount)
        {
            Health = Math.Max(0, Health - amount);
            Console.WriteLine($"  {Name} subit {amount} dégâts (santé restante : {Health}/{MaxHealth}).");
        }

        
        /// Chaque boss définit son propre comportement de combat, dépendant en général de son état de santé.
        public abstract void ExecutePhasePattern();
    }
}
