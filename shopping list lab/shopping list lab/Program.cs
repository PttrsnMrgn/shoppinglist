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
    Console.WriteLine("      WELCOME TO");
    Console.WriteLine("     MEAT N STUFF");
    Console.WriteLine("***********************");

    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
        Console.WriteLine(kvp);
    }
    Console.WriteLine("\n***********************");
    Console.WriteLine("***********************");

    Console.WriteLine("\nWHICH ITEM WOULD YOU LIKE?");
    Console.WriteLine("\nENTER 'CANCEL' TO EXIT");
    string input = Console.ReadLine().ToUpper();
    if (input == "CANCEL")
    {
        break;
    }
    if (menu.ContainsKey(input))
    {
        cost1 = menu[input];
        total = cost1 + total;
        shoppingList.Add(input);
        Console.WriteLine($"\nOK YOU'D LIKE {input},THE PRICE IS ${cost1}.");
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

foreach (string i in shoppingList)
{
    Console.WriteLine($"   {i} - {menu[i]}");
}

Console.WriteLine($"\n   TOTAL: ${total}");
Console.WriteLine("\n******************************");
Console.WriteLine("    THANKS FOR SHOPPING");
Console.WriteLine("        MEAT N STUFF");
Console.WriteLine("     HAVE A GREAT DAY!");
Console.WriteLine("******************************");

Console.ReadLine();

