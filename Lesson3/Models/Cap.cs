using System;


namespace Lesson3.Models
{
    internal class Cap : Clothes
    {
        public float VisorLengfth { get; private set; }
        public Cap(string name, int quantity, int size, string color, float visorLengfth) : base(name, quantity, size, color)
        {
            VisorLengfth = visorLengfth;
        }

        public override string ToString()
        {
             return $"Name = {Name} \nQuantity = {Quantity} \nSize = {Size} \nColor = {Color} \nVisor lengfth = {VisorLengfth}";
        }
    }
}
