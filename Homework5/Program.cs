
// Ödev 5 - Mükemmel sayı bulma

Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

for (int i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        toplam = toplam + i;
    }
}

if (toplam == sayi1)
{
    Console.WriteLine(sayi1 + " sayısı mükemmel sayıdır");
}
else
{
    Console.WriteLine(sayi1 + " sayısı mükemmel sayı değildir");
}
Console.ReadLine();
