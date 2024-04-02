using System;
using System.IO;
using System.Threading;

namespace Lekcja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OPERACJE NA PLIKACH

            StreamWriter sw = new StreamWriter("../../../file.txt", true);

            sw.WriteLine(Console.ReadLine());
            sw.Close();

            Console.WriteLine("\n Zawartość pliku:");
            StreamReader sr = new StreamReader("../../../file.txt");

            Console.WriteLine(sr.ReadLine());

            string line;
            while(( line = sr.ReadLine()) != null) 
            {
                Console.WriteLine(line);
            }

            sr.Close();



            // WIELOWATKOWOSC
            Console.WriteLine("\n \n \n");
            Console.WriteLine("WIELOWĄTKOWOŚĆ: ");


           // LongMethod(10);
           // LongMethod(10);

            Thread t1 = new Thread(new ParameterizedThreadStart(LongMethod));
            Thread t2 = new Thread(new ParameterizedThreadStart(LongMethod));
           
            t1.Start(500);
            t2.Start(3);

        }

        // WIELOWATKOWOSC

        static void LongMethod(object n) 
        {
            for (int i = 0; i < (int)n; i++)
            {
                Console.WriteLine($"ID: {Thread.CurrentThread.ManagedThreadId} : {i}");
            }
        
        }



        // REGIONY

        #region MyRegion
        class Animal 
            {

                #region Komentarz 
                //Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                #endregion
            }

        #endregion



    }
}