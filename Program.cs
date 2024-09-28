//start main

DisplayPizzaMenu();
string userChoice = GetUserChoice();
while(userChoice != "4")
    {
        RouteEm(userChoice);
        DisplayPizzaMenu();
        userChoice = GetUserChoice();
    }
Console.Clear();
System.Console.WriteLine("Goodbye!");

//end main


static void DisplayPizzaMenu()
{
    Console.Clear();
    System.Console.WriteLine("Welcome to Crimson Crust!\nThis program allows you to window-shop our pizza options with the touch of a button!\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
}

static string GetUserChoice()
{
    System.Console.WriteLine("Enter your menu choice");
    return Console.ReadLine();
}

static void RouteEm(string userChoice)
{
    Random rnd = new Random();
    int numRows = rnd.Next(8, 13);
    switch(userChoice)
    {
        case "1":
            PlainPizza(numRows);
            break;
        case "2":
            CheesePizza(numRows);
            break;
        case "3":
            PepperoniPizza(numRows);
            break;
        case "4":
            break;
        default:
            BadInput();
            Pause();
            break;
    }
}

static void PlainPizza(int numRows) //generates visual of a plain pizza slice
{
    Console.Clear();
    for(int i=numRows; i >= 1; i--)
    {
        for(int j=1; j <= i; j++)
        {
            System.Console.Write("*"+" ");
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void CheesePizza(int numRows) //generates visual of a cheese pizza slice
{
    Console.Clear();
    for(int i=(numRows+1); i >= 1; i--)
    {
        System.Console.Write("*"+" ");
    }
    System.Console.WriteLine();
    for(int i=(numRows-1); i >= 1; i--)
    {
        System.Console.Write("*"+" ");
        for(int j=1; j <= i-1; j++)
        {
            System.Console.Write("#"+" ");
        }
        System.Console.Write("*");
        System.Console.WriteLine();
    }
    System.Console.WriteLine("*");
    Pause();
}



static void PepperoniPizza(int numRows) //generates visual of a pepperoni pizza slice
{
    Console.Clear();
    for(int i=(numRows+1); i >= 1; i--)
    {
        System.Console.Write("*"+" ");
    }
    System.Console.WriteLine();
    for(int i=(numRows-1); i >= 1; i--)
    {
        System.Console.Write("*"+" ");
        for(int j=1; j <= i-1; j++)
        {
            string cheeseOrPepperoni = CheeseOrPepperoniGenerator();
            System.Console.Write($"{cheeseOrPepperoni}"+" ");
        }
        System.Console.Write("*");
        System.Console.WriteLine();
    }
    System.Console.WriteLine("*");
    Pause();
}

static string CheeseOrPepperoniGenerator() //decides with a 1:6 ratio whether the character will be pizza or pepperoni
{
    Random rnd = new Random();
    int cheeseOrPepperoniChance = rnd.Next(1, 8);
    string cheeseOrPepperoni;
    if (cheeseOrPepperoniChance <= 1)
    {
        cheeseOrPepperoni = "O";
    }
    else
    {
        cheeseOrPepperoni = "#";
    }
    return cheeseOrPepperoni;
}

static void Pause()
{
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void BadInput()
{
    System.Console.WriteLine("Invalid input");
}

