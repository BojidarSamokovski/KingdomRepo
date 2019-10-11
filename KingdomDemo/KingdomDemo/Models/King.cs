using KingdomDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomDemo
{
    public class King:ICharacter
    {

        public override void Fight()
        {
            Console.WriteLine("King uses Demacian slice!");
        }
    }
}
