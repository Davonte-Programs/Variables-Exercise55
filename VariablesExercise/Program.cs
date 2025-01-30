namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dmName = "The Dungeon Master";

            int dmLevel = 100;

            char dmClan = 'X';

            bool dmStart = true;

            double dmMovement = 25.5;

            decimal dmhealth = 1000.00m;

            string message = $"I am {dmName},a level {dmLevel} Warlock,of the {dmClan} clan. " +
                             $"You wish to begin this quest, This is {dmStart}?";

            Console.WriteLine(message);

            Console.WriteLine("Who is the leader of this quest?");

            string userResponseName = Console.ReadLine();

            Console.WriteLine($"Welcome {userResponseName}!");

            Console.WriteLine("What kind of adventurer are you, what is your class?");

            string userResponseClass = Console.ReadLine();

            Console.WriteLine($"Ahh, its been a long time since ive seen a {userResponseClass}!" +
                              $" Surely you are powerful, what level {userResponseClass} are you?");

            string userResponseLevel = Console.ReadLine();

            Console.WriteLine($"Level {userResponseLevel}! You are Powerful! I deem you worthy to begin this Quest!" +
                              $" Will you Poceed (Yes/No)?");

            string StartQuest = Console.ReadLine().ToLower();
            
            //added toLower to remove capitalization inconsistencies with answers

            if (StartQuest == "yes" || StartQuest == "sure") 
                Console.WriteLine("Let the adventure begin!");
            else if (StartQuest == "no" || StartQuest == "no thanks")
                Console.WriteLine("Understanable! Prehaps a nap first!");
            // add || or functions to accomodate some other answers
            // accomodate expected answers Yes, yes, No, no. 
            
            
            
        }
    }
}
