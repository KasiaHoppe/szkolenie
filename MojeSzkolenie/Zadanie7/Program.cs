using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To jest program dodający wielomiany.");
            List<Wielomian> listaWielomianowPelna = new List<Wielomian>();

            Wielomian PodajWielomian(int numer)
            {
                List<Wielomian> listaWielomianow = new List<Wielomian>();
                Console.WriteLine($"Wybierz sposób wprowadzenia {numer} wielomianu. \n 1. Wprowadź jednomian \n 2. Podaj stopień i współczynniki wielomianu \n 3. Podaj współczynniki wielomianu");
                string sposob = Console.ReadLine();
                bool czyBlad = false;

                switch (sposob)
                {
                    case "1":
                        listaWielomianow.Add(new Wielomian());
                        break;

                    case "2":
                        Console.WriteLine("Podaj stopień wielomianu");
                        List<double> wspolczynnikiPierwszegoWielomianu = new List<double>();
                        try
                        {
                            int stopienWielomianu = int.Parse(Console.ReadLine());
                            for (int i = 0; i <= stopienWielomianu; i++)
                            {
                                Console.WriteLine($"Podaj współczynnik przy potędze {stopienWielomianu - i} stopnia");
                                wspolczynnikiPierwszegoWielomianu.Add(double.Parse(Console.ReadLine()));
                            }
                            double[] tablicaWielomiany = wspolczynnikiPierwszegoWielomianu.ToArray();
                            listaWielomianow.Add(new Wielomian(stopienWielomianu, tablicaWielomiany));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Podano błędną wartość stopnia wielomianu");
                            czyBlad = true;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Podaj kolejne współczynniki wielomianu");
                        List<double> wspolczynnikiPierwszegoWielomianu2 = new List<double>();
                        bool czyWszystkieWspolczynniki = true;
                        try
                        {
                            Console.WriteLine("Podawaj kolejno współćzynniki zaczynając od tego przy najwyższej potędze");
                            while (czyWszystkieWspolczynniki)
                            {
                                Console.WriteLine("Podaj kolejny współczynnik");
                                wspolczynnikiPierwszegoWielomianu2.Add(double.Parse(Console.ReadLine()));
                                Console.WriteLine("Czy chcesz wpisać kolejny współczynnik? Y / N");
                                string odp = Console.ReadLine();
                                if (odp != "Y" && odp != "y")
                                {
                                    czyWszystkieWspolczynniki = false;
                                }

                            }
                            listaWielomianow.Add(new Wielomian(wspolczynnikiPierwszegoWielomianu2));

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Podano błędną wartość współczynnika wielomianu");
                            czyBlad = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Serio!? Miałeś wpisać 1,2 lub 3 i nawet tego nie potrafiłeś zrobić dobrze? :P");
                        Console.WriteLine("W takim razie domyślnie podstawiam jednomian.");
                        listaWielomianow.Add(new Wielomian());
                        break;
                }

                if (czyBlad)
                {
                    Console.WriteLine("Wykryto błąd. W takim razie domyślnie podstawiam jednomian.");
                    listaWielomianow.Add(new Wielomian());
                }
                return listaWielomianow[0];
            }


            listaWielomianowPelna.Add(PodajWielomian(1));
            listaWielomianowPelna.Add(PodajWielomian(2));





            Console.WriteLine("Pierwszy wielomian: ");
            listaWielomianowPelna[0].ZwrocStopienWielomianu();
            double[] wsp3w = listaWielomianowPelna[0].WypiszWspolczynniki();
            int ileWsp = wsp3w.Length;
            foreach (double wsp in wsp3w)
            {
                Console.WriteLine($"Współczynnik przy potędze {ileWsp} to: {wsp}");
                ileWsp -= 1;
            }

            Console.WriteLine("Drugi wielomian: ");
            listaWielomianowPelna[1].ZwrocStopienWielomianu();
            double[] wsp3w1 = listaWielomianowPelna[1].WypiszWspolczynniki();
            ileWsp = wsp3w1.Length;
            foreach (double wsp in wsp3w1)
            {
                Console.WriteLine($"Współczynnik przy potędze {ileWsp} to: {wsp}");
                ileWsp -= 1;
            }

            listaWielomianowPelna.Add(listaWielomianowPelna[0].DodawanieWielomianow(listaWielomianowPelna[1]));
            Console.WriteLine("Wielomian po dodaniu pierwszego i drugiego to: ");
            listaWielomianowPelna[2].ZwrocStopienWielomianu();
            double[] wsp3w2 = listaWielomianowPelna[2].WypiszWspolczynniki();
            ileWsp = wsp3w2.Length;
            foreach (double wsp in wsp3w2)
            {
                Console.WriteLine($"Współczynnik przy potędze {ileWsp} to: {wsp}");
                ileWsp -= 1;
            }



        }
    }
}
