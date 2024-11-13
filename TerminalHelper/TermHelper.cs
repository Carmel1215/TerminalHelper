namespace TerminalHelper;

public static class TermHelper
{
    public static void WriteLog(string line)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteLog(string line, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteWarning(string line)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteWarning(string line, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteError(string line)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteError(string line, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }
}