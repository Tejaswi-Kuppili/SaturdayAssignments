using System;

class InputValidator
{
    public void ValidateNumericInput(string userInput)
    {
        try
        {
            int numericValue = int.Parse(userInput);
            Console.WriteLine("Numeric value entered: " + numericValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value entered is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numeric value:");
        string userInput = Console.ReadLine();

        InputValidator inputValidator = new InputValidator();
        inputValidator.ValidateNumericInput(userInput);

        Console.ReadLine();
    }
}
