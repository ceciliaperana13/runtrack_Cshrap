using System;
// interface IProtectiveItem avec une propriété protection (int),une propriété name et une méthode int Protect(int incomingDamage).
interface IProtectiveitem
{
    int Protection{get;}
    string Name{get;}
    int Protect(int incomingDamage);
}
