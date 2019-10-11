using KingdomDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomDemo
{
    public class Troll : ICharacter
    {
        public override void Fight()
        {
            Console.WriteLine("Time to Troll!");
        }
    }
}
