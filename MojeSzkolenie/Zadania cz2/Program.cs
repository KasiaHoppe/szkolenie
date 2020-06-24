using System;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Kasiowe
{
    class Program
    {
        static void Main(string[] args)
        {
            void KonwersjaArabToRzym()
            {
                Console.WriteLine("Podaj liczbę arabską do konwersji na system rzymski.");
                int liczba;
                bool czyLiczbaArabska = false;
                try
                {
                    liczba = int.Parse(Console.ReadLine());
                    czyLiczbaArabska = true;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Błąd - podana wartość nie jest liczbą rzymską.");
                    liczba = 1;
                }

                if (czyLiczbaArabska)
                {
                    Konwersja konwersjaRzymska = new Konwersja();

                    string liczbaRzymska = konwersjaRzymska.ZwrocRzymska(liczba);

                    Console.WriteLine($"Liczba arabska {liczba} to w systemie rzymskim: {liczbaRzymska}");
                }
            }

            var path = @"C:\Users\Ja\Desktop\text.txt";
            string content = File.ReadAllText(path, Encoding.UTF8);
            content = content.ToLower();
            content = Regex.Replace(content, "[^a-z ]", String.Empty);
            content = content + " ";
            Console.WriteLine(content);
            Dictionary<string, int> slownikSlowa = new Dictionary<string, int>();

            string tymczasoweSlowo = "";
            int maxSlowo = 0;
            string maxKey = "";

            for (int i = 0; i < content.Length; i++)
            {

                if (Char.IsWhiteSpace(content[i]))
                {
                    if (slownikSlowa.ContainsKey(tymczasoweSlowo))
                    {
                        slownikSlowa[tymczasoweSlowo] = slownikSlowa[tymczasoweSlowo] + 1;
                    }
                    else
                    {
                        slownikSlowa.Add(tymczasoweSlowo, 1);
                    }
                    if (slownikSlowa[tymczasoweSlowo] > maxSlowo)
                    {
                        maxSlowo = slownikSlowa[tymczasoweSlowo];
                        maxKey = tymczasoweSlowo;
                    }
                    tymczasoweSlowo = "";
                }
                else
                {
                    tymczasoweSlowo += content[i];
                }

            }

            Console.WriteLine("Najwięcej powtórzeń " + maxSlowo + " odnotowało słowo " + maxKey);




        }



    }

    class Konwersja
    {


        public string ZwrocRzymska(int liczbaArabska)
        {
            Dictionary<int, string> rzym = new Dictionary<int, string> {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };

            string rzymska = "";
            if (liczbaArabska >= 1 || liczbaArabska <= 3999)
            {


                while (liczbaArabska > 0)
                {

                    foreach (KeyValuePair<int, string> entry in rzym)
                    {
                        if (liczbaArabska / entry.Key >= 1)
                        {
                            rzymska += entry.Value;
                            liczbaArabska = liczbaArabska - entry.Key;
                            break;
                        }

                    }
                }
            }

            return rzymska;


        }


    }
}
