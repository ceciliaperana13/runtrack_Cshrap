using System;

public struct Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    //Ajouter une méthode DistanceTo(TrapLocation other) pour calculer la distance entre vous et un piège.
    public double DistanceTo(Position other)
    {
        int deltaX = this.X - other.X;
        int deltaY = this.Y - other.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}