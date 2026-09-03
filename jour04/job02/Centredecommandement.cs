using System;
using System.Collections.Generic;

namespace SecoursVillage
{
    public class CentreDeCommandement
    {
        // Délégué multicast : chaque secouriste enregistré s'y abonne.
        private InstructionEvacuation? instructionsEvacuation;

        private readonly List<Secouriste> secouristes = new();

        public void EnregistrerSecouriste(Secouriste secouriste)
        {
            secouristes.Add(secouriste);
            instructionsEvacuation += secouriste.RecevoirInstruction;
        }

        
        /// Action d'envoi des instructions d'évacuation d'urgence  invoque le délégué, qui relaie le message à tous les secouristes enregistrés.
        public void EnvoyerInstructionsEvacuation(string message)
        {
            Console.WriteLine($"Centre de commandement : diffusion de l'ordre \"{message}\"");
            instructionsEvacuation?.Invoke(message);
        }
    }
}