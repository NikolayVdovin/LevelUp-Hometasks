namespace Lesson2.Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter store name");
            string nameStore = Console.ReadLine();

            Console.WriteLine("Enter sore address");
            string addressStore = Console.ReadLine();

            Store store = new Store(nameStore, addressStore);
            store.PrintInfo();
        }
    }
}
