// Ask for basic details from the player
Console.WriteLine("Welcome to the game. Please enter some info:");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}, welcome to the game.");
Console.WriteLine(" ");

// Ask player if they want to begin
StartQuestion();
static void StartQuestion()
{
    Console.WriteLine("Are you ready to being? (y/n)");
    string answer = Console.ReadLine();

    if (answer.Trim().ToLower() == "y")
    {
        Console.WriteLine(" ");
    }
    else if (answer.Trim().ToLower() == "n")
    {
        StartQuestion();
    }
    else{
        StartQuestion();
    }
}

// Player should choose magic and weapons
Console.WriteLine("First, choose two weapons and two magic spells: ");

// Player chooses two weapons
string[] weaponsList = { "sword", "mace", "spear", "bow"};

string[] chosenWeapon = new string[2];

ChooseWeapons(weaponsList, chosenWeapon);
static void ChooseWeapons(string[] list, string[] list2)
{
    foreach (string weapon in list)
    {
        Console.WriteLine(weapon);
    }
  
    int choicesMade = 0;
    while (choicesMade < 2)
    {
        Console.WriteLine("Choose a weapon: ");
        string weaponChoice = Console.ReadLine();
        
        switch (weaponChoice.Trim().ToLower())
        {
        case "sword":
        list2[choicesMade] = "sword";
        Console.WriteLine("sword added");
        choicesMade++;
        break;

        case "mace":
        list2[choicesMade] = "mace";
        Console.WriteLine("mace added");
        choicesMade++;
        break;

        case "spear":
        list2[choicesMade] = "spear";
        Console.WriteLine("spear added");
        choicesMade++;
        break;

        case "bow":
        list2[choicesMade] = "bow";
        Console.WriteLine("bow added");
        choicesMade++;
        break;

        default:
        Console.WriteLine("Sorry, not recognised");
        break;
        }  
    }
}

Console.WriteLine("You have chosen the following two weapons: ");
foreach (string weapon in chosenWeapon)
{
    Console.WriteLine(weapon);
}

// Player chooses two magic abilities
string[] MagicList = { "fire", "ice", "lightning", "water"};

string[] chosenMagic = new string[2];

ChooseMagic(MagicList, chosenMagic);
static void ChooseMagic(string[] list, string[] list2)
{
    foreach (string magic in list)
    {
        Console.WriteLine(magic);
    }
  
    int choicesMade = 0;
    while (choicesMade < 2)
    {
        Console.WriteLine("Choose magic");
        string magicChoice = Console.ReadLine();
        
        switch (magicChoice.Trim().ToLower())
        {
        case "fire":
        list2[choicesMade] = "fire";
        Console.WriteLine("fire added");
        choicesMade++;
        break;

        case "ice":
        list2[choicesMade] = "ice";
        Console.WriteLine("ice added");
        choicesMade++;
        break;

        case "lightning":
        list2[choicesMade] = "lightning";
        Console.WriteLine("lightning added");
        choicesMade++;
        break;

        case "water":
        list2[choicesMade] = "water";
        Console.WriteLine("water added");
        choicesMade++;
        break;

        default:
        Console.WriteLine("Sorry, not recognised");
        break;
        }  
    }
}

Console.WriteLine("You have chosen the following two magic: ");
foreach (string magic in chosenMagic)
{
    Console.WriteLine(magic);
}

// Some story for the player to read
Console.WriteLine(" ");
Console.WriteLine("You enter into a strange new world.");
Console.WriteLine("The skyscrapers stand tall below the crisp blue sky.");
Console.WriteLine("You come across your enemy.");
Console.WriteLine("Are you going to fight now or run?");

// Player chooses to fight or run
FightOrRun();
static void FightOrRun()
{
    Console.WriteLine("Type \"fight\" or \"run\"");
    string answer = Console.ReadLine();

    if (answer.Trim().ToLower() == "fight")
    {
        Console.WriteLine("You choose to fight!");
        Console.WriteLine(" ");
    }
    else if (answer.Trim().ToLower() == "run")
    {
        Console.WriteLine("You try to run but your enemy catched you! You have to fight!");
        Console.WriteLine(" ");
    }
    else{
        FightOrRun();
    }
}

// Create the player class instance
Character player = new Character();
player.Name = name; 
player.Age = 28; 

player.weapon1 = chosenWeapon[0];
player.weapon2 = chosenWeapon[1];
player.magic1 = chosenMagic[0];
player.magic2 = chosenMagic[1];

int[] playerHp = {100};

// Create the computer enemy class instance
Character enemy = new Character();
enemy.Name = "Enemy";
enemy.Age = 99; 

enemy.weapon1 = "sword";
enemy.weapon2 = "cross bow";
enemy.magic1 = "poison";
enemy.magic2 = "gravity";

int [] enemyHp = {100};

// Introduce each fighter
Console.WriteLine("There are two fighters: ");
player.intro();
enemy.intro();
Console.WriteLine(" ");

// Create game loop
while ((playerHp[0] > 0) && (enemyHp[0] > 0))
{
    Console.WriteLine("Enemy HP: " + enemyHp[0]);
    Console.WriteLine("Player HP: " + playerHp[0]);
    PlayerTurn(player.weapon1, player.weapon2, player.magic1, player.magic2, enemyHp);
    EnemyTurn(enemy.weapon1, enemy.weapon2, enemy.magic1, enemy.magic2, playerHp);
    Console.WriteLine(" ");
}

// End screen
if (enemyHp[0] <= 0)
{
    Console.WriteLine("You win!");
}
else
{
     Console.WriteLine("The computer has won!");
}

// Create player turn methods
static void PlayerTurn(string weapon1, string weapon2, string magic1, string magic2, int[] enemyHp)
{
    Console.WriteLine("Player move: " + weapon1 + " (a), " + weapon2 + " (b), " + magic1 + " (c), " + magic2 + " (d)");
    string answer = Console.ReadLine();

    switch (answer.Trim().ToLower())
    {
        case "a":
        Console.WriteLine("You attacked with the " + weapon1 + "!");
        enemyHp[0] -= 10;
        break;

        case "b":
        Console.WriteLine("You attacked with the " + weapon2 + "!");
        enemyHp[0] -= 15;
        break;
        
        case "c":
        Console.WriteLine("You attacked with " + magic1 + "!");
        enemyHp[0] -= 20;
        break;

        case "d":
        Console.WriteLine("You attacked with " + magic2 + "!");
        enemyHp[0] -= 25;
        break;
        
        default:
        Console.WriteLine("invalid input");
        break;
    }
}

// Create computer turn methods
static void EnemyTurn(string weapon1, string weapon2, string magic1, string magic2, int[] playerHp)
{
    Random rnd = new Random();
    int randNum = rnd.Next(1, 5);
    
    switch (randNum)
    {
        case 1:
        Console.WriteLine("The computer attacked with the " + weapon1 + "!");
        playerHp[0] -= 10;
        break;

        case 2:
        Console.WriteLine("The computer attacked with the " + weapon1 + "!");
        playerHp[0] -= 15;
        break;
        
        case 3:
        Console.WriteLine("The computer attacked with " + magic1 + "!");
        playerHp[0] -= 20;
        break;

        case 4:
        Console.WriteLine("The computer attacked with " + magic2 + "!");
        playerHp[0] -= 25;
        break;
        
        default:
        Console.WriteLine("invalid input");
        break;
    }
}

// create character class
public class Character
{
    public string Name;
    public int Age;
    public string weapon1; 
    public string weapon2;
    public string magic1; 
    public string magic2;

    public void intro()
    {
        Console.WriteLine(Name + " - " + Age + " years old.");
        Console.WriteLine("Abilities: " + weapon1 + ", " + weapon2 + ", " + magic1 + " and " + magic2 + ".");

    }
}