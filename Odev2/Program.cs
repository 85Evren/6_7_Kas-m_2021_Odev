using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci sayısını giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());

            double sonuc;
            double enb = 0;
            double enk = 0;
            double ort = 0;
            double toplam = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.Öğrenci Notunu Giriniz.");
                Console.WriteLine("---------------------------------");

                Console.WriteLine("1.Vize notu değerini giriniz.");
                int vize1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.Vize notu değerini giriniz.");
                int vize2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Final notu değerini giriniz.");
                int final = Convert.ToInt32(Console.ReadLine());

                sonuc = ((vize1 + vize2) * 0.3) + (final * 0.7);

                // İlk değer atama işlemi. 
                if (i == 0 )
                {
                    enb = sonuc;
                    enk = sonuc;

                }
                // En büyük sonuç değerini yakalamak. 
                if (sonuc > enb)
                {
                    enb = sonuc;
                 
                }
                // En küçük sonuç değerini yakalamak. 
                if (sonuc < enk)
                {
                    enk = sonuc;
                }

                toplam += sonuc;
                ort = toplam / n ;
                //Console.WriteLine($"Sonuc {sonuc}");
            }

            Console.WriteLine($"En Yüksek Sınav Puanı {enb}");
            Console.WriteLine($"En Küçük Sınav Puanı {enk}");
            Console.WriteLine($"Toplam Sınav Puanı {toplam}");
            Console.WriteLine($"Toplam Öğrenci Sayısı {n}");
            Console.WriteLine($"Toplam Sınav Puan Ortalaması {ort}");
            Console.ReadLine();

        }
    }
}
