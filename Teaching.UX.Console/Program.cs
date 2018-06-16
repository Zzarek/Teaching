using System;
using Teaching.Common;

namespace Teaching.UX.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {



            Turtle myTurtle = new Turtle();  //Instantiated a new instance of turtle.
            int yearsWithTurtle = 3; //Initialized

            Console.WriteLine("Hello World!");
            Console.WriteLine("I Want you to meet my Turtle.");
            Console.WriteLine(string.Format("His Name is: {0}. I've had hime for {1} years", myTurtle.Name, yearsWithTurtle));

            DisplayTurtleNameInNewSyntax(myTurtle); //Invoked, passed turtle as Parameter.

            Turtle Ralph = new Turtle("Donatello");  //Variables can be whatever you want, function is completely meaningless.

            // Invoking the method only cares that you HAVE the right object type. But, It can accept any *INSTANCE* of Turtle. Ralph, and MyTurtle are seperate INSTANCES of Turtle.
            //Any instance of turtle will work.
            DisplayTurtleNameInNewSyntax(Ralph);

            string ageString = GetAgeString(myTurtle.Age);
            string totalageString = "My first turtle is named" + ageString;
            Console.WriteLine(totalageString);

            //This is Cleaner and does the exact same thing as above. Just less wordy.
            Console.WriteLine($"{Ralph.Name}'s Age is {GetAgeString(Ralph.Age)}");

            //To FInd out what this does.... get rid of it and run it.
            System.Threading.Thread.Sleep(10000);//Milisecond

        }

        /// <summary>
        /// Note, Everything I say here when you highlight the methgod name in 'Main' above. 
        /// Thats due to the triple / comment and Summary tag, its a handly documentation trick. use it for important methods.
        /// More Importantly, note I wasnt coy about the name of this method. Its easy to say prvate static void X(Turtle y).... 
        /// But now you know what this method does WITHOUT NEEDING the comment in the first place!
        /// </summary>
        /// <param name="genericTurtle"></param>
        private static void DisplayTurtleNameInNewSyntax(Turtle genericTurtle) //Void means no Return.
        {
            Console.WriteLine($"This new syntax is Better, I can get {genericTurtle.Name}'s Name without having to check the end of the string");
        }


        private static string GetAgeString(int value)
        {
            return $"age is {value}";
        }
    }
}
