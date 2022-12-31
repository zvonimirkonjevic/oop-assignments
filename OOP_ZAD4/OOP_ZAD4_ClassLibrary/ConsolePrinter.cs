namespace OOP_ZAD4_ClassLibrary;

public class ConsolePrinter : IPrinter
{
    public void Print(string sentance)
    {
        Console.WriteLine(sentance);
    }
}