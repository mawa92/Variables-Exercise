namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName;

            dogName = "Piglet";

            int dogAge = 5;

            char firstInitial = 'P';

            bool isHappy = true;

            double dogWeight = 38.5;

            decimal dogHeight = 12.5m;


            Console.WriteLine($"Hello. My dog's name is {dogName}, his inital is {firstInitial} and he is {dogAge} years old.");
            Console.WriteLine($"He weighs {dogWeight} pounds and he is {dogHeight} inches tall);
            Console.WriteLine($"It is {isHappy} he is always happy!");
        }
    }
}
