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
   
    static double DaireHesapla(double yaricap, double PI=3.14)
    {
        return PI * yaricap * yaricap;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Kenar= 5 Alan=" + AlanHesapla(5));
        Console.WriteLine("Kenar1= 5 Kenar2=" + AlanHesapla(5, 10));
        Console.WriteLine("Yarı çap = 5, Alan= "+DaireHesapla(5.0));
        Console.WriteLine("Yarı çap = 5, Alan= "+DaireHesapla(5.0,3.1));
    }
}
