/*Yeni akıllı saatler olmadan günlük koşu mesafemizi ölçebilir miyiz? Sizden günlük koşu mesafemizi ölçen bir yazılım yapmanızı istiyorum. Yapacağınız yazılıma; sizin adım boyunuzu, bir dakikada kaç adım attığınızı ve toplam koşu sürenizi belirtiğinizde size metre cinsinden toplam koşu mesafenizi söyleyecek.
Yapacağınız çözümü modüllere bölmeyi unutmayın.
Veriyi 4 adımda alacağız:
1.Ortalama bir adımınızın kaç santimetre olduğunu gireceksiniz
2. Bir dakikada kaç adım koştuğunuzu gireceksiniz.
3. Koşu süresini
    3.1. Önce saat
    3.2. Ve dakika olarak gireceksiniz.
Lütfen her adımda verilerin doğruluğunu kontrol etmeyi unutmayın.

EK Soru:
Koşuyu aynı hızda koşmam mümkün olmayacağından koşunun belli bölümlerinde dakikada kaç adım attığımı girebileceğim bir farklı tasarım yapabilir misiniz?
*/

Karsilama();
int adimBoyu = AdimBoyuAl();
int adimSayisi = AdimSayisiAl();
int kosuSuresiSaat = KosuSaatDakikaCevir(KosuSuresiSaatAl());
int kosuSuresiDakika = KosuSuresiDakikaAl();
int kosulanMesafe = KosuMesafesiHesaplama(adimBoyu, kosuSuresiSaat + kosuSuresiDakika, adimSayisi);
SonucYazdir(kosulanMesafe);
Ugurlama();

void Karsilama()
{
    Console.WriteLine("Merhaba bu uygulama günlük koşu mesafenizi hesaplamak için tasarlanmıştır.");
}
int AdimBoyuAl()
{
    while (true)
    {
        //Normal boyutlarda bir insanın adım boyunun en fazla 100 cm en az 50 cm olabileceğini düşündüm.
        Console.Write("Lütfen adım boyunuzu cm cinsinden giriniz: ");
        if (int.TryParse(Console.ReadLine(), out adimBoyu))
        {
            if (adimBoyu < 101 && adimBoyu > 49)
            {
                return adimBoyu;
            }
            else
            {
                Console.WriteLine("Lütfen 50 ile 100 arası adım sayısını rakamla giriniz!");
            }
        }
    }
}
int AdimSayisiAl()
{
    while (true)
    {
        //Normal boyutlarda bir insan bir dakikada en fazla 120 en az 70 olabileceğini düşündüm.
        Console.Write("Lütfen bir dakikada atabileceğiniz adım sayınızı giriniz: ");
        if (int.TryParse(Console.ReadLine(), out adimSayisi))
        {
            if (adimSayisi < 121 && adimSayisi > 69)
            {
                return adimSayisi;
            }
            else
            {
                Console.WriteLine("Normal boyutlarda bir insan bir dakikada en fazla 120 en az 70 adım atabilir");
            }
        }
    }
}
int KosuSuresiSaatAl()
{
    while (true)
    {
        Console.Write("Lütfen Koştuğunuz sürenin zamanının sadece saat olan kısmını giriniz: ");
        if (int.TryParse(Console.ReadLine(), out kosuSuresiSaat))
        {
            //Günlük koşma süresi 2 saatten fazla olamaz diye düşünerek en fazla 1 saat 59 dk girebilmesini sağlayacağım.
            if (kosuSuresiSaat < 2 && kosuSuresiSaat >= 0)
            {
                return kosuSuresiSaat;
            }
            else
            {
                Console.WriteLine("Günlük koşu süresi en fazla 2 saat olabilir!");
            }
        }
    }
}
int KosuSaatDakikaCevir(int x)
{
    //x = kullanıcıdan alınan koşu zamanının saati
    int y = x * 60;
    return y;
}
int KosuSuresiDakikaAl()
{
    while (true)
    {
        Console.Write("Lütfen Koştuğunuz sürenin zamanının sadece dakika olan kısmını giriniz: ");
        if (int.TryParse(Console.ReadLine(), out kosuSuresiDakika))
        {
            //1 saatten fazla koşabileceği için 1 dk ile 59 dk arası değerler girebilir.
            if (kosuSuresiDakika < 60 && kosuSuresiDakika > 0)
            {
                return kosuSuresiDakika;
            }
            else
            {
                Console.WriteLine("Bir saat en fazla 59 dakikadan oluşmaktadır!");
            }
        }
    }
}
int KosuMesafesiHesaplama(int m, int t, int y)
{
    //m = adım boyu, t = koşu süresi(dakika olarak), y = dakikada adım sayısı, x = koşulan mesafe
    int x = m * t * y;
    return x;
}
void SonucYazdir(int x)
{
    Console.WriteLine($"Koşulan Mesafeniz: {x}cm, {x / 100}m");
}
void Ugurlama()
{
    Console.WriteLine("Uygulamamız burada bitmiştir. Devam etmek ister misiniz? Öyleyse EVET yazmanız yeterlidir!");
    string cevap = Console.ReadLine().ToUpper();
    if (cevap == "EVET")
    {
        Karsilama();
        int adimBoyu = AdimBoyuAl();
        int kosuSuresiSaat = KosuSaatDakikaCevir(KosuSuresiSaatAl());
        int kosuSuresiDakika = KosuSuresiDakikaAl();
        int kosulanMesafe = KosuMesafesiHesaplama(adimBoyu, kosuSuresiSaat + kosuSuresiDakika, adimSayisi);
        SonucYazdir(kosulanMesafe);
        Ugurlama();
    }
    else
    {
        Console.WriteLine("Güle Güle! Bizi tercih ettiğiniz için teşekkür ederiz!");
    }
}