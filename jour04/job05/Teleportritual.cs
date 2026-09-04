using System;

namespace TeleportRitual
{
    public class TeleportRitual
    {
        /// Événement déclenché à chaque étape pour signaler l'avancement
        public event EventHandler<RitualProgressEventArgs>? ProgressionRituel;

        private int progression = 0;
        private double stabilite = 100.0;

        protected virtual void OnProgression(string nomEtape)
        {
            ProgressionRituel?.Invoke(this, new RitualProgressEventArgs(nomEtape, progression, stabilite));
        }

        
        public void AlignRunes()
        {
            progression += 30;
            stabilite -= 5;   // léger désalignement 
            OnProgression("Alignement des runes");
        }

       
        public void PurifyMiasmaStream()
        {
            progression += 35;
            stabilite -= 20;  // le miasme perturbe fortement 
            OnProgression("Purification du flux de miasme");
        }

        public void StabilizeRift()
        {
            progression += 35;
            stabilite += 15; 
            if (stabilite > 100) stabilite = 100;
            OnProgression("Stabilisation de la brèche");
        }

        public void LancerRituel()
        {
            AlignRunes();
            PurifyMiasmaStream();
            StabilizeRift();
        }
    }
}