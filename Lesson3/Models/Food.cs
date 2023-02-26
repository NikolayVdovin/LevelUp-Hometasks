using System;


namespace Lesson3.Models
{
    internal abstract class Food : StoreItem, INatural_composition
    {
        public float Volume { get; private set; }
        public bool IsNatural { get; private set; }
        public Food(string name, int quantity, float volume, bool isNatural) : base(name, quantity)
        {
            Volume = volume;
            IsNatural = isNatural;
        }

        public bool isNatural()
        {
            return IsNatural;
        }
    }
}
