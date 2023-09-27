//Code challange

//Change to switch case;
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}"); */

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]){
    case "01": 
        Console.WriteLine("Sweat shirt");
        break;
    case "02":
        Console.WriteLine("T-Shirt");
        break;
    case "03":
        Console.WriteLine("Sweat pants");
        break;
    default:
        Console.WriteLine("Other");
        break;
}

switch (product[1]){
    case "BL":
        Console.WriteLine("Black");
        break;
    case "MN":
        Console.WriteLine("Maroon");
        break;
    default:
        Console.WriteLine("White");
        break;
}

switch (product[2]){
    case "S":
        Console.WriteLine("Small");
        break;
    case "M":
        Console.WriteLine ("Medium");
        break;
    case "L":
        Console.WriteLine("Large");
        break;
    default:
        Console.WriteLine("One Size Fits All");
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");