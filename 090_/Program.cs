/////Alan Hesapla /////////////////////////////////////////////////////////
class Program
{
    static int AlanHesapla(int kenar)
    {
        int sonuc = 0;
        sonuc = kenar * kenar;
        return sonuc;
    }

    static int AlanHesapla(int kenar1, int kenar2)
    {
        return kenar1 * kenar2;
    }

    static double DaireAlanHesapla(double yaricap, double PI = 3.14)
    {
        return PI * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Kenar = 5 Alan = " + AlanHesapla(5));
        Console.WriteLine("Kenar1 = 5, Kenar2 = 10  Alan = " + AlanHesapla(5, 10));
        Console.WriteLine("Yari Çap = 5, Alan = " + DaireAlanHesapla(5.0));
        Console.WriteLine("Yari Çap = 5, Alan = " + DaireAlanHesapla(5.0, 3.1));
    }
}

/////Kelime Sayma///////////////////////////////////////////////////////////
class Program
{
    static bool AyracMi(char karakter)
    {
        bool sonuc = false;
        string Ayraclar = "+-*/,.? !";
        for (int i = 0; i < Ayraclar.Length; i++)
        {
            if (Ayraclar[i] == karakter)
            {
                sonuc = true;
                break;
            }
        }
        return sonuc;
    }
    static int KelimeSay(string cumle)
    {
        int ayracSayisi = 0;
        for (int i = 0; i < cumle.Length; i++)
        {
            //if (i != 0 && cumle[i] == ' ' && cumle[i - 1] != ' ')
            //if (i != 0 && AyracMi(cumle[i]) == true && AyracMi(cumle[i - 1]) != true)
            if (i != 0 && AyracMi(cumle[i]) && !AyracMi(cumle[i - 1]))
                ayracSayisi++;
        }
        return ayracSayisi + 1;
    }
    static void Main(string[] args)
    {
        string cumle = "  InfoTech   Mecidiyeköy--  İstanbul / Türkiye";
        Console.WriteLine(cumle);

        int kelimeSayisi = KelimeSay(cumle);

        Console.WriteLine("Kelime Sayısı = " + kelimeSayisi);
    }
}
