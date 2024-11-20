namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result;
            string cases = "";

            while (cases != "E")
            {
                Console.WriteLine("Press A for Sumation");
                Console.WriteLine("Press B for Substraction");
                Console.WriteLine("Press C for Multiplication");
                Console.WriteLine("Press D for Division ");
                Console.WriteLine("Press E for Exit ");
                Console.WriteLine("=================================");
                Console.WriteLine("Plz Enter the Math operation");
                cases = Console.ReadLine();
                if (cases == "E")
                {
                    break;
                }
                Console.WriteLine("enter first num");
                firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second num");
                secondNumber = int.Parse(Console.ReadLine());

                switch (cases)
                {
                    case "A":
                        Console.WriteLine($" result is : {firstNumber + secondNumber}");
                        break;
                    case "B":
                        Console.WriteLine($" result is : {firstNumber - secondNumber}");
                        break;
                    case "C":
                        Console.WriteLine($" result is : {firstNumber * secondNumber}");
                        break;
                    case "D":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("you cannot divide by Zero");
                        }
                        else
                        {
                            Console.WriteLine($" result is : {firstNumber / secondNumber}");
                        }
                        break;
                    case "E":
                        break;
                    default:
                        Console.WriteLine("invaled input");
                        break;
                }
                Console.WriteLine("=================================");
            }

        }
    }
}
