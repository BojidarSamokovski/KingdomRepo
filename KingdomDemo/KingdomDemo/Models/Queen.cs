using KingdomDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomDemo
{
    public class Queen:ICharacter
    {

        public override void Fight()
        {
            Console.WriteLine("Queen uses Shield Bash!");
        }
    }
}
