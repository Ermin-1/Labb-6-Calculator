using Labb_6_Calculator;

public class Program
{
    static void Main(string[] args)
    {
        // Skapa instanser av Calculator, CalculationHistory och UserInterface
        var calculator = new Calculator();
        var history = new CalculatorHistory();
        var ui = new UserInterface();
        bool continueCalculating = true;

        // Huvudloop för att köra applikationen
        while (continueCalculating)
        {
            // Skriv ut huvudmenyn och hämta användarens val
            ui.PrintStartMenu();
            int startChoice = ui.GetMenuChoice(1, 2);

            if (startChoice == 1)
            {
                // Visa historiken
                ui.PrintHistory(history.GetHistory());
            }
            else if (startChoice == 2)
            {
                // Skriv ut beräkningsmenyn och hämta användarens val av räknesätt
                ui.PrintCalculationMenu();
                int choice = ui.GetMenuChoice(1, 4);

                // Hämta de två talen från användaren
                double num1 = ui.GetNumber("Ange det första talet:");
                double num2 = ui.GetNumber("Ange det andra talet:");
                double result = 0;
                string operation = "";

                try
                {
                    // Utför den valda beräkningen
                    switch (choice)
                    {
                        case 1:
                            result = calculator.Add(num1, num2);
                            operation = $"{num1} + {num2} = {result}";
                            break;
                        case 2:
                            result = calculator.Subtract(num1, num2);
                            operation = $"{num1} - {num2} = {result}";
                            break;
                        case 3:
                            result = calculator.Multiply(num1, num2);
                            operation = $"{num1} * {num2} = {result}";
                            break;
                        case 4:
                            result = calculator.Divide(num1, num2);
                            operation = $"{num1} / {num2} = {result}";
                            break;
                    }

                    // Skriv ut resultatet och spara beräkningen i historiken
                    ui.PrintResult(result);
                    history.AddCalculation(operation);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Fråga användaren om de vill fortsätta använda applikationen
            Console.WriteLine("Vill du fortsätta? (j/n)");
            continueCalculating = Console.ReadLine().ToLower() == "j";
        }
    }
}
