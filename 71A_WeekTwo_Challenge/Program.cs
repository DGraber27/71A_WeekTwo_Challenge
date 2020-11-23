using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71A_WeekTwo_Challenge
{
    class Program
    {
        //Challenge Five -- This is where I created the instance of the greeter class so that I can call upon the methods within that class. Here is wher I  pass the argument (the value) for the parameters in those methods, in this case the argument is whatever the user inputs as their name.
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine("Please, type your name.");
            string name = Console.ReadLine();
            greeter.Hello(name);
            greeter.TimeOfDay();
            greeter.Farewell(name);
            Console.ReadLine();
        }
    }
    //Challenge One -- Create new class called Greeter, Do NOT replace the Program class with Greeter.
    public class Greeter
    {
        //Challenge Two -- Create a method that takes in a name... Notice how this method doesn't pass an argument for the parameter I will do that in the Main method above, later.
           public void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        //Challenge Three -- Same as Challenge One really.
        public void Farewell(string name)
        {
            Console.WriteLine($"Fare thee well, {name}");
        }

        //Challenge Four -- There are multiple ways this can be done, but this is essentially the simplest way. 
        public void TimeOfDay()
        {
            int timeOfDay = DateTime.Now.Hour;

            if (timeOfDay >= 0 && timeOfDay <12)
            {
                Console.WriteLine("Good Morning!");
            }
           else if (timeOfDay >= 12 && timeOfDay < 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (timeOfDay >= 18 && timeOfDay < 20)
            {
                Console.WriteLine("Good Evening!");
            }
            else if (timeOfDay >= 20 && timeOfDay <= 23)
            {
                Console.WriteLine("Good Night!");
            }
        }
    }

}
