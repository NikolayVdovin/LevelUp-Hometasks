namespace Lesson2.UserCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string nameFromConsole = Console.ReadLine();

            Console.WriteLine("Enter surname:");
            string surnameFromConsole = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int ageFromConsole;

            while (!int.TryParse(Console.ReadLine(), out ageFromConsole))
            {
                Console.WriteLine("Please, enter the valid age. It should be a number");
            }

            Console.WriteLine("Enter hobby:");
            string hobbyFromConsole = Console.ReadLine();

            UserCard person = new UserCard(nameFromConsole, surnameFromConsole, ageFromConsole, hobbyFromConsole);

            Console.WriteLine(person);
        }
    }
}
