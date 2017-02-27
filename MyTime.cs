using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class MyTime
    {
        // We have 3 variables and a constructor to initialise them
        // We have getters and setters to each variable to change and read them
        private int hours;
        private int minutes;
        private int seconds;

        public MyTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void SetHours(int hours)
        {
            this.hours = hours;
        }

        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public int GetHours()
        {
            return this.hours;
        }

        public int GetMinutes()
        {
            return this.minutes;
        }
    }
    class MyTimeOrginal
    {
        static void Main(string[] args)
        {
            MyTime t1 = new MyTime(10, 20, 30);
            t1.SetHours(20);
            Console.WriteLine(t1.GetHours());
            t1.SetHours(33);
            Console.WriteLine(t1.GetMinutes());
            Console.ReadLine();
            // AS one can see it is real pain in ass to modify every private
            // variable (writing get and set methods). C# is dope and introduced
            // a new feature called properties . We will see same prog with Properties
        }
    }
}
