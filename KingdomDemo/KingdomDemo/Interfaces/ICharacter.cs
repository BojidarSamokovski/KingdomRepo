using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomDemo.Interfaces
{
    public abstract class ICharacter
    {
        public abstract void Fight();

        public void WashMySocks()
        {
            Console.WriteLine( "Wash my socks.");
        }
    }
}
