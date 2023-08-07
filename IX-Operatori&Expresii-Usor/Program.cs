using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace IX_Operatori_Expresii_Usor
{
    internal class Program
    {

        public static void Problema_939()
        // Se dau 2 numere naturale. Calculaţi suma celor 2 numere date.
        {
            string t = Console.ReadLine();
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);
            int s = x + y;

            Console.WriteLine(s.ToString());
        }

        public static void Problema_941()
        //Scrie un program care afişează pe ecran o urare pentru cei dragi ţie!
        {
            Console.WriteLine("Sarbatori fericite !");
            Console.ReadKey();
        }

        public static void Problema_1258()
        //Se dau două numere naturale. Calculați diferenţa lor.
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);
            int s = x - y;

            Console.WriteLine(s.ToString());
        }
        public static void Problema_1260()
        //Se citesc două numere naturale. Afișați suma, diferenţa, produsul şi câtul lor, în această ordine, separate prin câte un spațiu.
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);
            int s = x + y;
            int s1 = x - y;
            int s2 = x * y;
            int s3 = x / y;

            Console.WriteLine(s + " " + s1 + " " + s2 + " " + s3);
        }

        public static void Problema_1273()
        //Se dau două numere naturale x și y. Calculați ultima cifră a sumei lor.
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);
            int s = (x + y) % 10;

            Console.WriteLine(s.ToString());

            Console.ReadKey();
        }
        public static void Problema_813()
        //Într-un brad sunt a globuri albe, de două ori mai multe globuri roșii, iar globuri verzi cu 3 mai puține ca numărul de globuri roșii. Câte globuri sunt în total?
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = x * 2;
            int z = y - 3;
            int s = x + y + z;

            Console.WriteLine(s.ToString());
            Console.ReadKey();

        }
        public static void Problema_3178()
        //Într-o clasă sunt F fete și B băieți. Fiecare fată citește 3 pagini pe zi și fiecare băiat citește 2 pagini pe zi. Câte pagini vor citi copiii în n zile?
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int f = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int n = int.Parse(d[2]);

            int x = f * 3;
            int y = b * 2;
            int s = (x + y) * n;


            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
        public static void Problema_2240()
        //Într-o curte sunt câini, pisici și găini. Se știe că numărul de pisici este egal cu dublul numărului de câini, iar numărul de găini este egal cu dublul numărului de pisici. Dacă în curte sunt C câini, câte animale sunt în curte?
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);

            Console.WriteLine((7 * x).ToString());
            Console.ReadKey();
        }
        public static void Problema_3179()
        //Într-un parc sunt n alei. Pe fiecare alee sunt n arbori. Fiecare arbore are n crengi. Pe fiecare creanga sunt n cuiburi. În fiecare cuib sunt n păsări. Câte păsări sunt în parc?
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int n = int.Parse(d[0]);

            Console.WriteLine((n * n * n * n * n).ToString());
            Console.ReadKey();
        }
        public static void Problema_2263()
        //O firmă are două tipuri de camioane: camioane de tipul 1, care pot transporta câte t1 tone de marfă pe zi, și camioane de tipul 2, care pot transporta câte t2 tone de marfă pe zi.
        //Știind că firma are n camioane de tipul 1 și m camioane de tipul 2, câte tone de marfă pot transporta camioanele firmei în z zile.
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int t1 = int.Parse(d[0]);
            int t2 = int.Parse(d[1]);
            int n = int.Parse(d[2]);
            int m = int.Parse(d[3]);
            int z = int.Parse(d[4]);

            int s = z * (n * t1 + m * t2);
            Console.WriteLine(s.ToString());
            Console.ReadKey();

        }
        public static void Problema_814()
        //Fiind date două numere naturale x și y determinați valoarea care trebuie adunată la x pentru a obține triplul lui y.
        {
            string t = (Console.ReadLine());
            string[] d = t.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);

            int s = 3 * y - x;

            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
        public static void Problema_3210()
        //O cutie cu bomboane costă B lei. Gigel are S lei. Determinați câte cutii cu bomboane poate cumpăra Gigel și câți lei trebuie să mai primească pentru a cumpăra încă o cutie.
        {
            string t = Console.ReadLine();
            string[] d = t.Split(' ');


            int y = int.Parse(d[0]);
            int x = int.Parse(d[1]);
            int s1 = x / y;
            int s2 = x % y;
            int s3 = y - s2;


            Console.WriteLine(s1 + " " + s3);
            Console.ReadKey();
        }
        public static void Problema_3978()
        //Dacă x și y sunt două numere naturale cu x ≤ y, atunci notăm cu s(x,y) suma numerelor naturale cuprinse între x și y. De exemplu, s(3,6) = 3+4+5+6 = 18, iar s(7,7) = 7.
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            int z = int.Parse(numbers[2]);

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = x; i <= y; i++)
            {
                sum1 += i;
            }

            for (int i = y; i <= z; i++)
            {
                sum2 += i;
            }

            for (int i = x; i <= z; i++)
            {
                sum3 += i;
            }

            Console.WriteLine(string.Format("{0} {1} {2}", sum1, sum2, sum3));
            Console.ReadKey();
        }
        public static void Problema_3180()
        //Pe planeta Marte banii sunt altfel decât la noi. Există 3 tipuri de monede: primul tip de monedă valorează a lei marțieni, al doilea tip valorează b lei marțieni, iar al treilea tip de monedă valorează c lei marțieni.
        //Marțianul Iggle are n monede de primul tip, m monede de al doilea tip și p monede de al treilea tip. Câți lei marțieni are Iggle?
        {
            string input = Console.ReadLine();
            string[] d = input.Split(' ');

            int valx = int.Parse(d[0]);
            int valy = int.Parse(d[1]);
            int valz = int.Parse(d[2]);

            string input2 = Console.ReadLine();
            string[] f = input2.Split(' ');

            int sumn = int.Parse(f[0]);
            int summ = int.Parse(f[1]);
            int sump = int.Parse(f[2]);

            int sum = (valx * sumn + valy * summ + valz * sump);

            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
        public static void Problema_3182()
        //Pe planeta Marte anul marțian durează z zile marțiene. Marțianul Iggle își serbează ziua de naștere și constată că a trăit n zile. Câte lumânări va avea tortul lui Iggle?
        {
            string input = Console.ReadLine();
            string[] d = input.Split(' ');

            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);

            int sum = y / x;

            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }

        public static void Problema_815()
        //Câte cutii cubice de latură l pot fi suprapuse într-o încăpere de înălțime h.
        {
            string[] t = Console.ReadLine().Split(' ');

            int l = int.Parse(t[0]);
            int h = int.Parse(t[1]);


            int s = h / l;

            Console.WriteLine(s.ToString());

        }
        public static void Problema_175()
        //Într-o curte sunt G găini și O oi. Să se determine numărul de capete și numărul de picioare din curte.
        {
            string[] t = Console.ReadLine().Split(' ');

            int g = int.Parse(t[0]);
            int o = int.Parse(t[1]);

            int c = g + o;
            int p = (g * 2) + (o * 4);


            Console.WriteLine(c + " " + p);

        }
        public static void Problema_2061()
        //În Japonia trenurile pot suporta un număr de vagoane și marfă. Toate vagoanele au încărcături egale.
        {
            string[] t = Console.ReadLine().Split(' ');

            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);

            int s = m / n;

            Console.WriteLine(s.ToString());
        }
        public static void Problema_2764()
        //Orice culoare poate fi reprezentată drept o combinație de intensități de roșu (RED), verde (GREEN) și albastru (BLUE). Calculatorul tău folosește, cel mai probabil, culori reprezentate pe 24 de biți,
        //câte 8 rezervați fiecăreia dintre cele trei culori anterior menționate.
        //Definim opusul unei culori(r, g, b) ca fiind(255 – r, 255 – g, 255 – b).
        {
            string[] t = Console.ReadLine().Split(' ');

            int r = int.Parse(t[0]);
            int g = int.Parse(t[1]);
            int b = int.Parse(t[2]);

            int R = 255 - r;
            int G = 255 - g;
            int B = 255 - b;

            Console.WriteLine(R + " " + G + " " + B);
            Console.ReadKey();

        }

        public static void Problema_102()
        //Să se scrie un program care citeşte de la tastatură un număr natural cu cel puţin două cifre
        //şi determină suma dintre cifra zecilor şi cifra unităţilor numărului citit.
        {
            string[] t = Console.ReadLine().Split(' ');

            int x = int.Parse(t[0]);

            int x1 = x % 10;
            int x2 = x / 10 % 10;

            int s = x1 + x2;
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }

        public static void Problema_1282()
        //Se dă un număr. Să se afișeze rădăcina sa pătrată.
        {
            string[] t = Console.ReadLine().Split(' ');

            int n = int.Parse(t[0]);

            Console.WriteLine(Math.Sqrt(n));
            Console.ReadKey();
        }

        public static void Problema_2599()
        {
            string[] t = Console.ReadLine().Split(' ');

            int a = int.Parse(t[0]);
            int s = a += a * 16;

            Console.WriteLine(s.ToString());
            Console.ReadKey();

            // ???????????????????????????????????????????????????????????????????
        }

        public static void Problema_2377()
        //Se cunoaște faptul ca n pisici mănâncă n șoareci în n minute. Sa se determine în cat timp mănâncă m pisici m șoareci.
        {
            string[] t = Console.ReadLine().Split(' ');

            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);


        }

        public static void Problema_1343()
        //Se dă un număr real n. Să se afișeze rădăcina sa pătrată.
        {
            string[] t = Console.ReadLine().Split(' ');

            double n = double.Parse(t[0]);

            Console.WriteLine(Math.Sqrt(n));
        }









        static void Main(string[] args)
        {
            Problema_1343();
            Console.ReadKey();
        }
    }
}
