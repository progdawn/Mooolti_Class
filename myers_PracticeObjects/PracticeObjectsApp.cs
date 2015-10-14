using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracticeObjectsApp
{
    class PracticeObjectsApp
    {
        //Dawn Myers
        //ITDEV 110
        //Assignment 5

        static void Main(string[] args)
        {
            Admin GetReady = new Admin(); //instantiates an Admin object from the Admin class
            MathFun Calc1 = new MathFun(); //instantiates a MathFun object named Calc1
            MathFun Calc2 = new MathFun(); //just like before, but naming this one Calc2

            GetReady.ConsoleSetup(); //invokes the ConsoleSetup method from the Admin class
            GetReady.Intro(); //invokes the Intro method from Admin as well

            Calc1.Number1 = 5; //sets number1 as 5, via the Number1 property
            Calc1.Number2 = 10; //same, but for number2

            Calc2.Number1 = 20; //just like before, but we're setting it for our other object, Calc2
            Calc2.Number2 = 25; //same, sets number2 in object Calc2

            //gets the value of number1 and number2 from our Calc1 object
            Console.WriteLine("Value of Calc1, number1 after setting: " + Calc1.Number1);
            Thread.Sleep(1000);
            Console.WriteLine("\tValue of Calc1, number2 after setting: " + Calc1.Number2);
            Thread.Sleep(1000);
            Console.WriteLine();

            //gets the value of number1 and number 2 from Calc2 object
            Console.WriteLine("Value of Calc2, number1 after setting: " + Calc2.Number1);
            Thread.Sleep(1000);
            Console.WriteLine("\tValue of Calc2, number2 after setting: " + Calc2.Number2);
            Thread.Sleep(1000);
            Console.WriteLine();

            //invokes the MultiplyThem method for Calc1
            Console.WriteLine("Multiplying Calc1 number1 (" + Calc1.Number1 + ") and number2 (" + Calc1.Number2 + ") equals " + Calc1.MultiplyThem());
            Thread.Sleep(1000); 
            //invokes the AddThem method for Calc1
            Console.WriteLine("\tAdding Calc1 number1 (" + Calc1.Number1 + ") and number 2 (" + Calc1.Number2 + ") equals " + Calc1.AddThem());
            Thread.Sleep(1000);
            Console.WriteLine();

            //just like before, but multiplying number1 and number2 in the Calc2 object via the MultiplyThem method
            Console.WriteLine("Multiplying Calc2 number1 (" + Calc2.Number1 + ") and number2 (" + Calc2.Number2 + ") equals " + Calc2.MultiplyThem());
            Thread.Sleep(1000); 
            //adding number1 and number2 in the Calc2 object, via the AddThem method
            Console.WriteLine("\tAdding Calc2 number1 (" + Calc2.Number1 + ") and number 2 (" + Calc2.Number2 + ") equals " + Calc2.AddThem());
            Thread.Sleep(1000);
            Console.WriteLine();

            //gets the total of AddThem and MultiplyThem methods, which is set via "total = MultiplyThem() + AddThem();"
            Console.WriteLine("The total of Calc1 (" + Calc1.AddThem() + " + " + Calc1.MultiplyThem() + ") is " + Calc1.Total);
            Thread.Sleep(1000);
            //same as above, but done with the Calc2 object
            Console.WriteLine("\tThe total of Calc2 (" + Calc2.AddThem() + " + " + Calc2.MultiplyThem() + ") is " + Calc2.Total);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //invokes the Googbye method from Admin class
            GetReady.Goodbye();

        }
    }
}
