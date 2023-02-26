using static System.Net.Mime.MediaTypeNames;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testString = "\tThis is \n a - test string";
            var clearedString = testString.ClearingLine();

            Console.WriteLine( clearedString);
        }
    }
}