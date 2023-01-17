using CounterStirke;

#region Silah Secim Asamasi
Console.WriteLine("Oyun Basladi!! Silah Seciniz:\n1- Bicak\n2- Tabanca\n3- Roket Atar\n4- Tufek");
int kullaniciSilahi = int.Parse(Console.ReadLine());
int secim;

if (kullaniciSilahi == 4)
{
    Console.Clear();
    Console.WriteLine("1- Taramali Tufek\n2- Pompali Tufek");
    int tufekSecimi = int.Parse(Console.ReadLine());

    if (tufekSecimi == 1)
        kullaniciSilahi = 4;

    else
        kullaniciSilahi = 5;
}

Console.Clear();
#endregion

#region Oyunun Calistirilmasi
switch (kullaniciSilahi)
{
    case 1:
        BicakSecimi();
        break;

    case 2:
        TabancaSecimi();
        break;

    case 3:
        RoketAtarSecimi();
        break;

    case 4:
        TaramaliTufekSecimi();
        break;

    case 5:
        PompaliTufekSecimi();
        break;

    default:
        break;
}
#endregion

// Bicak secince donecek oyun
void BicakSecimi()
{
    Bicak bicak = new Bicak();
    Dusman dusman1 = new Dusman(20);
    bicak.VerilenHasar = dusman1.Can / 5;

    do
    {
        Console.WriteLine("1) Kes\n2) Bileyle");
        secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            bicak.Kes();
            dusman1.Can -= bicak.VerilenHasar;
            Console.WriteLine($"Kalan Dusman Cani: {(dusman1.Can <= 0 ? "0" : $"{dusman1.Can}")}");
        }

        else if (secim == 2)
            bicak.Bileyle();

        if (dusman1.Can <= 0)
            Console.WriteLine("\nDusman Olduruldu");

    } while (dusman1.Can > 0);

}

// Tabanca secince donecek oyun
void TabancaSecimi()
{
    Tabanca tabanca = new Tabanca();
    Dusman dusman2 = new Dusman(20);

    do
    {
        Console.WriteLine("1) Ates Et\n2) Sarjor Doldur");
        secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            tabanca.AtesEt();
            dusman2.Can = dusman2.Can - tabanca.VerilenHasar;
            Console.WriteLine($"Kalan Dusman Cani: {(dusman2.Can <= 0 ? "0" : $"{dusman2.Can}")}");
        }

        else if (secim == 2)
            tabanca.SarjorDoldur();

        if (dusman2.Can <= 0)
            Console.WriteLine("\nDusman Olduruldu");

    } while (dusman2.Can > 0);
}

// Roket Atar secince donecek oyun
void RoketAtarSecimi()
{
    RoketAtar roketAtar = new RoketAtar();
    Dusman dusman3 = new Dusman(20);

    do
    {
        Console.WriteLine("1) Ates Et\n2) Sarjor Doldur\n3) Yakinlastir\n4) Uzaklastir");
        secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            roketAtar.AtesEt();
            dusman3.Can = dusman3.Can - roketAtar.VerilenHasar;
            Console.WriteLine($"Kalan Dusman Cani: {(dusman3.Can <= 0 ? "0" : $"{dusman3.Can}")}");
        }

        else if (secim == 2)
            roketAtar.SarjorDoldur();

        else if (secim == 3)
            roketAtar.Yakinlastir();

        else if (secim == 4)
            roketAtar.Uzaklastir();

        if (dusman3.Can <= 0)
            Console.WriteLine("\nDusman Olduruldu");

    } while (dusman3.Can > 0);
}

// Taramali Tufek secince donecek oyun
void TaramaliTufekSecimi()
{
    TaramaliTufek taramaliTufek = new TaramaliTufek();
    Dusman dusman4 = new Dusman(20);

    do
    {
        Console.WriteLine("1) Ates Et\n2) Sarjor Doldur\n3) Yakinlastir\n4) Uzaklastir");
        secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            taramaliTufek.AtesEt();
            dusman4.Can = dusman4.Can - taramaliTufek.VerilenHasar;
            Console.WriteLine($"Kalan Dusman Cani: {(dusman4.Can <= 0 ? "0" : $"{dusman4.Can}")}");
        }

        else if (secim == 2)
            taramaliTufek.SarjorDoldur();

        else if (secim == 3)
            taramaliTufek.Yakinlastir();

        else if (secim == 4)
            taramaliTufek.Uzaklastir();

        if (dusman4.Can <= 0)
            Console.WriteLine("\nDusman Olduruldu");

    } while (dusman4.Can > 0);

}

// Pompali Tufek secince donecek oyun
void PompaliTufekSecimi()
{
    PompaliTufek pompaliTufek = new PompaliTufek();
    Dusman dusman5 = new Dusman(20);

    do
    {
        Console.WriteLine("1) Ates Et\n2) Sarjor Doldur\n3) Yakinlastir\n4) Uzaklastir");
        secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            pompaliTufek.AtesEt();
            dusman5.Can = dusman5.Can - pompaliTufek.VerilenHasar;
            Console.WriteLine($"Kalan Dusman Cani: {(dusman5.Can <= 0 ? "0" : $"{dusman5.Can}")}");
        }

        else if (secim == 2)
            pompaliTufek.SarjorDoldur();

        else if (secim == 3)
            pompaliTufek.Yakinlastir();

        else if (secim == 4)
            pompaliTufek.Uzaklastir();

        if (dusman5.Can <= 0)
            Console.WriteLine("\nDusman Olduruldu");

    } while (dusman5.Can > 0);
}