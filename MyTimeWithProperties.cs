using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class MyTimeWithProperties
    {
        private int hours;
        private int minutes;
        private int seconds;

        public MyTimeWithProperties(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        /// <summary>
        /// /The concept of Properties is that it is a Hybrid of Variables and Methods
        /// Methods can return a value and so they are used to code set and get mehtods 
        /// But writing setter and getter each variable is a verbose thing and opposed to
        /// coding. So the getters and setters of a variable are handled through Properties
        /// The property can have any name but it is used with same name with Capitals.
        /// There are two blocks of code 1 set and 2 get
        /// set block sets the value passed on to the property using the "Value" keyword.
        /// In the below example the variable "hours" is mapped to property "Hours"
        /// So whenever the main class modifies the Property, the variable hours is modified.
        /// One can use these two blocks as if they are actually methods and check the validity of
        /// the variable using conditions like in below
        /// </summary>
        public int Hours
        {
            set
            {
                if (value >=0 && value<= 23)
                hours = value;
            }

            get
            {
                return hours;
            }
        }
        /*
           a property can have either only get block or set block 
           If it has only get block - it is called as Read only
           If it has only set block - it is called as Write only
           Below property is an example of Read only property
        */
        public int TotalSeconds
        {
            get
            {
                return 3600 * Hours + 60 * minutes + seconds;
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            MyTimeWithProperties t1 = new MyTimeWithProperties(10, 20, 30);
            t1.Hours = 44;
            Console.WriteLine(t1.Hours);
            //Properties are called just like variables
            Console.WriteLine(t1.TotalSeconds);
            Console.ReadLine();
        }
    }
}
