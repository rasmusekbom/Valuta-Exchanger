using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValutaExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
                //Introduktion
            Console.WriteLine("Välkommen till Rasmus Valutaväxlare.");
            Console.WriteLine();
            Console.WriteLine("Vilken valuta har du? Tillgängliga valutor är: EUR, SEK, USD.");
            Console.WriteLine("Skriv din valuta och klicka på Enter för att fortsätta.");

            string CurrentCurrency = Console.ReadLine();

            Console.WriteLine();

            //Användaren börjar med EUR som valuta.
            if (CurrentCurrency == "EUR")
            {
                Console.WriteLine("Vilket belopp har du i denna valuta?");

                string CurrentEur = Console.ReadLine();
                double CurrentEur1 = double.Parse(CurrentEur);
                double EuroToSek = 9.48 * CurrentEur1;
                double EuroToUsd = 1.15 * CurrentEur1;

                Console.WriteLine();

                Console.WriteLine("Vilken valuta vill du växla till? Tillgängliga valutor är: SEK, USD");

                string NewCurrency = Console.ReadLine();
                Console.WriteLine();
                
                //Användaren väljer att växla EUR till SEK.
                if (NewCurrency == "SEK")
                {
                    //Denna rad kallar på listan och methoden för att räkna ut de olika valörerna.
                    List<int> Cash = ToCash(EuroToSek);

                    Console.WriteLine("Då får du tillbaka: " + Math.Round(EuroToSek, 0) + " SEK");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 500kr");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 100kr");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 50kr");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 20kr");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 10kr");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 1kr");
                    Enter();
                }

                //Användaren väljer att växla EUR till USD.
                else if (NewCurrency == "USD")
                {
                    List<int> Cash = ToUsd(EuroToUsd);

                    Console.WriteLine("Då får du tillbaka: " + Math.Round(EuroToUsd, 2) + " USD");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 100usd");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 50usd");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 20usd");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 10usd");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 5usd");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 2usd");
                    Console.WriteLine("Det blir: " + Cash[6] + "st 1usd");
                    Console.WriteLine("Det blir: " + Cash[7] + "st 50cent");
                    Console.WriteLine("Det blir: " + Cash[8] + "st 25cent");
                    Console.WriteLine("Det blir: " + Cash[9] + "st 10cent");
                    Console.WriteLine("Det blir: " + Cash[10] + "st 5cent");
                    Console.WriteLine("Det blir: " + Cash[11] + "st 1cent");
                    Enter();
                }
            }

            //Användaren börjar med SEK som valuta.
            else if (CurrentCurrency == "SEK")
            {
                Console.WriteLine("Vilket belopp har du i denna valuta?");

                string CurrentSek = Console.ReadLine();
                double CurrentSek1 = double.Parse(CurrentSek);
                double SekToEur = CurrentSek1 / 9.48;
                double SekToUsd = CurrentSek1 / 8.08;

                Console.WriteLine();

                Console.WriteLine("Vilken valuta vill du växla till? Tillgängliga valutor är: EUR, USD");

                string NewCurrency1 = Console.ReadLine();
                Console.WriteLine();

                //Användaren väljer att växla SEK till EUR.
                if (NewCurrency1 == "EUR")
                {
                    List<int> Cash = ToEuro(SekToEur);

                    Console.WriteLine("Då får du tillbaka: " + Math.Round(SekToEur, 2) + " EUR");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 500euro");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 200euro");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 100euro");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 50euro");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 20euro");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 10euro");
                    Console.WriteLine("Det blir: " + Cash[6] + "st 5euro");
                    Console.WriteLine("Det blir: " + Cash[7] + "st 2euro");
                    Console.WriteLine("Det blir: " + Cash[8] + "st 1euro");
                    Console.WriteLine("Det blir: " + Cash[9] + "st 50cent");
                    Console.WriteLine("Det blir: " + Cash[10] + "st 20cent");
                    Console.WriteLine("Det blir: " + Cash[11] + "st 10cent");
                    Console.WriteLine("Det blir: " + Cash[12] + "st 5cent");
                    Console.WriteLine("Det blir: " + Cash[13] + "st 2cent");
                    Console.WriteLine("Det blir: " + Cash[14] + "st 1cent");
                        Enter();
                }

                //Användaren väljer att växla SEK till USD.
                else if (NewCurrency1 == "USD")
                {
                    List<int> Cash = ToUsd(SekToUsd);

                    Console.WriteLine("Då får du tillbaka: " + Math.Round(SekToUsd, 2) + " USD");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 100usd");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 50usd");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 20usd");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 10usd");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 5usd");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 2usd");
                    Console.WriteLine("Det blir: " + Cash[6] + "st 1usd");
                    Console.WriteLine("Det blir: " + Cash[7] + "st 50cent");
                    Console.WriteLine("Det blir: " + Cash[8] + "st 25cent");
                    Console.WriteLine("Det blir: " + Cash[9] + "st 10cent");
                    Console.WriteLine("Det blir: " + Cash[10] + "st 5cent");
                    Console.WriteLine("Det blir: " + Cash[11] + "st 1cent");
                        Enter();
                }
        }

            //Användaren börjar med USD som valuta.
            else if (CurrentCurrency == "USD")
            {
                Console.WriteLine("Vilket belopp har du i denna valuta?");

                string CurrentUsd = Console.ReadLine();
                double CurrentUsd1 = double.Parse(CurrentUsd);
                double UsdToEur = CurrentUsd1 * 0.85;
                double UsdToSek = CurrentUsd1 * 8.08;

                Console.WriteLine("Vilken valuta vill du växla till? Tillgängliga valutor är: EUR, SEK");

                string NewCurrency2 = Console.ReadLine();
                Console.WriteLine();

                //Användaren väljer att växla USD till EUR.
                if (NewCurrency2 == "EUR")
                {
                    List<int> Cash = ToEuro(UsdToEur);

                    Console.WriteLine("Då får du tillbaka: " + Math.Round(UsdToEur, 2) + " EUR");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 500euro");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 200euro");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 100euro");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 50euro");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 20euro");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 10euro");
                    Console.WriteLine("Det blir: " + Cash[6] + "st 5euro");
                    Console.WriteLine("Det blir: " + Cash[7] + "st 2euro");
                    Console.WriteLine("Det blir: " + Cash[8] + "st 1euro");
                    Console.WriteLine("Det blir: " + Cash[9] + "st 50cent");
                    Console.WriteLine("Det blir: " + Cash[10] + "st 20cent");
                    Console.WriteLine("Det blir: " + Cash[11] + "st 10cent");
                    Console.WriteLine("Det blir: " + Cash[12] + "st 5cent");
                    Console.WriteLine("Det blir: " + Cash[13] + "st 2cent");
                    Console.WriteLine("Det blir: " + Cash[14] + "st 1cent");
                    Enter();
                }

                //Användaren väljer att växla USD till SEK.
                else if (NewCurrency2 == "SEK")
                {
                    List<int> Cash = ToCash(UsdToSek);
 
                    Console.WriteLine("Då får du tillbaka: " + Math.Round(UsdToSek, 0) + " SEK");
                    Console.WriteLine("Det blir: " + Cash[0] + "st 500kr");
                    Console.WriteLine("Det blir: " + Cash[1] + "st 100kr");
                    Console.WriteLine("Det blir: " + Cash[2] + "st 50kr");
                    Console.WriteLine("Det blir: " + Cash[3] + "st 20kr");
                    Console.WriteLine("Det blir: " + Cash[4] + "st 10kr");
                    Console.WriteLine("Det blir: " + Cash[5] + "st 1kr");
                    Enter();
                }
            }
        }

        //Method för att förminska koden.
        static void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("Klicka på Enter för att avsluta programmet.");
            Console.ReadLine();

        }


        //Method för att räkna ut antal av de olika SEK-valörerna.
        static List<int> ToCash(double ToSek)
        {
            int antal500 = 0;
            int antal100 = 0;
            int antal50 = 0;
            int antal20 = 0;
            int antal10 = 0;
            int antal1 = 0;

            int sek = (int)ToSek;

            while (sek != 0)
            {
                if (sek >= 500)
                {
                    antal500 = sek / 500;
                    sek = sek % 500;
                }

                else if (sek >= 100)
                {
                    antal100 = sek / 100;
                    sek = sek % 100;
                }

                else if (sek >= 50)
                {
                    antal50 = sek / 50;
                    sek = sek % 50;
                }

                else if (sek >= 20)
                {
                    antal20 = sek / 20;
                    sek = sek % 20;
                }

                else if (sek >= 10)
                {
                    antal10 = sek / 10;
                    sek = sek % 10;
                }

                else if (sek >= 1)
                {
                    antal1 = sek / 1;
                    sek = sek % 1;
                }
            }
            List<int> Cash = new List<int>();
            Cash.Add(antal500);
            Cash.Add(antal100);
            Cash.Add(antal50);
            Cash.Add(antal20);
            Cash.Add(antal10);
            Cash.Add(antal1);
            return Cash;
         }

        //Method för att räkna ut antal av de olika EUR-valörerna.
        static List<int> ToEuro(double ToEur)
        {
            int antal500 = 0;
            int antal200 = 0;
            int antal100 = 0;
            int antal50 = 0;
            int antal20 = 0;
            int antal10 = 0;
            int antal5 = 0;
            int antal2 = 0;
            int antal1 = 0;
            int antal50c = 0;
            int antal20c = 0;
            int antal10c = 0;
            int antal5c = 0;
            int antal2c = 0;
            int antal1c = 0;


            ToEur = Math.Round(ToEur, 2);
            int euro = (int)ToEur;
            double centd = (ToEur - euro) * 100;
            centd = Math.Round(centd, 0);
            int cent = (int)centd;

            while (euro != 0)
            {
                if (euro >= 500)
                {
                    antal500 = euro / 500;
                    euro = euro % 500;
                }

                else if (euro >= 200)
                {
                    antal200 = euro;
                }

                else if (euro >= 100)
                {
                    antal100 = euro / 100;
                    euro = euro % 100;
                }

                else if (euro >= 50)
                {
                    antal50 = euro / 50;
                    euro = euro % 50;
                }

                else if (euro >= 20)
                {
                    antal20 = euro / 20;
                    euro = euro % 20;
                }

                else if (euro >= 10)
                {
                    antal10 = euro / 10;
                    euro = euro % 10;
                }

                else if (euro >= 5)
                {
                    antal5 = euro / 5;
                    euro = euro % 5;
                }

                else if (euro >= 2)
                {
                    antal2 = euro / 2;
                    euro = euro % 2;
                }

                else if (euro >= 1)
                {
                    antal1 = euro / 1;
                    euro = euro % 1;
                }

            }

            while (cent != 0)

                if (cent >= 50)
                {
                    antal50c = cent / 50;
                    cent = cent % 50;
                }

                else if (cent >= 20)
                {
                    antal20c = cent / 20;
                    cent = cent % 20;
                }

                else if (cent >= 10)
                {
                    antal10c = cent / 10;
                    cent = cent % 10;
                }

                else if (cent >= 5)
                {
                    antal5c = cent / 5;
                    cent = cent % 5;
                }

                else if (cent >= 2)
                {
                    antal2c = cent / 2;
                    cent = cent % 2;
                }

                else if (cent >= 1)
                {
                    antal1c = cent / 1;
                    cent = cent % 1;
                }
        
            List<int> Cash = new List<int>();
            Cash.Add(antal500);
            Cash.Add(antal200);
            Cash.Add(antal100);
            Cash.Add(antal50);
            Cash.Add(antal20);
            Cash.Add(antal10);
            Cash.Add(antal5);
            Cash.Add(antal1);
            Cash.Add(antal2);
            Cash.Add(antal50c);
            Cash.Add(antal20c);
            Cash.Add(antal10c);
            Cash.Add(antal5c);
            Cash.Add(antal2c);
            Cash.Add(antal1c);
            return Cash;
        }
        //Method för att räkna ut antal av de olika USD-valörerna.
        static List<int> ToUsd(double ToUsd)
        {
            int antal100 = 0;
            int antal50 = 0;
            int antal20 = 0;
            int antal10 = 0;
            int antal5 = 0;
            int antal2 = 0;
            int antal1 = 0;
            int antal50c = 0;
            int antal25c = 0;
            int antal10c = 0;
            int antal5c = 0;
            int antal1c = 0;


            ToUsd = Math.Round(ToUsd, 2);
            int usd = (int)ToUsd;
            double centd = (ToUsd - usd) * 100;
            centd = Math.Round(centd, 0);
            int cent = (int)centd;

            while (usd != 0)
            {
                if (usd >= 100)
                {
                    antal100 = usd / 100;
                    usd = usd % 100;
                }

                else if (usd >= 50)
                {
                    antal50 = usd;
                    usd = usd % 50;
                }

                else if (usd >= 20)
                {
                    antal20 = usd / 20;
                    usd = usd % 20;
                }

                else if (usd >= 10)
                {
                    antal10 = usd / 10;
                    usd = usd % 10;
                }

                else if (usd >= 5)
                {
                    antal5 = usd / 5;
                    usd = usd % 5;
                }

                else if (usd >= 2)
                {
                    antal2 = usd / 2;
                    usd = usd % 2;
                }

                else if (usd >= 1)
                {
                    antal1 = usd / 1;
                    usd = usd % 1;
                }

            }

            while (cent != 0)
            {
                if (cent >= 50)
                {
                    antal50c = cent / 50;
                    cent = cent % 50;
                }

                else if (cent >= 25)
                {
                    antal25c = cent / 25;
                    cent = cent % 25;
                }

                else if (cent >= 10)
                {
                    antal10c = cent / 10;
                    cent = cent % 10;
                }

                else if (cent >= 5)
                {
                    antal5c = cent / 5;
                    cent = cent % 5;
                }

                else if (cent >= 1)
                {
                    antal1c = cent / 1;
                    cent = cent % 1;
                }
            }

            List<int> Cash = new List<int>();
            Cash.Add(antal100);
            Cash.Add(antal50);
            Cash.Add(antal20);
            Cash.Add(antal10);
            Cash.Add(antal5);
            Cash.Add(antal2);
            Cash.Add(antal1);
            Cash.Add(antal50c);
            Cash.Add(antal25c);
            Cash.Add(antal10c);
            Cash.Add(antal5c);
            Cash.Add(antal1c);
            return Cash;
        }
    } 
}

