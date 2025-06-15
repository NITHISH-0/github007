using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            Buildrequest("karthi");
            Buildrequest("nithish");
            Buildrequest("suren");
            Buildrequest("sarvesh");

            Buildrequest(10, 4);

            //Console.WriteLine(Buildrequest(4, 5, 6));
            //Console.WriteLine(Buildrequest(4, 8, 6));
            //Console.WriteLine(Buildrequest(9, 8, 6));
        }

        public static void Buildrequest(int a, int b)
        {

            var result = a + b;
            Console.WriteLine($"Addition : {result}");
            result = a - b;
            Console.WriteLine($"Sub : {result}");
            result = a * b;
            Console.WriteLine($"Multiple : {result}");
            result = a / b;
            Console.WriteLine($"Devision : {result}");
            result = a % b;
            Console.WriteLine($"Persentage : {result}");


            //Console.WriteLine($"Hi, My name is{name}");

            //int c = a + b + d;
            //return c;
        }
    }
}
