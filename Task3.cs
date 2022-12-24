// See https://aka.ms/new-console-template for more information
// Input olaraq daxil edilmiş temperatur dərəcəsinin "donma temperaturundan (0ºC)" aşağı və ya yuxarı olduğunu təyin edən alqoritma yazmaq.

Console.WriteLine("Dereceni daxil edin");
int selsi = int.Parse(Console.ReadLine());

if (selsi<=0)
{
    Console.WriteLine("Hava donma tempuraturundadir..");
}
else
{
    Console.WriteLine("Hava donma tempuraturundan yuksekdir..");
}
Console.ReadLine();