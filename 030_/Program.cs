class Program
{
    static void DiziGoster(int[] dizi)
    {
        Console.WriteLine("Dizide " + dizi.Length + " tane sayı var");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi[i]);
        }
        Console.WriteLine("------------------------");
    }

    static int EnBuyukSayi(int[] dizi)
    {
        int enBuyuk = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        return enBuyuk;
    }

    static int EnKucukSayi(int[] dizi)
    {
        //int enKucuk = int.MaxValue;
        int enKucuk = dizi[0];
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > enKucuk)
            {
                enKucuk = dizi[i];
            }
        }

        return enKucuk;
    }

    static void Main(string[] args)
    {

        int[] notlar = { 12, 78, 45, 96 };

        DiziGoster(notlar);
        Console.Write("En büyük sayı= ");
        Console.WriteLine(EnBuyukSayi(notlar));
        Console.Write("En küçük sayı= ");
        Console.WriteLine(EnKucukSayi(notlar));
    }
}
