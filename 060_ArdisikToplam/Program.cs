class Program
{

    //optional parametre
    static int ArdisikToplam(int bitis, int basla = 1, int artis = 1)
    {
        int toplam = 0;
        for (int i = basla; i <= bitis; i += artis)
        {
            toplam += i;
        }
        return toplam;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("1...10'a kadar olan sayıların toplamı = " + ArdisikToplam(10));
        Console.WriteLine("1...20'a kadar olan sayıların toplamı = " + ArdisikToplam(20));
        Console.WriteLine("10...50'a kadar olan sayıların toplamı = " + ArdisikToplam(50, 10));
        Console.WriteLine("70...90'a kadar olan sayıların toplamı = " + ArdisikToplam(90, 70));
        Console.WriteLine("20...100'a kadar olan 5er artan sayıların toplamı = " + ArdisikToplam(50, 20, 5));
        Console.WriteLine("50...200'a kadar olan 7şer artan sayıların toplamı = " + ArdisikToplam(200, 50, 7));
    }
}
