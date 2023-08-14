///Sayi Tahmin/////////////////////////////////////////////////
class Program
{
    static string EkrandanOku(string etiket)
    {
        string sonuc = "";
        Console.Write(etiket + " = ");
        sonuc = Console.ReadLine();
        return sonuc;
    }

    static int EkrandanSayiOku(string etiket)
    {
        return int.Parse(EkrandanOku(etiket));
    }
    static int RasgeleSayiUret(int basla = 1, int bitis = 10)
    {
        Random rnd = new Random();
        return rnd.Next(basla, bitis);
    }
    static void Main(string[] args)
    {
        int sayi = 0;
        int uretilenSayi = RasgeleSayiUret();

        Console.Write("Ipucu=");
        Console.WriteLine(uretilenSayi);

        do
        {
            sayi = EkrandanSayiOku("Tahmin edin");
            if (sayi > uretilenSayi)
            {
                Console.WriteLine("Buyuk bir sayi yazdiniz");
            }
            else if (sayi < uretilenSayi)
            {
                Console.WriteLine("Kucuk bir sayi yazdiniz");
            }
            else
            {
                Console.WriteLine("Tebrikler");
            }
        } while (uretilenSayi != sayi);

    }
}
