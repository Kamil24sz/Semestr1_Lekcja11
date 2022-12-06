using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PĘTLA DO WHILE   =>  różni się od while że wykona się przynajmniej raz niezależnie od wyniku wyrażenia logicznego
            //int liczba = 0;
            //do {
            //    Console.WriteLine("To się wypisuje " + liczba);
            //    liczba++;
            //}
            //while (liczba < 10);

            //TABLICE

            double zawodnik1 = 36.11;
            double zawodnik2 = 37.00;
            double zawodnik3 = 40.00;

            //deklaracja tablicy
            double[] zawodnicy = new double[] {35.1, 32.2, 21.3, zawodnik1, zawodnik2, zawodnik3};

            //skrócona deklaracja tablicy
            double[] zawodnicy2 = { 12.1, 24.0, 36.0 };

            //Sposób odczytania danych z tablicy
            Console.WriteLine(zawodnicy[0]);

            //Wypisywanie wszystkich wyników zawodników za pomocą pętli for
            for(int x = 0; x < zawodnicy.Length; x++)
            {
                Console.WriteLine(zawodnicy[x]);
            }

            //Ćwiczenie 1
            Console.WriteLine("Ćwieczenie 1");
            //Tworzymy tablice, która będzie przechowywać tytuły gier
            string[] bilbliotekaGier = { "Fortnite", "Minecraft", "Fifa 22", "Wiedźmin 2", "Wiedźmin 3", "Red Redemption 2", "GTA V" };
            Console.WriteLine("Oto moja biblioteka gier: ");
            Console.WriteLine(bilbliotekaGier[0]);
            Console.WriteLine(bilbliotekaGier[1]);
            Console.WriteLine(bilbliotekaGier[2]);
            Console.WriteLine(bilbliotekaGier[3]);
            Console.WriteLine(bilbliotekaGier[4]);
            Console.WriteLine(bilbliotekaGier[5]);
            Console.WriteLine(bilbliotekaGier[6]);
            Console.WriteLine();
            Console.WriteLine("W co chciałbyś zagrać? (1-7)");
            int wybór = int.Parse(Console.ReadLine());
            Console.WriteLine("Wybrałeś "+wybór+" czyli "+bilbliotekaGier[wybór - 1]);

            Console.WriteLine();
            //Ćwiczenie 2
            Console.WriteLine("Ćwiczenie 2");
            //Tworzymy tablicę liczb całkowitych (int), oraz program
            //który będzie znajdował największą z liczb w środku tablicy

            //deklaracja tablicy
            int[] liczby = {20, 42, 123, 24, 654, 23, 214, 5432, 2, 53, 2};

            //zmienna pomocnicza
            int aktualnieNajwieksza = liczby[0];
            int aktualnieNajmniejsza = liczby[0];

            for(int i = 0; i < liczby.Length; i++)
            {
                if(aktualnieNajwieksza < liczby[i])
                {
                    aktualnieNajwieksza = liczby[i];
                }

                if (aktualnieNajmniejsza > liczby[i])
                {
                    aktualnieNajmniejsza = liczby[i];
                }
            }
            Console.WriteLine("Największa liczba z tablicy to " + aktualnieNajwieksza);
            Console.WriteLine("Najmniejsza liczba z tablicy to " + aktualnieNajmniejsza);

            Console.WriteLine();
            Console.WriteLine("Konstrukcja foreach");
            //Konstrukcja foreach
            string[] zakupy = {"mleko", "masło", "ser", "pomidory"};

            foreach(string produkt in zakupy)
            {
                Console.WriteLine(produkt);
            }



            Console.ReadLine();

        }
    }
}
