namespace Lesson2.Resume
{
    internal class Resume
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public Resume(string name, string surname, int age, string hobby)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Hobby = hobby;
        }
        public override string ToString()
        {
            return $"Name: {Name} \nSurname: {Surname} \nAge: {Age}\nHobby: {Hobby}";
        }

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

            Resume person = new Resume(nameFromConsole, surnameFromConsole, ageFromConsole, hobbyFromConsole);

            Console.WriteLine(person);


        }
    }
}