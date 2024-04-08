namespace Calculator
{
    using System;

    class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first operand:");
                double firstOperand;
                if (!double.TryParse(Console.ReadLine(), out firstOperand))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter second operand:");
                double secondOperand;
                if (!double.TryParse(Console.ReadLine(), out secondOperand))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Which operation do you choose (add/substract/multiply/divide/modulo)?");
                string operation = Console.ReadLine().ToLower();

                double result = 0;

                switch (operation)
                {
                    case "add":
                        result = AddFlotants(firstOperand, secondOperand);
                        break;
                    case "substract":
                        result = SubstractFlotants(firstOperand, secondOperand);
                        break;
                    case "multiply":
                        result = MultiplyFlotants(firstOperand, secondOperand);
                        break;
                    case "divide":
                        result = DivideFlotants(firstOperand, secondOperand);
                        break;
                    case "modulo":
                        result = ModuloFlotants(firstOperand, secondOperand);
                        break;
                    default:
                        Console.WriteLine($"Unknown operation \"{operation}\"");
                        continue;
                }

                Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {result}");
            }
        }

        static double AddFlotants(double a, double b)
        {
            return a + b;
        }

        static double SubstractFlotants(double a, double b)
        {
            return a - b;
        }

        static double MultiplyFlotants(double a, double b)
        {
            return a * b;
        }

        static double DivideFlotants(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }

        static double ModuloFlotants(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot perform modulo with divisor zero.");
                return double.NaN;
            }
            return a % b;
        }
    }

}
