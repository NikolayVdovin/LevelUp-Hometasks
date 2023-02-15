using System;


namespace Lesson3.Models
{
    internal abstract class Clothes : StoreItem
    {
        public int Size { get; set; }
        public string? Color { get; set; }

        protected Clothes(string name, int quantity, int size, string color) : base(name, quantity)
        {
            Size = size;
            Color = color;
        }

        
       
    }
}
