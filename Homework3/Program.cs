
//Ödev 3


// while döngüsü koşul sağlandıkça devam eden döngülerdir,


int i = 20;

while (i >= 0)
{
    Console.WriteLine("n = {0}", i);
    i--;

}



/* do while ise koşulun doğruluğunu kontrol etmeden en az bir kere çalıştırır. 
 */


string uyeAdi = "user1"; string sifre = "998877";
string input1;
string input2;

do
{
    Console.Write("Lütfen kullanıcı adınızı girin: ");
    input1 = Console.ReadLine();
    Console.Write("Lütfen şifrenizi girin: ");
    input2 = Console.ReadLine();

}
while (uyeAdi != input1 && sifre != input2);

if (uyeAdi == input1 && sifre == input2)
{
    Console.WriteLine("Başarıyla giriş yaptınız");
}
