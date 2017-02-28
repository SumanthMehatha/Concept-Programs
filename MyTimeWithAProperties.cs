using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class MyTimeImp
    {
        //Automatically Implemented Properties
        //C# becomes super dope and from c# 3.0 introduces the AIP technique.
        //Here no need to create variables, no constructors. Everything is
        //done by properties.

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        /*But the cons of using Automatically Implemented Properties is that 
         we are losing the validity and control over the program. To use the 
         Properties like methods we are declaring them public so the variables
         control is compromised. Also there is no block of code for get and 
         set so validity is missed. The main catch here is one should be use 
         the right property (default or Auto implemented) according to need of
         the program*/ 

    }
    class MyTimeWithAProperties
    {
        public static void Main()
        {
            MyTimeImp t1 = new MyTimeImp { Hour = 20, Minute = 10 };
            Console.WriteLine("The hour value is {0}", t1.Hour);
        }
    }
}
