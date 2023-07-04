Console.WriteLine("Bu Taksimetre Programıdır \n");
Console.WriteLine("Taksi Sadece Kredi Kartı İle Ödeme Alır \n");
double kmBasiUcret = 8.51;
Console.WriteLine("Yolcu Taksiye Biner...\n");
Console.Write("Lütfen Alınan Sabit Ücreti Giriniz : ");
double sabitUcret = Int32.Parse(Console.ReadLine());
if (sabitUcret < 0)
{
    Console.WriteLine("\nLütfen Pozitif Bir Sayı Giriniz");
    Console.WriteLine("\nYolcu Taksiden İner...");
}
else if (sabitUcret >= 30)
{
    Console.WriteLine("\nSöylenen Ücret Çok Yüksek. Lütfen Fiyatı Düşürün");
    Console.WriteLine("\nYolcu Taksiden İner...");
}
else
{
    Console.WriteLine("\n1 - Kilometre");
    Console.WriteLine("2 - Metre");
    Console.Write("\nMesafe Kilometre Üzerinden Mi Yoksa Metre Üzerinden Mi Hesaplanacak? : ");
    int islem = Int32.Parse(Console.ReadLine());
    switch (islem)
    {
        case 1:
            Console.Write("\nKaç Kilometre Yol Gidilecek : ");
            double kmislem = Int32.Parse(Console.ReadLine());
            if (kmislem <= 0)
            {
                Console.WriteLine("\nLütfen Pozitif Bir Sayı Giriniz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else if (kmislem < 8 && kmislem > 0)
            {
                Console.WriteLine("\nKısa Mesafe Yolcu Alımı Olmaz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else if (kmislem >= 150)
            {
                Console.WriteLine("\nLütfen Taksi İçin Uygun Mesafe Giriniz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else
            {
                double toplamUcret = sabitUcret + (kmislem * kmBasiUcret);
                Console.WriteLine("\nÖdenecek Toplam Tutar = " + toplamUcret + " TL");
                Console.Write("\nBankada Ne Kadar Para Bulunmakata = ");
                double bankaPara1 = Int32.Parse(Console.ReadLine());
                if (bankaPara1 > 0)
                {
                    if (bankaPara1 >= toplamUcret)
                    {
                        Console.WriteLine("\nKredi Kartı Okutuluyor...");
                        Console.WriteLine("\nÖdeme Yapılıyor...");
                        double yeniBankaPara1 = bankaPara1 - toplamUcret;
                        Console.WriteLine("\nÖdeme Yapıldı.");
                        Console.WriteLine("\nYeni Bakiye = " + yeniBankaPara1 + "TL");
                        Console.WriteLine("\nYolcu Taksiden İner...");
                    }
                    else if (bankaPara1 < toplamUcret)
                    {
                        Console.WriteLine("\nKredi Kartı Okutuluyor...");
                        Console.WriteLine("\nYeterli Bakiye Bulunmuyor...");
                        Console.WriteLine("\nÖdeme Yapılamadı...");
                        Console.WriteLine("\nYolcu Taksiden İner...");
                    }
                }
                else if (bankaPara1 <= 0)
                {
                    Console.WriteLine("\nKredi Kartı Okutuluyor...");
                    Console.WriteLine("\nYeterli Bakiye Bulunmuyor...");
                    Console.WriteLine("\nÖdeme Yapılamadı...");
                    Console.WriteLine("\nYolcu Taksiden İner...");
                }   

            }
            break;
        case 2:
            Console.Write("\nKaç Metre Yol Gidilecek : ");
            double mislem = Int32.Parse(Console.ReadLine());
            if (mislem <= 0)
            {
                Console.WriteLine("\nLütfen Pozitif Bir Sayı Giriniz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else if (mislem < 8000 && mislem > 0)
            {
                Console.WriteLine("\nKısa Mesafe Yolcu Alımı Olmaz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else if (mislem >= 150000)
            {
                Console.WriteLine("\nLütfen Taksi İçin Uygun Mesafe Giriniz");
                Console.WriteLine("\nYolcu Taksiden İner...");
            }
            else
            {
                double mislem2 = mislem/1000;
                double toplamUcret = sabitUcret + (mislem2 * kmBasiUcret);
                Console.WriteLine("\nÖdenecek Toplam Tutar = " + toplamUcret + " TL");
                Console.Write("\nBankada Ne Kadar Para Bulunmakata = ");
                double bankaPara1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nKredi Kartı Okutuluyor...");
                if (bankaPara1 > 0)
                {
                    if (bankaPara1 >= toplamUcret)
                    {
                        Console.WriteLine("\nKredi Kartı Okutuluyor...");
                        Console.WriteLine("\nÖdeme Yapılıyor...");
                        double yeniBankaPara1 = bankaPara1 - toplamUcret;
                        Console.WriteLine("\nÖdeme Yapıldı.");
                        Console.WriteLine("\nYeni Bakiye = " + yeniBankaPara1 + "TL");
                        Console.WriteLine("\nYolcu Taksiden İner...");
                    }
                    else if (bankaPara1 < toplamUcret)
                    {
                        Console.WriteLine("\nKredi Kartı Okutuluyor...");
                        Console.WriteLine("\nYeterli Bakiye Bulunmuyor...");
                        Console.WriteLine("\nÖdeme Yapılamadı...");
                        Console.WriteLine("\nYolcu Taksiden İner...");
                    }
                }
                else if (bankaPara1 <= 0)
                {
                    Console.WriteLine("\nKredi Kartı Okutuluyor...");
                    Console.WriteLine("\nYeterli Bakiye Bulunmuyor...");
                    Console.WriteLine("\nÖdeme Yapılamadı...");
                    Console.WriteLine("\nYolcu Taksiden İner...");
                }
            }
            break;
        default:
            Console.WriteLine("\nMalesef Böyle Bir İşlem Yoktur. ");
            Console.WriteLine("\nYolcu Taksiden İner...");
            break;
    }
}

