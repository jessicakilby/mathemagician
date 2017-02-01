using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "for scoping purposes";
            string howMany = "also for scoping purposes";

            while (true)
            {
                Console.WriteLine("Pick a command: Natural, Prime, Fibonacci, Even or Odd. Or type \"quit\" to exit: ");
                //How you provide the user useful info is on you.
                //think about, 'How will the user pick a command?'
                //Is it better to modify the original question? Make it more useful?

                command = Console.ReadLine().ToLower();
                //Once I have the command (whatever it looks like), how do I check if 
                //it's a valid command?
                //When should you actually create an instance of your number class? now or later?

                if (command == "quit")
                {
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                }
                else if (command == "natural" || command == "prime" || command == "fibonacci" || command == "even" || command == "odd")
                {
                    Console.WriteLine("Cool you picked: " + command);
                    break;
                }
                else
                {
                    Console.WriteLine("You did not choose one of the given commands.");
                    continue;
                }
            }

            //When do I check if the "HowMany" response is too big? no more than 30
            //If they inter a number > 30, how do I respond and exit the program?
            while (true)
            {
                Console.WriteLine("How many should I print (between 1 - 30)? Or type 100 to exit: ");

                howMany = Console.ReadLine();
                var howManyTimes = int.Parse(howMany);

                if (howManyTimes == 100)
                {
                    break;
                }
                else if (howManyTimes <= 0)
                {
                    Console.WriteLine(howManyTimes + " is not an acceptable value. Please pick something else.");
                    continue;
                }
                else if (howManyTimes > 30)
                {
                    Console.WriteLine(howManyTimes + " is not an acceptable value. Please pick something else.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Cool, I'm going to print {howMany} {command} numbers.");
                    break;
                }
            }

            //okay!! Print some stuff!
            var howManyToPrint = int.Parse(howMany);

            if (command == "natural")
            {
                NaturalNumber naturalNumber = new NaturalNumber();
                var printNumbers = naturalNumber.GetSequence(howManyToPrint);
                Console.WriteLine(naturalNumber.PrintNumbers(printNumbers));
            }
            else if (command == "prime")
            {
                //PrimeNumber primeNumber = new PrimeNumber();
                //var printNumbers = primeNumber.GetSequence(howManyToPrint);
                //Console.WriteLine(primeNumber.PrintNumbers(printNumbers));
                Console.WriteLine($"{command}");
            }
            else if (command == "fibonacci")
            {
                FibonacciNumber fibonacciNumber = new FibonacciNumber();
                var printNumbers = fibonacciNumber.GetSequence(howManyToPrint);
                Console.WriteLine(fibonacciNumber.PrintNumbers(printNumbers));
            }
            else if (command == "even")
            {
                EvenNumber evenNumber = new EvenNumber();
                var printNumbers = evenNumber.GetSequence(howManyToPrint);
                Console.WriteLine(evenNumber.PrintNumbers(printNumbers));
            }
            else
            {
                OddNumber oddNumber = new OddNumber();
                var printNumbers = oddNumber.GetSequence(howManyToPrint);
                Console.WriteLine(oddNumber.PrintNumbers(printNumbers));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }
    }
}
