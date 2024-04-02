namespace Lekcja5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 3);
            rectangle.Draw();
            Circle circle = new Circle(4);
            circle.Draw();

            rectangle.Area();
            circle.Area();

            IArea iArea = new Circle(2);
            iArea.Other();

            ((IArea)circle).Other();


            Console.WriteLine(circle.Equals(new Circle(4)));
            


            // MODYFIKATORY DOSTEPU

            A a = new A();


            // ENUM


            Dog reks = new Dog("Reks", 10, Color.Black);
            Dog azor = new Dog("Azor", 5, Color.Black);

            Console.WriteLine(reks.color.Equals(azor.color));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(Color.Black + " - " + (int)Color.Black);
            Console.WriteLine(Color.White + " - " + (int)Color.White);
            Console.WriteLine(Color.Brown + " - " + (int)Color.Brown);


        }
            public enum Color 
            { 
                Black = 3, White = 11, Brown
            }
    }

    // ENUM 



    class Dog 
    {
        public string name;
        public int age;
        public Program.Color color;

        public Dog(string name, int age, Program.Color color) 
        { 
            this.name = name;
            this.age = age;
            this.color = color;
        
        }
    
    
    }







    // SEALED

    class Animal 
    { 
    
    }

    sealed class Cat : Animal
    { 
    
    }

    //class Dog : Cat{ }




    // MODYFIKATORY DOSTEPU



    public class A 
    {
        //  int defaultVar;   == private

        private int privateVar;
        protected int protectedVar;
        internal int internalVar;
        public int publicVar;

        protected internal int protectedInternalVar;

        private protected int privateProtectedVar;


        void Test() 
        {    
        
        
        }
    }

    class B : A
    {
       void Test() 
        { 
            
        }   
    }













    // INTERFEJSY 

    interface IArea 
    {
        const int num =2;

        void Area();
        void Other() 
        {

            Console.WriteLine("Mam domyślne działanie");

        }

    }


    abstract class Shape
    {
        public abstract void Draw();

    }

    class Rectangle : Shape, IArea 
    {
        public float a;
        public float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;

        }



        public void Area()
        {
            Console.WriteLine($"Pole prostokąta = {Math.Round(a * b, 2)}");

           

        }

        public override void Draw()
        {
            Console.WriteLine($"Prostokąt: {a}, {b}");
        }

    }

    class Circle : Shape, IArea, IEquatable<Circle>
    {
        public float r;

        public Circle(float r)
        {
            this.r = r;
        }

        public void Area()
        {
            Console.WriteLine($"Pole koła = {  Math.Round(Math.PI * r * r, 2)}");
        }

        public override void Draw()
        {
            Console.WriteLine($"Koło: r = {r}");
        }

        public bool Equals(Circle? other)
        {
            return r == other.r;
        }
    }


}