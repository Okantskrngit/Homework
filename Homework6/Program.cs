
// Ödev 6

string metin1 = "Okan ";
string kopyametin = (string)metin1.Clone();
Console.WriteLine(kopyametin);

string metin3 = "Taşkıran";
Console.WriteLine(metin3.IndexOf("a"));
Console.WriteLine(metin3.LastIndexOf("a"));
Console.WriteLine(metin3.Contains("ş"));

string metin4 = "Tobeto";
Console.WriteLine(metin4.ToUpper());
Console.WriteLine(metin4.ToLower());

string metin5 = "İstanbul Kodluyor";
Console.WriteLine(metin5.Replace("İstanbul ", "Kodluyor2 "));
Console.WriteLine(metin5.Length);

string metin6 = "   VisualStudio    ";
Console.WriteLine(metin6.Trim());

string metin7 = "HTML,CSS,Javascript";
string[] dizi = metin7.Split(',');
for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi[i]);
}

string metin8 = "GoogleChrome";
Console.WriteLine(metin8.Substring(6));
Console.WriteLine(metin8.Remove(6, 4));
