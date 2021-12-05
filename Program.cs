using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_11
{
    public struct Uravnenie
    {
        public double k;
        public double b;
        public Uravnenie(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
       
        public void root()
        {
            double x = 0;
            if (k != 0)
            {
                x = (-this.b / this.k);
                Console.WriteLine("x={0}", x);
            }
            else
            {
                if (this.b == 0)
                {
                    Console.WriteLine("x={любое число }");
                }
                else { Console.WriteLine("x={ нет решения}"); }

            }
        }

    }

    class Program
    {
        static Uravnenie make_Uravnenie(double k, double b)
        {
            Uravnenie ur1 = new Uravnenie(k, b);
            return ur1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            make_Uravnenie(a, b).root();

            Console.ReadKey();
        }

    }
}
