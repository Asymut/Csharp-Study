using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    //Słówka dostępności - określają jak mocno dostępne mają być elementy naszej klasy. (domyślnie jest to private)

    //private - prywatne, widoczne tylko dla danej klasy
    //public - publiczne, widoczne dla całego programu.

    class Person
    {
        //Dodanie konstuktora - taka sama nazwa jak klasa, zwykle znajduje się u góry i jest publiczny
        public Person(string name, int age) 
        {

            //this. - przeszukuje w pierwszej kolejności obszar o zasięu całej klasy, np:

            this.name = name;
            this.age = age;
            count++;

            //jak tworze zmienne wewnatrz konstuktora ktore nazywaja sie tak samo jak zmienne dla klasy i chce przypisac wartosci zmienncyh podanych dla konstruktora do zmiennych dla danego obiektu to uzywam this.aby wybrac zmienne globalne dla danego obiektu i pominac zmienne konstruktora

            //Po lewej stronie this.zmienna sa to zm o tej samej nazwie ale zm z klasy dla danego obiektu który wywołał konstruktor. Po prawej stronie są to zmienne z konstruktora.
            // scope:
            // bez "this" zasieg najblizszy - zmienne z konstuktora
            // z "this" zasieg najdalszy - zmienne dla obiektu z calej klasy
        }


        //Konstruktor możemy przeciążać, tak samo jak funkcję.
        //snippet: "ctor" + tab + tab   -  stworzy kopie konsturktora tak aby szybciej szło zrobić przeciążenie konstruktora

        //Hermetyzacja(enkapsulacja) - ukrywanie pul i robienie z nich pul prywatnych, ukrywanie zmiennych na zewnątrz

        //Ukrywanie prywatnego pola i jednoczesne posiadanie do nich dostępu - dwie dodatkowe metody dostępności. (metody w klasie)


        // Metoda publiczna pobrania wartosci ze zmiennej ("getNazwaZmiennej")
        public string getName() 
        { 
            // zwracam prywatne pole name
            return name;
        }

        //Metoda publiczna przypisujaca polu prywatnemu "name" wartości value ("setNazwaZmiennej")
        public void setName(string value) 
        { 
            //czy zmienna ktora ustawiam - czy jej wartosc jest dluzsza od 2
            if(value.Length > 2)
            name = value;   
        }


        private string name = "Anonim";

        public string Name
        {
            get 
            { 
                //modyfikujemy wartosc zwracana!
                return "Imie: " + name; 
            }
            set 
            { 
                if (value.Length > 2)
                    name = value; 
            }
        }



        //Nowoczesna hermetyzacja dla zmiennej age

        private int age;
        
        // tworzymy własciwość zmiennej age - metody dostepowe dla tej zmiennej
        public int Age 
        { 
            // dwa atrybuty - get lub set

            //atrybut musi cos zwracac.
            get 
            { 
                return age;
            }

            set 
            {
                // przypisanie zmiennej age wartosci z niezadeklarowanego slowa kluczowego "value" 
                // tworzymy logike biznesowa - walidacje dla naszego wieku
                if(value >= 0 && value <=200)
                     age = value;
            }

        }

        //uproszczona wlasciwosc - nie jest w stanie przed atrybutami zwalidowac danych.
        // jedna z tych metod moze byc prywatna ale 2 nie bo nie odróżnimy ich od zwykłego pola
        public string Country { get; set; }



        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }



        // pole sluzace do zliczania obiektow klasy Person
        public static int count = 0;





        //metoda statyczna - jednakowa dla całej klasy
        public static void Count() 
        {

            Console.WriteLine($"Jest nas: {count} - Ilość elementów klasy Person");

        }




    }
}
