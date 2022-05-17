using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Initials and Surname:BN Mabena
//Student Number:222011403

namespace _222011403
{
    internal class Program
    {
        //Global variables
        static int parkingMinutesUsed;
        static double totalDue;
        const double VAT = 1.15;
        static int menuNumber;


        static void Main(string[] args)

        {
            //Local variable
           
            Menu();

             
        }

         static void Menu()
        {
           //welcome screen
            //Main Menu of the program
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("AAM Pty Ltd - Parking Ticket SYSTEM");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Pay Parking Ticket");
            Console.WriteLine("2. Exit Parking System");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            //request to enter either number 1 or 2
            Console.WriteLine("Please enter menu number 1 or 2");
        }

         static void MainMenu()
         {
           switch
           {
            
                   
           }
         }

        static void PayParkingTicket()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     AAM Pty Ltd - Ticket Rates     ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     *up to 30mins       = free     ");
            Console.WriteLine("     *31mins to 60mis    = R20.00   ");
            Console.WriteLine("     *61mins to 120mins  = R35.00   ");
            Console.WriteLine("     *121mins+           = R50.00   ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    (Prices Excludes VAT of 15%)    ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter how many minutes was used for parking");

        }
    }


}
