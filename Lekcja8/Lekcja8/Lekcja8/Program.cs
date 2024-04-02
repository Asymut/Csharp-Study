namespace Lekcja8
{
    internal class Program
    {

        public delegate int CalcDelegate(int a, int b);

        static void Main(string[] args)
        {
            //DELEGATY, FUNKCJE ANONIMOWE
            
            CalcDelegate calcDelegate = Add;
            CalcWithText(calcDelegate.Invoke, 3, 5);


            CalcDelegate calcDelegate2 = delegate (int a, int b)
            {

                return a + b; 
            };

            Console.WriteLine(calcDelegate2.Invoke(2, 5));

            CalcWithText(calcDelegate2.Invoke, 2, 5);

            Func<int, int, int> funcDelegate = Add;

            CalcWithText(funcDelegate, 2, 5);


            Action<int, int> action = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            action.Invoke(2, 5);


            Predicate<int> predicate = delegate (int a)
            {
                return a == 0;
            };

            Console.WriteLine(predicate.Invoke(5));  // false
            Console.WriteLine(predicate.Invoke(0));  // true

            //WYRAZENIA LAMBDA

            Console.WriteLine(); Console.WriteLine("\n\n =====LAMBDA=====") ;


            CalcWithText(delegate (int a, int b)
            {
                return a + b;
            }, 2, 5);


            //wyrazenie lambda
            CalcWithText((x, y) => { Console.WriteLine("Jestem"); return x + y; }, 5, 2);

            CalcWithText((x, y) => x + y, 5, 2);

        }




        //WYRAZENIA LAMBDA










        //DELEGATY, FUNKCJE ANONIMOWE

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void CalcWithText(Func<int, int, int> func, int a, int b)
        {
            int res = func(a, b);
            Console.WriteLine($"Wynik: {res}");
        }



    }
}