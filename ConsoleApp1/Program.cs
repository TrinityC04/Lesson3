namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string filePath = @"C:\Users\TrinityC\source\repos\Lesson3";
            Console.WriteLine(filePath);

            string sentenceOne = "Hello There, \"This is the sentence.\"";
            Console.WriteLine(sentenceOne);

            string sentenceTwo = "This is the two line message\nNow this is the next line";
            Console.WriteLine(sentenceTwo);


            //2
            Console.Write("Type a command (Add, Remove, Quit): ");
            string command = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

            if (command == "ADD")
            {
                Console.WriteLine("You chose ADD.");
            }
            else if (command == "REMOVE")
            {
                Console.WriteLine("You chose REMOVE.");
            }
            else if (command == "QUIT")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Unknown command.");
            }


            //3
            Console.Write("Enter age: ");
            string ageInput = Console.ReadLine() ?? "";

            if (int.TryParse(ageInput, out int age))
            {
                if (age < 18)
                {
                    Console.WriteLine("Minor");
                }
                else
                {
                    Console.WriteLine("Adult");
                }
            }
            else
            {
                Console.WriteLine("Not valid whole number!");
            }


            //4
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine() ?? "0");

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num1} is the largest number.");
                }
                else
                {
                    Console.WriteLine($"{num3} is the largest number.");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num2} is the largest number.");
                }
                else
                {
                    Console.WriteLine($"{num3} is the largest number.");
                }
            }

        }
    }
}
