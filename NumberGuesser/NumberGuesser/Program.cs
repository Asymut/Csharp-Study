// See https://aka.ms/new-console-template for more information

using System; // sekcja dyrektyw  - możemy korzystać z przestrzeni nazw System

namespace NumberGuesser // przestrzen nazw - kontener na metody i klasy
{
    class Program  // glowna klasa ze zdefi metodami
    {
        static void Main()  //metoda Main - start dla programu
        {
            // wywołanie metody
            GetAppInfo();

            // zmienna ktorej przypisaniem jest wynik metody
            string user = GetUserName();

            GreetUser(user);

            Random random = new Random();
            int correctNumber = random.Next(1,11);
            bool coorectAnswer = false;

            Console.WriteLine("Zgadnij wylosowaną liczbę z przedziału od 1 do 10. ");

            while (coorectAnswer == false)
            {
                string input = Console.ReadLine();

                int guess;

                bool isNumber = int.TryParse(input, out guess);

                if (!isNumber) 
                {
                    PrintColor(ConsoleColor.Yellow, "Proszę wprowadzić liczbę!");
                    continue;
                }

                if (guess < 1 || guess > 10)
                {
                    PrintColor(ConsoleColor.Yellow, "Proszę wprowadzić liczbę od 1 do 10.");
                    continue;
                }

                if (guess < correctNumber)
                {
                    PrintColor(ConsoleColor.Red, "Błędna odpowiedź. Wylosowana liczba jest większa.");
                }
                else if (guess > correctNumber)
                {
                    PrintColor(ConsoleColor.Red, "Błędna odpowiedź. Wylosowana liczba jest mniejsza.");
                }
                else
                {
                    coorectAnswer = true;
                    PrintColor(ConsoleColor.Green, "Brawo! Prawidłowa odpowiedź!"); 
                }
                    

            }

        }

        // Tworzenie metody 
        // static Typ nazwa(parametry, parametry) {ciag instrukcji };

        static void GetAppInfo()
        {
            string author = "Kamil Nocoń";
            int age = 21;

            Console.WriteLine($"{author} ma {age} lat. " + "Good");

            string appName = "Zgadywanie Liczby";
            int appversion = 1;

            string info = $"[{appName}], Wersja: 0.0.{appversion}, Autor: {author}";

            //Console.ForegroundColor = ConsoleColor.Magenta; //Zmiana koloru czcionki

            PrintColor(ConsoleColor.Magenta, info);
            
            //Console.ResetColor(); // resetowanie koloru
        }

        static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");
            string UserName = Console.ReadLine();
            return UserName;
        }

        static void GreetUser(string name)
        {
           string greet = $"Powodzenia {name}, odgadnij liczbę...";

            PrintColor(ConsoleColor.Blue, greet);
        }

        static void PrintColor(ConsoleColor color, string message) 
        { 
            Console.ForegroundColor= color;
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }

}
