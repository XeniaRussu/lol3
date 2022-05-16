using System.Text;

namespace Method;
class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.WriteLine(ReverseLetter("my name is loxNikita. I study in CHNU and im a lox"));
    }
    public static int DescendingOrder(int num) 
    {
       
       return int.Parse(String.Concat(num.ToString()
            .Select(s => int.Parse(s.ToString()))
            .OrderByDescending(s => s)
            .Select(s => s.ToString())));
        // Bust a move right here
    }
}


    