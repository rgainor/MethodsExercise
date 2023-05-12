namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Story();
            var sum = AddNums(1, 2);
            Console.WriteLine(sum);
            subtractNums(5, 2);
            multiplyNums(2, 2);
            divideNums(4, 2);
            modulusNums(5, 3);

            Console.ReadKey();
        }

        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"Hello, my name is {name}. My favorite color is {favoriteColor}. My favorite animal is {favoriteAnimal}. My favorite band is {favoriteBand}.");
        }

        public static int AddNums(int num1, int num2)
        {
            int addNums = num1 + num2;
            return addNums;          
        }

        public static int subtractNums(int num1, int num2)
        {
            int subtractNums = num1 - num2;
            return subtractNums;
        }

        public static int multiplyNums(int num1, int num2)
        {
            int multiplyNums = num1 * num2;
            return multiplyNums;
        }

        public static int divideNums(int num1, int num2)
        {
            int divideNums = num1 / num2;
            return divideNums;
        }

        public static int modulusNums(int num1, int num2)
        {
            int modulusNums = num1 / num2;
            return modulusNums;
        }
    }
}

    

