using System; // dodaje do projektu biblioteke System (Używamy stworzonej przez kogos przestrzeni nazw System)

namespace Lekcja1 // Utworzona przestrzeń nazw (przez nas)
{
    internal class Program // klasa o nazwie Program
    {
        static void Main(string[] args) // funkcja statyczna o nazwie Main ()
        {
            /*
                /*
                    Console.WriteLine("Jak masz na imię?");
                    string name;
                    name = Console.ReadLine();
                    Console.WriteLine($"Hello {name}!");

                    //ZMIENNA
                    string zmienna = "Hello";
                    string zmienna2 = " World";

                    string a ="!!", b = ".", c;

                    Console.WriteLine(zmienna + zmienna2 + a + b);
                */
            //STAŁE
            /*
                const string LANGUAGE = "C#"; // const - stała (zmienna ktorej nie mozna zmienic zadeklarowanej wartosci)

                Console.WriteLine(Math.PI);

                //LICZBY CAŁKOWITE
                byte varByte = 8;
                Console.WriteLine($"Byte min: {byte.MinValue}, max: {byte.MaxValue}");

                short varShort = 3000;
                Console.WriteLine($"Short min: {short.MinValue}, max: {short.MaxValue}");

                int varInt = 300000;
                Console.WriteLine($"Int min: {int.MinValue}, max: {int.MaxValue}");

                long varLong = 100000000;
                Console.WriteLine($"Long min: {long.MinValue}, max: {long.MaxValue}");

                // Przeznaczanie ujemnęgo zakresu typu danych na rzecz dodatniego (zm na same dodatnie wartości)
                // W tym celu przed deklaracja zmiennej dodaje "u" np: uint, ulong, 

                Console.WriteLine();
                uint varUint = 543;
                Console.WriteLine($"Uint min: {uint.MinValue}, max:  {uint.MaxValue}");

                // Jesli chcemy byte ktory moze byc znakowany musimy dodac do niego "s"na poczatek

                Console.WriteLine();
                Console.WriteLine($"SByte min: {sbyte.MinValue}, max: {sbyte.MaxValue}");
                Console.WriteLine();

                //LICZBY ZMIENNOPRZECINKOWE

                float varFloat = 3.14f; // Na końcu floata musimy dodać sufiks "f" lub "F" - kompilator wie ze to float
                //przecinek moze sie przemieszczac tworzac rozna czesc po calosci i po przecinku
                Console.WriteLine(varFloat);
                Console.WriteLine($"Float min: {float.MinValue}, max: {float.MaxValue}");


                double varDouble = 456.766d; // sufiks litery d wskazuje na typ double // double jest domyslne - sufiks d jest dodatkowo
                Console.WriteLine($"Double min: {double.MinValue}, max: {double.MaxValue}");

                // arg 0 (":N20 - oznacza wypisz do 20 miejsc po przecinku (wyznacz zakres)") - pojawiaja sie nieporzadane smieciowe wartosci BŁĄD
                Console.WriteLine("{0:N20}", 0.1f); // BŁĄD PO PRZECINKU


                // typ decimal powstał w celu wyeliminowania bledu przy okresleniu wiekszej ilosci miejsc po przecinku (blad u góry)
                // Prefiks dla typu decimal = "m"
                decimal varDecimal = 5.5m;

                Console.WriteLine("{0:N20}", 0.1m); // TERAZ DZIAŁA


                // TYP ZNAKOWY

                // char - jeden znak - umieszczamy jeden znak w apostrofy - moga byc litery, cyfry lub znaki specjalne np - '\n' 
                char varChar = 'A';

                Console.WriteLine(varChar);
                //Rzutowanie char (znaku) na typ int liczbę
                //Wyświetli się kod ASCII dla podanego znaku!!
                Console.WriteLine((int)varChar);

                // ciag znakow string - kazda litera (kazdy ZNAK) jest interpretowany osobno i wedlug kolei
                string varString0 = "\nJakiś Tekst";
                string varString1 = "\nJakiś tekst".ToUpper();
                string varString2 = "\nJakiś tekst".ToLower();


                Console.WriteLine(varString0 + "\"" + varString1 + "\"" + varString2 + "\"");


                // Każdy typ danych może byc reprezentowany w postaci string (pisemnej) przy pomocy metody ToString();
                int a = 3;
                Console.WriteLine(a.ToString());


                //TYP LOGICZNY

                //bool - typ logiczny operuje na rozumowaniu komputera (1 albo 0) JEST/NIE MA (prawda=1 / fałsz=0)

                bool varBool = true; //1
                Console.WriteLine(varBool);
                Console.WriteLine();


                // Var - konwencja typów danych (nie typ) - niejawne deklarowanie zmiennych, tak aby domyśliły się jakiego typu mają być 


                var x = 2; // nowa dynamiczna zmienna (sam domyśla się jaki typ danych)

                Console.WriteLine(x.GetType());

                var y = "Tekst";
                Console.WriteLine(y.GetType());

                // RZUTOWANIE

                int varInt2 = 200000;

                // rzutowanie niejawne  (bez podania zmiennej w nawiasie)
                long varLong2;
                // (long) - opcjonalnie
                varLong2 = (long)varInt2;
                Console.WriteLine(varLong2);

                //rzutowanie jawne
                  // Nie mogę przypisać do mniejszego typu daną z większego typu ALE jeśli chcemy mogę zrobić to jawnie i zadeklarować
                short varShort2;
                varShort2 = (short)varInt2;
                Console.WriteLine(varShort2);
                // int był zbyt duży i zaszło przekręcenie licznika - short jest za mały by to przyjąć!

                // Rzut ze zmiennoprzecinkowej na całkowita - zapiszę się tylko część całkowita.
                float varFloat2 = 5.99f;
                varLong2 = (long)varFloat2;
                Console.WriteLine(varLong2);



                // PARSOWANIE (KONWERSJA)

                string tekst = Console.ReadLine();
                int variableInt;

                //Nasz typ danych staje się klasą osłonową (pomocniczą)
                // Parsowanie - Użycie metody z typu danych na który chcemy wartość przekształcić. Typ_na_który_zmieniamy.Parse(argument)

                // zmienia tekst = "200" na int = 200


                // variableInt = int.Parse(tekst);
                // Console.WriteLine(variableInt);


                // dodatkowa funkcja replace ktora zamieni . na , w zmiennej tekst
                float variableFloat;

                //dodatkowa metod TryParse - proba parsowania (jednej zmiennej, na druga) - zwraca bool (udany = 1)
                //Te "OUT" określa że Parsowanie na floata może się nie udać.

                bool success = float.TryParse(tekst, out variableFloat);
                Console.WriteLine($"{success}, {variableFloat}");



            tekst = variableFloat.ToString(); // każdy obiekt ma swoją reprezentacje tekstową

                Console.WriteLine(tekst);
                Console.WriteLine(tekst);
                Console.WriteLine(tekst);
            */
            /*
                // OPERATORY ARYTMETYCZNE
                Console.WriteLine("Podaj X:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Y:");
                int y = int.Parse(Console.ReadLine());

                // int wynik = x + y;


                //możemy w klamrach użyć operatorów arytmetycznych na zmiennych

                //DZIAŁANIA
                Console.WriteLine($"{x} + {y} = {x + y}");

                Console.WriteLine($"{x} - {y} = {x - y}");

                Console.WriteLine($"{x} * {y} = {x * y}");

                // Aby wynik dzielenia był dokladny możemy przerzutować go na wartosc zmiennoprzecinkowa

                Console.WriteLine($"{x} / {y} = {(float)x / (float)y}");

                // operator reszty z dzielenia  (modulo z liczby)
                Console.WriteLine($"{x} % {y} = {x % y}");

                Console.WriteLine("---------------");
                Console.WriteLine(x + x * x);
                // POTĘGOWANIE (metoda Pow(x, y) - od power)
                Console.WriteLine(Math.Pow(x, y));
                //PIERWIASTEK (2 stopnia)
                Console.WriteLine(Math.Sqrt(x));


                //Skrócone operatory arytm

                Console.WriteLine("---------------");

                int z = 5;
                // z = z + 10; - ZASADA DRY
                //powiększ zmienna z o 10 (dodaj do tego co było wartość 10)
                z += 10; // 15
                z -= 3;  // 12
                z *= 2;  // 24
                z /= 6;  // 4
                z %= 3;  // 1
                Console.WriteLine(z);

                Console.WriteLine("---------------");

                // INKRE I DEKRE

                int intA = 5;
                // a += 1;
                intA++;
                Console.WriteLine(intA);

                // a -= 1;
                intA--;
                Console.WriteLine(intA);
                // zwiekszam intA - jednak wypisze sie jego stara wartosc - wpierw wypisanie // POSTINKREMENTACJA
                Console.WriteLine(intA++);
                // wypisze sie już zwiększona wartość
                Console.WriteLine(intA);


                // OPERATORY PORÓWNANIA

                Console.WriteLine("Podaj C:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj D:");
                int d = int.Parse(Console.ReadLine());

                //SPRAWDŹ RÓWNOŚĆ

                bool wynik3 = c == d;

                //równość
                Console.WriteLine($" {c} == {d} = {c == d}");

                //różność
                Console.WriteLine($" {c} != {d} = {c != d}");

                //większe
                Console.WriteLine($" {c} > {d} = {c > d}");

                //mniejsze
                Console.WriteLine($" {c} < {d} = {c < d}");

                //wieksze lub rowne
                Console.WriteLine($" {c} >= {d} = {c >= d}");

                //mniejsze lub rowne
                Console.WriteLine($" {c} <= {d} = {c <= d}");



                // OPERATORY LOGICZNE - działają na argumentach typu bool

               bool wyn = 5 > 2 || 2 == 1; //OR 
                Console.WriteLine(wyn);

                wyn = true && false; //AND
                Console.WriteLine(wyn);

                wyn = !true; //negacja
                Console.WriteLine(wyn);

                // kolejnosc OPERATOROW LOGICZNYCH!!! 
                Console.WriteLine(true || true && false);
                //Moge zmienic nawiasami
                Console.WriteLine((true || true) && false);
        */

            // Instrukcje warunkowe 
            /*     
                     Console.WriteLine("Ile masz lat?");
                     int wiek = int.Parse(Console.ReadLine());

                     if (wiek >= 18)
                     {
                         Console.WriteLine("Zapraszamy");
                         if(wiek > 50)
                         {
                             Console.WriteLine("Masz więcej niż 50 lat!");
                         }
                     }
                     else
                     {
                         Console.WriteLine("Nie masz 18 lat!");
                     }

             */

            // ELSE IF
            /*
                    Console.WriteLine("Podaj liczbę: ");
                 int num = int.Parse(Console.ReadLine());


                 if (num > 0)
                 {
                     Console.WriteLine("Liczba jest większa od 0");
                 }
                 else if (num < 0)
                 {
                     Console.WriteLine("Liczba jest mniejsza od zera");
                 }
                 else
                 {
                     Console.WriteLine("Liczba jest równa 0");
                 }
             */

            // skrócone wyrażenie warunkowe

            /*
            Console.WriteLine("Podaj liczbę");
            int a1 = int.Parse(Console.ReadLine());


            //operator trójargumentowy - jeżeli warunek to prawda to zwróc to co napotkasz po prawej stronie "?". Zwróć to co po prawej stronie ":" jeśli warunek to był fałsz. 3 argumetny i 2 znaki specjalne (warunke ? ... : ...)
            // if {} else {}

           string wynik =  a1 % 2 == 0 ? "Parzysta" : "Nieparzysta";

            Console.WriteLine(wynik);

             */
            /*
            // SWITCH

            Console.WriteLine("Podaj dzień tygodnia: ");
            int intA = int.Parse(Console.ReadLine());

            //przełącznik (argument ktory decyduje) // ciało przypadku od : dp break
            switch (intA) 
            {
                case 1:  //==
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:  //==
                    Console.WriteLine("Wtorek");
                    break ;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia!");
                    break;

            }

              */
            /*

                // PĘTLE 



                Console.WriteLine("Podaj liczbę: ");
                int a = int.Parse(Console.ReadLine());

                //zmienna pomocnicza
                int i = 1; //j k l 

                //while
                Console.WriteLine("While: ");
                while (i <= a) //wykonuj ciało/coś dopóki - doóki to w nawiasach jest prawdziwe.
                {
                    Console.WriteLine(i);
                    i++;
                    // aby wymusic koniec petli uzywamy - break;
                }

                //while do while
                //Piszemy ją tak jak mówimy
                Console.WriteLine("Do While:");
                i = 1;

                do
                {
                    Console.WriteLine(i);
                    i++;
                }while (i <= a);

                */
            /*
            // PĘTLA FOR

            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
       
                // najbardziej kompleksowy warunek - 3 elem for( deklaracja zmiennej pomocniczej; warunek; co się ma wydarzyć po każdej iteracji)
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }

            */
            /*

            // PĘTLA FOR EACH - pętla obiektowa - musi spełniać warunki wstępne 

            Console.WriteLine("Podaj tekst: ");
            string text = Console.ReadLine();

            // var - ogólny typ danych, in - rozdziela pojedyncza zmienna od kolekcji 

            foreach (char c in text)
            {
                Console.WriteLine(c);
            }

            // pętla foreach działa tylk na kolekcjach - rozbier ona kolekcje na pojedyńcze elementy i te elementy inicjuję jako tymczasowe zmienne i z każdą tą zmienną przechodzi przez swoje ciało

             */

            // SŁOWA SKOKU

            // break, continue


            /* 
             * 
            for (int i = 0; ; i++)
            {
                if (i > 20)
                {
                    break; // break automatycznie zakańcza wykonywanie się pętli
                }
                if (i % 2 == 1)
                {
                    continue; // przejdź do kolejnego obiegu pętli, nie ważne co jest dalej
                }
                Console.WriteLine(i);
            }

            // GO TO

            //etykieta hello (nazwa i ":")
            int j = 1;
        hello:
            Console.WriteLine("Hello World!");
            j++;
            // udaj się do etykiety hello w programie
            if (j < 10)
                goto hello;

            */
                // TABLICE 
                // wpierw deklarujemy stworzenie tablicy, a po słowie "new" wytwarzamy ją

                int[] array = new int[5];
                 array[0] = 1;
                 array[1] = 2;
                 array[2] = 3;
                 array[3] = 4;

            Console.WriteLine("Length: {0}", array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            // Drugi sposób deklaracji tablicy - zadanie wartości
            //ta tablica jest kolekcją
            char[] array2 = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char item in array2)
            {
                Console.WriteLine(item);
            }



        }

    }
}