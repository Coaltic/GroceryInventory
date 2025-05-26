//public enum SearchType
//{
//    IDSearch = 0,
//    NameSearch = 1,
//    PriceSearch = 3,
//    StrengthSearch = 4
//};

bool shopping = true;


List<Cheese> cheeseList = new()
{
    new Cheese(1, "Stilton", 3.0m, 5),
    new Cheese(2, "Cheddar", 2.25m, 3),
    new Cheese(3, "Pineapple", 3.5m, 1),
    new Cheese(4, "Brie", 5.5m, 2),
    new Cheese(5, "Roquefort", 3.75m, 5),

};




while (shopping)
{
    //switch (searchType)
    //{
    //    case IDSearch:
    //        break;
    //    case NameSearch:
    //        break;
    //    case PriceSearch:
    //        break;
    //    case StrengthSearch:
    //        break;
    //    default:

    //        break;
    //}


    Console.WriteLine("Welcome to the Cheese Index, please select your search type:");
    Console.WriteLine();
    Console.WriteLine("1 - Search by: Item ID");
    Console.WriteLine("2 - Search by: Item Name");
    Console.WriteLine("3 - Search by Item Price");
    Console.WriteLine("4 - Search by Item Strength");

    ConsoleKeyInfo input;
    input = Console.ReadKey(true);

    if (input.KeyChar == '1')
    {
        Console.Clear();
        Console.WriteLine("Please enter the ID of the cheese you want to search for");
        Console.WriteLine();

        Console.ReadLine();
    }
    else if (input.KeyChar == '2')
    {
        Console.Clear();
        Console.WriteLine("Please enter the Name of the cheese you want to search for");
        Console.WriteLine();

        Console.ReadLine();
    }
    else if (input.KeyChar == '3')
    {
        Console.Clear();
        Console.WriteLine("Please enter the Price of the cheese you want to search for");
        Console.WriteLine();

        Console.ReadLine();
    }
    else if (input.KeyChar == '4')
    {
        Console.Clear();
        Console.WriteLine("Please enter the Strength of the cheese you want to search for");
        Console.WriteLine();

        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("no");
    }

}


    foreach (var cheese in cheeseList)
    {
        Console.WriteLine($"ID: {cheese.Id}, Name: {cheese.Name}");
    }

    Console.WriteLine();
    string cheeseName = Console.ReadLine();

    if (cheeseList.Any(cheese => cheese.Name.ToLower() == cheeseName.ToLower())) // ToLower() checks lower cases
    {
        Cheese cheese = cheeseList.FirstOrDefault(c => c.Name.ToLower() == cheeseName.ToLower());
        Console.Clear();
        Console.WriteLine($"{cheese.Name} cheese costs ${cheese.Price} and has a strength of {cheese.Strength}");
        Console.WriteLine();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Sorry, that cheese is unavailable");
        Console.WriteLine();
    }

//}