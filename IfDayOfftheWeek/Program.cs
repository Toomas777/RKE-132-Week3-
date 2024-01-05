
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if(weekDay == 0)
{
    Console.WriteLine("Täna on Pühapäev");
}
else if (weekDay == 1)
{
    Console.WriteLine("Täna on Esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("Täna on Teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("Täna on Kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("Täna on Neljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("Täna on Reede");
}
else if(weekDay == 6)
{
    Console.WriteLine("Täna on Laupäev");
}

   

Console.WriteLine("Mõnusat päeva");