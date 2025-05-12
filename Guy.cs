using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guys_and_Cash
{
    internal class Guy
    {
        public string? Name;
        public int Cash;

        /// <summary>
        /// Writes my name and how much cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine( Name + " has " + Cash + " bucks." );
        }

        /// <summary>
        /// Gives some of my cash, removing it from my wallet, or prints message to console window if I don't have enough cash.
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>The amount of cash removed from my wallet, or 0 if I don't have enough cash, or if the amount is invalid</returns>
        public int GiveCash( int amount )
        {
            if ( amount <= 0 )
            {
                Console.WriteLine( Name + " says: " + amount + " isn't a valid amount" );
                return 0;
            }
            else if ( amount > Cash )
            {
                Console.WriteLine( Name + " says: " + " I don't have enough cash to give you " + amount );
                return 0;
            }
            else
            {
                Cash -= amount;
                return amount;
            }
        }

        /// <summary>
        /// Adds cash to my wallet, or prints message to console window if the amount is invalid.
        /// </summary>
        /// <param name="amount">Amount of cash to receive</param>
        public void ReceiveCash( int amount )
        {
            if ( amount <= 0 )
            {
                Console.WriteLine( Name + " says: " + amount + " isn't a valid amount" );
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
