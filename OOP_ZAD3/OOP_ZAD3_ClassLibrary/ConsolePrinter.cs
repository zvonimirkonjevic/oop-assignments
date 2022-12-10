namespace OOP_ZAD3_ClassLibrary;

public class ConsolePrinter : IPrinter
{
    public void Print(string sentance)
    {
        Console.WriteLine(sentance);
    }
}