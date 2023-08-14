class Program
{
    static int ArdisikToplam(int sayi)
    {
        int toplam = 0;
        for (int i = 0; i < sayi; i++)
        {
            toplam += i;
        }
        return toplam;
    }

    static int ArdisikToplam(int basla, int bitis)
    {
        int toplam = 0;
        for (int i = basla; i < bitis; i++)
        {
            toplam += i;
        }
        return toplam;
    }

    static int ArdisikToplam(int basla, int bitis, int artis)
    {
        int toplam = 0;
        for (int i = basla; i < bitis; i += artis)
        {
            toplam += i;
        }
        return toplam;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("1...10'a kadar olan sayıların toplamı = " + ArdisikToplam(10));
        Console.WriteLine("1...20'a kadar olan sayıların toplamı = " + ArdisikToplam(20));
        Console.WriteLine("10...50'a kadar olan sayıların toplamı = " + ArdisikToplam(10, 50));
        Console.WriteLine("70...90'a kadar olan sayıların toplamı = " + ArdisikToplam(70, 90));
        Console.WriteLine("20...100'a kadar olan 5er artan sayıların toplamı = " + ArdisikToplam(20, 100, 5));
        Console.WriteLine("50...200'a kadar olan 7şer artan sayıların toplamı = " + ArdisikToplam(50, 200, 7));
    }
}
