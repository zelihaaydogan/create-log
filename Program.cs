using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_log
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loglama();
            Console.ReadLine();
        }

        private static void Loglama()
        {
          try
            {
                Console.WriteLine("Bir sayı giriniz.");
                int sayi=Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
