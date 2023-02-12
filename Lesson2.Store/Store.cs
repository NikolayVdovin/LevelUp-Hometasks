namespace Lesson2.Store
{
    internal class Store
    {
        public string Name { get; }
        public string Address { get; }
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Store name is \"{Name}\" and store address is \"{Address}\"");
        }
    }
}