using System;
using System.Threading.Tasks;
using System.Threading;

namespace FantasyCharacterNameGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            FantasyMethods fantasyMethods = new FantasyMethods(); //instance of the methods class to get access to its methods
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear(); //required to make entire background the color
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(@"                             .\^/.          ");
            Console.WriteLine(@"                           . |`|/| .        ");
            Console.WriteLine(@"                           |\|\|'|/|        ");
            Console.WriteLine(@"                        .--'-\`|/-''--.     ");
            Console.WriteLine(@"                         \`-._\|./.- '/     ");
            Console.WriteLine(@"                         >`-._ |/.- '<      ");
            Console.WriteLine(@"                         '~|/~~|~~\|~'      ");
            Console.WriteLine(@"                               |            ");

            Console.WriteLine("Welcome to Emeraldine Woodleave's Fantasy Character Name Generator!");
            Thread.Sleep(3000); //delays the script for 3 seconds in btwn so they don't appear all at once-Task.Delay
            Console.WriteLine("");
            Console.WriteLine("To get started, please select the gender you'd like the character name to be:");
            Console.WriteLine("Enter 'F' for female, 'M' for male, 'N' for neutral, or enter 'Q' to quit.");

            string genderInput = "";
            while (genderInput.ToUpper() != "Q")
            {
                genderInput = Console.ReadLine();

                if (genderInput.ToUpper() == "F" || genderInput.ToUpper() == "M" || genderInput.ToUpper() == "N")
                {
                    break; //break out of while loop & move on to next question & user input
                }
                else if (genderInput.ToUpper() == "Q")
                {
                    Environment.Exit(0); //exit the console application
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("**Invalid option. Please enter 'F', 'M', or 'N'. Or you can enter 'Q' to Quit.**");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine("");
            Console.WriteLine("**Please select the color of the cloak...er, I mean shirt...that you're wearing today.**");
            fantasyMethods.PrintColorOptions(); //loops through & prints each color & corresponding # choice
            string colorInput = "";
            int numberOfColor = -1;

            while (colorInput.ToUpper() != "Q")
            {
                colorInput = Console.ReadLine();
                try
                {
                    numberOfColor = int.Parse(colorInput);
                    if(numberOfColor > 10 || numberOfColor < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("**Invalid option. Please enter a number from the above list corresponding to your selected color.**");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else //if input is a number btwn 1-10
                    {
                        break; //break out of while loop & move on to next question & user input
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("**Invalid option. Please enter a number from the above list corresponding to your selected color.**");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            if (colorInput.ToUpper() == "Q")
            {
                Environment.Exit(0); //exit the console application
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();
            Console.WriteLine("**Please select your favorite mythical creature from below.**");
            Console.WriteLine("This list is nowhere near all inclusive, so I apologize if your familiar is not in the list;");
            Console.WriteLine("Emeraldine loves and supports all fantastical animals!");
            Console.WriteLine();
            fantasyMethods.PrintCreatureOptions();
            string creatureInput = "";
            int numberOfCreature = -1;
            while (creatureInput.ToUpper() != "Q")
            {
                creatureInput = Console.ReadLine();
                try
                {
                    numberOfCreature = int.Parse(creatureInput);
                    if (numberOfCreature > 10 || numberOfCreature < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("**Invalid option. Please enter a number from the above list corresponding to your selected creature.**");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else //if input is a number btwn 1-10
                    {
                        break; //break out of while loop & move on to next action
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("**Invalid option. Please enter a number from the above list corresponding to your selected creature.**");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            if (creatureInput.ToUpper() == "Q")
            {
                Environment.Exit(0); //exit the console application
            }

            Console.WriteLine("");
            Console.WriteLine("Wonderful, thank you kindly. Give the computer one moment to peruse the fantasy worlds.");
            Thread.Sleep(2000); //delays the script for 2 seconds
            Console.WriteLine("");
            Console.WriteLine("In the meantime, here's a joke to make you chuckle:");
            Console.WriteLine("Why does the dragon only sleep during the day?...");
            Thread.Sleep(2000); //delays the script for 2 seconds
            Console.WriteLine("...");
            Thread.Sleep(4000); //delays the script for 4 seconds
            Console.WriteLine("Because it hunts knights! :D ");
            Thread.Sleep(3000); //delays the script for 3 seconds
            //takes above inputs and passes them into the methods to get first & last name based on user's selections
            string characterFirstName = fantasyMethods.GetFirstName(genderInput.ToUpper(), numberOfColor);
            string characterLastName = fantasyMethods.GetLastName(genderInput.ToUpper(), numberOfCreature);
            string characterGenderFullWord = fantasyMethods.GetGenderWord(genderInput.ToUpper());

            Console.WriteLine("");
            Console.WriteLine("Ok we searched every fantasy world we know of to create the perfect name for you!");
            Console.WriteLine($"Your new {characterGenderFullWord} fantasy character name is: **{characterFirstName} {characterLastName}**");
            Thread.Sleep(4000);//delays the script for 4 seconds
            Console.WriteLine("");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("If you'd like to generate another name, hit Enter. Otherwise, you can hit 'Q' to quit.");
            Console.WriteLine("");
            //Console.Clear();


        }  //end of static main
    }
}
