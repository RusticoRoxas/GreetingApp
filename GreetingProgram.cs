using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp{
    class GreetingProgram{
        static void Main(string[] args){
            string name, courses, bookPrice;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter the total number of your enrolled courses: ");
            courses = Console.ReadLine();

            Console.Write("Enter the price of your favorite book: ");
            bookPrice = Console.ReadLine();

            Console.WriteLine("\n\n--------\n\n");

            Console.WriteLine($"Name {name}");
            Console.WriteLine($"Total enrolled courses {courses}");
            Console.WriteLine($"Price of {name}'s favorite book {bookPrice}");
        }
    }
}
