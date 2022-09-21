using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            string name, courses, bookPrice;

            Console.Write(Enter your name );
            name = Console.ReadLine();

            Console.Write(Enter the total number of your enrolled courses );
            courses = Console.ReadLine();

            Console.Write(Enter the price of your favorite book );
            bookPrice = Console.ReadLine();

            Console.WriteLine(nn--------nn);

            Console.WriteLine($Name {name});
            Console.WriteLine($Total enrolled courses {courses});
            Console.WriteLine($Price of {name}'s favorite book {bookPrice});
        }
    }
}
