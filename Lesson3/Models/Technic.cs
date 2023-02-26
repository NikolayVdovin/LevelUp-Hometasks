using System;


namespace Lesson3.Models
{
    internal abstract class Technic : StoreItem
    {
        public Technic(string name, int quantity) : base(name, quantity)
        {
        }
    }
}
