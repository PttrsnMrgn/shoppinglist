List<string> shoppingList = new List<string>();

Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    {"RIBEYE",18.99m},
    {"CHICKEN BREAST",3.99m},
    {"PORK CHOP",4.19m},
    {"ONION",.99m},
    {"ASPARAGUS",5.99m},
    {"GARLIC",.50m},
    {"BEER 6PK",9.49m},
    {"GALLON WATER",1.49m },
};

decimal total = 0.0m;
string loop1;
decimal cost1;

Waypoint1:
do
{
    Console.Clear();
    Console.WriteLine("***********************");
    Console.WriteLine("********WELCOME********");
    Console.WriteLine("\n");
    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
        Console.WriteLine(kvp);
    }
    Console.WriteLine("\n***********************");
    Console.WriteLine("***********************");

    Console.WriteLine("\nWHICH ITEM WOULD YOU LIKE?");
    string input = Console.ReadLine().ToUpper();

    if (menu.ContainsKey(input))
    {
        cost1 = menu[input];
        Console.Clear();
        Console.WriteLine($"\nOK YOU'D LIKE {input},THE PRICE IS ${cost1}.");
        total = cost1 + total;
        shoppingList.Add(input);
        Console.WriteLine("\nWOULD YOU LIKE SOMETHING ELSE? Y/N");
        loop1 = Console.ReadLine().ToUpper();
    }
    else
    {
        Console.WriteLine("\nI'M SORRY WE DON'T CARRY THAT ITEM.");
        Console.WriteLine("PRESS ENTER TO TRY AGAIN.");
        Console.ReadKey();
        goto Waypoint1;
    }
} while (loop1 == "Y");

Console.Clear();
Console.WriteLine("******************************");
Console.WriteLine("HERE'S YOUR RECEIPT FOR REVIEW");
Console.WriteLine("******************************");
Console.WriteLine("\n");

foreach (string i in shoppingList)
{
    Console.WriteLine($"{i} - {menu[i]}");
}

Console.WriteLine($"\nTOTAL: ${total}");
Console.WriteLine("\n******************************");
Console.WriteLine("      HAVE A GREAT DAY!");
Console.WriteLine("******************************");

Console.ReadLine();

