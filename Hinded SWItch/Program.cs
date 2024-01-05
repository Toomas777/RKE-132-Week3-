
Console.WriteLine("SISESTA PALUN OMA SAADUD HINNE, A, B, C, D, E, F,");

string HINNE = Console.ReadLine();

switch (HINNE)  // väärtus mida kontrollitakse
{                 //
    case "A":
        Console.WriteLine("Suurepärane");
        break;
    case "B":
        Console.WriteLine("Väga hea");
        break;
    case "C":
        Console.WriteLine("Hea");
        break;
    case "D":
        Console.WriteLine("Rahuldav");
        break;
    case "E":
        Console.WriteLine("Kasin");
        break;
    case "F":
        Console.WriteLine("Puudulik");
        break;
   
    default:
        Console.WriteLine("vale väärtus");
        break;
}

