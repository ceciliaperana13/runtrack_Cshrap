using System;

namespace CombatOrannis
{
       public class CombatException : Exception
    {
        public CombatException(string message) : base(message) { }
    }
}