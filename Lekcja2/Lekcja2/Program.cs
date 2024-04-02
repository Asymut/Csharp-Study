using System;


namespace Lekcja2
{
    internal class Program
    {

        static void Hello()
        {
            Console.WriteLine("Hello Wolrd");
        }

        //Arg opcjonalne muszą występować po wszystkich argumentach w fun(po prawej stronie)!!!
        static void Hello2(string text = "Hello na domyslny sposob", int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        static int Add(int a, int b)
        {
            return a+b;
        }

        // Add_P - funkcja dodawania przeciążona!
        static void Add_P(int a) 
        {
            Console.WriteLine(++a);
        }

        // Przeciążanie nazw funkcji działa dla samej zmiany typu danych
        static void Add_P(double a)
        {
            Console.WriteLine(++a);
        }

        static void Add_P(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Add_P(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        //Funkcja typu param
        // params (parametry) - uniezalezniam fun od ilości podanych argumentów. PO params - typ danych które przyjmuje w formie tablicy
        static void Print(string text, params string[] arg ) 
        {
            for (int i = 0; i < arg.Length; i++)
            {
                // jak zamienic coś z tekstu w zmienna

                //zamieniamy dawnego stringa na nowego
                text = text.Replace("{"+i+"}", arg[i]);

            }
            // Hello World wygenerowany z naszej funkcji typu params
            Console.WriteLine(text);
        }

        static void Main()
        {
            /*
            // TABLICE 
            // wpierw deklarujemy stworzenie tablicy, a po słowie "new" wytwarzamy ją
            int[] array0 = new int[5];
            // array[0] = 1;
            // array[1] = 2;
            // array[2] = 3;
            // array[3] = 4;


              Console.WriteLine(array0[0]);

            Console.WriteLine("Hello, World!");
            
             */
            /*

            // TABLICE WIELOWYMIAROWE - stawiamy przecinek który rozdziela wymiary tej tablicy - tablice mogę miec 3, 4, 5 itd wymiarów
            // int[1WYMIAR,2WYMIAR,3WYMIAR]
            int[,] array2D = new int[2,3]; //Każdy z 2 wymiarów musi posiadac swoje 3 podwymiary (Każdy indeks tablicy ma swoje własne 3 indeksy)
                                           //Może dzialać jak tabela - na każde 2 wiersze przypadaja 3 kolumny
            array2D[0,0] = 1;              // 1 wymiar - wiersze,  2 wymiar - kolumny
            array2D[1, 2] = 9;

            Console.WriteLine(array2D[0,0]);
            Console.WriteLine(array2D[1, 2]);
            Console.WriteLine();
            // Length zlicza wszystkie (pola) możliwe elementy dla wszytskich wymiarów // 2*3 = 6
            Console.WriteLine("Wymiary: "+ array2D.Length);
            // stosujemy metode GetLength - jako argument podajemy wymiar ktory nas interesuje
            Console.WriteLine(array2D.GetLength(0));
            Console.WriteLine(array2D.GetLength(1));

            for (int i=0; i < array2D.GetLength(0); i++) 
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i,j] + " ");
                }
                Console.WriteLine();
            }


            // TAB 3wymiarowa
            Console.WriteLine("Array3D");
            int[,,] array3D = new int[2, 2, 2];

            array3D[1, 1, 1] = 9;
            Console.WriteLine(array3D[1,1,1]);

            //Tab string z konstruktorem
            
            //ABY TO ZADZIAŁAŁO MUSZĘ DEKLAROWANE ELEMENTY WSTAWIĆ W TAKA ILOSC {} ILE jest wymiarów!
            // {1wymiar {2wymiar} }
            string[,] textArray = { {   "Hello", "World" }, {       "Witaj", "Świecie"} };
            //1wymiar. indeks1 indeks2     2wymiar   indeks3 indeks4

            // Hello World
            Console.WriteLine(textArray[0,0] + " " + textArray[0,1]);

            //Witaj Świecie
            Console.WriteLine(textArray[1,0] + " " + textArray[1,1]);

            // Petla dla wymiarow
            foreach (var item in textArray)
            {
                Console.WriteLine(item);
            }

            */
             
            /*
            // TABLICE TABLIC
            //1 wymiar - ale na każdym wymiarze mogą znajdować się inne tablice

            int[][] array = new int[3][]; // na pierwszej pozycji deklaruje ilość podtablic  - ktore jeszcze nie istnieją
            // tworzę każda z zadeklarowanych podtablic tablicy array:
            array[0] = new int[5];
            array[1] = new int[3];
            array[2] = new int[7];

            // Główna różnica pomiedzy 2wym tablicami a tablicami tablic - tablica tablic umożliwia nadanie innej ilości elementów [x] dla każdej swojej podtablicy
            // TABLICA wyszczerbiona - dany wiers ma różna ilość kolumn i konczy sie w roznym miejscu

            //Zmiennna array przechowuje 4 tablice - w tym 3 podtablice 

            array[0][0] = 1;
            array[2][6] = 9;

            Console.WriteLine(array[0][0]);
            Console.WriteLine(array[2][6]);

            Console.WriteLine("\n For: ");


            //Obojetnie ktorego Length udzielimy - i tak zliczamy ilosc elem 1 tablicy 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // var - wciela się w dowolny typ danych var = int[]
            foreach (int[] array2 in array)
            {
                foreach (int item in array2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            */

            // FUNKCJE BEZARGUMENTOWE - poza kodem 
            // dla obiektów są to metody
            //Nowa funkcje tworzymy w danej klasie.

            Hello();

            //ARGUMENTY FUNKCJI

            Hello2("Siemka świecie", 4);

            //ZWRRACANIE WARTOŚĆI Z FUN
            // To co zwracamy i jest po return zawsze musi odpowiadac slowku kluczowemu przed fun (info o zwracanej wartości)
            
            int res = Add(10, 5);

            Console.WriteLine(res);

            // Możemy wywoływać funkcje w ramach argumentu innej funkcji !!!
            Console.WriteLine(Add(10, 5));

            // FUN ARGUMENTY NAZWANE

            Hello2("Witaj", 2);

            // Hello2(2, "Witaj"); - błąd argumenty podane na odwrót niż zadeklarowane

            // argumenty nazwane - zmiana kolejności wywolania zadeklarowanych arg fun
            Hello2(times: 3, text: "Witaj Kolego");


            // WARTOŚCI DOMYŚLNE DLA ARG

            // W sygnaturze funkcji dla argu ktory ma miec wartosc domyslna przypisuje mu '=' wartosc domyslna.
            // ilosc po tekscie jest brana z sygnatury funkji i równa sie 1
            //argument opcjonalny - możemy go podać ale nie musimy bo ma on domyslna wartosc
            Hello2(times: 3, text: "Hello na 1 sposob");

            Hello2("Hello na 2 sposob");

            Hello2(); // moge wywolac bez arg bo sa one zadeklarowane wartoscia domyslna w sygnaturze

            // Przeciązenie funkcji - jako argument mogę podać różne przeciążenia - różne typy danych/różne opcje domyślne
            // Wartość domyślna to nie jest jeszcze przeciążenie

            // PRZECIĄŻANIE NAZW FUNKCJI
            // Zachodzi kiedy chcemy zachować jedną nazwę funkcji (jedną funkcję) ale dać jej mnogość,kilka róznych zachowań(działań)
            // Funkcja robi coś, ale wraz z podaniem innych argumentów - robi coś innego!
            //Funkcja z przeciążeniami - dla róznych typów i ilości argumentów ma różne działanie:
            Add_P(6);
            Add_P(6, 4);
            Add_P(6, 4, 100);

            // PARAMS - funkcja dostosowuje sie do ilosci argumentow jakimi przeciaza ją użytkownik

            Console.WriteLine("{0} {1} {2}", "Hello", "World", "!!!");
            // dwa argumenty - tak aby nie tworzyc nieskończonej ilości przeciążeń 
            // params to zbiór wartości który możemy stawiać po przecinku bez końca i możemy dzięki niemu podać dowolną ilość arg do fun a słówko params przyjmnie je do tablicy

            // Własna fun typu params
            Print("{0}-{1}-{2}", "Hello", "World", "!!!");
            

        }

    }
}


