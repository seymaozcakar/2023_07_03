class Program
{
    static bool AsalMi(int sayi)
    {
        bool sonuc = true;
        if (sayi < 2)
        {
            return false;
        }
        else if (sayi == 2 || sayi == 3)
        {
            return true;
        }
        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                sonuc = false;
                break;
            }
        }
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("Sayı = ");
        string strGirilen = Console.ReadLine();
        int girilenSayi = int.Parse(strGirilen);
        if (AsalMi(girilenSayi))
        {
            Console.WriteLine(girilenSayi + " - asaldır");
        }
        else
        {
            Console.WriteLine(girilenSayi + " - asal değildir");

        }


    }
}
