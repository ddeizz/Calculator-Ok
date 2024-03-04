using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("pilih menu calculator");
            Console.WriteLine("1\n penambahan");
            Console.WriteLine("2 pengurangan");
            Console.WriteLine("3 perkalian ");
            Console.WriteLine("4 pembaguan");

            Console.Write("\ninput nomer menu [1-4]: ");
            int menu = int.Parse(Console.ReadLine());


            Console.Write("input nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("input nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Hasil penambahan" + a + "+" + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan (int a, int b)
        { 
            return a + b;
        }
        static int pengurangan (int a, int b)
        { 
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static float pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
