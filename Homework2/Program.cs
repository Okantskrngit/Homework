
////Ödev 2


int urun1Fiyat = 800;
int urunStogu = 20;

Console.Write("Kaç adet ürün almak istiyorsunuz? ");
int satisAdedi = Convert.ToInt32(Console.ReadLine());
int fiyat = satisAdedi * urun1Fiyat;
for (int i = 0; satisAdedi <= urunStogu; i++)
{
    Console.WriteLine("Toplam fiyat: " + fiyat + " TL");
    break;

}

if (satisAdedi >= urunStogu)
{
    Console.WriteLine("Yetersiz stok");
}
else if ((satisAdedi <= 0))
{
    Console.WriteLine("Lütfen pozitif bir sayı girin");
}


