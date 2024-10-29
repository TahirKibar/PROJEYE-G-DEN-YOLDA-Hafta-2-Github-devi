using System;

class Program
{
    static void Main()
    {
        Console.Write("Kullanıcı adını girin: ");
        string kullaniciAdi = Console.ReadLine();
        
        Console.Write("Şifreyi girin: ");
        string sifre = Console.ReadLine();

        if (kullaniciAdi == "admin" && sifre == "Admin_32453@")
        {
            Console.WriteLine("Giriş başarılı!");
        }
        else
        {
            Console.WriteLine("Giriş başarısız!");
        }
    }
}
