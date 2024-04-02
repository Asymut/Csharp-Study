using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    class Turtle
    {
        public Turtle(string type, string name, int age, string color ) 
        { 
            this.type = type;
            this.name = name;
            this.age = age;
            this.color = color;
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }

        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public  int Age 
        {
            get { return age;}
            set { age = value; }
        }

        private string color;
        public string Color
        {
            get { return color;}
            set { color = value; }

        }

        public void Hello() 
        {
            Console.WriteLine($"Czesc, jestem {color} zolw {type}, mam na imie {name} i mam {age} lat.");
        }


    }
}
