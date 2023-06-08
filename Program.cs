
using System;
using System.Collections.Generic;

/*
Phase 1
Print the message "Plan Your Heist!".
Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
Prompt the user to enter a team member's name and save that name.
Prompt the user to enter a team member's skill level and save that skill level with the name.
Prompt the user to enter a team member's courage factor and save that courage factor with the name.
Display the team member's information.
*/

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Plan Your Heist!");

//         // Create variables to store team member information
//         string name;
//         int skillLevel;
//         double courageFactor;

//         // Prompt the user for team member's name
//         Console.Write("Enter a team member's name: ");
//         name = Console.ReadLine();


//         while (true)
//         {
//             // Prompt the user for team member's skill level
//             while (true)
//             {


//                 try //utilizing to catch wrong format error ie. user enters a decimal 2.0 vs int 2
//                 {
//                     Console.Write("Enter a team member's skill level (positive integer): ");

//                     skillLevel = int.Parse(Console.ReadLine());

//                     if (skillLevel < 0)
//                     {
//                         Console.WriteLine("Skill level must be a positive number!");
//                         continue;// restarts loop/next iteration vs. running the next line of code
//                     }
//                     break;
//                 }
//                 catch
//                 {

//                     Console.WriteLine("Wrong format. Must be an integer");
//                     continue;
//                 }
//             }

//             while (true)
//             {

//                 // Prompt the user for team member's courage factor
//                 Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
//                 courageFactor = double.Parse(Console.ReadLine());

//                 if (courageFactor < 0.0 || courageFactor > 2.0)
//                 {
//                     Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
//                     continue;
//                 }

//                 break; // Break the inner loop when a valid courage factor is entered so that I can stop asking prompt

//             }

//             break; // Break out to the outer loop when both skill level and courage factor are entered correctly; so can start giving the 3 prompt again for user to add more team mates
//         }


//         // Display the team member's information
//         Console.WriteLine("\nTeam Member Information:");
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("Skill Level: " + skillLevel);
//         Console.WriteLine("Courage Factor: " + courageFactor);

//         // Wait for user input before closing the console window
//         Console.WriteLine("\nPress any key to exit...");
//         //used to wait for the user to press any key before exiting the program.
//         Console.ReadKey();
//     }
// }

/*
Phase 2
Print the message "Plan Your Heist!".
Create a way to store several team members.
Collect several team members' information.
Stop collecting team members when a blank name is entered.
Display a message containing the number of members of the team.
Display each team member's information.
*/

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Plan Your Heist!");

//         // Create a list to store team member information
//         List<Teammate> listOfTeammates = new List<Teammate>();

//         while (true)
//         {

//             // Prompt the user for team member's information
//             Console.Write("Enter a team member's info: ");

//             // Create variables to store team member information
//             string name;
//             int skillLevel;
//             double courageFactor;

//             Console.WriteLine("\nTo exit program, enter a blank space for name: ");
//             Console.Write("Enter a team member's name: ");
//             name = Console.ReadLine();

//              if (string.IsNullOrWhiteSpace(name)){
//                 Console.Write("Goodbye!");
//                 break;
//             }

//             while (true)//created a loop to continue to give prompt to user until input meets specified condition
//             {

//                 Console.Write("Enter a team member's skill level (positive integer): ");

//                 if (!int.TryParse(Console.ReadLine(), out skillLevel) || skillLevel < 0)
//                 {
//                     Console.WriteLine("Skill level must be a positive number!");
//                     continue;//restarts loop/iteration and gives prompt to user again
//                 }


//                 while (true)
//                 {
//                     // Prompt the user for team member's courage factor
//                     Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
//                     if (!double.TryParse(Console.ReadLine(), out courageFactor) || courageFactor < 0.0 || courageFactor > 2.0)
//                     {
//                         Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
//                         continue;
//                     }

//     break; // Break the inner loop when a valid courage factor is entered so that I can access outer loop

// }

// break; // Break the outer loop when both skill level and courage factor are entered correctly; must break since while loop is an infinite loop
//             }

//             //instantiate Teammate class

//             Teammate teammate = new Teammate(name, skillLevel, courageFactor);

//             listOfTeammates.Add(teammate);
//         }
//         // Wait for user input before closing the console window
//         Console.WriteLine("\nPress any key to exit...");
//         //used to wait for the user to press any key before exiting the program.
//         Console.ReadKey();

//  // Display the team member's information
//         Console.WriteLine("\nTeam Member Information:");
//         Console.WriteLine($"Number of Teammater: {listOfTeammates.Count()}");

//         foreach (var singleTeammate in listOfTeammates)
//         {
//             Console.WriteLine($"Name:{singleTeammate.Name}, Skill Level: {singleTeammate.SkillLevel}, Courage Factor: {singleTeammate.CourageFactor}");
//         }
//     }
// }

// /*
// Phase 3
// Stop displaying each team member's information.
// Store a value for the bank's difficulty level. Set this value to 100.
// Sum the skill levels of the team. Save that number.
// Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
// */

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Plan Your Heist!");

//         // Create a list to store team member information
//         List<Teammate> listOfTeammates = new List<Teammate>();
//         int bankDifficultyLevel = 100;

//         while (true)
//         {

//             // Prompt the user for team member's information
//             Console.WriteLine("\nTo exit program, enter a blank space for name: ");
//             Console.Write("Enter a team member's info: ");

//             // Create variables to store team member information
//             string name;
//             int skillLevel;
//             double courageFactor;


//             Console.Write("Enter a team member's name: ");
//             name = Console.ReadLine();

//              if (string.IsNullOrWhiteSpace(name)){
//                 Console.Write("Goodbye!");
//                 break;
//             }

//             while (true)//created a loop to continue to give prompt to user until input meets specified condition
//             {

//                 Console.Write("Enter a team member's skill level (positive integer): ");

//                 if (!int.TryParse(Console.ReadLine(), out skillLevel) || skillLevel < 0)
//                 {
//                     Console.WriteLine("Skill level must be a positive number!");
//                     continue;//restarts loop/iteration and gives prompt to user again
//                 }


//                 while (true)
//                 {
//                     // Prompt the user for team member's courage factor
//                     Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
//                     if (!double.TryParse(Console.ReadLine(), out courageFactor) || courageFactor < 0.0 || courageFactor > 2.0)
//                     {
//                         Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
//                         continue;
//                     }

// break; // Break the inner loop when a valid courage factor is entered so that I can stop asking prompt

//             }

//             break; // Break out to the outer loop when both skill level and courage factor are entered correctly; so can start giving the 3 prompt again for user to add more team mates
//             }

//             //instantiate Teammate class

//             Teammate teammate = new Teammate(name, skillLevel, courageFactor);

//             listOfTeammates.Add(teammate);
//         }
//         // Wait for user input before closing the console window
//         Console.WriteLine("\nPress any key to exit...");
//         //used to wait for the user to press any key before exiting the program.
//         Console.ReadKey();

//  // Display the team member's information
//         Console.WriteLine("\nTeam Member Information:");
//         Console.WriteLine($"Number of Teammater: {listOfTeammates.Count()}");

//         int sumSkillLevel = 0;
//         foreach (var singleTeammate in listOfTeammates)
//         {
//             sumSkillLevel += singleTeammate.SkillLevel;

//         }

//         if (sumSkillLevel >= bankDifficultyLevel){
//             Console.WriteLine("Success! You got the Moolah!");
//         }
//         else
//         {
//             Console.WriteLine("Darn! Poor little jailbirds! You got Caught!");
//         }
//     }
// }

/*
Phase 4
The program should be updated to...

Create a random number between -10 and 10 for the heist's luck value.
Add this number to the bank's difficulty level.
Before displaying the success or failure message, display a report that shows.
The team's combined skill level
The bank's difficulty level
*/

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Plan Your Heist!");

//         // Create a list to store team member information
//         List<Teammate> listOfTeammates = new List<Teammate>();
//         int bankDifficultyLevel = 100;

//         // Create an instance of the Random class from the .NET framework
//         Random randomNumber = new Random();

//         // Generate a random number between -10 and 10; Next method takes two arguments: the inclusive lower bound and the exclusive upper bound
//         int heistLuck = randomNumber.Next(-10, 11);


//         while (true)
//         {

//             // Prompt the user for team member's information
//             Console.WriteLine("\nTo exit program, enter a blank space for name: ");
//             Console.Write("Enter a team member's info: ");

//             // Create variables to store team member information
//             string name;
//             int skillLevel;
//             double courageFactor;


//             Console.Write("Enter a team member's name: ");
//             name = Console.ReadLine();

//             if (string.IsNullOrWhiteSpace(name))
//             {
//                 Console.Write("Goodbye!");
//                 break; //break out of the outer loop= exit the program
//             }

//             while (true)//created a loop to continue to give prompt to user until input meets specified condition
//             {

//                 Console.Write("Enter a team member's skill level (positive integer): ");

//                 if (!int.TryParse(Console.ReadLine(), out skillLevel) || skillLevel < 0)
//                 {
//                     Console.WriteLine("Skill level must be a positive number!");
//                     continue;//restarts loop/iteration and gives prompt to user again
//                 }


//                 while (true)
//                 {
//                     // Prompt the user for team member's courage factor
//                     Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
//                     if (!double.TryParse(Console.ReadLine(), out courageFactor) || courageFactor < 0.0 || courageFactor > 2.0)
//                     {
//                         Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
//                         continue;
//                     }

//                     break; // Break the inner loop when a valid courage factor is entered so that I can stop asking prompt

//                 }

//                 break; // Break out to the outer loop when both skill level and courage factor are entered correctly; so can start giving the 3 prompt again for user to add more team mates
//             }

//             //instantiate Teammate class

//             Teammate teammate = new Teammate(name, skillLevel, courageFactor);

//             listOfTeammates.Add(teammate);
//         }
//         // Wait for user input before closing the console window
//         Console.WriteLine("\nPress any key to exit...");
//         //used to wait for the user to press any key before exiting the program.
//         Console.ReadKey();

//         // Display the team member's information
//         Console.WriteLine("\nTeam Member Information:");

//         //loop through array holding teammates and add up their skill level
//         int sumSkillLevel = 0;

//         foreach (var singleTeammate in listOfTeammates)
//         {
//             sumSkillLevel += singleTeammate.SkillLevel;

//         }

//         //Print for user the team's skill level and bank level
//         Console.WriteLine($" Total Skill Level: {sumSkillLevel}");
//         Console.WriteLine($" Bank Difficulty Level: {bankDifficultyLevel + heistLuck}");


//         if (sumSkillLevel >= bankDifficultyLevel)
//         {
//             Console.WriteLine("Success! You got the Moolah!");
//         }
//         else
//         {
//             Console.WriteLine("Darn! Poor little jailbirds! You got Caught!");
//         }
//     }
// }

/*
Phase 5
The program should be updated to...

Run the scenario multiple times.
After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
*/

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Plan Your Heist!");

//         // Create a list to store team member information
//         List<Teammate> listOfTeammates = new List<Teammate>();
//         int bankDifficultyLevel = 100;


//         while (true)
//         {

//             // Prompt the user for team member's information
//             Console.WriteLine("\nTo exit program, enter a blank space for name: ");
//             Console.Write("Enter a team member's info: ");

//             // Create variables to store team member information
//             string name;
//             int skillLevel;
//             double courageFactor;


//             Console.Write("Enter a team member's name: ");
//             name = Console.ReadLine();

//             if (string.IsNullOrWhiteSpace(name))
//             {

//                 break; //break out of the outer loop= exit the program
//             }

//             while (true)//created a loop to continue to give prompt to user until input meets specified condition
//             {

//                 Console.Write("Enter a team member's skill level (positive integer): ");

//                 if (!int.TryParse(Console.ReadLine(), out skillLevel) || skillLevel < 0)
//                 {
//                     Console.WriteLine("Skill level must be a positive number!");
//                     continue;//restarts loop/iteration and gives prompt to user again
//                 }


//                 while (true)
//                 {
//                     // Prompt the user for team member's courage factor
//                     Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
//                     if (!double.TryParse(Console.ReadLine(), out courageFactor) || courageFactor < 0.0 || courageFactor > 2.0)
//                     {
//                         Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
//                         continue;
//                     }

//                     break; // Break the inner loop when a valid courage factor is entered so that I can stop asking prompt

//                 }

//                 break; // Break out to the outer loop when both skill level and courage factor are entered correctly; so can start giving the 3 prompt again for user to add more team mates
//             }

//             //instantiate Teammate class

//             Teammate teammate = new Teammate(name, skillLevel, courageFactor);

//             listOfTeammates.Add(teammate);
//         }
//         // Ask user to enter number of heist trials they want their team to try

//         Console.Write("Enter the number of heists you want your Team to attempt: ");
//         int trialNumber = int.Parse(Console.ReadLine());

//         // Display the team member's information
//         Console.WriteLine("\nTeam Member Information:");

//         //loop through array holding teammates and add up their skill level
//         int sumSkillLevel = 0;

//         foreach (var singleTeammate in listOfTeammates)
//         {
//             sumSkillLevel += singleTeammate.SkillLevel;

//         }

//         for (int i = 0; i < trialNumber; i++)
//         {
//             //Move heistLuck within for loop so that each trial gets a new heistLuck value

//             Random randomNumber = new Random();
//             int heistLuck = randomNumber.Next(-10, 11);

//             //Print for user the team's skill level and bank level
//             Console.WriteLine($"Total Skill Level: {sumSkillLevel}");

//             Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel + heistLuck}");

//             // Show a success or failure message
//             if (sumSkillLevel >= bankDifficultyLevel)
//             {
//                 Console.WriteLine("Success! You got the Moolah!");
//             }
//             else
//             {
//                 Console.WriteLine("Darn! Poor little jailbirds! You got Caught!");
//             }
//         }

//         // Wait for user input before closing the console window
//         Console.WriteLine("\nPress any key to exit...");
//         //used to wait for the user to press any key before exiting the program.
//         Console.ReadKey();
//     }
// }

/*
Phase 6
The program should be updated to...

At the beginning of the program, prompt the user to enter the difficulty level of the bank.
At the end of the program, display a report showing the number of successful runs and the number of failed runs.
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");
        Console.WriteLine("To exit program, enter a blank space for name: ");
        // Console.WriteLine();

    int bankDifficultyLevel = 0;
        try
        {
            Console.Write("Enter the bank difficulty level: ");
            bankDifficultyLevel += int.Parse(Console.ReadLine()); 
        }
        catch 
        {
            
            Console.WriteLine("Please enter an integer");
        }    
       

        // Create a list to store team member information
        List<Teammate> listOfTeammates = new List<Teammate>();
       


        while (true)
        {

            // Create variables to store team member information
            string name;
            int skillLevel;
            double courageFactor;


            Console.Write("Enter a team member's name: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {

                break; //break out of the outer loop= exit the program
            }

            while (true)//created a loop to continue to give prompt to user until input meets specified condition
            {

                Console.Write("Enter a team member's skill level (positive integer): ");

                if (!int.TryParse(Console.ReadLine(), out skillLevel) || skillLevel < 0)
                {
                    Console.WriteLine("Skill level must be a positive number!");
                    continue;//restarts loop/iteration and gives prompt to user again
                }


                while (true)
                {
                    // Prompt the user for team member's courage factor
                    Console.Write("Enter a team member's courage factor (between 0.0 and 2.0): ");
                    if (!double.TryParse(Console.ReadLine(), out courageFactor) || courageFactor < 0.0 || courageFactor > 2.0)
                    {
                        Console.WriteLine("Courage factor must be a decimal number between 0.0 and 2.0!");
                        // Console.WriteLine();
                        continue;
                    }

                    break; // Break the inner loop when a valid courage factor is entered so that I can stop asking prompt

                }

                break; // Break out to the outer loop when both skill level and courage factor are entered correctly; so can start giving the 3 prompt again for user to add more team mates
            }

            //instantiate Teammate class

            Teammate teammate = new Teammate(name, skillLevel, courageFactor);

            listOfTeammates.Add(teammate);
        }
        
        // Ask user to enter number of heist trials they want their team to try

        Console.Write("Enter the number of heists you want your Team to attempt: ");
        int trialNumber = int.Parse(Console.ReadLine());

        // Display the team member's information
        Console.WriteLine("\nTeam Member Information:");

        //loop through array holding teammates and add up their skill level
        int sumSkillLevel = 0;

        foreach (var singleTeammate in listOfTeammates)
        {
            sumSkillLevel += singleTeammate.SkillLevel;

        }

        int wins= 0;
        int losses= 0;
        
        for (int i = 0; i < trialNumber; i++)
        {
            //Move heistLuck within for loop so that each trial gets a new heistLuck value

            Random randomNumber = new Random();
            int heistLuck = randomNumber.Next(-10, 11);

            //Print for user the team's skill level and bank level
            Console.WriteLine($"Total Skill Level: {sumSkillLevel}");

            bankDifficultyLevel += heistLuck;
            Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");

            // Show a success or failure message
            if (sumSkillLevel >= bankDifficultyLevel)
            {
              
                wins ++;
                // Console.WriteLine();
            }
            else
            {
                losses ++;
                // Console.WriteLine();
            }
        }

        Console.WriteLine($"The heist was successful {wins} times, and failed {losses} times. ");
        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        //used to wait for the user to press any key before exiting the program.
        Console.ReadKey();
    }
}