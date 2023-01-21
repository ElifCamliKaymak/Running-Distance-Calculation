Karsilama();
int adimBoyu = AdimBoyuAl();
int adimSayisi = AdimSayisiAl("ilk saat için");
int sonAdimSayisi = AdimSayisiAl("ilk saatten sonrası için");
int kosuSuresiDakika = KosuSuresiDakikaAl();
int kosulanMesafe = KosuMesafesiHesaplama(adimBoyu, kosuSuresiDakika, adimSayisi, sonAdimSayisi);
SonucYazdir(kosulanMesafe);
Ugurlama();

void Karsilama()
{
    Console.WriteLine("Merhaba bu uygulama günlük koşu mesafenizi hesaplamak için tasarlanmıştır.");
    Console.WriteLine(new string('*', 40));
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
int AdimSayisiAl(string mesaj)
{
    while (true)
    {
        //Normal boyutlarda bir insan bir dakikada en fazla 120 en az 70 olabileceğini düşündüm.
        Console.Write($"Lütfen {mesaj} bir dakikada attığınız adım sayınızı giriniz: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (x < 121 && x > 69)
            {
                return x;
            }
            else
            {
                Console.WriteLine("Normal boyutlarda bir insan bir dakikada en fazla 120 en az 70 adım atabilir");
            }
        }
    }
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
int KosuMesafesiHesaplama(int m, int t, int y, int z)
{
    //ilk saat için dakikada adım sayısının değişmeyeceğini, bir saatten sonra adım sayısının değişeceğini varsaydım.
    //m = adım boyu, t = koşu süresi(dakika olarak),y = ilk saat dakikada atılan adım sayısı, z = ilk saatten sonra atılan adım sayısı, x = koşulan mesafe
    int x = m * (60 * y + z * t);
    return x;
}
void SonucYazdir(int x)
{
    Console.WriteLine($"Koşulan Mesafeniz: {x / 100}m");
}
void Ugurlama()
{
    Console.WriteLine("Uygulamamız burada bitmiştir. Devam etmek ister misiniz? Öyleyse EVET yazmanız yeterlidir!");
    string cevap = Console.ReadLine().ToUpper();
    if (cevap == "EVET")
    {
        Karsilama();
        int adimBoyu = AdimBoyuAl();
        int adimSayisi = AdimSayisiAl("İlk saat için");
        int sonAdimSayisi = AdimSayisiAl("İlk saatten sonrası için");
        int kosuSuresiDakika = KosuSuresiDakikaAl();
        int kosulanMesafe = KosuMesafesiHesaplama(adimBoyu, kosuSuresiDakika, adimSayisi, sonAdimSayisi);
        SonucYazdir(kosulanMesafe);
        Ugurlama();
    }
    else
    {
        Console.WriteLine("Güle Güle! Bizi tercih ettiğiniz için teşekkür ederiz!");
    }
}