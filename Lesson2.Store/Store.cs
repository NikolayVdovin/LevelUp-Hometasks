namespace Lesson2.Store
{
    internal class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Store name is \"{Name}\" and store address is \"{Address}\"");
        }
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