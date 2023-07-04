Console.WriteLine("-Kart ATM'ye Koyulmuştur-");
Console.WriteLine("\nBu Bir Bankacılık Sistemidir");
Console.Write("\nLütfen Bakiye Giriniz : ");
int bakiye = Int32.Parse(Console.ReadLine());
if (bakiye >= 0)
{

    Console.WriteLine("\n***İŞLEMLER***");
    Console.WriteLine("1. Para Çekme");
    Console.WriteLine("2. Para Yatırma");
    Console.WriteLine("3. Bakiye Sorgulama ");
    Console.WriteLine("4. Kart İade");

    Console.Write("\nLütfen İşleminizi Seçiniz : ");

    int islem = Int32.Parse(Console.ReadLine());

    switch (islem)
    {

        case 1:
            if (bakiye > 0)
            {
                Console.WriteLine("\nMevcut Bakiye = " + bakiye + "\n");
                Console.Write("Ne Kadar Para Çekilecektir = ");
                int cekilecekpara = Int32.Parse(Console.ReadLine());
                if (cekilecekpara > bakiye)
                {
                    Console.WriteLine("\nHesapta Yeteri Kadar Para Yoktur");
                    Console.WriteLine("\nKart İade Ediliyor...");
                }
                else if (cekilecekpara <= bakiye == cekilecekpara > 0)
                {
                    int yeniBakiye = bakiye - cekilecekpara;
                    Console.WriteLine("\nPara Çekilmiştir");
                    Console.WriteLine("\nYeni Bakiye = " + yeniBakiye);
                    Console.WriteLine("\nKart İade Ediliyor...");
                }
                else
                {
                    Console.WriteLine("\nBöyle Bir Nakit Bulumamaktadır");
                    Console.WriteLine("\nKart İade Ediliyor...");
                }
            }
            else
            {
                Console.WriteLine("\nHata Maalesef Çekebilecek Paranız Bulunmamaktadır");
                Console.WriteLine("\nKart İade Ediliyor...");
            }
            break;
        case 2:
            Console.WriteLine("\nMevcut Bakiye = " + bakiye + "\n");
            Console.Write("Lütfen Yatırılacak Tutarı Giriniz = ");
            int yatirilacakPara = Int32.Parse(Console.ReadLine());
            if (yatirilacakPara >= 0 == yatirilacakPara <= 50000)
            {
                int yeniBakiye = bakiye + yatirilacakPara;
                Console.WriteLine("\nPara Yatırılmıştır");
                Console.WriteLine("\nYeni Bakiye = " + yeniBakiye);
                Console.WriteLine("\nKart İade Ediliyor...");
            }
            else if (yatirilacakPara > 50000)
            {
                Console.WriteLine("\nHata Maalesef Tek Sferde 50.000TL'den Fazla Nakit Hesapa Yüklenemez");
                Console.WriteLine("\nKart İade Ediliyor...");
            }
            else
            {
                Console.WriteLine("\nLütfen Yüklenecek Nakti Pozitif Tam Sayı Olarak Giriniz");
            }

            break;
        case 3:
            Console.WriteLine("\nMevcut Bakiye = " + bakiye);
            Console.WriteLine("\nKart İade Ediliyor...");
            break;
        case 4:
            Console.WriteLine("\nKart İade Ediliyor...");
            break; 
        default:
            Console.WriteLine("\nBöyle Bir İşlemimiz Bulunmamaktadır");
            Console.WriteLine("\nKart İade Ediliyor...");
            break;
    }
}
else
{
    Console.WriteLine("\nLütfen Bakiyenizi Pozitif Tam Sayı Olarak Giriniz");
    Console.WriteLine("\nKart İade Ediliyor...");
}



