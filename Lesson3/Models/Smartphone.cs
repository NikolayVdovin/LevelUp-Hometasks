using System;


namespace Lesson3.Models
{
    internal class Smartphone : Technic
    {
        public float DisplaySize { get; private set; }
        public Smartphone(string name, int quantity, float displaySize) : base(name, quantity)
        {
             DisplaySize = displaySize;
        }
    }
}
