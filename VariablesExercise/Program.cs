namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            String dogName = "Jackson";

            int dogAge = 115;

            char firstInitials = 'J';

            bool isHungry = true;

            double dogWeight = 25.23;

            decimal dogHeight = 12.69m;

            Console.WriteLine($"Hello, my dog's name is {dogName} and he is {dogAge} years old.");
            Console.WriteLine($" {dogName}'s initials is {firstInitials} and it is {isHungry.ToString().ToLower()} he is always hungry.");
            Console.WriteLine($" {dogName} weighs about {dogWeight} and stands at about {dogHeight} inches.");
        }
    }
}
