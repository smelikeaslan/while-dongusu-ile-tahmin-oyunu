using System;

namespace TahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dogruSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı oluştur
            int kullaniciTahmini = 0;

            Console.WriteLine("1 ile 100 arasında bir sayı tahmin ediniz:");

            while (kullaniciTahmini != dogruSayi)
            {
                Console.Write("Tahmininiz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out kullaniciTahmini))
                {
                    if (kullaniciTahmini > dogruSayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı tahmin ediniz.");
                    }
                    else if (kullaniciTahmini < dogruSayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı tahmin ediniz.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }
                Console.ReadKey();
            }
        }
    }
}


