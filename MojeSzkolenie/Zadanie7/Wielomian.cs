using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Wielomian
    {
        int stopien_wielomianu; // n
        double[] wspolczynnik_wielomianu; // a

        public Wielomian(int st = 0, double wsp = 1.0)
        {
            double[] wsp2 = { 1.0 };
            stopien_wielomianu = st;
            wspolczynnik_wielomianu = wsp2;
        }

        public Wielomian(int st, double[] wsp)
        {
            List<string> bledy = Sprawdz_bledy(st, wsp);
            if (bledy.Count == 0)
            {
                stopien_wielomianu = st;
                wspolczynnik_wielomianu = wsp;
            }

            else Wypisz_bledy(bledy);
        }

        public Wielomian(List<double> list_wsp)
        {
            List<string> bledy = Sprawdz_bledy(list_wsp.Count() - 1, list_wsp.ToArray());
            if (bledy.Count == 0)
            {
                stopien_wielomianu = list_wsp.Count() - 1;
                wspolczynnik_wielomianu = list_wsp.ToArray();
            }

            else Wypisz_bledy(bledy);
        }

        public List<string> Sprawdz_bledy(int st, double[] wsp)
        {
            List<string> lista_bledow = new List<string>();
            if (wsp[0] == 0 && st > 0)
            {
                lista_bledow.Add("Współczynnik przy najwyższej potędze nie może się równać 0");
            }

            if (st < 0)
            {
                lista_bledow.Add("Stopień wielomianu nie może być mniejszy od 0");
            }

            if (wsp.Length != st + 1)
            {
                lista_bledow.Add("Libcza współczynników musi być o 1 większa od stopnia wielomianu");
            }

            return lista_bledow;
        }

        void Wypisz_bledy(List<string> list)
        {
            foreach (string blad in list)
            {
                Console.WriteLine(blad);
            }

        }

        public void ZwrocStopienWielomianu()
        {
            Console.WriteLine($"stopień wielomianu to {stopien_wielomianu}");
        }

        public void ZwrocWspolczynnik(int nr_wspolczynnika)
        {
            if (wspolczynnik_wielomianu.Length - 1 >= nr_wspolczynnika && nr_wspolczynnika >= 0)
            {
                Console.WriteLine($"Wybrany współczynnik to: { wspolczynnik_wielomianu[(wspolczynnik_wielomianu.Length - 1) - (nr_wspolczynnika)]}");
            }

            else Console.WriteLine($"Współczynników jest {wspolczynnik_wielomianu.Length} podaj prawiłową wartość od 0 do {wspolczynnik_wielomianu.Length - 1}");
        }

        public void ZmienWspolczynniki(int ktory_wsp, double nowy_wsp)
        {
            if (wspolczynnik_wielomianu.Length - 1 >= ktory_wsp && ktory_wsp >= 0)
            {
                if (ktory_wsp == wspolczynnik_wielomianu.Length - 1 && nowy_wsp == 0)
                {
                    Console.WriteLine("Współczynnik przy najwyższej potędze nie może się równać 0");
                }
                else
                {
                    wspolczynnik_wielomianu[(wspolczynnik_wielomianu.Length - 1) - (ktory_wsp)] = nowy_wsp;
                    Console.WriteLine($"Nowy wspołczynnik numer {ktory_wsp} to {nowy_wsp}.");
                }

            }
            else Console.WriteLine($"Współczynników jest {wspolczynnik_wielomianu.Length} podaj prawiłową wartość od 0 do {wspolczynnik_wielomianu.Length - 1}");
        }

        public double[] WypiszWspolczynniki()
        {
            return wspolczynnik_wielomianu;

        }

        public Wielomian DodawanieWielomianow(Wielomian wielomianDodawany)
        {
            double[] wspolczynnik2 = wielomianDodawany.WypiszWspolczynniki();
            int dlugoscWielomianu1 = wspolczynnik_wielomianu.Length;
            int dlugoscWielomianu2 = wielomianDodawany.WypiszWspolczynniki().Length;
            int minDlugosc;
            int maxDlugosc;
            List<double> noweWspolczynnikiLista = new List<double>();

            if (dlugoscWielomianu1 > dlugoscWielomianu2)
            {
                minDlugosc = dlugoscWielomianu2;
                maxDlugosc = dlugoscWielomianu1;
            }
            else
            {
                minDlugosc = dlugoscWielomianu1;
                maxDlugosc = dlugoscWielomianu2;
            }

            for (int i = 1; i <= minDlugosc; i++)
            {
                noweWspolczynnikiLista.Add(wspolczynnik_wielomianu[dlugoscWielomianu1 - i] + wspolczynnik2[dlugoscWielomianu2 - i]);

            }

            for (int i = minDlugosc + 1; i <= maxDlugosc; i++)
            {
                if (dlugoscWielomianu1 > dlugoscWielomianu2)
                {
                    noweWspolczynnikiLista.Add(wspolczynnik_wielomianu[dlugoscWielomianu1 - i]);
                }
                else
                {
                    noweWspolczynnikiLista.Add(wspolczynnik2[dlugoscWielomianu2 - i]);
                }
            }
            List<double> wspOdKonca = new List<double>();
            for(int i = noweWspolczynnikiLista.Count()-1; i>=0;i--)
            {
                wspOdKonca.Add(noweWspolczynnikiLista[i]);
            }

            Wielomian wynik = new Wielomian(wspOdKonca);
            return wynik;
        }

    }
}
