// Array to hold names


string[] names = {
            "Justin", "Ethan", "Victoria", "Ethan", "Ben",
            "Kyra", "Jack", "Ramses", "Clare", "Ramsey",
            "Ali", "Pedro", "Mellisa"
        };

// Array to hold favorite foods
string[] favoriteFoods = {
            "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs",
            "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum",
            "Indian", "Italian", "Pizza"
        };

// Array to hold hometowns
string[] hometowns = {
            "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham",
            "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn",
            "Dearborn Heights", "Chicago", "Detroit"
        };
//loop program
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("What student would you like to know about? Please enter a number 1-13 or to see a list of students enter 0.");

    //getting user input as an int
    int numChoice = int.Parse(Console.ReadLine());
   
        
       
        //validate user number

        if (numChoice < 0 || numChoice > names.Length)
        {
            Console.WriteLine("Please enter a num between 1-11");
            continue;
        }
        else if (numChoice == 0)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]}");
            }
            continue;

        }
        else
        {
            Console.Write($"Student {numChoice} is {names[numChoice - 1]}. ");

               
            bool learnabout = true;
            while (learnabout)
            {
                //hometown or food
                Console.Write("Would you like to learn about their Hometown or Favorite Food? ");
                string learn = Console.ReadLine().ToLower().Trim();
                //validate category 
                if ("hometown".Contains(learn))
                {
                    Console.WriteLine($"{names[numChoice - 1]} is from {hometowns[numChoice - 1]}.");
                    learnabout = false;
                    break;

                }
                else if ("favorite food".Contains(learn))
                {
                    Console.WriteLine($"{names[numChoice - 1]}'s favorite food is {favoriteFoods[numChoice - 1]}.");
                    learnabout = false;
                    break;

                }
                else
                {
                    Console.WriteLine("That category does not exist. Please try gain");
                }
            }
        }




    //get out of loop
    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string yn = Console.ReadLine().ToLower().Trim();
        if (yn == "y")
        {
            break;
        }
        else if (yn == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input. Please try again");
        }
    }
}