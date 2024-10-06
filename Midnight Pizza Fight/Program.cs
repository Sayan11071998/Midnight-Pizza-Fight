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
        Console.WriteLine("\n==================================================");
        Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕    ");
        Console.WriteLine("\n==================================================");
        Console.WriteLine("Dough Master: That scoundrel won't escape with my creation!\n");
    }

    private int generateRandomNumberInRange(int min, int max)
    {
        Random rand = new Random();
        int RandomNumber = rand.Next(min, max + 1);
        return RandomNumber;
    }

    public int CalculateTotalDamage()
    {
        int additionalDamage = generateRandomNumberInRange(5, 15);
        int totalDamage = attackDamage + additionalDamage;
        return totalDamage;
    }

    public void ShowAttackDamage(int totalDamage)
    {
        Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
        Console.WriteLine("============================================");
        Console.WriteLine("Dough Master's attack dealt " + totalDamage + " damage! 🥊");
        Console.WriteLine("--------------------------------------------");
    }

    public void TakeDamage(int damageRecieved) => health -= damageRecieved;

    public int CalculateTotalHeal()
    {
        int additionalHeal = generateRandomNumberInRange(10, 20);
        int totalHeal = healingCapacity + additionalHeal;
        return totalHeal;
    }

    public void Heal(int healAmount) => Health += healAmount;

    public void ShowHeal(int healAmount)
    {
        if(Health >= maxHealth)
        {
            Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
            Console.WriteLine("============================================");
            Console.WriteLine("     Dough Master is bursting with energy! 🚀    ");
            Console.WriteLine("--------------------------------------------");
        }
        else
        {
            Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
            Console.WriteLine("============================================");
            Console.WriteLine("Dough Master's heal restored " + healAmount + " hp! ☕");
            Console.WriteLine("--------------------------------------------");
        }
    }

    public void DisplayPlayerStats()
    {
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("              DOUGH MASTER'S STATS                ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Health: " + Health + "/" + maxHealth);
        Console.WriteLine("Dough Slapper: " + attackDamage);
        Console.WriteLine("Espresso Shot ☕: " + healingCapacity);
        Console.WriteLine("Dough Slapper Boost 🌪️: 5 to 15");
        Console.WriteLine("Espresso Shot Boost ☕: 10 to 20");
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
        Console.WriteLine("\n==================================================");
        Console.WriteLine("   🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹  ");
        Console.WriteLine("\n==================================================");
        Console.WriteLine("Crust Bandit: The Delectable pizza is mine now!");
        Console.WriteLine("You'll never catch me, flour face!\n");
    }

    private int generateRandomNumberInRange(int min, int max)
    {
        Random rand = new Random();
        int RandomNumber = rand.Next(min, max + 1);
        return RandomNumber;
    }

    public int CalculateTotalDamage()
    {
        int additionalDamage = generateRandomNumberInRange(5, 15);
        int totalDamage = maxDamage + additionalDamage;
        return totalDamage;
    }

    public void ShowAttackDamage(int totalDamage)
    {
        Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
        Console.WriteLine("============================================");
        Console.WriteLine("Crust Bandit's attack dealt " + totalDamage + " damage! 🥊");
        Console.WriteLine("--------------------------------------------");
    }

    public void TakeDamage(int damageRecieved) => health -= damageRecieved;
    
    public void DisplayEnemyStats()
    {
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("              CRUST BANDIT'S STATS                ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Health: " + Health + "/" + maxHealth);
        Console.WriteLine("Sneaky Jab: " + maxDamage);
        Console.WriteLine("Sneaky Jab Boost 🌪️: 5 to 15");
    }

}

class Game
{
    Player player;
    Enemy enemy;

    public void SpawnCharacters()
    {
        player = new Player();
        enemy = new Enemy();
    }

    public void DisplayGameStory()
    {
        Console.Clear();
        Console.WriteLine("\n==================================================");
        Console.WriteLine("            🍕 MIDNIGHT PIZZA FIGHT 🍕           ");
        Console.WriteLine("==================================================");
        Console.WriteLine("\nIn a bustling pizzeria on a busy Friday night...");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("You, the Dough Master, created your magnum opus -");
        Console.WriteLine("the perfect pizza. Suddenly, a sneaky Crust Bandit");
        Console.WriteLine("snatches your masterpiece!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("\nFueled by passion for your craft, you give chase...");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Through winding alleys and crowded streets, you");
        Console.WriteLine("pursue the pizza pilferer. Finally, the thief is");
        Console.WriteLine("cornered in a dead-end alley. It's time to recover");
        Console.WriteLine("your stolen slice!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("                      FIGHT!                      \n");
    }

}

class Program
{
    static void Main()
    {
        Game game = new Game();
        game.DisplayGameStory();
        game.SpawnCharacters();
    }
}