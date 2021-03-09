using System;
using System.Collections.Generic;
using System.Text;

namespace Lucky_ticket
{
    public class Game
    {
        public Status GameStatus = Status.GameOff;
        public void Start(Ticket ticket)
        {
            do
            {
                Console.WriteLine("Enter your ticket number");
                ticket.Number = Console.ReadLine();
                ticket.IsHappyTicket();

                Console.WriteLine("If you want to exit, enter -" + " exit. If you want repaly - press enter");
                if (Console.ReadLine() == "exit")
                {
                    GameStatus = Status.GameOff;
                }
            }
            while (GameStatus == Status.GameOn);
        }
    }
}
