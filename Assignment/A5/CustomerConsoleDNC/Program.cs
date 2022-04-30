namespace CustomerConsoleDNC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            string? a = Console.ReadLine();
            Console.WriteLine(a is "42069" or "69420" ? "Hello World" : "Goodbye World");
        }
    }
}
