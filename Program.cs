using System;

namespace Classes_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Greetings greetings = new Greetings();
            //
            greetings.Welcome();

            //
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            //
            greetings.Hello(userName);
        }
    }
}
