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
