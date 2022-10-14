namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Variable Declarations
        int age;
        string name;
        bool isAlive;
        char myCharacter;
        decimal myDecimal;
        double myDouble;

        //Variable Initializations
        age = 30;
        name = "Rob";
        isAlive = false;
        myCharacter = 'a';
        myDecimal = 4485.3454m;
        myDouble = 45.5;


            Console.WriteLine($"My name is {name}, I am {age} years old");
            Console.ReadLine();
            
        }
    }
}