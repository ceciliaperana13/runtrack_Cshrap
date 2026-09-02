using System;

namespace Tartaros.Exploration
{
    //Classe sealed : impossible d'en hériter
    sealed class RunicSeal
    {
        public string Symbole { get; }

        public RunicSeal(string symbole)
        {
            this.Symbole = symbole;
        }

        public void Decrire()
        {
            Console.WriteLine($"Le sceau runique porte le symbole : {Symbole}");
        }
    }
    // Erreur générée par le compilateur :
    // CS0509 : 'FakeSeal' : impossible de dériver d'un type scellé 'RunicSeal'
}