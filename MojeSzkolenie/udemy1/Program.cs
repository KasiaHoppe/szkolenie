using System;

namespace udemy1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            Console.WriteLine("Wynik to: {0}", a + b);

            //Console.WriteLine("Hello World!");

            // int a;
            //a = 5;
            /*
             
            int b = 10;
            sbyte liczba = 125;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Liczba jest równa: " + liczba);
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "/" + b + "=" + (a / (double)b)); //rzutowanie
            Console.WriteLine("modulo a/b " + (a % b));//modulo

            a += 3; // a = a + 3
            Console.WriteLine(a);*/

            /* int zm1 = 5, zm2 = 10;
             Console.WriteLine(zm1 == zm2); //zwraca prawdę tylko jeśli elementy są sobie równe*/

            //Console.WriteLine((5 > 4) && (3 < 2));

            //postinkrementacja
            /*Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(a);*/

            //preinkrementacja
            /*Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.WriteLine(a);*/

            //postdekrementacja
            /*Console.WriteLine(a--);
            Console.WriteLine(a);
            Console.WriteLine(a);*/

            //predekrementacja
            /*Console.WriteLine(--a);
            Console.WriteLine(a);
            Console.WriteLine(a);*/

            //Console.ReadLine();

            /*TYPY ZMIENNYCH
             * 1. LICZBY CAŁKOWITE
            sbyte (signedbyte) od -128 do 127, zapisywane na 8 bitach (1 bajcie)
            short od -32.768 do 32.767, zapisywane na 16 bitach (2 bajty)
            int od ~ -2mld do 2mld, zapisywane na 32 bit (4 bajty)
            long od - 2^63 do 2^63-1, zapisywane na 64 bitach (8 bajtów)

            byte od 0 do 255, zapisywane na 8 bitach
            ushort (u - unsigned) od 0 do 65.535
            uint od 0 do 2^32-1
            ulong od 0 do 2^64-1

            2. LICZBY ZMIENNOPRZECINKOWE - FLOATING-POINT TYPES

            float - może mieć 7 znaków po przecinku, 1.5 * 10 ^ -45 do 3.4 * 10 ^ 38, 32 bity
            double - może mieć 15-16 miejsc po przecinku  5 * 10^-28 do 1.7 * 10^308
            decimal - przy dużej precyzji 28 znaków po przecinku od 1 * 10^-28 do 7.9 * 10^28, 128 bitów
            bool - true or false


            3. TYPY ZNAKOWE
            char - znaki zapisujemy, np. znak = 'a'
            string - zapisujemy slowo = "imię"


            ZASADY NAZEWNICTWA"
            - nie można zacząć nazwy zmiennej od cyfry
            - nie można dawać spacji w nazwach zmiennych jak coś ma być razem
            - nie korzystamy ze znaków specjalnych, np. ?
            - nie korzystamy z zarezerwowanych słów
            - mogę być polskie znaki, ale lepiej z tego nie korzystać
            - liczy się wielkość liter
            - zmienne powinny by,ć self-descripting (powinno się opisywać tak żeby było wiadomo co opisuje ta zmienna

            */

            /* 4.1. INSTRUKCJE WARUNKOWE IF, ELSE IF, ELSE I INSTRUKCJE ZAGNIEŻDŻONE
            int a = 10, b = 5;
            if (a < b)
            {
                Console.WriteLine("a < b");
                Console.WriteLine("wygrałeś")
            }
            else if (a > b)
                Console.WriteLine("a > b")
            else
            {
                Console.WriteLine("a == b")
            }

            if (((5 > 7) && (7 > 4)) || (10 == 10))
                Console.WriteLine("prawda");*/

            /*
             * if (warunek)
             * instrukcja;
             * 
             * if (warunek)
             * instrukcja;
             * else if (warunek2)
             * instrukcja2;
             * ....
             * else
             * instrukcja3;
             * 
             * 
             * ZAGNIEŻDŻONE
             * 
             * 
             * */
            /*if (a == b)
           {
               Console.WriteLine("a równe b");
               a += 10;
               if (a > b)
                   Console.WriteLine("a zostało zmienione i jest teraz większe od b");
               else if (a < b)
                   Console.WriteLine("a zostało zmienione i jest teraz mniejsze niż b");
               else
                   Console.WriteLine("a nadal równe b");
           }
           */

            //4.2. INSTRUKCJA WARUNKOWA SWITCH

            /*string nazwaKraju = "UK";

            switch (nazwaKraju)
            {
                case "PL":
                    Console.WriteLine("Jesteś z Polski");
                    break;
                case "EN":
                case "UK":
                    Console.WriteLine("You speak english");
                    break;
                default:
                    Console.WriteLine("Nie wiem skąd jesteś");
                    break;
            }*/

            /*Wersja z goto
             * 
             * switch (nazwaKraju)
            {
                case "PL":
                    Console.WriteLine("Jesteś z Polski");
                    break;
                case "EN":
                    Console.WriteLine("You speak english");
                    break;
                case "UK":
                    Console.WriteLine("You speak english");
                    goto case "EN";
                default:
                    Console.WriteLine("Nie wiem skąd jesteś");
                    break;
            }*/


            // 4.3. OPERATOR WARUNKOWY
            //int a = 20;
            //int b = 10;

            // (WARUNEK) ? gdy warunek spełniony (true) : gdy niespełniony (flase);

            //string tekst = (a > b) ? "a jest większe od b" : "a jest mniejsze od b";

            //Console.WriteLine(tekst);


            // 5.1. PĘTLE, PĘTLA FOR

            /*
             * for ( inicjalizacja zmiennej; warunkowanie; krok)
             * instrukcje - powtarzane dopóki jest spełniony warunek
             * 
             * */

            // for (int i = 0; i < 3; i++)
            //   Console.WriteLine(i);

            // to samo, ale w pierwszym zmienn i służy tylko do pętli a w drugim w całym kodzie

            //int i = 0;

            //for ( ; i < 3; i++)
            //  Console.WriteLine(i);)

            //for (; ; i++)
            //  Console.WriteLine(i);

            // warunku nie można pominąć, bo będzie się wykonywał w nieskończoność

            //for (int i = 0; i < 3;)
            //{
            //  Console.WriteLine(i);
            //i++;
            //}

            // for (int i = 0; i < 3;)
            //{
            //  Console.WriteLine(++i);

            //} zaczyna wypisywać od 1 zamiast od 0


            // 5.2. PĘTLA WHILE ORAZ DO WHILE

            /* int i = 0;

             while (i < 3)
             {
                 Console.WriteLine(i);
                 i++;
             }
             */

            /*do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 3);
            */
            // wykonuje najpierw a później sprawdza warunek


            // 5.3. PĘTLE ZGNIEŻDŻONE

            //for (int i = 0; i < 4; i++)
            //  for (int j = 0; j < 2; j++)
            //    Console.WriteLine(j);
            /*
             * 1 2 3 4 5 6 7 8 9 10
             * 2 4 6 8 10 12 14 16 18 20
             * 3 6 9 12 15 18 21 24 27 30
             * 
             */
            // JAK ZROBIĆ TABLICZKĘ MNOŻENIA

            /*for (int i = 1; i <= 10; i++) // ILOŚĆ WIERSZY, DŁUGOŚĆ KOLUMN
            {
                for (int j = 1; j <= 10; j++) // ILOŚĆ KOLUMN, DŁUGOŚĆ WIERSZA
                    Console.Write(i * j + " ");

                Console.WriteLine();
            }*/


            // 5.4. INSTRUKCJA BREAK I CONTINUE

            /*for (int i = 1; i <= 10; i++) // ILOŚĆ WIERSZY, DŁUGOŚĆ KOLUMN
             {
                if (i == 3)
                    continue; //to co jest po continue nie jest wykonywanie, ale pętla mimo wszystko jest wykonywana

                if (i == 3)
                    break; // to co jest po break nie jest wykonywane i wychodzimy z najbliższej pętlipętli

                for (int j = 1; j <= 10; j++) // ILOŚĆ KOLUMN, DŁUGOŚĆ WIERSZA
                   Console.Write(i * j + " ");

               Console.WriteLine();
            }*/

            /*for (int i = 1, j = 1; i <= 10; i++)
            {
                Console.Write(i * j + " ");

                if (i == 10)
                {
                    i = 0;
                    j++;
                    Console.WriteLine();
                }

                if (j == 10 + 1)
                    break;
            }
            */

            // 6.1. TABLICE JEDNOWYMIAROWE

            // TABLICA - struktura danych składająca sie z ułożonych kolejno zmiennych

            /*
             *  int[] tab;
             * 
             * tab = new int[4];
             * 
             * |.......|.......|.......|.......|
             *  tab[0]   tab[1]  tab[2]  tab[3]
             * |.......|.......|.......|.......|
             * 
             * tab[0] = 5;
             * tab[1] = 7;
             * tab[2] =4;
             * tab[3] = 10;
             * 
             * Console.WriteLine(tab[1]);
             */

            /*int[] tab;

            tab = new int[4];

            tab[0] = 5;
            tab[1] = 7;
            tab[2] = 4;
            tab[3] = 10;

            for (int i = 0; i < tab.Length; i++) // żeby samo pobierało długość tablicy jeśli zmienmy ilość elemetów 
                Console.WriteLine(tab[i]);

            int[] cos = new int[4];

            for (int i = 0; i < cos.Length; i++)
            {
                cos[i] = i + 1;
                Console.WriteLine(cos[i]);
            }

            int[] ciag new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] ciag2 = { 1, 2, 3, 4, 5, 6 };
            */

            // 6.2. PĘTLA FOREACH, ZMIENNA TYPU VAR



            // 7.1.  WPROWADZENIE DO OBIEKTOW

            /*
            //deklaracja
            Czlowiek x;
            // inicjalizacja
            x = new Czlowiek();
            Czlowiek y = new Czlowiek();

            x.setName("Katarzyna");
            y.setName("Asia");
            Console.WriteLine(x.getName());
            Console.WriteLine(y.getName());

            */


            // 7.2. KONSTRUKTORY, METODY

            Gracz gracz = new Gracz();

            //if (gracz.id == null)
            //Console.WriteLine("Nie ma id");


            Console.ReadLine();




        }
    }
}

// instancją klasy jest obiekt - u nas x to obiekt klasy

class Czlowiek
{
    //string Name = "Kasia"; // zmienna jest cechą człowieka

    string name;

    /*
     * [modyfikator - opcjonalnie] TYP_ZWRACANY NAZWA_FUNKCJI (TYP_ZMIENNEJ PARAMETR1, TYP_ZMIENNEJ PARAMETR2)
     * {
     *  // instrukcje
     *  return
     * 
     *  */
     public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }
}

class Gracz
{
    public Gracz(string nick)
        {
        this.nick = nick;
    }
    public string nick;
    public int id;

}