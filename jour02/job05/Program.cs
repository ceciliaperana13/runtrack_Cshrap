//main
public class Program
{
    public static void Main(string[] args)
    {
        // Créez une instance de la structure Position
        Position currentPos = new Position(10, 20);
        Position backupPos = currentPos; // Copie de la structure
        backupPos.X = 30;
        backupPos.Y = 40;

        Console.WriteLine($"Current Position: ({currentPos.X}, {currentPos.Y})");
        Console.WriteLine($"Backup Position: ({backupPos.X}, {backupPos.Y})");
        
        //Afficher la distance entre les deux positions en utilisant la méthode DistanceTo.
        double distance = currentPos.DistanceTo(backupPos);
        Console.WriteLine($"Distance between currentPos and backupPos: {distance}");
    }
}



