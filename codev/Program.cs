// ÖDEV 1

/* 1.	Size göre en doğru döngüyü kullanarak ekranda 10 kez Merhaba yazan uygulamayı geliştirin.

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i + "Merhaba");

}
Console.ReadLine();

*/

/* 2.Kullanıcıdan alacağı değeri ekrana 5 kez yazdıran uygulamayı geliştirin.

Console.WriteLine("Bugün nasılsınız?");
string result=Console.ReadLine();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(result);
}
Console.ReadLine();

*/

/* 3.  0 – 10 aralığındaki(0 ve 10 dahil) tüm sayıların toplamını hesaplayıp ekrana yazan uygulamayı geliştirin

int sayi1 = 0;
for (int i = 0; i <= 10; i++)
{
	sayi1 += i;
}
Console.WriteLine(sayi1);
Console.ReadLine();

*/

/* 4.  0 dan başlayarak kullanıcıdan alacağınız sayıya kadar ki tüm sayıların toplamını bulan uygulamayı geliştirin.

int sayi1 = 0;
Console.WriteLine("Lütfen bir sayı giriniz");
int deger = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= Convert.ToInt32(deger); i++)
{
    sayi1 += i;
}
Console.WriteLine(sayi1);

*/

/* 5.Kullanıcıdan alınan sayının tek ya da çift olduğunu bulup ekrana “Tek” ya da “Çift” yazan uygulamayı geliştirin.

Console.WriteLine("Bir sayı giriniz");
int sayi= Convert.ToInt32(Console.ReadLine());
if (sayi % 2==0)
{
    Console.WriteLine("çift sayı");
}
else
{
    Console.WriteLine("tek sayı");
}
Console.ReadLine();

*/

/* 6.Kullanıcıdan alınan sayıya kadar ki tek ve çift sayıların toplamını alarak ayrı ayrı ekrana yazan uygulamayı geliştirin.

Console.WriteLine("Bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 0; i < Convert.ToInt32(sayi); i++)
{
    if (i % 2==0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
Console.WriteLine("Tek sayıların toplamı:" + tekToplam);
Console.WriteLine("Çift sayıların toplamı:" + ciftToplam);
Console.ReadLine();

*/

/* 7. Kullanıcıdan 10 adet sayı alan ve bu sayıların 50 den küçük olanlarının sayısını bulup ekrana yazan uygulamayı geliştirin


List<int> kucukler = new List<int>();
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i + ". sayıyı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi < 50)
    {
        kucukler.Add(sayi);
    }
}

Console.WriteLine("50 den küçük olan sayı adeti:" + kucukler.Count);
Console.ReadLine();

*/


/* 8.Kullanıcıdan kaç tane sayıyı toplamak istediğini alan sonrasında toplanacak sayı adedi kadar sayıyı kullanıcıdan
 tek tek alıp bu sayıların toplamını ekrana yazan programı geliştirin


Console.WriteLine("Kaç tane sayı girmek istersiniz?");
int sayilar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayıları yazınız");
int[] sayi = new int[sayilar];
int toplam = 0;
for (int i = 0; i < sayi.Length; i++)
{
    sayi[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayi[i];
}
Console.WriteLine("Toplam: " + toplam);
Console.ReadLine();

*/

/*    BONUS
    
  Kullanıcıdan 2değer al.Aldığın 2 değeri çarp

Console.WriteLine("Lütfen bir sayı giriniz");
int deger1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen farklı bir sayı daha giriniz");
int deger2= Convert.ToInt32(Console.ReadLine());

int sonuc = deger1 * deger2;
Console.WriteLine(sonuc);
Console.ReadLine();

*/

/*     BONUS
  
  Kullanıcıdan 2değer al.Aldığın 2 değerin arasındaki sayıları topla

Console.WriteLine("Lütfen bir sayı giriniz");
int deger1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen birinci sayıdan daha büyük bir sayı giriniz");
int deger2 = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
for (int i = deger1+1 ; i < deger2; i++)
{
     toplam += i;
}
Console.WriteLine(toplam);

*/