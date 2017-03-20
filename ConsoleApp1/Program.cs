using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            int year = 1492;
            bool doggyHome = true;
            DateTime todayDate = DateTime.Now;
            string onlyDate = todayDate.ToShortDateString();
            decimal money = 5.45m;
            char exxx = 'Z';

            Console.WriteLine(helloWorld);
            Console.WriteLine($"Columbus sailed the world in {year}.");
            if (doggyHome)
            {
                Console.WriteLine("It is true that I have a dog at home");
            }
            else
            {
                Console.WriteLine("There is no doggy when you get home.");
            }
            Console.WriteLine($"Today is {onlyDate}!");
            Console.WriteLine($"I spent {money:c} on lunch");
            Console.WriteLine($"{exxx} marks the spot.");

            Console.WriteLine("Please provide me a number");
            string randomNumber = Console.ReadLine();
            int valueBucket = 0;
            int.TryParse(randomNumber, out valueBucket);
            Console.WriteLine($"Here is the number you entered {valueBucket}");

            Console.WriteLine("This time you have to give me actual numbers...");
            string realNumber = Console.ReadLine();
            int realBetterBe = 0;
            bool digitMachine = int.TryParse(realNumber, out realBetterBe);
            while (!digitMachine)
            {
                Console.WriteLine("FALSE!");
                Console.WriteLine("I need a number...");
                string realNumber2nd = Console.ReadLine();
                digitMachine = int.TryParse(realNumber2nd, out realBetterBe);


            }
            Console.WriteLine("Done");


        }
    }
}
