// See https://aka.ms/new-console-template for more information
using HodinaJedenact;
try
{
    Osoba osoba = new Osoba("Karel","Novák",18);
    Console.WriteLine(osoba);

    Osoba osoba2 = new Osoba(" ", "Nazaretský", 17);
    Console.WriteLine(osoba2);
}
catch(JmenoException ex)
{
    Console.WriteLine($"{ex.Cas} {ex.Message}");
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Argument je mimo rozsah. Jde o parametr {ex.ParamName} a stalo se ze {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Doslo k chybe: " + ex.Message);
}

finally
{
    Console.WriteLine("Konec programu");
}
Console.ReadLine();
