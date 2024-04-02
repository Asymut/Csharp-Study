using System.Drawing;

namespace Lekcja4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat1 = new Cat();
            cat1.age = 10;
            cat1.name = "Milka";

            cat1.Show();
            cat1.GetVoice();

            Animal animal1 = new Animal();
            Dog dog1 = new Dog();
            dog1.Voice();

            Tiger Tiger1 = new Tiger();

            Console.WriteLine();
            Tiger1.GetVoice();
            Tiger1.Show();

            //Object

            // Dziedziczenie konstruktory


            Console.WriteLine();
            CatConst cat = new CatConst("Milka", 10, "blue");
            cat.Show();



            // POLIMORFIZM

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Polimofrizm:");


            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            shape.Draw();
            rectangle.Draw();
            circle.Draw();

            // Shape rectangleShape = (Shape)rectangle;

            Console.WriteLine("-------");
            ((Shape)rectangle).Draw();
            ((Shape)circle).Draw();


            Shape[] shapes = new Shape[2];
            shapes[0] = rectangle;
            shapes[1] = circle;

            Console.WriteLine();

            foreach (Shape item in shapes)
            {
                item.Draw();
            }

            Console.WriteLine("====");

            shape = rectangle;    // shape od teraz to rectangle
            shape.Draw(); // rectangle
            Rectangle rectangle1 = (Rectangle)shape;
            rectangle1.Draw();



            // is oraz as  (ta sama hierarchia klas figur)

            Shape shape2 = new Shape();
            Rectangle rectangle2 = new Rectangle();
            Circle circle2 = new Circle();
            shape2 = (Shape)circle2; //1
            // circle2 = (Circle)shape2;        - błąd 1/2 //2
            // circle2 = rectangle2;    - błąd //3
            // circle2 = (Circle)"Abc"; - błąd //4

            object obj = shape;
            obj = rectangle;
            obj = circle;
            obj = "Object przyjmie wszytko";


            // circle2 = shape2;        - błąd //2

            shape2 = (Shape)circle2; //1
            circle2 = (Circle)shape2;
            circle2.Draw();

            Console.WriteLine();

            if (shape2 is Circle)
            {
                circle2 = (Circle)shape2;
                circle.Draw();
            }
            else
            {
                circle = null;
            }

            //Console.WriteLine( shape2 is Circle);

            shape2 = (Shape)circle2;
            Console.WriteLine(shape2 as Circle);

            Console.WriteLine("<><><><><><><>");

            circle2 = shape2 as Circle;
            circle2.Draw();


            shape2 = rectangle2;
            rectangle2 = shape2 as Rectangle;

            if (rectangle2 != null)
            {

                rectangle2.Draw();

            }


            //rectangle2.Draw();












            // ABSTRACT - bazujemy na klasach shape, circle, rectangle

            Console.WriteLine();
            Console.WriteLine("==========ABSTRACT=========");

            Shape shape3 = new Shape();
            Rectangle rectangle3 = new Rectangle();
            Circle circle3 = new Circle();

            shape3.Draw();
            rectangle3.Draw();
            circle3.Draw();






            // INTERFEJSY







        }
    }



        // klasa bazowa
        class Animal
        {
            public string name;
            public int age;

            public void Show()
            {
                Console.WriteLine("I am Animal");
            }

        }

        class Cat : Animal
        {
            public void GetVoice()
            {
                Console.WriteLine("Meow meow!");
            }
        }

        class Tiger : Cat
        {

        }

        class Dog : Animal
    {
        public void Voice()
        {
            Console.WriteLine("How how!");
        }

    }
  




    // Dziedziczenie konstruktora

    class AnimalConst 
    {

        public AnimalConst(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

        public void Show()
        {
            Console.Write($"Imie:  {name}, wiek: {age}");
        }

    }

    class CatConst : AnimalConst 
    {
        public CatConst(string name, int age, string color) : base(name, age)
        {
            this.color = color;
        }

        public string color;


        public void Show() 
        {
            base.Show();
            Console.WriteLine($", kolor: {color}");
        }

    }


    // POLIMORFIZM

   abstract class Shape 
    {
        public int x;

        public int MyProperty 
        { get; set; }

        public abstract void Draw();
    
        public void Hello() 
        {
            Console.WriteLine("Jakies dzialanie");
        }

    }

    abstract class Star : Shape
    {
       
    }

    class Square : Star
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }



    class Rectangle : Shape 
    {


        public override void Draw() 
        {
            Console.WriteLine("Prostokąt");
        }


    }

        
    class Circle : Shape 
    { 
        
        public override void Draw() 
        {
            Console.WriteLine("Koło");
        }
    
    }

}