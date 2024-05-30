public class UserInterface
{
    // Metod för att skriva ut huvudmenyn
    public void PrintStartMenu()
    {
        Console.WriteLine("Välj ett alternativ:");
        Console.WriteLine("1. Se historik");
        Console.WriteLine("2. Göra en uträkning");
    }

    // Metod för att skriva ut beräkningsmenyn
    public void PrintCalculationMenu()
    {
        Console.WriteLine("Välj räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
    }

    // Metod för att hämta användarens val från menyn
    public int GetMenuChoice(int min, int max)
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
        {
            Console.WriteLine("Ogiltigt val, försök igen.");
        }
        return choice;
    }

    // Metod för att hämta ett tal från användaren
    public double GetNumber(string prompt)
    {
        double number;
        Console.WriteLine(prompt);
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ogiltigt tal, försök igen.");
        }
        return number;
    }

    // Metod för att skriva ut resultatet
    public void PrintResult(double result)
    {
        Console.WriteLine($"Resultatet är: {result}");
    }

    // Metod för att skriva ut historiken
    public void PrintHistory(List<string> history)
    {
        Console.WriteLine("Tidigare beräkningar:");
        foreach (var item in history)
        {
            Console.WriteLine(item);
        }
    }
}
