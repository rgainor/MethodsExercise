namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();

            // Store and use => int onePlusTwo = Add(1, 2);

            // Just use it:

            Console.WriteLine($"Add: {Add(3, 3)}");
            Console.WriteLine($"Subtract: {Subtract(5, 2)}");
            Console.WriteLine($"Multiply: {Multiply(2, 2)}");
            Console.WriteLine($"Divide: {Divide(4, 2)}");

            Console.WriteLine($"Params Keyword Method: {AddAllNums(1, 1, 1, 1, 1)}");


        }

        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}. What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"Hello, my name is {name}. My favorite color is {favoriteColor}. My favorite animal is {favoriteAnimal}. My favorite band is {favoriteBand}.");
        }

        

        public static int Add(int num1, int num2)
        {
        return num1 + num2;         
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
        return num1 / num2;
        }

        //Bonus
        public static int AddAllNums(params int[] nums)
        {
            int sum = 0;
            foreach(var number in nums)
            {
                sum = sum + number;
            }

            return sum;
            
        }
    }
}

    

