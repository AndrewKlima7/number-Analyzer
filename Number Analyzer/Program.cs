using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am Computer what is your name? ");
            string userName = Console.ReadLine();
            bool again = true; 
            while(again == true)
            {
                bool correctNum = false;
                while(correctNum == false)
                {
                    Console.WriteLine($"{userName} please pick a number between 1 and 100");
                    string num = Console.ReadLine();
                    int userNum = int.Parse(num);
                    
                    if (userNum < 1 || userNum > 100)
                    {
                        Console.WriteLine($"{userName} that is not a valid number");
                        Console.WriteLine();
                        correctNum = false;
                    }
                    else if (userNum % 2 == 0 && userNum >= 2 && userNum <= 25)
                    {
                        Console.WriteLine($"{userName} The number you picked is {userNum} is even and is less than 25");
                        correctNum = true;
                    }
                    else if (userNum % 2 == 0 && userNum >= 26 && userNum <= 60)
                    {
                        Console.WriteLine($"{userName} The number you picked is even");
                        correctNum = true;
                    }
                    else if (userNum % 2 == 0 && userNum > 60)
                    {
                        Console.WriteLine($"{userName}, your number is {userNum} and is even.");
                        correctNum = true;
                    }
                    else if (userNum % 2 == 1 && userNum > 60)
                    {
                        Console.WriteLine($"{userName} your number is {userNum} and is odd.");
                        correctNum = true;
                    }
                    else if (userNum % 2 == 1)
                    {
                        Console.WriteLine($"{userName} the number you pick is {userNum} and is odd.");
                        correctNum = true;
                    }

                }
                
                again = GetCont();
            }

           

        }

        
        public static bool GetCont()
        {
            Console.WriteLine("Want to play again? Y/N ");
            string userInput = Console.ReadLine();

            if(userInput.ToUpper() == "Y" || userInput.ToUpper().Contains("YES"))
            {
                Console.WriteLine("Lets go!");
                return true;
            } 
            else if (userInput.ToUpper() == "N" || userInput.ToUpper().Contains("NO"))
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid response");
                return GetCont();
            }
        }

    }


}
