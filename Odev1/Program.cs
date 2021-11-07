using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, sifre;
            bool returnValue = true;
            int n = 0;
            do
            {
                Console.WriteLine("Kullanıcı adını giriniz.");
                kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifre giriniz.");
                sifre = Console.ReadLine();

                if (kullaniciAdi == "admin" && sifre == "123")
                {
                    //break;
                    returnValue = false;
                    Console.WriteLine("Hoş geldin Admin....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya Şifrenizi yanlış girdiniz.");
                    Console.WriteLine("**************************************************");
                    n++;

                    if (n == 3)
                    {
                        Console.WriteLine("Kullanıcı adı,Şifreniz en fazla 3 kez girilebilir. ");
                        break;
                    }

                }

            } while (returnValue);

            Console.ReadLine();
        }
    }
}
