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

            string StartQuest = Console.ReadLine();

            if (StartQuest == "Yes") 
                Console.WriteLine("Let the adventure begin!");
            else if (StartQuest == "yes")
                Console.WriteLine("Let the adventure begin!");
            else if (StartQuest == "No")
                Console.WriteLine("Understanable! Prehaps a nap first!");
            else if (StartQuest == "no")
                Console.WriteLine("Understanable! Prehaps a nap first!");
            // Have not reviewed methods yes so this isnt effecient but should work to 
            // accomodate expected answers Yes, yes, No, no. 
        }
    }
}
