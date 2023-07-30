internal class hesap
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("-----Hesap Makinesi-----");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("Seçiminizi yapın 1, 2, 3 veya 4");
            int vote;
            if (!int.TryParse(Console.ReadLine(), out vote))
            {
                Console.WriteLine("Geçersiz seçim. Lütfen 1, 2, 3 veya 4 seçeneğini girin.");
                return;
            }

            switch (vote)
            {
                case 1:
                    ToplamaIslemi();
                    break;
                case 2:
                    CikartmaIslemi();
                    break;
                case 3:
                    CarpmaIslemi();
                    break;
                case 4:
                    BolmeIslemi();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen 1, 2, 3 veya 4 seçeneğini girin.");
                    break;
            }
        }
    }

    static void ToplamaIslemi()
    {
        Console.WriteLine("Toplama işlemi");
        Console.WriteLine("Sayıları aralarında boşluk olarak girin:");
        string[] numbers = Console.ReadLine().Split(' ');
        int toplam = 0;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                toplam += num;
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Geçerli sayılar girin.");
                return;
            }
        }
        Console.WriteLine("Sonuç: " + toplam);
    }

    static void CikartmaIslemi()
    {
        Console.WriteLine("Çıkartma işlemi");
        Console.WriteLine("Sayıları aralarında boşluk olarak girin:");
        string[] numbers = Console.ReadLine().Split(' ');
        int çıkan = 1;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                çıkan -= num;
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Geçerli sayılar girin.");
                return;
            }
        }
        Console.WriteLine("Sonuç:" + çıkan);
    }

    static void CarpmaIslemi()
    {
        Console.WriteLine("Çarpma İşlemi");
        Console.WriteLine("Sayıları aralarında boşluk olarak girin:");
        string[] numbers = Console.ReadLine().Split(' ');
        int çarpan = 1;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                çarpan *= num;
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Geçerli sayılar girin.");
                return;
            }
        }
        Console.WriteLine("Sonuç: " + çarpan);
    }

    static void BolmeIslemi()
    {
        Console.WriteLine("Bölme İşlemi");
        Console.WriteLine("Sayıları aralarında boşluk olarak girin:");
        string[] numbers = Console.ReadLine().Split(' ');
        int bölen = 1;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                bölen /= num;
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Geçerli sayılar girin.");
                return;
            }
        }
        Console.WriteLine("Sonuç: " + bölen);
    }
} 
