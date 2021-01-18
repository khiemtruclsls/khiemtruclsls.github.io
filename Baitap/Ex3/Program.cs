using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    { 
        static void Main(string[] args)
        {   
            int a, b;
            Console.WriteLine("         ***************************************************");
            Console.WriteLine("         *                                                 *");
            Console.WriteLine("         *    Chuong trinh giai phuong trinh Ax + B = 0    *");
            Console.WriteLine("         *                                                 *");
            Console.WriteLine("         ***************************************************");
            Console.WriteLine("Please enter a ( a > 0): ");
            a = Convert.ToInt32(Console.ReadLine());
            if( a <= 0 ) {
                Console.WriteLine("wrong syntax???????");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Please enter b : ");
                b = Convert.ToInt32(Console.ReadLine());
                int x = -b / a;
                Console.WriteLine("Result : " + x);
                Console.WriteLine("The program takes the form : {0}.{1} + {2} = 0", a, x, b);
                Console.ReadLine();
            }
           
        }
        static void show()
        {
            /*
            Console.WriteLine("1.Enter hotel infomation ");
            Console.WriteLine("2.Show hotel infomation ");
            Console.WriteLine("3.Booking ");
            Console.WriteLine("4.Find empty room ");
            Console.WriteLine("5.Hotel revenue statistics");
            Console.WriteLine("6.Find customer infomation ");
            Console.WriteLine("7.Exit");
            */

        }
    }
}
