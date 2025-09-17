using System;

class Program
{
    static void Main()
    {
         
    }

    static void F1()
    {
        Console.WriteLine("Hello world!");
    }

    static void F2()
    {
        Console.Write("Kérlek add meg a neved: ");
        string nev = Console.ReadLine();
        Console.WriteLine("Üdvözöllek, " + nev + "!");
    }

    static void F3()
    {
        Console.Write("Adj meg egy (egész) számot: ");
        string s = Console.ReadLine();
        if (!int.TryParse(s, out int szam))
        {
            Console.WriteLine("Hiba: nem egész szám lett megadva.");
            return;
        }
        int eredmeny = szam * 2; // kétszeres
        Console.WriteLine("A kétszerese: " + eredmeny);
    }

    static void F4() 
    {
        Console.Write("Írj be két számot (space): ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // szóközökkel vagy tabulátorokkal elválasztva
        if (parts.Length < 2)
        {
            Console.WriteLine("Hiba: két szám szükséges.");
            return;
        }
        if (!double.TryParse(parts[0], out double elso) || !double.TryParse(parts[1], out double masodik)) // mind s kettő szám legyen
        {
            Console.WriteLine("Hiba: érvénytelen számformátum.");
            return;
        }

        double osszeg = elso + masodik; 
        double kulonbseg = elso - masodik; 
        double szorzat = elso * masodik;

        Console.WriteLine("Összeg: " + osszeg);
        Console.WriteLine("Különbség: " + kulonbseg);
        Console.WriteLine("Szorzat: " + szorzat);

        if (masodik != 0)
            Console.WriteLine("Hányados: " + (elso / masodik));
        else
            Console.WriteLine("Hányados: nem értelmezhető (osztó = 0).");
    }

    static void F5()
    {
        Console.Write("Kérlek add meg két egész számot: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // szóközökkel vagy tabulátorokkal elválasztva
        if (parts.Length < 2 || !int.TryParse(parts[0], out int a) || !int.TryParse(parts[1], out int b)) // mind s kettő egész szám legyen
        {
            Console.WriteLine("Hiba: két egész szám szükséges.");
            return;
        }

        if (a > b)
            Console.WriteLine("A nagyobb: " + a);
        else if (b > a)
            Console.WriteLine("A nagyobb: " + b);
        else
            Console.WriteLine("A két szám egyenlő.");
    }

    static void F6()
    {
        Console.Write("Adj meg három egész számot: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // szóközökkel vagy tabulátorokkal elválasztva
        if (parts.Length < 3 || !int.TryParse(parts[0], out int x1) || !int.TryParse(parts[1], out int x2) || !int.TryParse(parts[2], out int x3)) // mind s kettő egész szám legyen
        {
            Console.WriteLine("Hiba: három egész szám szükséges.");
            return;
        }

        int legkisebb = x1;
        if (x2 < legkisebb) legkisebb = x2;
        if (x3 < legkisebb) legkisebb = x3;

        Console.WriteLine("A legkisebb: " + legkisebb);
    }

    static void F7()
    {
        Console.Write("Adja meg a háromszög három oldalát: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); 
        if (parts.Length < 3 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b) || !double.TryParse(parts[2], out double c))
        {
            Console.WriteLine("Hiba: három szám szükséges.");
            return;
        }

        if (a + b > c && a + c > b && b + c > a) // háromszög-egyenlőtlenség
            Console.WriteLine("Ez a háromszög megszerkeszthető.");
        else
            Console.WriteLine("Nem szerkeszthető háromszög.");
    }

    static void F8()
    {
        Console.Write("Két pozitív szám: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b)) // mind s kettő szám legyen
        {
            Console.WriteLine("Hiba: két szám szükséges.");
            return;
        }
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Hiba: pozitív számokat kérünk.");
            return;
        }

        double szamtani = (a + b) / 2.0;
        double mertani = Math.Sqrt(a * b);

        Console.WriteLine("Számtani közép: " + szamtani);
        Console.WriteLine("Mértani közép: " + mertani);
    }

    static void F9()
    {
        Console.Write("Másodfokú egyenlet együtthatói (a b c): ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); 
        if (parts.Length < 3 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b) || !double.TryParse(parts[2], out double c)) 
        {
            Console.WriteLine("Hiba: három szám szükséges.");
            return;
        }

        const double eps = 1e-12; // kis szám az összehasonlításhoz
        if (Math.Abs(a) < eps) // lineáris eset
        {

            if (Math.Abs(b) < eps)
            {
                if (Math.Abs(c) < eps)
                    Console.WriteLine("Azonos egyenlet: végtelen sok megoldás.");
                else
                    Console.WriteLine("Nincs megoldás (ellenmondó egyenlet).");
            }
            else
            {
                Console.WriteLine("Lineáris egyenlet, egy valós megoldás van.");
            }
            return;
        }

        double D = b * b - 4 * a * c; // diszkrimináns
        if (D < 0)
            Console.WriteLine("Nincs valós megoldás.");
        else
            Console.WriteLine("Van valós megoldás.");
    }

    static void F10()
    {
        Console.Write("Másodfokú egyenlet együtthatói (a b c): ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 3 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b) || !double.TryParse(parts[2], out double c))
        {
            Console.WriteLine("Hiba: három szám szükséges.");
            return;
        }

        const double eps = 1e-12; // kis szám az összehasonlításhoz
        if (Math.Abs(a) < eps)
        {

            if (Math.Abs(b) < eps) 
            {
                if (Math.Abs(c) < eps) 
                {
                    Console.WriteLine("Azonos egyenlet: minden valós szám megoldás.");
                }
                else
                {
                    Console.WriteLine("Nincs megoldás.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Lineáris eset, megoldás: x = " + x);
            }
            return;
        }

        double D = b * b - 4 * a * c; // diszkrimináns
        if (D < 0)
        {
            Console.WriteLine("Nincs valós megoldás.");
        }
        else if (Math.Abs(D) < eps)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Egy valós megoldás: x = " + x);
        }
        else
        {
            double sqrtD = Math.Sqrt(D); // pozitív gyök
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);
            Console.WriteLine("Két valós megoldás: x1 = " + x1 + ", x2 = " + x2);
        }
    }

    static void F11()
    {
        Console.Write("A derékszögű háromszög befogói: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b))
        {
            Console.WriteLine("Hiba: két szám szükséges.");
            return;
        }

        double c = Math.Sqrt(a * a + b * b); 
        Console.WriteLine("Átfogó: " + c.ToString("F2")); // két tizedesjegyre kerekítve
    }

    static void F12()
    {
        Console.Write("A téglatest három éle: ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 3 || !double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b) || !double.TryParse(parts[2], out double c))
        {
            Console.WriteLine("Hiba: három szám szükséges.");
            return;
        }

        double felszin = 2 * (a * b + a * c + b * c); // felszín képlete
        double terfogat = a * b * c; // térfogat képlete

        Console.WriteLine("Felszín: " + felszin);
        Console.WriteLine("Térfogat: " + terfogat);
    }

    static void F13()
    {
        Console.Write("A kör átmérője: ");
        string s = Console.ReadLine();
        if (!double.TryParse(s, out double atmero))
        {
            Console.WriteLine("Hiba: érvénytelen szám.");
            return;
        }
        double r = atmero / 2.0;

        double kerulet = 2 * Math.PI * r;
        double terulet = Math.PI * r * r;

        Console.WriteLine("Kerület: " + kerulet);
        Console.WriteLine("Terület: " + terulet);
    }

    static void F14()
    {
        Console.Write("Kör sugara és középponti szöge (fok): ");
        string[] parts = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2 || !double.TryParse(parts[0], out double r) || !double.TryParse(parts[1], out double szog))
        {
            Console.WriteLine("Hiba: két szám szükséges (sugár és fokban megadott szög).");
            return;
        }

        double ivhossz = 2 * Math.PI * r * (szog / 360.0); // ívhossz képlete
        double szeletTerulet = Math.PI * r * r * (szog / 360.0); // körszelet területe

        Console.WriteLine("Ívhossz: " + ivhossz);
        Console.WriteLine("Szelet területe: " + szeletTerulet);
    }
}

// 15. Kiírja 1-től n-ig a számokat szóközzel elválasztva
//static void F15()
//{
//    Console.Write("Adj meg egy pozitív egész számot: ");
//    int n = int.Parse(Console.ReadLine());
//    for (int i = 1; i <= n; i++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


// 16. Kiírja 1-től n-ig a számokat egymás alá
//static void F16()
//{
//    Console.Write("Adj meg egy pozitív egész számot: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= n; i++)
//    {
//        Console.WriteLine(i);
//    }
//}


// 17. Egy szám osztóinak kiírása
//static void F17()
//{
//    Console.Write("Adj meg egy pozitív egész számot: ");
//    int szam = int.Parse(Console.ReadLine());
//    Console.WriteLine("A(z) " + szam + " osztói:");
//    for (int i = 1; i <= szam; i++)
//    {
//        if (szam % i == 0)
//            Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


// 18. Osztók összege
//static void F18()
//{
//    Console.Write("Adj meg egy pozitív egész számot: ");
//    int szam = Convert.ToInt32(Console.ReadLine());
//    int osszeg = 0;
//    for (int i = 1; i <= szam; i++)
//    {
//        if (szam % i == 0)
//            osszeg += i;
//    }
//    Console.WriteLine("Az osztók összege: " + osszeg);
//}


// 19. Tökéletes szám-e?
//static void F19()
//{
//    Console.Write("Adj meg egy pozitív egész számot: ");
//    int n = int.Parse(Console.ReadLine());
//    int osszeg = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//            osszeg += i;
//    }
//    if (osszeg == 2 * n)
//        Console.WriteLine(n + " tökéletes szám.");
//    else
//        Console.WriteLine(n + " nem tökéletes szám.");
//}


//// 20. Hatványozás
//static void F20()
//{
//    Console.Write("Hatványalap: ");
//    int alap = int.Parse(Console.ReadLine());
//    Console.Write("Kitevő: ");
//    int kitevo = int.Parse(Console.ReadLine());
//    double eredmeny = Math.Pow(alap, kitevo);
//    Console.WriteLine("Hatványérték: " + eredmeny);
//}


//// 21. Csak pozitív számot fogad el
//static void F21()
//{
//    int n;
//    do
//    {
//        Console.Write("Adj meg egy pozitív számot: ");
//    } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
//    Console.WriteLine("Köszönöm, a szám: " + n);
//}
//}

// azokhoz a sorokhoz irtam kommentet, amihez hasznaltam valamilyen segitseget. legtöbb esetben ait.