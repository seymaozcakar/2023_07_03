class Program
{
    static void IsimListele(string[] isimler)
    {
        Console.WriteLine("Dizide " + isimler.Length + " tane isim var");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < isimler.Length; i++)
        {
            Console.Write(i + 1 + ".");
            Console.WriteLine(isimler[i]);
        }
        Console.WriteLine("-------------------------");
    }
    static string EnUzunIsim(string[] adlar)
    {
        string ad = "";
        int maxLength = 0;
        int ndx = 0;

        for (int i = 0; i < adlar.Length; i++)
        {
            if (adlar[i].Length > maxLength)
            {
                maxLength = adlar[i].Length;
                ndx = i;
            }

        }
        ad = adlar[ndx];
        return ad;
    }

    static void Main(string[] args)
    {
        string[] isimlerim = { "Lizge", "Arda", "Yavuz", "Özge", "Şeyma", "Muhammed" };
        string[] isimListesi = { "Berat", "İsmail", "Lizge", "Arda", "Yavuz", "Özge", "Şeyma", "Muhammed" };
        string[] isimListesi2 = { "Berat", "İsmail", "Lizge", "Arda", "Yavuz", "Özge", "Şeyma", "Muhammed" };

        IsimListele(isimlerim); Console.WriteLine();
        IsimListele(isimListesi); Console.WriteLine();
        IsimListele(isimListesi2); Console.WriteLine();
        Console.WriteLine(EnUzunIsim(isimlerim)); Console.WriteLine();
    }
}
