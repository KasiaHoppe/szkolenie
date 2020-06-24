using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\a9wkxzz\OneDrive - 3M\Desktop\text.txt"; // tu podaj ścieżkę do pliku
            string content = File.ReadAllText(path, Encoding.UTF8);
            content = content.ToLower();
            content = Regex.Replace(content, "[^a-z ]", String.Empty);
            content = content + " ";
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
}
