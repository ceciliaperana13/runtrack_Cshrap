using System;

namespace DonjonFinal
{
    //Énumération des rôles possibles
    public enum Role
    {
        Guerrier, 
        Mage,
        Boss
    }

    // Struct immuable pour les statistiques de base
    public readonly struct Stats
    {
        public int Vie { get; }
        public int Attaque { get; }
        public int Defense { get; }

        public Stats(int vie, int attaque, int defense)
        {
            Vie = vie;
            Attaque = attaque;
            Defense = defense;
        }
    }

    //  Classe Combatant utilisée pour le joueur, Sameth et le Boss
    public class Combatant
    {
        public string Nom { get; }
        public Role Role { get; }
        public Stats StatsBase { get; }

        //Encapsulation : la vie est protégée, accessible uniquement en lecture depuis l'extérieur
        private int _santeActuelle;
        public int SanteActuelle => _santeActuelle;

        public bool EstVivant => _santeActuelle > 0;

        // Champ nullable pour un éventuel effet d'état 
        public string? EffetEtat { get; set; }

        // Utilisation de "this" dans le constructeur
        public Combatant(string nom, Role role, Stats statsBase)
        {
            this.Nom = nom;
            this.Role = role;
            this.StatsBase = statsBase;
            this._santeActuelle = statsBase.Vie;
            this.EffetEtat = null;
        }

        public void SubirDegats(int degats)
        {
            _santeActuelle -= degats;
            if (_santeActuelle < 0)
                _santeActuelle = 0;
        }

        public override string ToString()
        {
            string effet = EffetEtat is null ? "Aucun" : EffetEtat;
            return $"{Nom} ({Role}) - PV: {_santeActuelle}/{StatsBase.Vie} - Effet: {effet}";
        }
    }

    // calculs de combat
    public static class BattleSystem
    {
        public static int CalculateDamage(int attack, int defense)
        {
            int degats = attack - defense;
            return degats < 1 ? 1 : degats; //  inférieurs à 1
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Création des combattants
            Combatant joueur = new Combatant("Vous", Role.Guerrier, new Stats(vie: 120, attaque: 25, defense: 15));
            Combatant sameth = new Combatant("Sameth", Role.Mage, new Stats(vie: 90, attaque: 30, defense: 8));
            Combatant boss = new Combatant("Gardien du Donjon", Role.Boss, new Stats(vie: 200, attaque: 20, defense: 12));

            Console.WriteLine("debut du combat !\n");

            int tour = 1;

            //  Boucle while : le duo affronte le Boss jusqu'à ce que sa santé tombe à 0
            while (boss.EstVivant && (joueur.EstVivant || sameth.EstVivant))
            {
                Console.WriteLine($"Tour {tour}");

                // Tour du joueur
                if (joueur.EstVivant)
                {
                    int degatsJoueur = BattleSystem.CalculateDamage(joueur.StatsBase.Attaque, boss.StatsBase.Defense);
                    boss.SubirDegats(degatsJoueur);
                    Console.WriteLine($"{joueur.Nom} attaque le Boss et inflige {degatsJoueur} dégâts.");
                    if (!boss.EstVivant) break;
                }

                // Tour de Sameth
                if (sameth.EstVivant)
                {
                    int degatsSameth = BattleSystem.CalculateDamage(sameth.StatsBase.Attaque, boss.StatsBase.Defense);
                    boss.SubirDegats(degatsSameth);
                    Console.WriteLine($"{sameth.Nom} attaque le Boss et inflige {degatsSameth} dégâts.");
                    if (!boss.EstVivant) break;
                }

                // Tour , il attaque un des deux au hasard
                Random rand = new Random();
                Combatant cible = rand.Next(2) == 0 && joueur.EstVivant ? joueur : sameth;
                if (!cible.EstVivant) cible = joueur.EstVivant ? joueur : sameth;

                int degatsBoss = BattleSystem.CalculateDamage(boss.StatsBase.Attaque, cible.StatsBase.Defense);
                cible.SubirDegats(degatsBoss);
                Console.WriteLine($"Le Boss attaque {cible.Nom} et inflige {degatsBoss} dégâts.");

                Console.WriteLine($"\n{joueur}");
                Console.WriteLine(sameth);
                Console.WriteLine(boss);
                Console.WriteLine();

                tour++;
            }

            Console.WriteLine("Fin\n");

            if (boss.EstVivant)
            {
                Console.WriteLine("Vous avez échoué... le Gardien vivant");
            }
            else
            {
                Console.WriteLine("Vous avez vaincu le Gardien du Donjon !");
                Console.WriteLine("En mourant, le Boss laisse tomber un médaillon gravé d'un symbole mystérieux.");

                //Le médaillon est confié à Sameth via son effet d'état, en remplacement 
                sameth.EffetEtat = "Médaillon mystérieux équipé";
                Console.WriteLine($"Vous décidez de laisser le médaillon à Sameth.");
                Console.WriteLine(sameth);
            }
        }
    }
}