using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çift.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tek.");
        }
    }
}
