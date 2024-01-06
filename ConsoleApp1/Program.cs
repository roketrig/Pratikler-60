using System.Collections;

void enbuyukenkucuk(int a, int b,int c)
{
    int[] sayilar = { a, b, c };
    int enKucuk = int.MaxValue;
    int enBuyuk = int.MinValue;

    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] < enKucuk)
        {
            enKucuk = sayilar[i];
        }

        if (sayilar[i] > enBuyuk)
        {
            enBuyuk = sayilar[i];
        }
    }

    Console.WriteLine("En Küçük Sayı: " + enKucuk);
    Console.WriteLine("En Büyük Sayı: " + enBuyuk);
    Console.WriteLine("Toplam: " + (enKucuk + enBuyuk));
}

void zam()
{
    Console.Write("Maaşınızı Giriniz: ");
    int maas = Convert.ToInt32(Console.ReadLine());
    Console.Write("Zam Oranınızı Giriniz: ");
    double zam = Convert.ToInt32(Console.ReadLine());
    double yeni_maas = maas * (zam / 100);
    yeni_maas += maas;
    Console.WriteLine("Zamlı maasınız: " + yeni_maas);
}

void aritmetikhesap()
{
    int[] sayilar = new int[20];
    Random random = new Random();
    int[] buyuksayilar = new int[sayilar.Length];
    int[] kucuksayilar = new int[sayilar.Length];
    int toplam = 0;

    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = random.Next(0, 100);
        toplam += sayilar[i];
    }

    int ortalamasi = toplam / 20;

    int kucukIndex = 0;
    int buyukIndex = 0;

    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] > ortalamasi)
        {
            buyuksayilar[buyukIndex] = sayilar[i];
            buyukIndex++;
        }
        else
        {
            kucuksayilar[kucukIndex] = sayilar[i];
            kucukIndex++;
        }
    }

    Console.Write("Küçük Sayılar: ");
    for (int i = 0; i < kucukIndex; i++)
    {
        Console.Write(kucuksayilar[i] + " ");
    }

    Console.WriteLine();

    Console.Write("Büyük Sayılar: ");
    for (int i = 0; i < buyukIndex; i++)
    {
        Console.Write(buyuksayilar[i] + " ");
    }
}

void metinkelimehesabı()
{
    string kelimeler = "Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan Console Application";
    string[] kelimeler_gurubu = kelimeler.Split(' ');
    int toplam = kelimeler_gurubu.Length;
    Console.WriteLine("Girdiğiniz Toplam Kelime sayısı: " + toplam);
}

void degistir()
{
    string kelimeler = ("Merhaba, Benim. Adım, Semih, Size. Nasıl. Yardımcı, Olabilirim.");
    string[] kelimeler_ = kelimeler.Split(" ");
    for (global::System.Int32 i = 0; i < kelimeler_.Length; i++)
    {
        string harfler = kelimeler_[i];
        char a = harfler[harfler.Length -1];
        if (a == ',')
        {
            string son = kelimeler_[i].Remove(kelimeler_[i].Length - 1);
            Console.Write(son + ".");
        }
        if (a == '.')
        {
            string son = kelimeler_[i].Remove(kelimeler_[i].Length -1);
            Console.Write(son + ",");
        }
    }
}

void bosluk()
{
    string kelime = "MerhabaBenim Adım...";
    string[] kelimeler = kelime.Split(" ");
    Console.WriteLine(kelimeler[0]);
}

void enuzun()
{
    string[] elemanlar = {"Selam","Merhabalarseninletanıstıgımamemnunoldum" , "Selam", "Lorem", "Ipsum", "simply","is","the","well","party","heji"};
    bool hey = false;
    int herkelime = 0;
    for (global::System.Int32 i = 0; i < elemanlar.Length; i++)
    {
        for (global::System.Int32 j = 0; j < elemanlar.Length; j++)
        {
            if (herkelime > elemanlar[j].Length)
            {
                Console.WriteLine(elemanlar[j]);
            }


        }

    }

}

void disardanarttir()
{
    double[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        double a = (sayilar[i] / 100) * 10;
        Console.WriteLine("Arttirilmis sayilar: "+(a + sayilar[i] ));
    }
}

void arama()
{
    Console.Write("Bir metin girin: ");
    string metin = Console.ReadLine();

    Console.Write("Aranacak alt dizeyi girin: ");
    string aranan = Console.ReadLine();

    int sayac = 0;
    int index = 0;

    while ((index = metin.IndexOf(aranan, index)) != -1)
    {
        sayac++;
        index += aranan.Length;
    }

    Console.WriteLine($"Aranan alt dize \"{aranan}\" metin içinde {sayac} defa geçiyor.");
}

void enbuyuk()
{
    int[] enbuyuksayi = { 10, 50, 90 };
    int max = int.MinValue;
    int yenisayi = 0;
    for (global::System.Int32 i = 0; i < enbuyuksayi.Length; i++)
    {
        if (enbuyuksayi[i] > max)
        {
            yenisayi = (enbuyuksayi[i]);
        }
    }
    Console.WriteLine(yenisayi);
}

void rastgelemetin()
{
    string rastgele = "ABCÇDEFGĞH";
    Random rand = new Random();
    string yeni = " ";
    for (global::System.Int32 i = 0; i < rastgele.Length; i++)
    {
        yeni += rastgele[rand.Next(10)];
    }
    Console.WriteLine(yeni);
}

void icaci()
{
    int kenarA = 30;
    int kenarB = 20;
    int toplam = 180 - (kenarA + kenarB);
    Console.WriteLine(toplam);
}

void sonelemandanyazdir()
{
    string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };

    for (int i = isimler.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(isimler[i]);
    }
}

void ushesapla()
{

    Console.Write("Lütfen Taban Değeri Giriniz: ");
    int taban = Convert.ToInt32(Console.ReadLine());
    Console.Write("Lütfen Üssü Griniz: ");
    int us = Convert.ToInt32(Console.ReadLine());
    int toplam = 1;
    for (global::System.Int32 i = 0; i < us; i++)
    {
        toplam *= taban;
    }
    Console.WriteLine(toplam);
}

void dikdortgen()
{
    Console.Write("İlk Kenarı Giriniz: ");
    int dikkenar1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci Kenarı Giriniz: ");
    int dikkenar2 = Convert.ToInt32(Console.ReadLine());
    int dikkenar3 = 0;
    for (global::System.Int32 i = 0; i < 1; i++)
    {
        dikkenar3 += dikkenar1 * dikkenar1;
        dikkenar3 += dikkenar2 * dikkenar2;
    }
    Console.WriteLine(dikkenar3);
} 

void sondanyazdir()
{
    string[] isimler = { "Hasan", "Hüseyin", "Ali", "Ece", "Miray", "Gamze" };
    for (int i = isimler.Length-1;  i>= 0; i--)
    {
        Console.WriteLine(isimler[i]);
    }
}

void ehliyet()
{
    Console.Write("Lütfen Yaşınızı Giriniz: ");
    int yas = Convert.ToInt32(Console.ReadLine());
    if (yas >= 18)
    {
        Console.WriteLine("Ehliyet Alabilirsiniz...");
    }
    else
    {
        int a = 18 - yas;
        Console.WriteLine("Ehliyet alabilmeniz için şu kadar yıl beklemelisiniz: " +  a);
    }
}

void ortalamaal()
{
    int[] sayilar = new int[5];
    int ciftler =  0;
    int ortalama = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Lütfen Sayi giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        if (sayilar[i] % 2 == 0)
        {
            ciftler += sayilar[i];
            ortalama++;
        }

    }
    Console.WriteLine("Girdiğiniz sayıların çift olanlarının ortalaması: "+ciftler / ortalama);
}

void ekranayazdir()
{
    int[] sayiar = new int[3];
    for (global::System.Int32 i = 0; i < sayiar.Length; i++)
    {
        Console.Write("Lütfen Sayıyı Giriniz: ");
        sayiar[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Girdiğiniz Sayılar: ");
    foreach (var item in sayiar)
    {
        Console.Write(item+ " ");
    }
}

void cifttek()
{
    Console.Write("LÜtfen Bir Sayı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        Console.WriteLine(sayi /2);
    }
    else
    {
        Console.WriteLine(sayi * 2);
    }
}

void topla()
{
    int toplam = 0;
    int[] sayilar = new int[3];
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Bir sayı giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        toplam += sayilar[i];
    }
    Console.WriteLine("Girdiğiniz sayıların toplamı: "+toplam);
}

void islemsec()
{
    Console.WriteLine("Bir işlem seçin - + * /");
    string a = Console.ReadLine();
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case "+":
            Console.WriteLine(c + b);
            break;
        case "-":
            Console.WriteLine(c - b);
            break;
        case "*":
            Console.WriteLine(c * b);
            break;
            case "/":
            Console.WriteLine(c / b);
            break;

    }

}

void ortalambul()
{
    int[] sayilar = new int[3];
    int toplam = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Sayi giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        toplam += sayilar[i];
    }
    Console.WriteLine(toplam / sayilar.Length);
} 

void buyukbul()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine("En büyük sayı: " + a);
    }
    else
    {
        Console.WriteLine("En büyük sayı: " + b);
    }

}

void sirala()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine("En büyük sayı: " + a);
        Console.Write("Sıralı: "+a + " " + b);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
    else
    {
        Console.WriteLine("En büyük sayı: " + b);
        Console.Write("Sıralı: " + b + " " + a);
        Console.WriteLine();
        Console.WriteLine(b);
        Console.WriteLine(a);
    }

}

void daire()
{
    double dairealani = 1;
    double daireyaricapi = 5;
    double pi = 3.1;

    dairealani = (dairealani * pi) * daireyaricapi;
    Console.WriteLine(dairealani);

}

void tambolun()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("Tam Bölünüyor...");
    }
    else
    {
        Console.WriteLine("Tam Bölünmüyor.");
    }
}

void faktoryel()
{
    Console.Write("Lütfen Faktriyeli Alınacak Sayıyı Giriniz: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = 1;
    for (global::System.Int32 i = 1; i <= a; i++)
    {
        b *= i;
    }
    Console.WriteLine(b);
}

void yaricaphesapla()
{
    double daireyaricapi = 10;
    double pi = 3.1;
    Console.WriteLine(2 * pi * daireyaricapi);
} 

void toplambul()
{
    int toplam = 0;
    for (global::System.Int32 i = 1; i <= 10; i++)
    {
        toplam += i;
    }
    Console.WriteLine(toplam);
}

void tekcift()
{
    int[] sayilar = new int[6];
    int tek = 0;
    int cift = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Sayı giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        if (sayilar[i] % 2 == 0)
        {
            cift += sayilar[i];
        }
        else
        {
            tek += sayilar[i];
        }

    }
    Console.WriteLine("Çift Sayıların Toplamı: " + cift);
    Console.WriteLine("Tek Sayıların Toplamı: " +tek);
}

void sayionoldugunda()
{
    int a = 0;
    while (a < 10) 
    {
        a++;
        Console.WriteLine("Sayı: " + a);
    }
}

void adanz()
{
    for (char i = 'a'; i <= 'z'; i++)
    {
        Console.WriteLine(i);
    }
} // A dan Z ye Char ile for döngüsü


void tekciftbul()
{
    Console.Write("Sayı Giriniz: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("Sayı Çifttir: " + a);
    }
    else
    {
        Console.WriteLine("Sayı Tektir: " + a);
    }
}

void birdenyuze()
{
    int[] sayilar = new int[100];
    int toplamadet = 0;
    Random random = new Random();
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = random.Next(1, 101);
    }
    for (global::System.Int32 i = 1; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 5 == 0)
        {
            toplamadet++;
        }
    }
    Console.WriteLine("5 E bölünen toplam sayı miktarı: " + toplamadet);
}

void enbuyukenkucukler()
{
    int[] sayilar = { 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int a = sayilar.Max();
    int b = sayilar.Min();
    Console.WriteLine(a);
    Console.WriteLine(b);
}

void bolbol()
{
    int[] sayilar = new int[150];
    Random random = new Random();
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = random.Next(50, 201);
    }
    Console.Write("Lütfen Bir Sayı Giriniz: ");
    int deger = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i]% deger == 0)
        {
            toplam++;
            Console.WriteLine(sayilar[i]);
        }
    }
    Console.WriteLine("Verdiğiniz sayıya bölünen sayıların adeti: " + toplam);
}

void ortalamaalbul()
{
    Console.Write("Vize Notunuzu Giriniz: ");
    int vize = Convert.ToInt32(Console.ReadLine());
    Console.Write("Final Notunuzu Giriniz: ");
    int final = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bütünleme Notunuzu Giriniz: ");
    int butunleme = Convert.ToInt32(Console.ReadLine());
    int toplam = (vize+final + butunleme) / 3;
    switch (toplam)
    {
        case < 30:
            Console.WriteLine("FF");
            break;
        case < 50:
            Console.WriteLine("DD");
            break;
        case < 60:
            Console.WriteLine("CC");
            break;
        case < 70:
            Console.WriteLine("BB");
            break;
        case < 80:
            Console.WriteLine("AA");
            break;
    }
}

void secimyap()
{
    Console.Write("Bir Sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.Write("Birini Seç Karesini al{1} Küpünü al{2} Karekökünü al{3}: ");
    int secim = Convert.ToInt32(Console.ReadLine());
    switch(secim)
    {
        case 1:
            Console.WriteLine(sayi * sayi);
            break;
        case 2:
            Console.WriteLine((sayi * sayi) * sayi);
            break;
        case 3:
            Console.WriteLine((sayi * sayi) * sayi);
            break;
    }
}

void rastgeledizi()
{
    Console.Write("Kaç tane rastgele sayı istersiniz?: ");
    int adet = Convert.ToInt32(Console.ReadLine());
    int[] sayilar = new int[adet];
    Random random = new Random();
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = random.Next(1000);
    }
    foreach (var item in sayilar)
    {
        Console.Write(item +" ");
    }
}

void loto()
{
    int[] sayilar = new int[6];
    Random random = new Random();
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = random.Next(1,90);
    }
    Console.Write("Loto Sonuçları: ");
    foreach (var item in sayilar)
    {
        Console.Write(item+" ");
    }
}

void sayitopla()
{
    Console.Write("Toplanacak sayı miktarı: ");
    int toplanacaksayilar = Convert.ToInt32(Console.ReadLine());
    int[] sayilar = new int[toplanacaksayilar];
    int toplam = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Lütfen sayı giriniz{" + i +"}: " );
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        toplam += sayilar[i];
    }
    Console.WriteLine("Girdiğiniz Sayıların Toplamı: "+toplam);
}

void kdv()
{
    Console.Write("Lütfen Fiyat Giriniz: ");
    double fiyat = Convert.ToDouble(Console.ReadLine());
    double toplam = (fiyat * 18) / 100;
    toplam += fiyat;
    Console.WriteLine(toplam);
}

void kdv2()
{
    Console.Write("Lütfen Fiyat Giriniz: ");
    double fiyat = Convert.ToDouble(Console.ReadLine());
    Console.Write("Lütfen KDV Oranını Giriniz: ");
    double kdv = Convert.ToDouble(Console.ReadLine());
    double toplam = (fiyat * kdv) / 100;
    toplam += fiyat;
    Console.WriteLine(toplam);
}

void negatif()
{

    int[] sayilar = new int[3];
    int toplam = 0;
    for (global::System.Int32 i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Lütfen Sayı Giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        if (sayilar[i] < 0)
        {
            break;
        }
        else
        {
            toplam += sayilar[i];
        }
    }
    Console.WriteLine("Girdiğiniz Pozitif Sayıların Toplamı: "+toplam);
} 

void tersarray()
{
    string[] isimler = { "Hasan", "Ali", "Ece", "Elif" };

    Console.WriteLine("İsimlerin Tersten Yazılışı:");

    for (int i = isimler.Length - 1; i >= 0; i--)
    {
        Console.Write(isimler[i] + " ");
    }
}

void isimara()
{
    Console.Write("Lütfen bir isim giriniz: ");
    string isim = Console.ReadLine();
    string[] isimler = { "Hasan", "Ali", "Ece", "Elif" };
    for (global::System.Int32 i = 0; i < isim.Length -1; i++)
    {
        if (isimler[i] == isim)
        {
            Console.WriteLine("Aradığınız isimde biri var...");
            break;
        }
        if (i == 3)
        {
            Console.WriteLine("Aradığınız isimde biri yok...");
            break;
        }
    }
} //57

void non_generic()
{
    ArrayList liste = new ArrayList();
    liste.Add(10);
    liste.Add("10");
    liste.Add('1');
    liste.Add(null);
    liste.Add(true);

    var liste2 = new ArrayList()
    {
        5,
        "Ahmet",
        false,
        4.5,
        null

    };
    int[] sayilar = { 10, 20, 30 };
    liste.AddRange(sayilar);
    liste.Insert(3, '5');
    liste.Remove(null);
    liste.RemoveAt(3);
    foreach (var item in liste)
    {
        Console.WriteLine(item);
    }
} // non generic list

void generic()
{
    List<int> sayilar = new List<int>();
    sayilar.Add(10);
    sayilar.Add(20);
    int[] sayilarlar = { 10, 20, 30, 40 };
    sayilar.AddRange(sayilarlar);

    List<string> liste = new List<string>() {"Ali","Ahmet","Ayşe","Hakan"};


    List<Product> urunler = new List<Product>();
    urunler.Add(new Product() { Id = 1, Title = "Sünger", Price = 4.99 });
    urunler.Add(new Product() { Id = 2, Title = "Kitap", Price = 7.99 });
    urunler.Add(new Product() { Id = 3, Title = "Sabun", Price = 10 });
    urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Bilezik",Price= 13.85});
    urunler.RemoveAt(2);
    urunler.Remove(urunler[0]);

    foreach (var item in urunler) 
    {
        Console.WriteLine(item.Title+ " " + item.Price);
    }
} // Generic list ve classlar ile list

void dictionary()
{
    Dictionary<int,string> plakalar = new Dictionary<int,string>();
    plakalar.Add(41, "Kocaeli");
    plakalar.Add(34, "İstanbul");
    plakalar.Add(53, "Rize");

    Dictionary<int, string> sayilar = new Dictionary<int, string>()
    {
        {1,"bir" },
        {2,"iki" },
        {3,"üç" }
    };

    if (plakalar.ContainsKey(34))
    {
        Console.WriteLine(plakalar[34]);
    }

    foreach (var item in plakalar)
    {
        Console.WriteLine(item.Key +" " + item.Value);
    }
    sayilar[1] = "one";
    //Console.WriteLine(sayilar[1]);
    sayilar.Remove(1);
}

dictionary();
class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
}
