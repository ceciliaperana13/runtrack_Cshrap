using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmeTri
{
    public static class TrieMots
    {
        public static List<string> Sort(List<string> mots)
        {
            bool inverserTout = mots.Any(ContientTrick);
            bool trierParTailleDabord = mots.Count == 10;

           
            var tailleOriginale = mots.Select(m => m.Length).ToList();

            // Mots de taille d'origine 11 : on retire leurs chiffres avant trier
            var motsTraites = mots
                .Select(m => (m.Length == 11) != inverserTout ? RetirerChiffres(m) : m)
                .ToList();

            var elements = new List<Element>();
            for (int i = 0; i < mots.Count; i++)
            {
                elements.Add(new Element
                {
                    Original = mots[i],
                    Traite = motsTraites[i],
                    TailleOriginale = tailleOriginale[i],
                    Groupe = EstMotPrioritaireMP(mots[i]) ? 0 : 1,
                    Cle = CalculerCle(mots[i], motsTraites[i])
                });
            }

            IOrderedEnumerable<Element> tries;

            if (trierParTailleDabord)
            {
                tries = inverserTout
                    ? elements.OrderBy(e => e.TailleOriginale)
                    : elements.OrderByDescending(e => e.TailleOriginale);

                tries = inverserTout
                    ? tries.ThenByDescending(e => e.Groupe).ThenByDescending(e => e.Cle, StringComparer.Ordinal)
                    : tries.ThenBy(e => e.Groupe).ThenBy(e => e.Cle, StringComparer.Ordinal);
            }
            else
            {
                tries = inverserTout
                    ? elements.OrderByDescending(e => e.Groupe).ThenByDescending(e => e.Cle, StringComparer.Ordinal)
                    : elements.OrderBy(e => e.Groupe).ThenBy(e => e.Cle, StringComparer.Ordinal);
            }

            return tries.Select(e => e.Traite).ToList();
        }

        private static bool EstMotPrioritaireMP(string mot)
        {
            if (mot.Length == 0 || !char.IsLetter(mot[0])) return false;
            char majuscule = char.ToUpperInvariant(mot[0]);
            return majuscule is >= 'M' and <= 'P';
        }

        private static string CalculerCle(string original, string traite)
        {
            if (original.Length == 0) return traite;

            char premier = original[0];

            if (char.IsDigit(premier))
            {
                int i = 0;
                int sommeChiffres = 0;
                while (i < original.Length && char.IsDigit(original[i]))
                {
                    sommeChiffres += original[i] - '0';
                    i++;
                }
                char prochaineLettre = i < original.Length ? original[i] : '\0';

                
                return $"{prochaineLettre}{sommeChiffres:D4}{traite}";
            }

            if (!char.IsLetterOrDigit(premier))
            {
               
                var sb = new StringBuilder(traite.Length);
                foreach (char c in traite)
                    sb.Append((char)(char.MaxValue - c));
                return sb.ToString();
            }

            
            return traite;
        }

        ///Retire tous les chiffres d'un mot, sans regex
        private static string RetirerChiffres(string mot)
        {
            var sb = new StringBuilder(mot.Length);
            foreach (char c in mot)
            {
                if (!char.IsDigit(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        private static bool ContientTrick(string mot) => mot.Contains("trick", StringComparison.Ordinal);

        private class Element
        {
            public string Original { get; set; } = "";
            public string Traite { get; set; } = "";
            public int TailleOriginale { get; set; }
            public int Groupe { get; set; }
            public string Cle { get; set; } = "";
        }
    }
}