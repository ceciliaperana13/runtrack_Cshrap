public class Wolf
{
    // Propriétés
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    // Constructeur principal 
    public Wolf(string name, int health, int damage)
    {
        this.Name = name;
        this.Health = health;
        this.Damage = damage;
    }

    // Second constructeur 
    public Wolf(string name) : this(name, 20, 5)
    {
    }
    //main pour tester la classe Wolf
    public static void Main(string[] args)
    {
        Wolf wolf1 = new Wolf("Loup Gris", 30, 10);
        Wolf wolf2 = new Wolf("Loup Blanc");

        Console.WriteLine($"Nom: {wolf1.Name}, Santé: {wolf1.Health}, Dégâts: {wolf1.Damage}");
        Console.WriteLine($"Nom: {wolf2.Name}, Santé: {wolf2.Health}, Dégâts: {wolf2.Damage}");
    }
   
}