using System;

namespace KingdomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King();
            king.Fight();
            king.WashMySocks();
            Queen queen = new Queen();
            queen.Fight();
            Troll troll = new Troll();
            troll.Fight();
        }
    }
}
