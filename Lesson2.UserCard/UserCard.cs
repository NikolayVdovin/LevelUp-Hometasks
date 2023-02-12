namespace Lesson2.UserCard
{
    internal class UserCard
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Hobby { get; }

        public UserCard(string name, string surname, int age, string hobby)
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
    }
}