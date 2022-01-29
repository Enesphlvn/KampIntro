// See https://aka.ms/new-console-template for more information

//type safety = tip güvenliği
//Do not repeat yourself = kendini tekrar etme
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;

double dolarDun = 13.35;
double dolarBugun = 13.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Eşittir Butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Giriş Yapıldı");
}
else
{
    Console.WriteLine("Lütfen Giriş Yapın");
}

Console.WriteLine(kategoriEtiketi);

