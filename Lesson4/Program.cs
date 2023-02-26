namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cache = new SimpleGenericCache<string>();
            var value = "Hello!";

            cache.Store("first", value, 0);
            cache.Store("second", value);

            Console.WriteLine(cache.Fetch("first"));
            Console.WriteLine(cache.Fetch("second")); 
        }
    }
}