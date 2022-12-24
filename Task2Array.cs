// See https://aka.ms/new-console-template for more information
string[] fennler= new string[3];
fennler[0]= "Biology";
fennler[1] = "Math";
fennler[2] = "Chemistry";

int[] qiymetler = new int [3];
qiymetler[0] = 65;
qiymetler[1] = 40;
qiymetler[2] = 60;

for (int i = 0; i < fennler.Length; i++)
{
    Console.WriteLine(fennler[i]);
    Console.WriteLine(qiymetler[i]);
}
int toplam = 0;
for (int j = 0; j < 3; j++)
{
    toplam += qiymetler[j];
}
if (toplam / 3 >60 && toplam/3 != 60)
{
    Console.WriteLine("Siz imtahandan kecmisiniz");
}
else
{
    Console.WriteLine("Kesilmisiniz");

}
Console.ReadLine();


