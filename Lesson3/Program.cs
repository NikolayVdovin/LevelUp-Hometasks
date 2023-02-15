using Lesson3.Models;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cap cap = new Cap("Nike", 3, 46, "Red", 17);          
            Cap cap2 = new Cap("Nike", 1, 46, "Green", 17);
            Vodka vodka = new Vodka("Столичная", 3, 0.5f ,true, 40);
            
            Console.WriteLine(cap.Id);
            Console.WriteLine(cap);
            Console.WriteLine(cap2.Id);
            Console.WriteLine(cap2);
        }
    }
}