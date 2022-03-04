using App.Controller;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

int numberTrades = 0;
CultureInfo provider = new CultureInfo("en-us");
DateTime? referenceDate = null;



Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("         Welcome to the Credit Suisse!         \n");
Console.BackgroundColor = ConsoleColor.Black;

while (true) 
{
    Console.Write("Referece Date: ");
    var date = Console.ReadLine();

    if (!Validation.ValidateFormatDate(date))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Date Formate Error: Please, inform a correct date format mm/dd/yyyy");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        referenceDate = DateTime.ParseExact(date,"MM/dd/yyyy",provider);
        break;
    }
}

while (true)
{
    Console.Write("Numer of Trades: "); 
    var number = Console.ReadLine();

    if (String.IsNullOrEmpty(number) || !number.All(char.IsDigit))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Number Error: Please, inform a correct number!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        numberTrades = Int32.Parse(number);
        break;
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nInput the {numberTrades.ToString()} portfolios business be: Trade Amount, Client Sector and Date Next Pending Payment. (separe with space)..:");
Console.ForegroundColor = ConsoleColor.White;

List<Trade> listTrades = new List<Trade>();
for (int i = 0; i < numberTrades; i++)
{
    Trade trade = null;
    while (true)
    {
        var portfolio = Console.ReadLine();
        try
        {
            trade = new Trade().Validate(portfolio, (global::System.DateTime)referenceDate);
            break;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    listTrades.Add(trade);
}

Console.WriteLine("\nCATEGORIES....:");
foreach (var trade in listTrades)
{
    Console.WriteLine(trade.Category);
}

Console.ReadLine();






