




/*string? user;
do
{
    // Display the menu options
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine("1. List all of our current pet information");
    Console.WriteLine("2. Display all dogs with a specified characteristic");
    Console.WriteLine("Enter your selection number (or type 'Exit' to exit the program):");

    // Read user input
    user = Console.ReadLine();

    // Handle different user input cases
    if (user == "1")
    {
        Console.WriteLine("Listing all of our current pet information...");
        // Here you can display actual pet information
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for user to press Enter
    }
    else if (user == "2")
    {
        Console.WriteLine("Enter one desired dog characteristic to search for:");
        string? characteristic = Console.ReadLine();
        Console.WriteLine($"Displaying dogs with the characteristic: {characteristic}");
        // Here you can add code to filter and display dogs based on characteristic
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for user to press Enter
    }
    else if (user?.ToLower() != "exit")
    {
        // Handle invalid input
        Console.WriteLine("Invalid selection. Please enter 1, 2, or type 'Exit' to exit.");
    }

} while (user?.ToLower() != "exit"); // Keep running the menu until the user types "Exit"*/

// #1 the ourAnimals array will store the following: 

// Variables to store animal attributes
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
//#6 Add support for suggested donation data
string suggestedDonation = "";
//#10 Combine the dog descriptions to make it easier to search
string dogDescription = "";

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// #8 declare decimalDonation
decimal decimalDonation = 0.00m;

bool noMatchesDog = true;

// #3 array used to store runtime data, there is no persisted data
// #7 Update ourAnimals array to hold 7 "columns" of data for each animal instead of 6.
//string[,] ourAnimals = new string[maxPets, 6];
string[,] ourAnimals = new string[maxPets, 7];

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "Medium sized cream-colored female golden retriever weighing about 45 pounds. Housebroken.";
            animalPersonalityDescription = "Loves to have her belly rubbed and likes to chase her tail. Gives lots of kisses.";
            animalNickname = "Lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "Large reddish-brown male golden retriever weighing about 85 pounds. Housebroken.";
            animalPersonalityDescription = "Loves to have his ears rubbed when he greets you at the door. Loves to lean in and give doggy hugs.";
            animalNickname = "Gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "3";
            animalPhysicalDescription = "Small black and white male cat, about 10 pounds.";
            animalPersonalityDescription = "Likes to nap in the sun and play with string toys.";
            animalNickname = "Whiskers";
            suggestedDonation = "40.00";
            break;


        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "4";
            animalPhysicalDescription = "Large, gray female cat with green eyes.";
            animalPersonalityDescription = "Curious and loves to explore new spaces.";
            animalNickname = "Shadow";
            suggestedDonation = ""; // No suggested donation
            break;


        // Default case for uninitialized entries
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = ""; // No suggested donation
            break;
    }

    // #8 part [1]
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }

    // Populate `ourAnimals` array with the animal data and suggested donation
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    //ourAnimals[i, 6] = "Suggested Donation: $" + suggestedDonation;
    // #8 part[2]
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // Skip uninitialized entries
                    if (string.IsNullOrWhiteSpace(ourAnimals[i, 0])) continue;

                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)//update to 7 or // increased exit condition
                    {
                        if (!string.IsNullOrWhiteSpace(ourAnimals[i, j]))
                            Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Display all dogs with a specified characteristic");
            // #9 delete below comment code and update code with new logic
            // Console.WriteLine("\nUNDER CONSTRUCTION - please check back next month to see progress.");

           Console.WriteLine("\nEnter one characteristic to search for:");
            readResult = Console.ReadLine();
            string dogCharacteristic = readResult?.ToLower().Trim() ?? "";

            // Handle null or empty input for characteristic
            if (string.IsNullOrEmpty(dogCharacteristic))
            {
                Console.WriteLine("No characteristic entered. Please enter a valid characteristic next time.");
                break;
            }

            noMatchesDog = true;

            // Search and display matching dogs
            for (int i = 0; i < maxPets; i++)
            {
                //#10
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    dogDescription = ourAnimals[i, 4].ToLower() + " " + ourAnimals[i, 5].ToLower();
                    
                    if (dogDescription.Contains(dogCharacteristic))
                    {
                        Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                        Console.WriteLine(ourAnimals[i, 4]);
                        Console.WriteLine(ourAnimals[i, 5]);
                        noMatchesDog = false;
                    }
                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }

            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        

        default:
            break;
    }


} while (menuSelection != "exit");