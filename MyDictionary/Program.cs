using Console = System.Console;

namespace Lab_6;

class Program
{
    public static MyDictionary<string, int> animalsNumbers = new MyDictionary<string, int>();
    
    static void Main(string[] args)
    {
        animalsNumbers.Add("cat", 12);
        animalsNumbers.Add("fish", 22);
        Console.WriteLine(animalsNumbers.Count);
        Console.WriteLine(animalsNumbers["cat"]);
        Console.WriteLine("");
    }
}
