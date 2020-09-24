using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRiveraTechProject3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Name ");
          


            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                WeclomeMessage(input);
               
            } // End of try



            catch
            { 
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch


        } // End of Main


       
        private static void WeclomeMessage(string input)
        {
         
            Console.WriteLine("Hello "+ input + " - Go USF!");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        } 


    } // End of class
} // End of namespace

