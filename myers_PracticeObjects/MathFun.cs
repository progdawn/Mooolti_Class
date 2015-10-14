using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectsApp
{
    class MathFun
    {
        //private, hidden from other classes. Can only be altered by using the correlating properties
        private int number1;
        private int number2;
        private int total;

        //default constructor
        public MathFun()
        {

        }

        //allows another class to set the value of number1, and also retrieve the value of number1
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }

        //same as above, allows another class to set the value of number2, and get it as well
        }

        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }

        //adds the total of the AddThem and MultiplyThem methods, storing it in total
        public int Total
        {
            get
            {
                return MultiplyThem() + AddThem();
            }

            set
            {
                total = MultiplyThem() + AddThem();
            }
        }

        //multiples number1 and number2
        public int MultiplyThem()
        {
            return number1 * number2;
        }

        //adds number1 and number2
        public int AddThem()
        {
            return number1 + number2;
        }

    }
}
