namespace Bottles;

internal class Program
{
    public static void Main(string[] args)
    {
        var bottles = new Bottles();
        var song = bottles.Song();

        Console.WriteLine(song);
    }
}
