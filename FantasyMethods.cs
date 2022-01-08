using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCharacterNameGenerator
{
    public class FantasyMethods
    {
        //          0       1         2        3        4       5      6        7        8         9
        public string[] femaleFirstNames = new string[]
             { "Misty", "Willow", "Piper", "Silvyr", "Talia", "Aura", "Luna", "Nyssa", "Elysse", "Leafa" };
        public string[] maleFirstNames = new string[]
             { "Wen", "Elwin", "Caldor", "Dray", "Galdeen", "Sulfa", "Vyn", "Zorion", "Jackzl", "Temley" };
        public string[] neutralFirstNames = new string[]
             { "Axil", "Ragna", "Zika", "Soril", "Sterling", "Twindle",  "Dorath", "Pondra", "Laken", "Kelza"  };
        public string[] allLastNames = new string[]
             { "Amberhide", "Autumnbow", "Duskbloom", "Embershadow", "Feathersworn", "Slatemoore", "Skymeaden", "Winddane", "Whispercrest", "Riversforde" };
        //          0            1            2             3               4             5             6            7             8             9
        public string[] colorOptions = new string[]
             { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink", "White", "Black", "Multi/Tye-Dye" };
        public string[] creatureOptions = new string[]
             {"Unicorn", "Dragon", "Griffin", "Kitsune", "Cerberus", "Sphinx", "Chimera", "Phoenix", "Hydra", "Chupacabra"};
        //{"Frosted Flakes", "Lucky Charms", "Cocoa Puffs", "Fruit Loops", "Captain Crunch", "Honey Bunches of Oats", "Cheerios", "Cinnamon Toast Crunch", "Shredded Wheat", "Other (I'm a unique snowflake)" };

        public void PrintColorOptions()
        {
            for (int i = 0; i < colorOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{colorOptions[i]}"); //numbers each as it's printed, starting at 1 (not 0 for user experience)
            }
            Console.WriteLine("Or you can press Q to Quit.");
        }

        public void PrintCreatureOptions()
        {
            for (int i = 0; i < creatureOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{creatureOptions[i]}"); //numbers each as it's printed, starting at 1 (not 0 for user experience)
            }
            Console.WriteLine("Or you can press Q to Quit.");
        }
        public string GetFirstName(string genderLetter, int colorNumber)
        {
            string returnFirstName = "";
            if(colorNumber == -1)
            {
                Console.WriteLine("Error reading color selection.");
            }
            else if(genderLetter == "F")
            {
                returnFirstName = femaleFirstNames[colorNumber - 1];
            }
            else if(genderLetter == "M")
            {
                returnFirstName = maleFirstNames[colorNumber - 1];
            }
            else //if genderLetter == "N"
            {
                returnFirstName = neutralFirstNames[colorNumber - 1];
            }
            return returnFirstName;
        }

        public string GetLastName(string genderLetter, int creatureNumber)
        {
            //select corresponding name from allLastNames as per user input-accessed via array index[0]
            string returnLastName = "";
            if (creatureNumber == -1)
            {
                Console.WriteLine("Error reading creature selection.");
            }
            else
            {
                returnLastName = allLastNames[creatureNumber - 1];
            }
            return returnLastName;
        }

        public string GetGenderWord(string genderLetter)
        {
            //convert gender letter to full word for retur message printed out below
            string characterGenderFullWord = "";
            if (genderLetter == "F")
            {
                characterGenderFullWord = "female";
            }
            else if (genderLetter == "M")
            {
                characterGenderFullWord = "male";
            }
            else if (genderLetter == "N")
            {
                characterGenderFullWord = "neutral";
            }
            return characterGenderFullWord;
        }

    } //end of class
}
