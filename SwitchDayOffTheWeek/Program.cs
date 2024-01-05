int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0-6

switch (weekDay)  // väärtus mida kontrollitakse
{                 //
    case 0:
        Console.WriteLine("Täna on Pühapäev");
        break;
    case 1:
        Console.WriteLine("Täna on Esmaspäev");
        break;
    case 2:
        Console.WriteLine("Täna on Teisipäev");
        break;
    case 3:
        Console.WriteLine("Täna on Kolmapäev");
        break;
    case 4:
        Console.WriteLine("Täna on Neljapäev");
        break;
    case 5:
        Console.WriteLine("Täna on Reede");
        break;
    case 6:
        Console.WriteLine("Täna on Laupäev");
        break;
        default: Console.WriteLine("OOOps,Teie kalender on katki :)");
        break;
}

Console.WriteLine("Mõnusat päeva");

