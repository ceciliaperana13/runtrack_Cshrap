using System;

namespace SecoursVillage
{
    
    public class Secouriste
    {
        public string Nom { get; }

        public Secouriste(string nom)
        {
            Nom = nom;
        }

        
        /// Méthode appelée automatiquement lorsque le délégué
        public void RecevoirInstruction(string message)
        {
            Console.WriteLine($"  [{Nom}] reçoit l'instruction : \"{message}\"");
        }
    }
}