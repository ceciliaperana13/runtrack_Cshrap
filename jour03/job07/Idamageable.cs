namespace CombatGolem
{
  
    /// Contrat pour toute entité pouvant subir des dégâts.
    public interface IDamageable
    {
        void TakeDamage(int amount);
    }
}