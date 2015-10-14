using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracticeObjectsApp
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Practicing Objects"; //window title
            Console.SetWindowSize(105, 25); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.Black; //background color of console
            Console.ForegroundColor = ConsoleColor.White; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("In this appliction, I will be demonstrating how to:");
            Thread.Sleep(500);
            Console.WriteLine("\tInstatiate objects from other classes.");
            Thread.Sleep(500);
            Console.WriteLine("\tGet and set properties from other classes.");
            Thread.Sleep(500);
            Console.WriteLine("\tCall methods from other classes.");
            Thread.Sleep(500);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 1000);
            Console.WriteLine("Thanks for using the app!");
            Thread.Sleep(500);
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
