namespace OOP_ZAD3_ClassLibrary;

public class FilePrinter : IPrinter
{
    private string outputFileName;

    public FilePrinter(string OutputFileName)
    {
        outputFileName = OutputFileName;
    }
    public void Print(string file)
    {
        File.WriteAllText(outputFileName, file);
    }
}