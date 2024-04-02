using System;
using System.Diagnostics;
using System.Text;

namespace Lekcja6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRUCT

            Punkt2D p1 = new Punkt2D(2,3);
           // p1.x = 2;
           // p1.y = 3;
            p1.Show();

            Punkt2D p2;
            p2 = p1;
            p2.x = 20;
            //p2.Show();
            p2.y = 30;
            p2.Show();
            p1.Show();




            // EQUALS AND ==
            Console.WriteLine("=================");


            object t1 = "Kurs C#";
            //object t2 = "Kurs C#";

            object t2 ="Kurs C#";

            Console.WriteLine("String: ");
            Console.WriteLine($"== : {t1 == t2}");           // True
            Console.WriteLine($"Equals : {t1.Equals(t2)}");  // True
                                                             // 
            Punkt2D p3 = new Punkt2D(2, 5);
            Punkt2D p4 = new Punkt2D(2, 5);

            Console.WriteLine();
            Console.WriteLine("Punkt2D: ");
            //Console.WriteLine($"== : {p3 == p4}");           // False
            Console.WriteLine($"Equals : {p3.Equals(p4)}");  // False

            // ToString()

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("======ToString()=======");

            Punkt3D punkt1 = new Punkt3D(2, 5, 10);
            //Console.WriteLine(punkt1.Show());
            Console.WriteLine(punkt1);







            // STRING BUILDER:

            // obiekt mierzy uplyw czasu od wykonania jakiegos kodu do innego fragmentu kodu -  zegarek (stoper)
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            string t3 = CreateStringByAdd(100000);
            stopwatch.Stop();
            Console.WriteLine($"Czas +: {stopwatch.ElapsedMilliseconds} ");


            stopwatch.Restart();
            string t4 = CreateStringByStringBuilder(100000);
            stopwatch.Stop();
            Console.WriteLine($"Czas StringBuilder: {stopwatch.ElapsedMilliseconds} ");





            Console.WriteLine(t3.Equals(t4));

           
        }

        // STRING BUILDER:


            static string CreateStringByAdd(int n) 
            {

                string s="";

                for (int i = 0; i < n; i++)
                {
                    s += "A";
                }
                return s;
            }

           

            static string CreateStringByStringBuilder(int n) 
            { 
            
                StringBuilder sb = new StringBuilder();
                
                for (int i = 0; i < n; i++)
                {
                    sb.Append("A");
                }

                return sb.ToString();

            }

    }


   


    //ToString()

    class Punkt3D 
    {

        public Punkt3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float x, y, z;
    


        public override string ToString()
        {
            return $"x: {x}, y: {y}, z: {z}";
        }


    }






    // STRUCT
    struct Punkt2D : IEquatable<Punkt2D>
    {
        public Punkt2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float x;
        public float y;

        public void Show() 
        {
            Console.WriteLine($"x = {x}, y = {y}");
        
        }

        public bool Equals(Punkt2D other)
        {
           return x == other.x && y == other.y;
        }
    }





}