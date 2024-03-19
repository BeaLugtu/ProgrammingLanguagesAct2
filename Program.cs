using System;

namespace ProgrammingLanguagesAct2
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Bea Alyssa G. Lugtu";
            String CourseYearSection = "BSCS2A";
            String SubjectCodeDescription = "Programming Languages [CS 105]";
            bool exitChoice = false;

            // Main Menu
            while (!exitChoice)
            {
                Console.Clear();
                Console.WriteLine("[Main Menu]");
                Console.WriteLine("[A] Condition Statement");
                Console.WriteLine("[B] Loop Statement");
                Console.WriteLine("[C] Exit");
                Console.Write("Input your Choice: ");

                String choice = Console.ReadLine();

                if (choice.ToUpper() == "A")
                {
                    // Run Condition Statement
                    CondtionStatement();
                } else if (choice.ToUpper() == "B")
                {
                    // Run Loop Statement
                    LoopStatement();
                } else if (choice.ToUpper() == "C")
                {
                    // Exit/Terminate Program
                    exitChoice = ExitProgram(fullname, CourseYearSection, SubjectCodeDescription, exitChoice);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                    Thread.Sleep(2000);
                }
            }
        }
        static void CondtionStatement()
        {
            bool isValid = false;

            while (!isValid)
            {
                Console.Clear();
                Console.WriteLine("Kindly input a number [Odd/Even]");
                Console.Write("Enter a Value: ");
                int valueNumber;

                if (!int.TryParse(Console.ReadLine(), out valueNumber))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (valueNumber % 2 == 0)
                {
                    Console.WriteLine("You Entered a Value: " + valueNumber);
                    Console.WriteLine("Number " + valueNumber + " is an Even number");
                }
                else
                {
                    Console.WriteLine("You Entered a Value: " + valueNumber);
                    Console.WriteLine("Number " + valueNumber + " is an Odd number");
                }

                Console.WriteLine("");
                Console.Write("Try another number? [Y/N]: ");
                String tryAgainNumber = Console.ReadLine();

                if (tryAgainNumber.ToUpper() == "Y")
                {
                    isValid = false;
                }
                else if (tryAgainNumber.ToUpper() == "N")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Proceeding to Main Menu...");
                    isValid = true;
                    Thread.Sleep(500);
                }
            }
        }
        static void LoopStatement()
        {
            Boolean inputNameAgain = false;

            while (!inputNameAgain) 
            {
                Console.Clear();
                Console.Write("Please Enter your Name: ");
                String inputName = Console.ReadLine();

                for(int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(inputName);
                }

                Console.Write("Would you like to try again [Y/N]: ");
                String answer = Console.ReadLine();
                if(answer.ToUpper() == "Y")
                {
                    inputNameAgain = false;
                } else if(answer.ToUpper() == "N")
                {
                    inputNameAgain = true;
                } else
                {
                    Console.WriteLine("Invalid input. Proceeding to Main Menu...");
                    inputNameAgain = true;
                    Thread.Sleep(500);
                }
            }
        }
        static bool ExitProgram(String fullname, String CourseYearSection, String SubjectCodeDescription, bool exitChoice)
        {
            Console.Clear();
            for(int i = 0;i <= 5; i++) 
            {
                Console.WriteLine("");
            }

            CenterText(fullname);
            CenterText(CourseYearSection);
            CenterText(SubjectCodeDescription);

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("");
            }

            Thread.Sleep(5000);
            CenterText("Thankyou rAwR");
            return true;

        }
        static void CenterText(string text)
        {
            int width = Console.WindowWidth;
            int spaces = (width - text.Length) / 2;
            Console.WriteLine(new string(' ', spaces) + text);
        }
    }
}