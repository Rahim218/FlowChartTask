// See https://aka.ms/new-console-template for more information
#region Input olaraq daxil edilmiş iki natural ədəddən hansının böyük olduğunu təyin edən alqoritma yazmaq.
Console.WriteLine("Ilk rəqəmi daxil edin : ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci rəqəmi daxil edin :");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 != num2)
{
    Console.WriteLine("En boyuk reqem budur : " + num1);
}
else
{
    Console.WriteLine("En boyuk reqem budur : " + num2);
}
Console.ReadLine();
#endregion







