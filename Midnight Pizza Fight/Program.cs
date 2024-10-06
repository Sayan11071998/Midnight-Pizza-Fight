using System;

class Player
{
    // Variables
    private int health = 100;
    private int maxHealth = 100;
    private int attackDamage = 20;
    private int healingCapacity = 15;

    public int Health
    {
        // GETTER
        get
        {
            return health;
        }
        // SETTER
        private set
        {
            if (value < 0)
                health = 0;
            else if (value > maxHealth)
                health = maxHealth;
            else
                health = value;
        }
    }

    // Default Constructor
    public Player()
    {
        SpawnPlayer();
    }

    // Functions
    private void SpawnPlayer()
    {
        Console.WriteLine("\n==================================================================");
        Console.WriteLine("         🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕           ");
        Console.WriteLine("==================================================================");
        Console.WriteLine("Dough Master: That scoundrel won't escape with my creation!\n");
    }
}

class Enemy
{
    // Variables
    private int health = 150;
    private int maxDamage = 15;
    private int maxHealth = 150;

    public int Health
    {
        // GETTER
        get
        {
            return health;
        }
        // SETTER
        private set
        {
            if (value < 0)
                health= 0;
            else if (value > maxHealth)
                health = maxHealth;
            else
                health= value;
        }
    }

    // Default Constructor
    public Enemy()
    {
        SpawnEnemy();
    }

    // Functions
    private void SpawnEnemy()
    {
        Console.WriteLine("\n==================================================================");
        Console.WriteLine("          🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹            ");
        Console.WriteLine("==================================================================");
        Console.WriteLine("You'll never catch me, flour face!\n");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("\n==================================================================");
        Console.WriteLine("             🍕 MIDNIGHT PIZZA FIGHT 🍕             ");
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nIn a bustling pizzeria on a busy Friday night...");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("You, the Dough Master, created your magnum opus - the perfect pizza🤌. Suddenly, a sneaky " +
            "Crust Bandit snatches your masterpiece!");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("Fuelled by the passion for your craft, you give chase...");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("Through winding alleys and crowded streets, you pursue the pizza pilferer. Finally, the thief is " +
            "cornered in a dead-end alley. It's time to recover your stolen slice!");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("                               FIGHT                               ");

        //Creating and Spawning the Player Character
        Player player = new Player();
        Enemy enemy = new Enemy();
    }
}