using System;
using System.Collections.Generic;
using System.Text;

namespace Lucky_ticket
{
    public class Ticket
    {
        
        string number;
        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length > 4 && value.Length < 8)
                {

                    if (value.ToString().Length % 2 == 0)
                    {
                        number = value;
                    }
                    else
                    {
                        number = "0" + value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid num");
                }
            }
        }
        public void IsHappyTicket()
        {
            int sum1 = 0;
            int sum2 = 0;

            char[] numbers = Number.ToCharArray();

            for (int i = 0; i < Number.ToString().Length; i++)
            {
                if (i < number.Length / 2)
                {
                    sum1 += Int32.Parse(numbers[i].ToString());
                }
                else
                {
                    sum2 += Int32.Parse(numbers[i].ToString());
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("You are lucky, you win");
            }
            else
            {
                Console.WriteLine("Maybe in the nex time");
            }
        }
    }
}
