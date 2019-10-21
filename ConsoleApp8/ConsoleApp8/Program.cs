using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public static void main()
        {
            Console.WriteLine("skriv ett tal");
            float tal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett till");
            float tal2 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett till");
            float tal3 = float.Parse(Console.ReadLine());
            Console.WriteLine("medelvärdet är" + BeräknaMedel(tal1, tal2, tal3));
        }



        public float BeräknaMedel(float tal1, float tal2, float tal3)
        {
            float a = (tal1 + tal2 + tal3) / 3;
            return a;
        }
    }
}
