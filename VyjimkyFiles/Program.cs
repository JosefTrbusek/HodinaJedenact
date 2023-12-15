// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej cestu:");
string cesta=Console.ReadLine();
try
{
    File.AppendAllText(cesta, "Ahoj soubore");    
}
catch(UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Neexistuje cesta k souboru: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Obecná výjimka: " + ex.Message);
}

Console.ReadLine();
