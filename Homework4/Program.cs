
// Ödev 4

int tahmin = 0;
int aralik;
int sayac = 0;
Random random = new Random();
aralik = random.Next(1, 10);

while (tahmin != aralik)
{
    sayac++;
    Console.WriteLine("Sayı tahmin etme oyunu");
    Console.WriteLine("---------------------");
    Console.Write("Bir sayı girin: ");
    tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin > aralik)
    {
        Console.WriteLine("Girdiğiniz sayı büyük");
    }
    else if (tahmin < aralik)
    {
        Console.WriteLine("Girdiğiniz sayı küçük");
    }
    else if (tahmin == aralik)
    {
        Console.WriteLine("Tebrikler doğru bildiniz!");
    }
}

Console.WriteLine("{0}. denemede buldunuz!", sayac);



