using System.Drawing;
using System.Numerics;
using System.Text;
using System;

namespace Prog120_W24_L2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Uncomment to run string example
            // StringExample();
            // ReadLineExample();
            //IntExample();

            double tea = 70.00;
            double tax = .1;
            double taxOnTea = tea * tax;
            double totalTransaction = tea + taxOnTea;

            Console.WriteLine($"Cost of Tea: {tea.ToString("c")}");
            Console.WriteLine($"Tax in WA: {tax}");
            Console.WriteLine($"Tax of Tea: {taxOnTea}");
            Console.WriteLine($"Total Tranaction: {totalTransaction}");






        } // main

        public static void IntExample()
        {
            // Whole Number - int
            // Integral

            int number1 = 15;
            int number2 = 25;

            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

            int minus = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {minus}");

            int multi = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {multi}");

            int divide = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {divide}");

            int mod = number1 % number2;
            Console.WriteLine($"{number1} % {number2} = {mod}");

            Console.WriteLine(25 % 10);

            // Addition +
            // Subtraction -
            // Multiply *
            // Divide /
            // Modulous %



        }

        public static void StringExample()
        {
            // c w tab to quickly create a console writeline

            // variables
            // string - is a data type for characters. abc, 123, ^&$
            // a string is whatever is in double quotes ""
            // Declaring and initializing a string
            // string type, variables

            // Smackraken
            // The first time you make a variable, you have to say the type
            string playerName = "Smackraken";
            Console.WriteLine("Hello," + playerName);

            // Reassigning a value
            playerName = "Kaze";
            Console.WriteLine("Welcome," + playerName);


        }

        public static void ReadLineExample()
        {
            // Console.ReadLine(); 
            // It waits for the user to enter a piece of information and press enter, then the value
            // is saved to a string variable.

            //Console.WriteLine("Welcome traveler, please enter your name: ");
            //string playerName = Console.ReadLine();

            //Console.WriteLine("Ah! Welcome " + playerName);

            Console.Write("Welcome to Amazon - Please enter you frist name: ");

            // variable names start with lower case
            // do not start with number
            // camel case lower case first word, upper case afterwards
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");

            string lastName = Console.ReadLine();


            //string fullName = firstName + " " + lastName;
            // Doller sign turns this into a interpolted string literal
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine("Welcome " + fullName);


            //string agnesUC = "AGNES";
            //Console.WriteLine(agnesUC + "(O.S.)");
            //Console.WriteLine("Oh my gosh look at that fluffy unicorn!");



            //            AGNES(O.S.)
            //"Oh my gosh look at that fluffy unicorn!"
        }


    } // class

} // 

// To Comment do double forward slash
// The hotkey is Ctrl + k, c
// To uncomment do Ctrl + k, u