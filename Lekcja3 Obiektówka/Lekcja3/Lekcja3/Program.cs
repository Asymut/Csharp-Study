//Jezyk C# jest zorientowany obiektowo - odwzorowywanie rzeczywistości na obiektach
//Klasa - ogólny zbiór obiektów np. meble (klasa to przepis na tworzenie obiektów)
//Obiekt - konkretna wystapienie, reprezentacja klasy, pojedynczy element np. krzeslo
//Klasy zawierają zmienne i metody

using System;

namespace Lekcja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.Count();

            // tworzenie obietku - tworzymy typ danych typu Person (klasa) 
            // Klasa(typ danych) nazwa = new Person();

            Person p1 = new Person("Adrian", 20);

            Person.Count();

            // wywolanie zmiennych i metody po nazwie obiektu p1 (zestaw zmiennych i metod dla tego obiektu)

            // przypisanie zmiennych do obiektu p1

            //uzycie metody do ustawienia prywatnego pola name
            p1.setName("Adam");


            //uzycie atrybuty set do ustawienia prywatnego pola name
            p1.Name = "Arnold";
            p1.Name = "-"; // nie zadziala - dzieki logice biznesowej i walidacji w set
            Console.WriteLine(p1.Name);

            // dostep do wlasciwosci Age 
            p1.Age = 21;
            p1.Age = -23; // nie da sie przypisac gdyz atrybut set nie ustawil ujemnego wieku - zabezpieczenie.
            Console.WriteLine(p1.Age);

            //uzycie metody do wyswietlenia  prywatnego pola imie
            Console.WriteLine(p1.getName());



            // Nowa wlasciowsc uproszczona 
            p1.Country = "Polska";
            Console.WriteLine(p1.Country);











            // konstuktor wypełnia obiekty danymi - te 2 linie sa zbędne.

            // wywołanie klasy dla obiektu p1
            p1.Hello();

            //Tworzymy drugi obiekt

            Person p2 = new Person("Ania", 24);


            Person.Count();
          


            p2.Hello();
          

            Console.WriteLine();

            Turtle t1 = new Turtle("chinski", "Kyle", 77, "czerwony");
            t1.Age = 66;
            
            t1.Hello();


            Turtle t2 = new Turtle("ladowy", "Mariusz", 30, "niebieski");
            t2.Name = "Marek";
            
            t2.Hello();


            Turtle t3 = new Turtle("grecki", "Bąbel", 15, "piaskowy");
            t3.Hello();

            Turtle t4 = new Turtle("morski", "Aleksandra", 92, "różowy");
            t4.Hello();



            //readonly

            Test test = new Test(2);
            Test test2 = new Test(10);

            //test.varReadonly = 2;

            //Test.varConst = 2;

            Console.WriteLine();

            Console.WriteLine("stała: " + Test.varConst);
            Console.WriteLine("readonly1: "+ test.varReadonly);
            Console.WriteLine("readonly2: "+ test2.varReadonly);







            //Indeksery:

            string tekst1 = "Witaj świecie!";

            // string - tak jakby tablica, wiec mozemy sie odwolac do jej jakiegos indeksu
            Console.WriteLine(tekst1[1]);


            Tekst tekst = new Tekst("hello");

            Console.WriteLine();
            tekst[0] = 'H'; // ZMIENI z "h" na "H"
            Console.Write(tekst["jeden"]);
            Console.Write(tekst[1]);
            Console.Write(tekst[2]);
            Console.Write(tekst[3]);
            Console.WriteLine(tekst["ostatni_dsf"]);
            // wypisze Hello - bez zmian, gdyz skorzysta   z przeciazonych indeksatorow


            //Przeciazanie operatorow
            Punkt2D pkt1 = new Punkt2D(2, 5);
            pkt1.Show();
            Punkt2D pkt2 = new Punkt2D(5, 7);
            pkt2.Show();

            // Dodanie dwoch obiektow klasy Punkt2D
            Punkt2D pkt3 = pkt1 + pkt2;
            pkt3.Show();

            Punkt2D pkt4 = pkt1 + 10;
            pkt4.Show();


        }

    }


    class Test 
    {
        // stala
        public const int varConst = 1;

        // zmienna tylko do odczytu
        public readonly int varReadonly = 1;

        void Change() 
        {
           // varConst = 2; - blad
           //  varReadonly = 2; - blad
        }

        //konstruktor
        public Test(int n)
        {
            //varConst = n; - blad
            varReadonly = n;
        }

        //konstruktor statyczny
        
        static Test() 
        { 
           //varConst = n; - blad
           // varReadonly = n; - musiałaby zmienna byc statyczna
        }
    
    }



    // odwzorowujemy typ string w naszej klasie
    class Tekst 
    {
        public Tekst(string txt) 
        {
            tekst = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                tekst[i] = txt[i];
            }
        }

        private char[] tekst;


        // tworzymy indekser - taka ala wlasciwosc - tyczy sie całej klasy
           public char this[int n]
            {
               get 
                { 
                    return tekst[n]; 
                }

               set 
                { 
                    tekst[n] = value; 
                }
                
            }


        // przeciazenie tego indeksera 
            public char this[string n]
            {
                get
                {
                    if (n.Equals("jeden"))
                        return tekst[0];
                    return tekst[tekst.Length - 1];
                }

            }



    }


    class Punkt2D 
    {
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;


        public static Punkt2D operator +(Punkt2D a, Punkt2D b) 
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }


        // inne przeciazenie
        public static Punkt2D operator +(Punkt2D a, int b)
        {
            return new Punkt2D(a.x + b, a.y + b);
        }

        public void Show() 
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
    
    }

}