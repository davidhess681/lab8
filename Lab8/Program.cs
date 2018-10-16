using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        // declare these variables here to use them in multiple methods
        static int userInput;
        static int toIndex;
        static string userQuestion;

        static void Main(string[] args)
        {
            // create array of students and their favorite season/color
            string[,] studentInfo = new string[19, 3];
            PopulateArray(studentInfo);

            Console.WriteLine("Welcome to our C# class!!");

            do
            {
                Console.WriteLine("\nWhich student would you like to learn more about?");
                Console.Write("(enter a number 1-19): ");

                // use GetStudentName to get the name at the specified index (send studentInfo so we can play with it within the method)
                string currnetName = GetStudentName(studentInfo);

                Console.WriteLine("\nStudent {0} is {1}. What would you like to know about {1}?", userInput, currnetName);
                Console.Write("(enter 'favorite season' or 'favorite color'): ");

                // use GetStudentInfo to return either the student's favorite season or favorite color
                string info = GetStudentInfo(studentInfo);

                Console.WriteLine("\n{0}'s favorite {1} is {2}. Would you like to learn about a different student?", currnetName, userQuestion, info);
                Console.Write("(y/n): ");
            }
            while (PlayAgain());
        }
        static void PopulateArray(string[,] studentInfo)
        {
            // assign a name to each row in the first column
            studentInfo[0, 0] = "Andrea";
            studentInfo[1, 0] = "Anthony";
            studentInfo[2, 0] = "Brian";
            studentInfo[3, 0] = "Camille";
            studentInfo[4, 0] = "Clayton";
            studentInfo[5, 0] = "Damacious";
            studentInfo[6, 0] = "David";
            studentInfo[7, 0] = "Evan";
            studentInfo[8, 0] = "Heather";
            studentInfo[9, 0] = "Jacky";
            studentInfo[10, 0] = "Johnathan";
            studentInfo[11, 0] = "Katie";
            studentInfo[12, 0] = "Levi";
            studentInfo[13, 0] = "Mauricio";
            studentInfo[14, 0] = "Nicholas";
            studentInfo[15, 0] = "Rudy";
            studentInfo[16, 0] = "SeanO";
            studentInfo[17, 0] = "Steve";
            studentInfo[18, 0] = "Ty";

            // seasons for second column
            studentInfo[0, 1] = "Winter";
            studentInfo[1, 1] = "Spring";
            studentInfo[2, 1] = "Summer";
            studentInfo[3, 1] = "Fall";
            studentInfo[4, 1] = "Winter";
            studentInfo[5, 1] = "Spring";
            studentInfo[6, 1] = "Summer";
            studentInfo[7, 1] = "Fall";
            studentInfo[8, 1] = "Winter";
            studentInfo[9, 1] = "Spring";
            studentInfo[10, 1] = "Summer";
            studentInfo[11, 1] = "Fall";
            studentInfo[12, 1] = "Winter";
            studentInfo[13, 1] = "Spring";
            studentInfo[14, 1] = "Summer";
            studentInfo[15, 1] = "Fall";
            studentInfo[16, 1] = "Winter";
            studentInfo[17, 1] = "Spring";
            studentInfo[18, 1] = "Summer";

            // colors for third column
            studentInfo[0, 2] = "Red";
            studentInfo[1, 2] = "Orange";
            studentInfo[2, 2] = "Yellow";
            studentInfo[3, 2] = "Green";
            studentInfo[4, 2] = "Blue";
            studentInfo[5, 2] = "Indigo";
            studentInfo[6, 2] = "Purple";
            studentInfo[7, 2] = "Red";
            studentInfo[8, 2] = "Orange";
            studentInfo[9, 2] = "Yellow";
            studentInfo[10, 2] = "Green";
            studentInfo[11, 2] = "Blue";
            studentInfo[12, 2] = "Indigo";
            studentInfo[13, 2] = "Purple";
            studentInfo[14, 2] = "Red";
            studentInfo[15, 2] = "Orange";
            studentInfo[16, 2] = "Yellow";
            studentInfo[17, 2] = "Green";
            studentInfo[18, 2] = "Blue";

            // I made up all the data LOLOL
        }

        static string GetStudentName(string[,] studentInfo)
        {
            try
            {
                // set user input to a variable
                userInput = int.Parse(Console.ReadLine());

                // user's number is one more than the index they are looking for, so we correct it here
                toIndex = userInput - 1;

                // return the name at the specified index
                return studentInfo[toIndex, 0];
            }
            catch (IndexOutOfRangeException)
            {
                // if user input is outside of the range of the array, we use recursion to give the user another try
                Console.Write("That student doesn't exist. Try again: ");
                return GetStudentName(studentInfo);
            }
            catch (FormatException)
            {
                // if user input is not an integer, we use recursion to give the user another try
                Console.Write("Not an integer. Try again: ");
                return GetStudentName(studentInfo);
            }
        }

        static string GetStudentInfo(string[,] studentInfo)
        {
            // set user input to a variable
            userQuestion = Console.ReadLine();

            // check if user input is either "season" or "favorite season" (for user-friendly-ness)
            if (userQuestion == "favorite season" || userQuestion == "season")
            {
                // for consistency in the upcoming Console.WriteLine
                userQuestion = "season";

                // return the season corresponding to the current student
                return studentInfo[toIndex, 1];
            }
            // check if user input is either "color" or "favorite color"
            else if (userQuestion == "favorite color" || userQuestion == "color")
            {
                // for consistency in the upcoming Console.WriteLine
                userQuestion = "color";

                // return the color corresponding to the current student
                return studentInfo[toIndex, 2];
            }
            else
            {
                // use recursion to try again
                Console.Write("That data does not exist. Try again: ");
                return GetStudentInfo(studentInfo);
            }
        }

        static bool PlayAgain()
        {
            // repeat the program if user types "y", close if "n"
            switch (Console.ReadLine())
            {
                case "y":
                    {
                        return true;
                    }
                case "n":
                    {
                        return false;
                    }
                default:
                    {
                        Console.Write("Invalid. Try again: ");
                        return PlayAgain();
                    }
            }
        }
    }
}
