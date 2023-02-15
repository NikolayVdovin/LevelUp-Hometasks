using System;


namespace Lesson3.Models
{
    internal class Vodka : Food
    {
        public int Alcohol { get; private set; }
        public Vodka(string name, int quantity, float volume, bool isNatural, int alcohol ) : base(name, quantity, volume, isNatural )
        {
            Alcohol = alcohol;
        }
    }
}
