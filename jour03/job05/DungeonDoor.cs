using System;

namespace Tartaros.Exploration
{
    //Classe de base avec une méthode virtuelle Open
    class DungeonDoor
    {
        public virtual void Open()
        {
            Console.WriteLine("La porte s'ouvre lentement...");
        }
    }

    //Sous-classe qui hérite de DungeonDoor
    class SealedDoor : DungeonDoor
    {
        private bool hasKey;

        public SealedDoor(bool hasKey)
        {
            this.hasKey = hasKey;
        }

        //redéfinition de Open, marquée sealed : plus aucune sous-classe
        // ne pourra la modifier davantage.
        public sealed override void Open()
        {
            if (hasKey)
            {
                Console.WriteLine("Vous insérez la clé runique... La porte scellée s'ouvre !");
            }
            else
            {
                Console.WriteLine("La porte reste immobile. Il vous manque la clé runique.");
            }
        }
    }

    // Erreur générée par le compilateur :
    // CS0239 : 'BrokenDoor.Open()' : impossible de substituer le membre hérité
    // 'SealedDoor.Open()' car il est scellé (sealed)
}