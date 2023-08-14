class Program
{
    static int Karesi(int Sayi)
    {
        int sonuc = 0;
        sonuc = Sayi * Sayi;
        return sonuc;
    }
    static int Kupu(int Sayi)
    {
        return Sayi * Sayi * Sayi;
    }

    //ard arda uzatmamak için method oluşturalım;

    static int Kuvveti(int taban, int kuvveti)
    {
        if (kuvveti == 0)
            return 1;

        int sonuc = taban;
        for (int i = 1; i < kuvveti; i++)
        {
            sonuc *= taban;
        }
        return sonuc;
    }

    static void Main(string[] args)
    {
        for (int taban = 0; taban < 10; taban++)
        {
            Console.Write(taban);
            for (int kuvvet = 0; kuvvet < 6; kuvvet++)
            {
                Console.Write("\t" + Kuvveti(taban, kuvvet));
            }
            Console.WriteLine();
        }
    }
}
