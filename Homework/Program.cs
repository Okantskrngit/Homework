
// Ödev1

char secim;
Console.WriteLine("Sipariş ekranına hoşgeldiniz!");
Console.WriteLine("--------------------");
Console.WriteLine("Akıllı telefon için 1: ");
Console.WriteLine("Oyun bilgisayarı için 2: ");
Console.WriteLine("Dizüstü bilgisayar için 3: ");
Console.WriteLine("Oyun konsolu için 4: ");
Console.WriteLine("Tablet için 5: ");
Console.WriteLine("-----------------------");
Console.Write("Sipariş etmek istediğiniz ürünün numarasını girin: ");
secim = Convert.ToChar(Console.Read());


switch (secim)
{
    case '1':
        Console.WriteLine("Akıllı telefon siparişiniz alınmıştır");
        break;
    case '2':
        Console.WriteLine("Oyun bilgisayarı siparişiniz alınmıştır");
        break;
    case '3':
        Console.WriteLine("Dizüstü bilgisayar siparişiniz alınmıştur");
        break;
    case '4':
        Console.WriteLine("Oyun konsolu siparişiniz alınmıştır");
        break;
    case '5':
        Console.WriteLine("Tablet siparişiniz alınmıştır");
        break;
    default:
        Console.WriteLine("Hatalı bir rakam girdiniz");
        break;
}
