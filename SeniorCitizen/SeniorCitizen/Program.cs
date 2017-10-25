using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorCitizen
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            string input = "";
            while (input != "0")
            {
                Console.WriteLine();
                Console.WriteLine("Hello and Welcome");
                Console.WriteLine("Choose your choice from menu:");
                Console.WriteLine("(1) Senior Citize");
                Console.WriteLine("(2) Repeat it ten time");
                Console.WriteLine("(3) The third world");
                Console.WriteLine("(0) Exit program");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Option1();
                }
                else if (input == "2")
                {
                    Option2();
                }
                else if (input == "3")
                {
                    Option3();
                }
                else if (input == "0")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Incorrect choice");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Bye and thank you");
            Console.ReadLine();
        }
        public static void Option1()
        {
            Console.WriteLine("Please input your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if (age < 20)
            {
                Console.WriteLine("Kids deal: 80kr");
            }
            else if (age >= 64)
            {
                Console.WriteLine("Senior Citizen Discount:90kr");
            }
            else
            {
                Console.WriteLine("Standard price:120");
            }
            Console.ReadLine();
        }
        public static void Option2()
        {
            /* string speed;
            Console.WriteLine("Please enter number of word you want to display");
            speed = Console.ReadLine();
            int size = int.Parse(speed);
            Console.WriteLine("Please enter any text" + speed);
            string[] array = new string[size];
            for (int i = 0; i < size; i++)
            {
            Console.Write("Input #" + (i + 1) + ": ");
            speed = Console.ReadLine();
            if (i < 0)
            {
            if (speed == array[i - 1])
           {
            Console.WriteLine("Try to write something else");
           i--;
            }
           else
           {
            array[i] = speed;
            }
            }
            else {
            array[i] = speed;
            }
            }
            for (int i = 0; i < size; i++)
            {
            Console.Write(array[i] + "");
            }
            Console.ReadLine(); */
            Console.WriteLine("Enter words");
            string speed = Console.ReadLine();
            Console.WriteLine("Enter the number of time you want to print");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(speed);
                }
            }
        }

        public static void Option3()
        {
            string temp;
            string sentenceText = (" ");
            Console.WriteLine("Please Enter sentence with at least three words");
            temp = Console.ReadLine();
            sentenceText = temp;

            string[] split = sentenceText.Split(' ');
            foreach (string item in split)
            {
                Console.WriteLine(item);
            }
            // find the third word and out put the third word
            string text = sentenceText.Split(' ')[3];
            if (sentenceText.Length >= 3)
            {
                Console.WriteLine("The third word is:" + text);
            }
            else
            {
                Console.WriteLine("You need more than 3 words");
            }
            Console.ReadLine();
        }
    }
}
