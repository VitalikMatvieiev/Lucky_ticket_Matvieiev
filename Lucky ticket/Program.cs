using System;
using System.Text.RegularExpressions;

namespace Lucky_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket();
            Game game = new Game();
            game.Start(t1);
        }
    }
}
