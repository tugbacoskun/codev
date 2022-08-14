// ÖDEV 2

Console.Title = "Hesap Makinesi V-1.0";

bool yeniIslem =false;
do
{
    Console.WriteLine("1.Toplama");
    Console.WriteLine("2.Çıkarma");
    Console.WriteLine("3.Çarpma");
    Console.WriteLine("4.Bölme");
    Console.WriteLine("5.Çıkış");
    Console.Write("Lütfen bir seçim yapın : ");
    int secim = Convert.ToInt32(Console.ReadLine());
    double sayi1 = 0, sayi2 = 0, sonuc = 0;
    if (secim == 1 || secim == 2 || secim == 3 || secim == 4)
    {
        Console.Write("1.operantı girin : ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2. operantı girin : ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
    }


    switch (secim)
    {
        case 1:
            sonuc = sayi1 + sayi2;

            break;
        case 2:
            sonuc = sayi1 - sayi2;

            break;
        case 3:
            sonuc = sayi1 * sayi2;

            break;
        case 4:
            sonuc = sayi1 / sayi2;

            break;
        case 5:
            Environment.Exit(0);

            break;
    }


    Console.Write("İşlem sonucu : " + sonuc);
    Console.ReadLine();
    Console.WriteLine("Yeni bir işlem yapmak ister misiniz?(e/h)");
    char c = char.Parse(Console.ReadLine());

    if (c == 'e')
    {
        Console.Clear();
        yeniIslem = true;
    }
    else
    {
        Environment.Exit(0);
    }
} while (yeniIslem);

