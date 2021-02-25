using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";

            while (code != "secret" )
            {
                Console.WriteLine("Enter your log in");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("Successful");
        }

    }
}
