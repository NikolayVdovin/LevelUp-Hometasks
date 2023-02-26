using System;


namespace Lesson3.Models
{
    public abstract class StoreItem
    {
        private static int _countId;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public StoreItem( string name, int quantity)
        { 
            Id = ++_countId;
            Name = name;
            Quantity = quantity;
        }
    }
}
